using UnityEngine;


namespace Visitor.ExampleHit
{
    public sealed class ConsoleDisplay : IDealingDamage
    {
        public void Visit(Enemy hit, InfoCollision info)
        {
            Debug.Log($"{nameof(Enemy)} - {info.Damage}");
        }

        public void Visit(Environment hit, InfoCollision info)
        {
            Debug.Log($"{nameof(Environment)} - {info.Damage}");
        }

        public void Visit(Knight hit, InfoCollision info)
        {
            Debug.Log($"{nameof(Knight)} - {info.Damage}");
        }
    }
}
