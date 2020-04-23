using UnityEngine;

namespace Command.ExampleSecond
{
    public abstract class Command
    {
        protected float moveDistance = 1f;

        public abstract void Execute(Transform boxTrans, Command command);

        public virtual void Undo(Transform boxTrans) { }

        public virtual void Move(Transform boxTrans) { }
    }
}