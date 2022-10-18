using Installers.Core;

namespace CommandQueues.Core
{
    public abstract class NodeCommandInstaller : MonoInstaller<INodeCommand>
    {
        protected override INodeCommand GetData()
        {
            return GetNodeCommand();
        }

        protected abstract INodeCommand GetNodeCommand();
    }
}