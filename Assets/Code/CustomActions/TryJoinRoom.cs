namespace DireDungeons {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
    
    
    public partial class TryJoinRoom {
        
        public override void Execute() {

			if (PhotonNetwork.JoinRoom(RoomId)) {
				if(null != Yes){
					Yes();
				}
			} else {
				if(null != No){
					No();
				}
			}
		}
    }
}
