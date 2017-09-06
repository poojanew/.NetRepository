using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace multiThreadingDemo
{
    public class taskInfo
    {
        public string ename;
        public string empid;
        public taskInfo(string name,string eid)
        {
            ename = name;
            empid = eid;
        }
    }
    class threadPoolDemo
    {
        public void callThread()
        {
            taskInfo ti = new taskInfo("Pooja", "X5212");
             ThreadPool.QueueUserWorkItem(displayTaskInfo, ti);
            Console.WriteLine("Main thread does some work, then sleeps.");
         
            Thread.Sleep(1000);
            Parallel.Invoke(tplMethod,tplMethod2);

            Console.WriteLine("Main thread exits.");
        }

        public void displayTaskInfo(Object ti)
        {
            taskInfo t1 = (taskInfo) ti;
            Console.WriteLine("I am {0} & my employee id is {1}", t1.ename, t1.empid);

        }

        public void tplMethod()
        {
            string s = "";
            for (int i = 0; i < 10; i++)
            {
                s = s + "*";
                Console.WriteLine(s);
            }
        }

        public void tplMethod2()
        {
            string s = "**********";
            for (int i = 1; i < 10; i++)
            {
                s = s.Remove(1,1);
                Console.WriteLine(s);
            }
        }
    }

   
}
