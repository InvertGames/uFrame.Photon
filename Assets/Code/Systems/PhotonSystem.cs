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
    using UniRx;
    using uFrame.Kernel;
    using uFrame.ECS;
    
    
    [uFrame.Attributes.uFrameIdentifier("97d52782-4401-46ef-9738-b17fac1746fb")]
    public partial class PhotonSystem : uFrame.ECS.EcsSystem {
        
        private PhotonSystemGameReadyHandler PhotonSystemGameReadyHandlerInstance = new PhotonSystemGameReadyHandler();
        
        public override void Setup() {
            base.Setup();
            this.OnEvent<uFrame.Kernel.GameReadyEvent>().Subscribe(_=>{ PhotonSystemGameReadyFilter(_); }).DisposeWith(this);
        }
        
        protected void PhotonSystemGameReadyHandler(uFrame.Kernel.GameReadyEvent data) {
            var handler = PhotonSystemGameReadyHandlerInstance;
            handler.System = this;
            handler.Event = data;
            StartCoroutine(handler.Execute());
        }
        
        protected void PhotonSystemGameReadyFilter(uFrame.Kernel.GameReadyEvent data) {
            this.PhotonSystemGameReadyHandler(data);
        }
    }
}
