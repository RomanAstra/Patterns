using UnityEngine;


namespace Bridge
{
    public sealed class Enemy : MonoBehaviour
    {
        private IAttake _attake;
        private IMove _move;
        
        private void Start()
        {
            _attake = new MagicalAttack();
            _move = new TransformMove();
        }


        public void Atake()
        {
            _attake.Attake();
        }
        
        public void Move()
        {
            _move.Move();
        }
    }
}
