using UnityEngine;


namespace Adapter
{
    public sealed class Enemy : IFire
    {
        private readonly IAttack _attack = new AttackBullet();
        
        public void Fire(Vector3 position)
        {
            _attack.Attack(position);
        }
    }
}
