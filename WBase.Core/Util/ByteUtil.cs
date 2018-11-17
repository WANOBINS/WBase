using System;
using System.Collections.Generic;
using System.Text;

namespace WBase.Core.Util
{
    public static class ByteUtil
    {
        private static Dictionary<Type, int> Cache = new Dictionary<Type, int>();

        public static int BytesIn(Type t)
        {
            if (!Cache.ContainsKey(t))
            {
#pragma warning disable CS0618 // Type or member is obsolete
                Cache.Add(t, System.Runtime.InteropServices.Marshal.SizeOf(t) / 8);
#pragma warning restore CS0618 // Type or member is obsolete
            }
            return Cache[t];
        }
    }
}
