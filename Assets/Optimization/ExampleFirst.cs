 using System.Runtime.CompilerServices;
 using UnityEngine;

 namespace Optimization
{
    public sealed class ExampleFirst : MonoBehaviour
    {
        private Renderer _renderer;
        private static readonly int EmissionColor = Shader.PropertyToID("_EmissionColor");
        private static readonly int Run = Animator.StringToHash("Run");

        private void Update()
        {
            if (Time.frameCount % 2 == 0)
            {
                ComparisonsString();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void ComparisonsString()
        {
            string str1 = "Roman";
            string str2= "Roman";
            Debug.Log(str1.Equals(str2));
        }

        private void AddressPropertiesByID()
        {
            _renderer.material.SetColor (EmissionColor, Color.cyan);
        }

        private void ComponentCaching()
        {
            _renderer = GetComponent<Renderer>();
        }

        private void NonAllocatingPhysics()
        {
            //Physics.RaycastNonAlloc()
            //Physics.OverlapSphereNonAlloc()
        }

        private void NullComparisons()
        {
            // Проверка на null UnityEngine.Object дорого 
        }

        private void VectorAndQuaternionMathAndOrderOfOperations()
        {
            Vector3 x = Vector3.back;

            int a = 1;
            int b = 2;

// Less efficient: results in two vector multiplications

            Vector3 slow = a * x * b;

// More efficient: one integer mult, one vector mult

            Vector3 fast = a * b * x;
        }

        private void BuiltInColorUtility()
        {
            var htmlStringRgb = ColorUtility.ToHtmlStringRGB(Color.cyan);
        }
    }
}
