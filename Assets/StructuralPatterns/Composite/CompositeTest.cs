using UnityEngine;


namespace Composite
{
    public sealed class CompositeTest : MonoBehaviour
    {
        private void Start()
        {
            IAttack attack = new Unit();
            Detachment attacks = new Detachment();
            attacks.AddUnit(attack);
            
            attacks.Attack();
        }
    }
}
