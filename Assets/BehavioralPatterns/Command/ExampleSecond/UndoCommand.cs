using System.Collections.Generic;
using UnityEngine;

namespace Command.ExampleSecond
{
    public sealed class UndoCommand : Command
    {
        public override void Execute(Transform boxTrans, Command command)
        {
            List<Command> oldCommands = InputHandler.OldCommands;

            if (oldCommands.Count > 0)
            {
                Command latestCommand = oldCommands[oldCommands.Count - 1];

                latestCommand.Undo(boxTrans);

                oldCommands.RemoveAt(oldCommands.Count - 1);
            }
        }
    }
}
