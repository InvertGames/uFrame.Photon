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
    
    
    public class LobbySystemUpdateHandler {
        
        public LobbyMenu Group;
        
        private uFrame.ECS.ISystemUpdate _Event;
        
        private uFrame.ECS.EcsSystem _System;
        
        private object ActionNode43_a = default( System.Object );
        
        private object ActionNode43_b = default( System.Object );
        
        private bool BoolNode44 = false;
        
        private bool ActionNode43_Result = default( System.Boolean );
        
        private UnityEngine.GameObject ActionNode41_Obj_Connecting = default( UnityEngine.GameObject );
        
        private DireDungeons.UpdateConnectionStatus ActionNode41 = new DireDungeons.UpdateConnectionStatus();
        
        public uFrame.ECS.ISystemUpdate Event {
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
            ActionNode43_a = Group.Connected;
            ActionNode43_b = BoolNode44;
            // ActionNode
            while (this.DebugInfo("2e20ce5f-8751-44f4-abd1-c6ade61c5bf0","08fb7026-7407-48bc-947a-ed9153f0cab7", this) == 1) yield return null;
            // Visit uFrame.Actions.Comparisons.AreEqual
            ActionNode43_Result = uFrame.Actions.Comparisons.AreEqual(ActionNode43_a, ActionNode43_b, ()=> { System.StartCoroutine(ActionNode43_yes()); }, ()=> { System.StartCoroutine(ActionNode43_no()); });
            yield break;
        }
        
        private System.Collections.IEnumerator ActionNode43_yes() {
            ActionNode41_Obj_Connecting = Group.txt_Connecting;
            // ActionNode
            while (this.DebugInfo("08fb7026-7407-48bc-947a-ed9153f0cab7","a580f04c-44e3-42c8-93b7-396f7ad3b9f6", this) == 1) yield return null;
            // Visit DireDungeons.UpdateConnectionStatus
            ActionNode41.Obj_Connecting = ActionNode41_Obj_Connecting;
            ActionNode41.System = System;
            ActionNode41.Execute();
            yield break;
        }
        
        private System.Collections.IEnumerator ActionNode43_no() {
            yield break;
        }
    }
}
