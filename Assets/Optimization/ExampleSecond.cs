using UnityEngine;

namespace Optimization
{
    public sealed class ExampleSecond : MonoBehaviour
    {
        private Renderer myRenderer;

        private void Start()
        {
            myRenderer = GetComponent<Renderer>();
        }

        private void Update()
        {
            UpdateTransformPosition();

            if (myRenderer.isVisible)
            {
                UpateAnimations();
            }
        }

        private void UpateAnimations()
        {
           //...
        }

        private void UpdateTransformPosition()
        {
           //...
        }
    }
}
