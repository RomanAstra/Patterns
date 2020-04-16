using System.Collections.Generic;


namespace Decorator
{
    public static class AssetPath
    {
        public static readonly Dictionary<ModificationWeaponType, string> Modifications = new Dictionary<ModificationWeaponType, string>
        {
            {ModificationWeaponType.Muffler, "Prefabs/ModificationWeapon/Prefabs_ModificationWeapon_Muffler"},
            {ModificationWeaponType.Aim, "Prefabs/ModificationWeapon/Prefabs_ModificationWeapon_Aim"},
        };
    }
}
