using UnityEngine;


namespace Strategy
{
    [CreateAssetMenu(fileName = "Move", menuName = "Data/Behaviour/Move", order = 1)]
    public sealed class MoveBehaviour : BaseBehaviour
    {
        public float Length;
        public override void Behaviour(Transform value)
        {
            value.position = new Vector3(value.position.x,
                Mathf.PingPong(Time.time * _speed, Length),
                value.position.z);
        }
    }
}
