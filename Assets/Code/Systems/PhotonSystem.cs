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
    using uFrame.Kernel;
    using UniRx;
    using uFrame.ECS;
    
    
    [uFrame.Attributes.uFrameIdentifier("97d52782-4401-46ef-9738-b17fac1746fb")]
    public partial class PhotonSystem : uFrame.ECS.EcsSystem {
        
        private IEcsComponentManagerOf<LobbyButton> _LobbyButtonManager;
        
        private IEcsComponentManagerOf<Room> _RoomManager;
        
        private IEcsComponentManagerOf<Driver> _DriverManager;
        
        private PhotonSystemGameReadyHandler PhotonSystemGameReadyHandlerInstance = new PhotonSystemGameReadyHandler();
        
        public IEcsComponentManagerOf<LobbyButton> LobbyButtonManager {
            get {
                return _LobbyButtonManager;
            }
            set {
                _LobbyButtonManager = value;
            }
        }
        
        public IEcsComponentManagerOf<Room> RoomManager {
            get {
                return _RoomManager;
            }
            set {
                _RoomManager = value;
            }
        }
        
        public IEcsComponentManagerOf<Driver> DriverManager {
            get {
                return _DriverManager;
            }
            set {
                _DriverManager = value;
            }
        }
        
        public override void Setup() {
            base.Setup();
            LobbyButtonManager = ComponentSystem.RegisterComponent<LobbyButton>();
            RoomManager = ComponentSystem.RegisterComponent<Room>();
            DriverManager = ComponentSystem.RegisterComponent<Driver>();
            this.OnEvent<uFrame.Kernel.GameReadyEvent>().Subscribe(_=>{ PhotonSystemGameReadyFilter(_); }).DisposeWith(this);
        }
        
        protected void PhotonSystemGameReadyHandler(uFrame.Kernel.GameReadyEvent data, Driver group) {
            var handler = PhotonSystemGameReadyHandlerInstance;
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            StartCoroutine(handler.Execute());
        }
        
        protected void PhotonSystemGameReadyFilter(uFrame.Kernel.GameReadyEvent data) {
            var DriverItems = DriverManager.Components;
            for (var DriverIndex = 0
            ; DriverIndex < DriverItems.Count; DriverIndex++
            ) {
                this.PhotonSystemGameReadyHandler(data, DriverItems[DriverIndex]);
            }
        }
    }
}
