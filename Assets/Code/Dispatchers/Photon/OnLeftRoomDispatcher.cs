using uFrame.Attributes;

namespace uFrame.ECS
{
	[UFrameEventDispatcher("On Left Room"), uFrameCategory("Photon")]
	public class OnLeftRoomDispatcher : EcsDispatcher, IPunCallbacks
	{
		public void OnLeftRoom(){
			Publish (this);
		}
		
		void IPunCallbacks.OnConnectedToPhoton(){}
		//void IPunCallbacks.OnLeftRoom(){}
		void IPunCallbacks.OnMasterClientSwitched(PhotonPlayer newMasterClient){}
		void IPunCallbacks.OnPhotonCreateRoomFailed(object[] codeAndMsg){}
		void IPunCallbacks.OnPhotonJoinRoomFailed(object[] codeAndMsg){}
		void IPunCallbacks.OnCreatedRoom(){}
		void IPunCallbacks.OnJoinedLobby(){}
		void IPunCallbacks.OnLeftLobby(){}
		void IPunCallbacks.OnFailedToConnectToPhoton(DisconnectCause cause){}
		void IPunCallbacks.OnConnectionFail(DisconnectCause cause){}
		void IPunCallbacks.OnDisconnectedFromPhoton(){}
		void IPunCallbacks.OnPhotonInstantiate(PhotonMessageInfo info){}
		void IPunCallbacks.OnReceivedRoomListUpdate(){}
		void IPunCallbacks.OnJoinedRoom(){}
		void IPunCallbacks.OnPhotonPlayerConnected(PhotonPlayer newPlayer){}
		void IPunCallbacks.OnPhotonPlayerDisconnected(PhotonPlayer otherPlayer){}
		void IPunCallbacks.OnPhotonRandomJoinFailed(object[] codeAndMsg){}
		void IPunCallbacks.OnConnectedToMaster(){}
		void IPunCallbacks.OnPhotonMaxCccuReached(){}
		void IPunCallbacks.OnPhotonCustomRoomPropertiesChanged(ExitGames.Client.Photon.Hashtable propertiesThatChanged){}
		void IPunCallbacks.OnPhotonPlayerPropertiesChanged(object[] playerAndUpdatedProps){}
		void IPunCallbacks.OnUpdatedFriendList(){}
		void IPunCallbacks.OnCustomAuthenticationFailed(string debugMessage){}
		void IPunCallbacks.OnWebRpcResponse(ExitGames.Client.Photon.OperationResponse response){}
		void IPunCallbacks.OnOwnershipRequest(object[] viewAndPlayer){}
		void IPunCallbacks.OnLobbyStatisticsUpdate(){}
	}
}