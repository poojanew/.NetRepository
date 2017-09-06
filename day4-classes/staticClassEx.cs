using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4_classes
{
    static class staticClassEx
    {
        static double pi = (22 / 7);
        public static void degreeToRadian(float value)
        {
            double result = ((value * pi) / 180);
            Console.WriteLine("Radian Value is : " + result);
        }
    }
}
