using UnityEngine;

namespace FactoryMethod
{
    public sealed class SmallEnemyFactory : ICreatorEnemy
    {
        public Enemy Create(Hp hp)
        {
            var enemy = Object.Instantiate(Resources.Load<SmallEnemy>(AssetPath.Enemies[EnemyType.Small]));

            enemy.SetHP(hp);

            return enemy;
        }
    }
}
