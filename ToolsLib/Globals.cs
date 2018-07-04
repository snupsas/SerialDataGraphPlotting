using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsLib
{
    public static class Globals
    {
        public struct Bytes
        {
            public static byte NUL => 0B00000000;
            public static byte CR => 0b00001101;
            public static byte LF => 0b00001010;
        }
    }
}
