using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4_classes
{
    public static class extensionMethodEx
    {
        public static int digitCount(this int a)
        {
            int digitCount=0;

            while (a!=0)
            {
                a=a / 10;
                digitCount++;
            }
            return digitCount;
        }
    }
}
