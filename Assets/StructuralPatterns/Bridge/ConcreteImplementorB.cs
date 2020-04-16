using UnityEngine;


namespace Bridge
{
    public sealed class ConcreteImplementorB : Implementor
    {
        public override void Operation()
        {
            Debug.Log("ConcreteImplementorB Operation");
        }
    }
}
