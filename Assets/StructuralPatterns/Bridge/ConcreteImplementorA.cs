using UnityEngine;


namespace Bridge
{
    public sealed class ConcreteImplementorA : Implementor
    {
        public override void Operation()
        {
            Debug.Log("ConcreteImplementorA Operation");
        }
    }
}
