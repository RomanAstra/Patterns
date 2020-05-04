using UnityEngine;


namespace Bridge
{
    public sealed class Enemy : MonoBehaviour
    {
        private IAtake _atake;
        private IMove _move;
        
        private void Start()
        {
            _atake = new MagicalAttack();
            _move = new TransformMove();
        }


        public void Atake()
        {
            _atake.Atake();
        }
        
        public void Move()
        {
            _move.Move();
        }
    }
}
