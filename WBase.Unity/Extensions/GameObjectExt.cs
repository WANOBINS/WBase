using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace WBase.Unity.Extensions
{
    public static class GameObjectExt
    {
        public static GameObject[] GetChildrenRecursively(this GameObject gameObject)
        {
            return gameObject.transform.GetChildrenRecursive().GameObjects();
        }
    }
}
