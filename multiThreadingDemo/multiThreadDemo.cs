using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace multiThreadingDemo
{
    class multiThreadDemo
    {
      
        public void executeThread()
        {
            Thread t1 = new Thread(func1);
            Thread t2 = new Thread(func2);
            t1.IsBackground = true;
            t1.Start();
            t2.Start();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("In main thread for {0} times", i);
            }
            Console.WriteLine("Exiting from main thread");
        }

        public void func1()
        {
            Console.WriteLine("In thread 1...");
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine("Hello {0}", i);
            }
            
        }

        public void func2()
        {
            Console.WriteLine("In thread 2...");
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Hii {0}", i);
            }
        }
    }

    
}
