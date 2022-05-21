using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPong
{
    public static class Boundaries
    {
        public const int topOfWorld = 0, bottomOfWorld = 568, leftEnd = 0, rightEnd = 1083;
        public const int centreX = (leftEnd + rightEnd) / 2;
        public const int centreY = (topOfWorld + bottomOfWorld) / 2;
    }
}
