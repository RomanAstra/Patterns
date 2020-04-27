using System;
using UnityEngine;


namespace NullObject
{
    public sealed class NullObjectTest : MonoBehaviour
    {
        public event Action Doing = () => { };
        
        private void Start()
        {
            Doing.Invoke();
            
            // Пример в паттерне команда класс DoNothing
        }
    }
}
