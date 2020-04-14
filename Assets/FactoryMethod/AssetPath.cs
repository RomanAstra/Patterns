using System.Collections.Generic;

namespace FactoryMethod
{
    public static class AssetPath
    {
        public static readonly Dictionary<EnemyType, string> Enemies = new Dictionary<EnemyType, string>
        {
            {EnemyType.Small, "Prefabs/Enemies/Prefabs_Enemies_SmallEnemy"}
        };
    }
}
