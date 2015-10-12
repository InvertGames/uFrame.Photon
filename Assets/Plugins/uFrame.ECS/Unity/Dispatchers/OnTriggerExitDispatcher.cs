using uFrame.Attributes;
using UnityEngine;

namespace uFrame.ECS
{
    [UFrameEventDispatcher("On Trigger Exit"), uFrameCategory("Unity Messages")]
    public class OnTriggerExitDispatcher : EcsDispatcher
    {
        public int ColliderId { get; set; }
        public Collider ColliderData { get; set; }
        public void OnTriggerExit(Collider coll)
        {

            var colliderEntity = coll.gameObject.GetComponent<Entity>();
            if (colliderEntity == null) return;
            ColliderId = colliderEntity.EntityId;
            EntityId = gameObject.GetComponent<Entity>().EntityId;
            ColliderData = coll;
            Publish(this);
        }
    }
}