namespace DireDungeons {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
	using UnityEngine;
    
    public partial class ShowLobby {
        public override void Execute() {
			Obj_Rooms.SetActive (true);
			Obj_Connecting.SetActive (false);
        }
    }
}
