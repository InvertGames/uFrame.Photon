namespace DireDungeons {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
	using UnityEngine;
	using UnityEngine.EventSystems;
	using uFrame.Kernel;
    
    
    public partial class UnloadScene {
        
        public override void Execute() {
			EventSystem _EventSystem = EventSystem.current;
			foreach (EventSystem es in FindObjectsOfType<EventSystem>())
			{
				if (_EventSystem.GetInstanceID() != es.GetInstanceID())
				{
					Destroy(es.gameObject);
				}
			}
			System.Publish (new UnloadSceneCommand(){
				SceneName = OldScene
			});
			Destroy(GameObject.Find (OldScene).gameObject);
        }
    }
}
