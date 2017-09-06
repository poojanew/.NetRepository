using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Aug8_
{
    class addOverloading
    {
        public void add(int a,int b)
        {
            Console.WriteLine("Addition of {0} and {1} : {2}", a, b, (a + b));
        }

        public void add(int a, int b,int c)
        {
            Console.WriteLine("Addition of {0},{1} and {2} : {3}", a, b,c, (a + b+c));
        }

        public void add(int a, int b, int c,int d)
        {
            Console.WriteLine("Addition of {0},{1},{2} and {3} : {4}", a, b, c,d, (a + b + c+d));
        }
    }
}
