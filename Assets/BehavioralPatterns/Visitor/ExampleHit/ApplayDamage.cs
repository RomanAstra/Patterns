namespace Visitor.ExampleHit
{
    public sealed class ApplayDamage : IDealingDamage
    {
        public void Visit(Enemy hit, InfoCollision info)
        {
            hit.Health -= info.Damage;
            hit.TextMesh.text = hit.Health.ToString();
        }

        public void Visit(Environment hit, InfoCollision info)
        {
        }

        public void Visit(Knight hit, InfoCollision info)
        {
            var armor = hit.Armor;
            
            armor -= info.Damage;
            hit.Health -= armor;
            hit.TextMesh.text = hit.Health.ToString();
        }
    }
}
