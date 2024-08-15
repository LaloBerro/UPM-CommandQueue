namespace CommandQueues.Core
{
    public class EmptyNodeCommandInstaller : NodeCommandInstaller
    {
        protected override INodeCommand GetData()
        {
            return new EmptyNodeCommand();
        }
    }
}