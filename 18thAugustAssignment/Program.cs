using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18thAugustAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            removeWhiteSpace rwsobj = new removeWhiteSpace();
            rwsobj.removeSpace();
            Console.WriteLine("------------------------------------");
            collectionDemo cd = new collectionDemo();
            cd.demoTest();
            Console.ReadLine();
        }
    }
}
