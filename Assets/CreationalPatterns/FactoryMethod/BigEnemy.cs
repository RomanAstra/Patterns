using UnityEngine;


namespace FactoryMethod
{
    public sealed class BigEnemy : Enemy
    {
        public override void Fire()
        {
            Debug.Log(nameof(BigEnemy));
        }
    }
}
