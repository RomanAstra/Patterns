using UnityEngine;

namespace Singleton
{
    public sealed class TestSingleton : MonoBehaviour
    {
        private void Start()
        {
            Manager.Instance.Test();
            Services.Instance.Test();
        }
    }
}