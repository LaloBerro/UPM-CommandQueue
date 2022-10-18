using System.Collections.Generic;
using Zenject;
using ZenjectExtensions.Zinstallers;

namespace CommandQueues.Core
{
    public class CommandQueueZinstaller : InstanceZinstaller<ICommandQueue>
    {
        private List<INodeCommand> _nodeCommands;

        [Inject]
        public void InjectDependencies(List<INodeCommand> nodeCommands)
        {
            _nodeCommands = nodeCommands;
        }

        protected override ICommandQueue GetInitializedClass()
        {
            return new CommandQueue(_nodeCommands.ToArray());
        }
    }
}