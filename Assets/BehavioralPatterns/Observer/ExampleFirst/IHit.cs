using System;

namespace BehavioralPatterns.Observer.ExampleFirst
{
    public interface IHit
    {
        event Action<float> OnHitChange;
        void Hit(float damage);
    }
}
