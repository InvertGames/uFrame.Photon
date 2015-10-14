namespace DireDungeons {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
	using UnityEngine;
	using uFrame.Kernel;
    
    public partial class EnterRoom {
        
        public override void Execute() {
			Debug.Log ("Remove lobby scene here, go to caves sceen.");
			GameObject spawn = GameObject.Find ("SpawnLocation"+(PhotonNetwork.room.playerCount-1));
			GameObject self = PhotonNetwork.Instantiate ("Prefabs/User", spawn.transform.position, spawn.transform.rotation, 0);
			FollowUser camFollow = GameObject.FindObjectOfType<FollowUser> ();
			camFollow.Target = self;
        }
    }
}
