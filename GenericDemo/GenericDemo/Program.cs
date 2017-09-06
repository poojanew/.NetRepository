using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            genericSwapping<int> genericObj = new genericSwapping<int>();
            genericSwapping<string> genericObj1 = new genericSwapping<string>();


            int a = 6, b = 10;
            genericObj.swap(ref a, ref b);

            string a1 = "pooja", b1 = "newase";
            genericObj1.swap(ref a1, ref b1);

            Console.ReadLine();
        }
    }

    class genericSwapping<T>
    {
        public void swap(ref T a,ref T b)
        {

            Console.WriteLine("Before swapping\na:{0},b:{1}\n", a, b);

            T temp;
            temp = a;
            a = b;
            b = temp;

            Console.WriteLine("After swapping\na:{0},b:{1}", a,b);
        }
    }
}
