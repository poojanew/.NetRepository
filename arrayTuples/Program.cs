using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayTuples
{
    class Program
    {
        static void Main(string[] args)
        {
            arrayDemo arr = new arrayDemo();
            arr.printSArray();
            arr.printMArray();
            arr.jaggedArray();

            Console.WriteLine("---------------------------------------");
            tupleDemo tup = new tupleDemo();
            tup.displayTuple();

            Console.WriteLine("---------------------------------------");
            structDemo s1 = new structDemo(5,7);
            structDemo s2 = s1;
            int x = s1.a;
            int y = s1.b;
            int c = s2.a;
            int d = s2.b;
            Console.WriteLine("{0},{1},{2},{3}",x,y,c,d);

            struct_class sc1 = new struct_class();
            struct_class sc2 = sc1;
            int x1 = sc1.a;
            int y1 = sc1.b;
            int c1 = sc2.a;
            int d1 = sc2.b;
            Console.WriteLine("{0},{1},{2},{3}", x1, y1, c1, d1);


            Console.ReadLine();
        }
    }
}
