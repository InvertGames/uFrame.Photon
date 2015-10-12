namespace DireDungeons {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
	using UnityEngine;
    
    public partial class TryConnectToPhoton {
        public override void Execute() {
			if (PhotonNetwork.connected || PhotonNetwork.connecting) {
				PhotonNetwork.Disconnect();
			}
			PhotonNetwork.ConnectUsingSettings (GameVersion);
        }
    }
}