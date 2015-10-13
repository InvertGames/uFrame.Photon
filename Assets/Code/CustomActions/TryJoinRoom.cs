namespace DireDungeons {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
	using UnityEngine;
    
    public partial class TryJoinRoom {

		public RoomOptions roomOptions;

		public override void Execute() {
			Debug.Log ("Trying to join room:"+RoomId);
			roomOptions = new RoomOptions ();
			roomOptions.maxPlayers = (byte)MaxPlayers;
			roomOptions.customRoomProperties = new ExitGames.Client.Photon.Hashtable ();
			roomOptions.customRoomProperties.Add ("map", RoomId);
			PhotonNetwork.JoinOrCreateRoom (RoomId, roomOptions, TypedLobby.Default);
		}
    }
}