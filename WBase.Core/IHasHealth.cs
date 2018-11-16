using System;
using System.Collections.Generic;
using System.Text;

namespace WBase.Core
{
    interface IHasHealth
    {
        double Health { get; }
        void ApplyDamage(float DamageAmount);
        void ApplyHealing(float HealingAmount);
    }
}
