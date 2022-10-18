using System.Collections.Generic;
using Installers.Core;
using UnityEngine;

namespace CommandQueues.Core
{
    public class CommandQueueInstaller : MonoInstaller<ICommandQueue>
    {
        [Header("References")]
        [SerializeField] private MonoInstaller<INodeCommand>[] _nodeCommandInstallers;

        protected override ICommandQueue GetData()
        {
            List<INodeCommand> _nodeCommands = new List<INodeCommand>();

            foreach (var nodeCommandInstaller in _nodeCommandInstallers)
            {
                _nodeCommands.Add(nodeCommandInstaller.Data);
            }

            return new CommandQueue(_nodeCommands.ToArray());
        }
    }
}