namespace CommandQueues.Core
{
    public interface INodeCommand : ICommand
    {
        void SetCommandQueue(ICommandQueue commandQueue);
    }
}