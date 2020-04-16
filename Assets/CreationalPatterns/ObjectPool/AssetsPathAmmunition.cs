using System.Collections.Generic;


namespace ObjectPool
{
    public sealed class AssetsPathAmmunition
    {
        #region Fields

        public static readonly Dictionary<AmmunitionType, string> Ammunitions = new Dictionary<AmmunitionType, string>
        {
            {
                AmmunitionType.Bullet, "Prefabs/Ammunition/Prefabs_Ammunition_Bullet"
            }
        };

        #endregion
    }
}
