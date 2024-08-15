using DependencyInjector.Core;
using DependencyInjector.Installers;

namespace CommandQueues.Core
{
    public class CommandQueueInstaller : SingleMonoInstaller<ICommandQueue>
    {
        [Inject] private INodeCommand[] _nodeCommands;

        protected override ICommandQueue GetData()
        {
            return new CommandQueue(_nodeCommands);
        }
    }
}