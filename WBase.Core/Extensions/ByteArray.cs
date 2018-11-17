using System;
using System.Collections.Generic;
using System.Text;

namespace WBase.Core.Extensions
{
    public static class ByteArray
    {
        public static byte[] SubBytes(this byte[] bytes, int newStart)
        {
            int NewBytesLength = bytes.Length - newStart;
            byte[] output = new byte[NewBytesLength];
            for(int i = 0; i< NewBytesLength; i++)
            {
                output[i] = bytes[newStart + i];
            }
            return output;
        }
    }
}
