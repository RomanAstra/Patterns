using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Object = UnityEngine.Object;


namespace ObjectPool
{
    public sealed class AmmunitionPool
    {
        #region Fields

        private readonly Dictionary<AmmunitionType, HashSet<Ammunition>> _ammunitionPool;
        private readonly int _capacityPool;
        private Transform _rootPool;

        #endregion
        

        #region ClassLifeCycles

        public AmmunitionPool(int capacityPool)
        {
            _ammunitionPool = new Dictionary<AmmunitionType, HashSet<Ammunition>>();
            _capacityPool = capacityPool;
            if (!_rootPool)
            {
                 _rootPool = new GameObject(NameManager.POOL_AMMUNITION).transform;
            }
        }

        #endregion
        

        #region Methods

        public Ammunition GetAmmunition(AmmunitionType type)
        {
            Ammunition result;
            switch (type)
            {
                case AmmunitionType.Bullet:
                    result = GetBullet(GetListAmmunition(type));
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }

            return result;
        }

        private HashSet<Ammunition> GetListAmmunition(AmmunitionType type)
        {
            return _ammunitionPool.ContainsKey(type) ? _ammunitionPool[type] : _ammunitionPool[type] = new HashSet<Ammunition>();
        }

        private Ammunition GetBullet(HashSet<Ammunition> ammunitions)
        {
            var ammunition = ammunitions.FirstOrDefault(a => !a.gameObject.activeSelf);
            if (ammunition == null )
            {
                var laser = CustomResources.Load<Bullet>(AssetsPathAmmunition.Ammunitions[AmmunitionType.Bullet]);
                for (var i = 0; i < _capacityPool; i++)
                {
                    var instantiate = Object.Instantiate(laser);
                    ReturnToPool(instantiate.transform);
                    ammunitions.Add(instantiate);
                }

                GetBullet(ammunitions);
            }
            ammunition = ammunitions.FirstOrDefault(a => !a.gameObject.activeSelf);
            return ammunition;
        }

        private void ReturnToPool(Transform transform)
        {
            transform.localPosition = Vector3.zero;
            transform.localRotation = Quaternion.identity;
            transform.gameObject.SetActive(false);
            transform.SetParent(_rootPool);
        }

        public void RemovePool()
        {
            Object.Destroy(_rootPool.gameObject);
        }

        #endregion
    }
}
