using UnityEngine;


namespace Bridge
{
    public sealed class BridgeTest : MonoBehaviour
    {
        private void Start ( )
        {
            Abstraction ab = new RefinedAbstraction();

            ab.Implementor = new ConcreteImplementorA();
            ab.Operation();
        }
    }
}
