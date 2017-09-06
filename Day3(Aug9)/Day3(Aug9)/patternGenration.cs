using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Aug9_
{
    class patternGenration
    {
        public void generatePattern()
        {
            int count;
            Console.WriteLine("Enter no of steps : ");
            int step = Convert.ToInt16( Console.ReadLine());
            count = step;
            for (int i = 0; i < step; i++)
            {
                for (int j = 0; j < step; j++)
                {
                    if (count > j)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");

                    }


                }

                Console.WriteLine("\n");
                count--;
            }

            Console.ReadLine();
        }
    }
}
