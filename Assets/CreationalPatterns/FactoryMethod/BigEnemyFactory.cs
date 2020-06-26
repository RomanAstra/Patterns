using UnityEngine;


namespace FactoryMethod
{
    public sealed class BigEnemyFactory : ICreatorEnemy
    {
        public Enemy Create(Hp hp)
        {
            var enemy = Object.Instantiate(Resources.Load<BigEnemy>(AssetPath.Enemies[EnemyType.Big]));

            enemy.SetHP(hp);

            return enemy;
        }
    }
}
