using uFrame.ECS;
using UnityEngine;

namespace uFrame.Actions
{
    public abstract class UFAction : MonoBehaviour
    {
        public Entity EntityView;
        public EcsSystem System;

        public virtual void Execute()
        {
            
        }

    }
}