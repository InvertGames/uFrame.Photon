namespace DireDungeons {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
    
    
    public partial class CreateNewRoom {
        
        public override void Execute() {
			if (PhotonNetwork.CreateRoom (RoomId)) {
				if(null != Yes){
					Yes();
				}
			}
        }
    }
}
