using UnityEngine;

namespace Command.ExampleSecond
{
    public sealed class MoveLeft : Command
    {
        public override void Execute(Transform boxTrans, Command command)
        {
            Move(boxTrans);

            InputHandler.OldCommands.Add(command);
        }

        public override void Undo(Transform boxTrans)
        {
            boxTrans.Translate(boxTrans.right * moveDistance);
        }

        public override void Move(Transform boxTrans)
        {
            boxTrans.Translate(-boxTrans.right * moveDistance);
        }
    }
}
