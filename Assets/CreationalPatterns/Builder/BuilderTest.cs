using UnityEngine;


namespace Builder
{
    public sealed class BuilderTest : MonoBehaviour
    {
        [SerializeField] private Sprite _sprite;
        
        private void Start()
        {
            new GameObject().SetName("Enemy").AddBoxCollider2D().AddBoxCollider2D().AddRigidbody2D(5.0f).AddSprite(_sprite);
        }
    }
}
