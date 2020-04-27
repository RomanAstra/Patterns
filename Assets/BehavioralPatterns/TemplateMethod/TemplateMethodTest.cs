using UnityEngine;


namespace TemplateMethod
{
    public sealed class TemplateMethodTest : MonoBehaviour
    {
        private void Start()
        {
            var vk = new VK();
            vk.Draw();
        }
    }
}
