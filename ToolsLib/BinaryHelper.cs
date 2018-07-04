using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsLib
{
    public static class BinaryHelper
    {
        public static int IndexOfFirstElement(this byte[] byteArray, Func<byte, bool> searchCriterea)
        {
            for (int i = 0; i < byteArray.Length; i++)
            {
                var elemtent = byteArray[i];
                if (searchCriterea.Invoke(elemtent))
                {
                    return i;
                }
            }
            return -1;
        }

        public static bool EndsWithCRLF(this byte[] byteArray)
        {
            var firstNullIndex = byteArray.IndexOfFirstElement(x => x == Globals.Bytes.NUL);
            if (firstNullIndex < 2)
            {
                return false;
            }

            return byteArray[firstNullIndex - 1] == Globals.Bytes.LF && byteArray[firstNullIndex - 2] == Globals.Bytes.CR;
        }

        public static void Clear(this byte[] byteArray)
        {
            for (int i = 0; i < byteArray.Length; i++)
            {
                byteArray[i] = Globals.Bytes.NUL;
            }
        }

        public static byte[] GetBytesWithoutCRLF(this byte[] byteArray)
        {
            if (!EndsWithCRLF(byteArray))
            {
                return byteArray;
            }

            var firstNullIndex = byteArray.IndexOfFirstElement(x => x == Globals.Bytes.NUL);
            return byteArray.Take(firstNullIndex - 2).ToArray();
        }
    }
}
