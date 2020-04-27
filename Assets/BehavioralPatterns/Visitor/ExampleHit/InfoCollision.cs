using UnityEngine;


namespace Visitor.ExampleHit
{
    public readonly struct InfoCollision
    {
        private readonly Vector3 _dir;
        private readonly float _damage;

        public InfoCollision(float damage, Vector3 dir = default)
        {
            _damage = damage;
            _dir = dir;
        }

        public Vector3 Dir => _dir;

        public float Damage => _damage;
    }
}
