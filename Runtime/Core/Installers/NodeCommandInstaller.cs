using DependencyInjector.Installers;

namespace CommandQueues.Core
{
    public abstract class NodeCommandInstaller : MultipleMonoInstaller<INodeCommand>
    {
    }
}