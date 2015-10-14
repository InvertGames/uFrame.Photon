namespace DireDungeons {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
	using UnityEngine;
    
    public partial class LateUpdateFollowUser {

		private Transform targetTrans;
		private Transform myTrans;

        public override void Execute() {
			if (FollowUser.Target == null) {
				return;
			}
			myTrans = myTrans == null ? FollowUser.gameObject.transform : myTrans;
			targetTrans = targetTrans == null ? FollowUser.Target.transform : targetTrans;
			myTrans.position = Vector3.Lerp(myTrans.position, FollowUser.wantPos, Time.deltaTime * Mathf.Max (FollowUser.distance, 2));
			myTrans.LookAt ((targetTrans.position + (Vector3.up * 2)) - (FollowUser.wantPos - myTrans.position));
        }
    }
}
