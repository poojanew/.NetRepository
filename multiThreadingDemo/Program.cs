using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace multiThreadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //multiThreadDemo demo = new multiThreadDemo();
            //demo.executeThread();
            //divideFunc divDemo = new divideFunc();
            //divDemo.executeLockThreads();
            threadPoolDemo dm = new threadPoolDemo();
            dm.callThread();

            
          


            Console.ReadLine();

        }

     
    }
}
