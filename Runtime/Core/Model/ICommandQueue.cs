namespace CommandQueues.Core
{
    public interface ICommandQueue : INodeCommand
    {
        void NotifyCommandDone();
    }
}