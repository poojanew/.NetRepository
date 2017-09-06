using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Aug9_
{
    class assignment2
    {
        public void numPrint()
        {
            Console.WriteLine("Enter number");
            int num = Convert.ToInt16(Console.ReadLine());
          

            for (int i = 0; i < 3; i++)
            {
                Console.Write(num);
                Console.Write(" ");
            }
        }
    }
}
