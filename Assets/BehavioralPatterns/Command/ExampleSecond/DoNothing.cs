using UnityEngine;

namespace Command.ExampleSecond
{
    public class DoNothing : Command
    {
        public override void Execute(Transform boxTrans, Command command)
        {
        }
    }
}
