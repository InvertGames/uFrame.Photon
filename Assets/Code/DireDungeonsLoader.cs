// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace DireDungeons {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
    using uFrame.Kernel;
    
    
    public partial class DireDungeonsLoader : uFrame.Kernel.SystemLoader {
        
        public override void Load() {
            EcsSystem system = null;
            system = this.AddSystem<UserSystem>();
            system = this.AddSystem<LobbySystem>();
            system = this.AddSystem<RoomSystem>();
            system = this.AddSystem<PhotonSystem>();
        }
    }
}