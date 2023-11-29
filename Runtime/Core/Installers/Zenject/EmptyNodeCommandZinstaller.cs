namespace CommandQueues.Core
{
    public class EmptyNodeCommandZinstaller : NodeCommandZinstaller
    {
        protected override INodeCommand GetInitializedClass()
        {
            return new EmptyNodeCommand();
        }
    }
}