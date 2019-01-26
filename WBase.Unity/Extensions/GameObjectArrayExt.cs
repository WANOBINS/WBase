using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace WBase.Unity.Extensions
{
    public static class GameObjectArrayExt
    {
        public static GameObject GetClosestTo(this GameObject[] GameObjects, Vector3 Position)
        {
            GameObject Closest = null;
            foreach(GameObject go in GameObjects)
            {
                if(Closest == null || (go.transform.position - Position).magnitude < (Closest.transform.position - Position).magnitude)
                {
                    Closest = go;
                }
            }
            return Closest;
        }
    }
}
