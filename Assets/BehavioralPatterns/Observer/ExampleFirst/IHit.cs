using System;

namespace Observer
{
    public interface IHit
    {
        event Action<float> OnHitChange;
        void Hit(float damage);
    }
}
