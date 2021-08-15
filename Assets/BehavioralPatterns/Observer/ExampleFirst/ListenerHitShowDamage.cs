﻿using UnityEngine;

namespace BehavioralPatterns.Observer.ExampleFirst
{
    public sealed class ListenerHitShowDamage
    {
        public void Add(IHit value)
        {
            value.OnHitChange += ValueOnOnHitChange;
        }

        public void Remove(IHit value)
        {
            value.OnHitChange -= ValueOnOnHitChange;
        }

        private void ValueOnOnHitChange(float damage)
        {
            Debug.Log(damage);
        }
    }
}
