using System;
using System.Collections.Generic;

namespace CommandQueues.Core
{
    public class CommandQueue : ICommandQueue
    {
        private readonly Queue<INodeCommand> _nodeCommands;
        private ICommandQueue _commandQueue;

        public Action OnExecutionDone { get; set; }

        public CommandQueue(INodeCommand[] nodeCommands)
        {
            _nodeCommands = new Queue<INodeCommand>();

            foreach (var nodeCommander in nodeCommands)
            {
                nodeCommander.SetCommandQueue(this);
                _nodeCommands.Enqueue(nodeCommander);
            }
        }

        public void Execute()
        {
            if (_nodeCommands.Count <= 0)
            {
                ExecutionIsDone();
                return;
            }

            RunNextCommand();
        }

        public void RunNextCommand()
        {
            INodeCommand nodeCommand = _nodeCommands.Dequeue();
            nodeCommand?.Execute();
        }

        public void NotifyCommandDone()
        {
            if (_nodeCommands.Count <= 0)
            {
                ExecutionIsDone();
                return;
            }

            RunNextCommand();
        }

        private void ExecutionIsDone()
        {
            OnExecutionDone?.Invoke();
            _commandQueue?.NotifyCommandDone();
        }

        public void SetCommandQueue(ICommandQueue commandQueue)
        {
            _commandQueue = commandQueue;
        }
    }
}