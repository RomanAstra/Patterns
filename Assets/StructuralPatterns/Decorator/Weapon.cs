using UnityEngine;


namespace Decorator
{
    public sealed class Weapon : MonoBehaviour
    {
        [SerializeField] private float _shotVolume;
        [SerializeField] private Transform _placeForMuffler;

        public void SetShotVolume(float shotVolume)
        {
            _shotVolume -= shotVolume;
        }

        public Vector3 MufflerPosition()
        {
            return _placeForMuffler.position;
        }
    }
}
