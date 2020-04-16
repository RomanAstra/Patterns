using System;
using UnityEngine;

namespace FactoryMethod
{
    public sealed class CreatorEnemies : MonoBehaviour
    {
        [SerializeField] private EnemyType _enemyType;
        [SerializeField] private float _hp;
        private ICreatorEnemy _creatorEnemy;
        private void Start()
        {
            // Enemy.CreateSmallEnemy(new Hp());

            switch (_enemyType)
            {
                case EnemyType.None:
                case EnemyType.Small:
                    _creatorEnemy = new SmallEnemyFactory();
                    break;
                case EnemyType.Big:
                default:
                    throw new ArgumentOutOfRangeException();
            }

            var enemy = _creatorEnemy.Create(new Hp());
            
            // var enemy = Instantiate(Resources.Load<SmallEnemy>(AssetPath.Enemies[EnemyType.Small]));
            enemy.Hp.HP -= 5;
        }
        
    }
}
