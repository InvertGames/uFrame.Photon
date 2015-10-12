using uFrame.Attributes;
using UnityEngine;

namespace uFrame.ECS
{
    [UFrameEventDispatcher("On Trigger Stay"), uFrameCategory("Unity Messages")]
    public class OnTriggerStayDispatcher : EcsDispatcher
    {
        public int ColliderId { get; set; }
        public Collider ColliderData { get; set; }
        public void OnTriggerStay(Collider coll)
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