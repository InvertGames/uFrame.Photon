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
    using DireDungeons;
    using UnityEngine;
    using uFrame.Kernel;
    using UniRx;
    using uFrame.ECS;
    
    
    [uFrame.Attributes.uFrameIdentifier("08ae4260-616a-4ee3-a10d-280c86c98733")]
    public partial class UserSystem : uFrame.ECS.EcsSystem {
        
        private IEcsComponentManagerOf<FollowUser> _FollowUserManager;
        
        public IEcsComponentManagerOf<FollowUser> FollowUserManager {
            get {
                return _FollowUserManager;
            }
            set {
                _FollowUserManager = value;
            }
        }
        
        public override void Setup() {
            base.Setup();
            FollowUserManager = ComponentSystem.RegisterComponent<FollowUser>();
        }
    }
}
