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
    using UniRx;
    using UnityEngine;
    
    
    [uFrame.Attributes.uFrameIdentifier("0b8463f1-cc9e-49a3-ac7c-7ba4bb93b92f")]
    public partial class LobbyButton : uFrame.ECS.EcsComponent {
        
        private Subject<String> _RoomIdObservable;
        
        private Subject<Int32> _MaxPlayersObservable;
        
        [UnityEngine.SerializeField()]
        private String _RoomId;
        
        [UnityEngine.SerializeField()]
        private Int32 _MaxPlayers;
        
        public int ComponentID {
            get {
                return 5;
            }
        }
        
        public IObservable<String> RoomIdObservable {
            get {
                if (_RoomIdObservable == null) {
                    _RoomIdObservable = new Subject<String>();
                }
                return _RoomIdObservable;
            }
        }
        
        public IObservable<Int32> MaxPlayersObservable {
            get {
                if (_MaxPlayersObservable == null) {
                    _MaxPlayersObservable = new Subject<Int32>();
                }
                return _MaxPlayersObservable;
            }
        }
        
        public String RoomId {
            get {
                return _RoomId;
            }
            set {
                _RoomId = value;
                if (_RoomIdObservable != null) {
                    _RoomIdObservable.OnNext(value);
                }
            }
        }
        
        public Int32 MaxPlayers {
            get {
                return _MaxPlayers;
            }
            set {
                _MaxPlayers = value;
                if (_MaxPlayersObservable != null) {
                    _MaxPlayersObservable.OnNext(value);
                }
            }
        }
    }
}
