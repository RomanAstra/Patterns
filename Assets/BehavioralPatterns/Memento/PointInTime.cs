using UnityEngine;


namespace Memento
{
    public sealed class PointInTime
    {
        public Vector3 Position;
        public Quaternion Rotation;

        public PointInTime (Vector3 position, Quaternion rotation)
        {
            Position = position;
            Rotation = rotation;
        }

    }
}
