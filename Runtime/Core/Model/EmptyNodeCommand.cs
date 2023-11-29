namespace CommandQueues.Core
{
    public class EmptyNodeCommand : NodeCommand
    {
        public override void Execute()
        {
            NotifyDoneExecution();
        }
    }
}