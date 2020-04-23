using UnityEngine;
using System.Collections;
using System.Collections.Generic;


namespace Command.ExampleSecond
{
    public sealed class InputHandler : MonoBehaviour
    {
        [SerializeField] private Transform _box;
        private Command _buttonW;
        private Command _buttonS;
        private Command _buttonA;
        private Command _buttonD;
        private Command _buttonB;
        private Command _buttonZ;
        private Command _buttonR;
        private Vector3 _boxStartPosition;
        private Coroutine _replayCoroutine;
        public static readonly List<Command> OldCommands = new List<Command>();
        public static bool ShouldStartReplay;
        private bool _isReplaying;

        private void Start()
        {
            _buttonB = new DoNothing();
            _buttonW = new MoveForward();
            _buttonS = new MoveReverse();
            _buttonA = new MoveLeft();
            _buttonD = new MoveRight();
            _buttonZ = new UndoCommand();
            _buttonR = new ReplayCommand();

            _boxStartPosition = _box.position;
        }

        private void Update()
        {
            if (!_isReplaying)
            {
                HandleInput();
            }

            StartReplay();
        }


        private void HandleInput()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                _buttonA.Execute(_box, _buttonA);
            }
            else if (Input.GetKeyDown(KeyCode.B))
            {
                _buttonB.Execute(_box, _buttonB);
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                _buttonD.Execute(_box, _buttonD);
            }
            else if (Input.GetKeyDown(KeyCode.R))
            {
                _buttonR.Execute(_box, _buttonZ);
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                _buttonS.Execute(_box, _buttonS);
            }
            else if (Input.GetKeyDown(KeyCode.W))
            {
                _buttonW.Execute(_box, _buttonW);
            }
            else if (Input.GetKeyDown(KeyCode.Z))
            {
                _buttonZ.Execute(_box, _buttonZ);
            }
        }


        private void StartReplay()
        {
            if (ShouldStartReplay && OldCommands.Count > 0)
            {
                ShouldStartReplay = false;

                if (_replayCoroutine != null)
                {
                    StopCoroutine(_replayCoroutine);
                }

                _replayCoroutine = StartCoroutine(ReplayCommands(_box));
            }
        }


        private IEnumerator ReplayCommands(Transform boxTrans)
        {
            _isReplaying = true;
            
            boxTrans.position = _boxStartPosition;

            for (int i = 0; i < OldCommands.Count; i++)
            {
                OldCommands[i].Move(boxTrans);

                yield return new WaitForSeconds(0.3f);
            }

            _isReplaying = false;
        }
    }
}
