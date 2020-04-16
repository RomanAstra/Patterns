using UnityEngine;


namespace ObjectPool
{
    public sealed class Gun : MonoBehaviour
    {
        #region Fields
        
        [SerializeField] private Transform _barrel;
        [SerializeField] private float _powerShooting;
        private AmmunitionPool _ammunitionPool;

        #endregion

        
        #region UnityMethods

        private void Awake()
        {
            _ammunitionPool = new AmmunitionPool(8);
        }

        private void Update()
        {
            Shooting();
        }

        #endregion
        

        #region Methods
        
        private void Shooting()
        {
            if (Input.GetButtonDown(AxisManager.FIRE1))
            {
                var ammunition = _ammunitionPool.GetAmmunition(AmmunitionType.Bullet);
                ammunition.AddForce(_barrel.position, 
                    Quaternion.Euler(ammunition.transform.eulerAngles.x, 
                        ammunition.transform.eulerAngles.y, Random.Range(0, 360)), 
                    _barrel.up * _powerShooting);
            }
        }

        #endregion
    }
}
