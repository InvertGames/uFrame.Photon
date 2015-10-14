namespace DireDungeons {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
	using UnityEngine;
    
    
    public partial class UpdateFollowUser {
        
		private Transform targetTrans;
		private Transform myTrans;

        public override void Execute() {
			if (FollowUser.Target == null) {
				return;
			}
			myTrans = myTrans == null ? FollowUser.gameObject.transform : myTrans;
			targetTrans = targetTrans == null ? FollowUser.Target.transform : targetTrans;

			FollowUser.wantPos = SphericalToCartesian (FollowUser.PosDistance, FollowUser.PosElevation * Mathf.Deg2Rad, FollowUser.PosHeading * Mathf.Deg2Rad, FollowUser.wantPos);
			FollowUser.wantPos += targetTrans.position;
			FollowUser.distance = Vector3.Distance (myTrans.position, FollowUser.wantPos);
        }

		private Vector3 SphericalToCartesian(float distance, float elevation, float heading, Vector3 result){
			result = result == null ? new Vector3 () : result;
			float a = distance * Mathf.Cos (elevation);
			result.x = a * Mathf.Cos (heading);
			result.y = distance * Mathf.Sin (elevation);
			result.z = a * Mathf.Sin (heading);
			return result;
		}
    }
}