using UnityEngine;


namespace Facade
{
    public sealed class FacadeTest : MonoBehaviour
    {
        [SerializeField] private int _mapSize;
        [SerializeField] private string _userName;
        private void Start()
        {
            var gameService = new GameService();
            gameService.Start(_mapSize,  _userName);
        }
    }
}
