using System.Collections.Generic;
using UnityEngine;

namespace Optimization
{
    public sealed class ExampleThree : MonoBehaviour
    {
        private List<int> _myList = new List<int>();
        private string playerTag = "Player";

        private void Update()
        {
            _myList.Clear();
            PopulateList(_myList);
        }

        private void PopulateList(List<int> list)
        {
            //...
        }

        private void OnTriggerEnter(Collider other)
        {
            bool isPlayer = other.gameObject.CompareTag(playerTag);
        }
    }
}
