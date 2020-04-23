using UnityEngine;

namespace Mediator
{
    public sealed class MediatorTest : MonoBehaviour
    {
        [SerializeField] private View _view;

        private void Awake()
        {
            new Controller(new Model(100), _view).Show();
        }
    }
}
