using uFrame.Kernel;

namespace uFrame.ECS
{
    public interface IEcsComponent : IDisposableContainer
    {
        int EntityId { get; set; }
        int ComponentId { get; }
    }

 
}