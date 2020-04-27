using UnityEngine;


namespace Strategy
{
    [CreateAssetMenu(fileName = "Rotate", menuName = "Data/Behaviour/Rotate", order = 0)]
    public sealed class RotateBehaviour: BaseBehaviour
    {
        public override void Behaviour(Transform value)
        {
            value.Rotate(Vector3.up * _speed);
        }
    }
}