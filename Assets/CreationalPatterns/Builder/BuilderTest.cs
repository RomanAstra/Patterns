using UnityEngine;


namespace Builder
{
    public sealed class BuilderTest : MonoBehaviour
    {
        [SerializeField] private Sprite _sprite;
        
        private void Start()
        {
            // new ExampleApp().Run();

            new GameObject().SetName("Enemy").AddRigidbody2D(1.0f).AddBoxCollider2D().AddRigidbody2D(1.0f).AddSprite(_sprite);
        }
    }
}
