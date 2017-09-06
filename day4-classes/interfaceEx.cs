using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4_classes
{
    interface IEmployee
    {
        void calculateSalary();
        void empName();
        
    }
    class interfaceEx : IEmployee
    {
        public void calculateSalary()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Salary is : 10000");
        }

        public void empName()
        {
            //throw new NotImplementedException();
            Console.WriteLine("EmpName is : name" );

        }
    }


    class abc
    {
        public static void method2(IEmployee obj)
        {
            obj.calculateSalary();
            obj.empName();

        }
    }

}
