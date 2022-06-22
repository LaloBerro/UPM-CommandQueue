using System;

namespace CommandQueues.Core
{
    public interface ICommandQueue : INodeCommand
    {
        Action OnExecutionDone { get; set; }
        void NotifyCommandDone();
    }
}