using UnityEngine;

namespace Command.ExampleSecond
{
    public sealed class ReplayCommand : Command
    {
        public override void Execute(Transform boxTrans, Command command)
        {
            InputHandler.ShouldStartReplay = true;
        }
    }
}
