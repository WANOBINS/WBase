using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace WBase.Unity.Extensions
{
    public static class ListExt
    {
        public static void PurgeNulls(this List<GameObject> list)
        {
            for(int i = 0; i < list.Count;)
            {
                if (list[i] != null)
                {
                    i++;
                }
                else
                {
                    list.RemoveAt(i);
                }
            }
        }
    }
}
