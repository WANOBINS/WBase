using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace WBase.Unity.Extensions
{
    public static class TransformArrayExt
    {
        public static GameObject[] GameObjects(this Transform[] transforms)
        {
            List<GameObject> gameObjects = new List<GameObject>();
            foreach(Transform t in transforms)
            {
                gameObjects.Add(t.gameObject);
            }
            return gameObjects.ToArray();
        }
    }
}
