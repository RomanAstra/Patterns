using UnityEngine;


namespace Adapter
{
    public sealed class AdapterTest : MonoBehaviour
    {
        private Camera _camera;
        private IFire _fire;
        
        private void Awake()
        {
            _camera = Camera.main;
            _fire = new Enemy();
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                var mousePos = Input.mousePosition;
                mousePos.z = 20.0f;
                var objectPos = _camera.ScreenToWorldPoint(mousePos);
                
                _fire.Fire(objectPos);
            }
        }
    }
}
