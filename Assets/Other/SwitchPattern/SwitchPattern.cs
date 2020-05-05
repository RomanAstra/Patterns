using System;
using System.Collections.Generic;

namespace SwitchPattern
{
    public sealed class SwitchPattern
    {
        private readonly Dictionary<Move, Action> _moveMap;

        public SwitchPattern()
        {
            _moveMap = new Dictionary<Move, Action> 
            {
                {Move.Up, MoveUp},
                {Move.Down, MoveDown},
                {Move.Left, MoveLeft},
                {Move.Right, MoveRight}, 
                {
                    Move.Combo, () => 
                    {
                        MoveUp();
                        MoveUp();
                        MoveDown();
                        MoveDown();
                    }
                }
            };
        }

        public void Perform(Move move) 
        {
            switch (move) 
            {
                case Move.Up:
                    MoveUp();
                    break;
                case Move.Down:
                    MoveDown();
                    break;
                case Move.Left:
                    MoveLeft();
                    break;
                case Move.Right:
                    MoveRight();
                    break;
                case Move.Combo:
                    MoveUp();
                    MoveUp();
                    MoveDown();
                    MoveDown();
                    break;
            }
        }

        public void PerformWithDictionary(Move move) 
        {
            _moveMap[move]();
        }

        private void MoveRight() {}

        private void MoveLeft() {}

        private void MoveDown() {}

        private void MoveUp() {}
    }
}
