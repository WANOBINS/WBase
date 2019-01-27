using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace WBase.Unity.Extensions
{
    public static class TransformExt
    {
        public static Transform[] GetChildrenRecursive(this Transform transform)
        {
            List<Transform> output = new List<Transform>();
            for(int i = 0; i < transform.childCount; i++)
            {
                output.Add(transform.GetChild(i));
                output.AddRange(transform.GetChild(i).GetChildrenRecursive());
            }
            return output.ToArray();
        }
    }
}
