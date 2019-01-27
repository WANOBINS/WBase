using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace WBase.Unity.Extensions
{
    public static class Vector3Ext
    {
        public static Vector3 FromFloat(this Vector3 v3, float f)
        {
            return new Vector3(f, f, f);
        }

        public static Vector3 FromInt(this Vector3 v3, int i)
        {
            return new Vector3(i, i, i);
        }

        public static Vector3 FromFloat(float f)
        {
            return new Vector3(f, f, f);
        }

        public static Vector3 FromInt(int i)
        {
            return new Vector3(i, i, i);
        }
    }
}
