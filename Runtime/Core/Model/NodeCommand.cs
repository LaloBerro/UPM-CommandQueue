namespace CommandQueues.Core
{
    public abstract class NodeCommand : INodeCommand
    {
        private ICommandQueue _commandQueue;

        public void SetCommandQueue(ICommandQueue commandQueue)
        {
            _commandQueue = commandQueue;
        }

        public abstract void Execute();

        protected void NotifyDoneExecution()
        {
            _commandQueue.NotifyCommandDone();
        }
    }
}