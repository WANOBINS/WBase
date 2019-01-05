using System;
using System.Collections.Generic;
using System.Text;

namespace WBase.Core
{
    public interface IDamageSource
    {
        string GetDeathString(INamed named);
        string GetDeathString(string name);
    }
}
