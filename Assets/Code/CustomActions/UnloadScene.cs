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
			foreach (EventSystem es in GameObject.FindObjectsOfType<EventSystem>())
			{
				if (_EventSystem.GetInstanceID() != es.GetInstanceID())
				{
					GameObject.Destroy(es.gameObject);
				}
			}
			System.Publish (new UnloadSceneCommand(){
				SceneName = OldScene
			});
			GameObject sceneObject = GameObject.Find (OldScene);
			GameObject.Destroy(sceneObject.gameObject);
        }
    }
}
