using System;

namespace WBase.Unity.Util
{
    public class TimeUtil
    {
        public static int UnixTimestamp
        {
            get
            {
                return (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
            }
        }
    }
}
