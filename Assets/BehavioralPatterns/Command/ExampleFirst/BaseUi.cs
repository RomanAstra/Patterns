using UnityEngine;


namespace Command.ExampleFirst
{
    public abstract class BaseUi : MonoBehaviour
    {
        public abstract void Execute();  
        public abstract void Cancel();
        //public abstract void Repeat();
        //....
    }
}
