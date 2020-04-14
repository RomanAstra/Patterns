using UnityEngine;


namespace Singleton
{
    public sealed class Manager : SingletonMonoBehaviour<Manager>
    {
        public void Test()
        {
            Debug.Log($"{nameof(Manager)} - {GetInstanceID()}");
        }
    }
}
