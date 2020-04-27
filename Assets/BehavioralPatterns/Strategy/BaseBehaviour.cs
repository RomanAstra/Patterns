using UnityEngine;


namespace Strategy
{
    public abstract class BaseBehaviour : ScriptableObject
    {
        [SerializeField] protected float _speed;
        public abstract void Behaviour(Transform value);
    }
}
