namespace DireDungeons {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
	using UnityEngine;
	using UnityEngine.UI;
    
    public partial class UpdateConnectionStatus {
		private Text myText;

        public override void Execute() {
			if (Obj_TxtConnecting != null) {
				myText = myText == null ? Obj_TxtConnecting.GetComponent<Text> () : myText;
				if (myText != null) {
					myText.text = PhotonNetwork.connectionStateDetailed.ToString ();
				}
			}
        }
    }
}
