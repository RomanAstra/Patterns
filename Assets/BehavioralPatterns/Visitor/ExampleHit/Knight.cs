namespace Visitor.ExampleHit
{
    public sealed class Knight : Hit
    {
        public float Armor;
        public override void Activate(IDealingDamage value, float damage)
        {
            value.Visit(this, new InfoCollision(damage));
        }
    }
}
