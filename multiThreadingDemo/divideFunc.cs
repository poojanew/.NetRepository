using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace multiThreadingDemo
{
    class divideFunc
    {
        static int num1;
        static int num2;

        public void executeLockThreads()
        {
            Thread t1 = new Thread(divide);
            Thread t2 = new Thread(divide);

            try
            {
                t1.Start();
                t2.Start();
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e);
            }
            
            
         
        }
        public void divide()
        {
        
                Random rnd = new Random();
      
                 for (int i = 0; i < 2000000; i++)
                {
                Monitor.Enter(this);
                    num1 = rnd.Next(1, 100);
                    num2 = rnd.Next(1, 100);
                    int result = num1 / num2;
               
                    Console.WriteLine("Division of {0},{1} is {2}", num1, num2, result);
                    num1 = 0;
                    num2 = 0;
                Monitor.Exit(this);
                }




        }
    }
}
