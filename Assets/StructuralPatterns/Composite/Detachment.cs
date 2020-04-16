using System.Collections.Generic;


namespace Composite
{
    public sealed class Detachment : IAttack
    {
        private List<IAttack> _attacks = new List<IAttack>();

        public void AddUnit(IAttack attack)
        {
            _attacks.Add(attack);
        }

        public void RemoveUnit(IAttack attack)
        {
            _attacks.Remove(attack);
        }
        
        public void Attack()
        {
            foreach (var attack in _attacks)
            {
                attack.Attack();
            }
        }
    }
}
