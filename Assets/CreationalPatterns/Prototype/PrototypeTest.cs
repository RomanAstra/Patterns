using UnityEngine;


namespace Prototype
{
    public sealed class PrototypeTest : MonoBehaviour
    {
        private void Start()
        {
            DeepCopyExample example = new DeepCopyExample{ Hp = 100};
            DeepCopyExample example2 =  example.DeepCopy();
            example2.Hp = 50;

            Debug.Log(example.Hp);
            Debug.Log(example2.Hp);
        }
    }
}
