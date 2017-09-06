using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using d= day3;
using globalVar;
using n= nest1.nest2;

/// <summary>
/// 
/// </summary>

namespace day3_Aug10_
{
    class Program
    {
        static int Main(string[] args)
        {


      
            return 0;


        }
    }
}

namespace globalVar
{
    class Console
    {
        public void WriteLine()
        {
            global::System.Console.WriteLine("In globalVar namespace");
        }
    }
}

namespace nest1
{
    namespace nest2
    {
        class inNest2
        {
            public void print()
            {
                global::System.Console.WriteLine("In nested namespace");
            }
        }
    }
}


