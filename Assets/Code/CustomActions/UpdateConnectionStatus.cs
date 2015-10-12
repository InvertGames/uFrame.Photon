namespace DireDungeons {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
	using UnityEngine;
	using UnityEngine.UI;
    
    public partial class UpdateConnectionStatus {
		Text myText;

        public override void Execute() {
			if (Obj_Connecting != null) {
				myText = myText == null ? Obj_Connecting.GetComponent<Text> () : myText;
				if (myText != null) {
					myText.text = PhotonNetwork.connectionStateDetailed.ToString ();
				}
			}
        }
    }
}
