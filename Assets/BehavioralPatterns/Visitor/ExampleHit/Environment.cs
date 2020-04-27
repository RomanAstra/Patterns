namespace Visitor.ExampleHit
{
    public sealed class Environment : Hit
    {
        public override void Activate(IDealingDamage value, float damage)
        {
            value.Visit(this, new InfoCollision(damage));
        }
    }
}
