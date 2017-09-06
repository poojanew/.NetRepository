using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Aug8_
{
    class birdInheritance
    {
        public void walk()
        {
            Console.WriteLine("Bird can Walk");
        }
    }

    class bird1 : birdInheritance
    {
  
        public void fly()
        {
            Console.WriteLine("Bird1 can walk");
        }
    }

    class bird2 : birdInheritance
    {
   
        public void sing()
        {
            Console.WriteLine("Bird2 can sing");
        }
    }
}
