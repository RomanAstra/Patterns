using UnityEngine;


namespace Proxy
{
    public sealed class ProxyTest : MonoBehaviour
    {
        private void Start()
        {
            MathProxy proxy = new MathProxy();

            Debug.Log("2 + 2 = " + proxy.Add(2, 2));
            Debug.Log("2 - 2 = " + proxy.Sub(2, 2));
            Debug.Log("2 * 2 = " + proxy.Mul(2, 2));
            Debug.Log("2 / 2 = " + proxy.Div(2, 2));
        }
    }
}
