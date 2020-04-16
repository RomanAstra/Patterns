namespace FactoryMethod
{
    public sealed class BigEnemyFactory : ICreatorEnemy
    {
        public Enemy Create(Hp hp)
        {
            throw new System.NotImplementedException();
        }
    }
}
