using System.Collections;
using UnityEngine;


namespace ChainOfResponsibility
{
    public sealed class MoveToPosition : GameHandler
    {
        [SerializeField] private Vector3 _positionToMove;
        [SerializeField] private float _speed;
        private bool _moveToPosition;

        private IEnumerator StartMoving()
        {
            while ((transform.position -_positionToMove).sqrMagnitude > 0.0f)
            {
                transform.position = Vector2.MoveTowards(transform.position, _positionToMove, Time.deltaTime * _speed);
                yield return null;
            }
            base.Handle();
        }

        public override void Handle()
        {
            StartCoroutine(StartMoving());
        }
    }
}
