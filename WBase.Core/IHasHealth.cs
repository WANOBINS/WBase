using System;
using System.Collections.Generic;
using System.Text;

namespace WBase.Core
{
    public interface IHasHealth
    {
        float Health { get; }
        void ApplyHealing(IHealingSource healingSource, float healingAmount);
        void ApplyHealing(float healingAmount);
        void ApplyDamage(IDamageSource damageSource, float damageAmount);
        void AppleDamage(float damageSource);
    }
}
