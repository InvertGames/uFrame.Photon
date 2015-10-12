using uFrame.Kernel;
using UnityEngine;

namespace uFrame.ECS
{
    public partial class Entity : uFrameComponent, IEcsComponent
    {

        public Entity ProxyFor;

        [SerializeField]
        private int _entityId;

        public int EntityId
        {
            get
            {
                if (ProxyFor != null)
                {
                    return ProxyFor.EntityId;
                }
                return _entityId == 0 ? (_entityId = EntityService.NewId()) : _entityId;
            }
            set { _entityId = value; }
        }

        public int ComponentId
        {
            get { return 0; }
        }

        public override void KernelLoading()
        {
            base.KernelLoading();
            if (ProxyFor == null)
            EntityService.RegisterEntityView(this);

        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            if (ProxyFor == null)
            EntityService.UnRegisterEntityView(this);
        }
    }
}