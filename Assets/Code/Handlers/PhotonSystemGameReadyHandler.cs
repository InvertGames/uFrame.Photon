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
    using UnityEngine;
    using uFrame.Kernel;
    
    
    public class PhotonSystemGameReadyHandler {
        
        private uFrame.Kernel.GameReadyEvent _Event;
        
        private uFrame.ECS.EcsSystem _System;
        
        private string ActionNode23_GameVersion = default( System.String );
        
        private string StringNode7 = "v0.0";
        
        private DireDungeons.TryConnectToPhoton ActionNode23 = new DireDungeons.TryConnectToPhoton();
        
        public uFrame.Kernel.GameReadyEvent Event {
            get {
                return _Event;
            }
            set {
                _Event = value;
            }
        }
        
        public uFrame.ECS.EcsSystem System {
            get {
                return _System;
            }
            set {
                _System = value;
            }
        }
        
        public virtual System.Collections.IEnumerator Execute() {
            ActionNode23_GameVersion = StringNode7;
            // ActionNode
            while (this.DebugInfo("a580f04c-44e3-42c8-93b7-396f7ad3b9f6","1e28bd40-5c1e-4783-a79d-cf4ba795e9a9", this) == 1) yield return null;
            // Visit DireDungeons.TryConnectToPhoton
            ActionNode23.GameVersion = ActionNode23_GameVersion;
            ActionNode23.System = System;
            ActionNode23.Execute();
            yield break;
        }
    }
}