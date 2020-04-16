using UnityEngine;


namespace Decorator
{
    
    /// <summary>
    /// Добавить прицел и удалить прицел и глушитель
    /// </summary>
    public sealed class DecoratorTest : MonoBehaviour
    {
        [SerializeField] private Weapon _weapon;
        
        private void Start()
        {
            ModificationMuffler modificationMuffler = new ModificationMuffler();
            
            modificationMuffler.AddModification(_weapon);
        }
    }
}
