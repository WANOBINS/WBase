using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace WBase.Unity
{
    public class CoolDown
    {
        private float? LastActivation = null;
        public float Delay;

        public CoolDown(float Delay)
        {
            this.Delay = Delay;
        }

        public bool Start()
        {
            if(LastActivation == null || Time.time >= LastActivation + Delay)
            {
                LastActivation = Time.time;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
