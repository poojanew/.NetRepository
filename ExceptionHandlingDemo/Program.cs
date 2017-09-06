using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //customDemo cd = new customDemo();
            //cd.showTemp();


            Program p = new Program();
           
            p.division(7, 0);
            // p.division(8, 5);

            Console.ReadLine();
        }

        public void division(int a,int b)
        {
            int result=0;
            try
            {
                result = a / b;
            }
            catch(DivideByZeroException e)
            {

                Console.WriteLine("Exception occured : {0}\n\n\n{1}", e,(e.TargetSite).Name);
            }
            finally
            {
                Console.WriteLine("{0} divided by {1} gives {2}", a, b, result);
            }
        }

        public void addition()
        {
            int result = 0,a=0,b=0;
            try
            {
                Console.WriteLine("Enter values : ");
                // a = Convert.ToInt32(Console.ReadLine());
                // b = Convert.ToInt32(Console.ReadLine());
                bool m = true;
                IConvertible k = m;
                char c = k.ToChar(null);
                result = a + b;
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine("Exception : {0}", e);
            }
            finally
            {
                Console.WriteLine("{0} divided by {1} gives {2}", a, b, result);
            }
        }

        public void multiplication()
        {
            int result = 0, a=0, b=0;
            try
            {
                Console.WriteLine("Enter values : ");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());

                result = a + b;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception : {0}", e);
            }
            finally
            {
                Console.WriteLine("{0} divided by {1} gives {2}", a, b, result);
            }
        }
    }
}
