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
    using DireDungeons;
    
    
    public class CameraLateUpdateHandler {
        
        public FollowUser Group;
        
        private uFrame.ECS.ISystemLateUpdate _Event;
        
        private uFrame.ECS.EcsSystem _System;
        
        private DireDungeons.FollowUser ActionNode9_FollowUser = default( DireDungeons.FollowUser );
        
        private DireDungeons.LateUpdateFollowUser ActionNode9 = new DireDungeons.LateUpdateFollowUser();
        
        public uFrame.ECS.ISystemLateUpdate Event {
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
            ActionNode9_FollowUser = this.Group;
            // ActionNode
            while (this.DebugInfo("7035a610-77c8-488e-bc6e-4576c1841565","834a4a73-c79a-4c81-bd10-1cb6b733d6c2", this) == 1) yield return null;
            // Visit DireDungeons.LateUpdateFollowUser
            ActionNode9.FollowUser = ActionNode9_FollowUser;
            ActionNode9.System = System;
            ActionNode9.Execute();
            yield break;
        }
    }
}