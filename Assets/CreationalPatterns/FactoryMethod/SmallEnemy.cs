using UnityEngine;

namespace FactoryMethod
{
    public sealed class SmallEnemy : Enemy
    {
        public override void Fire()
        {
            Debug.Log(nameof(SmallEnemy));
        }
    }
}
