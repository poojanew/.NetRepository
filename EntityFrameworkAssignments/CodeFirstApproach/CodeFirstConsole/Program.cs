using CodeFirstApproach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstConsole
{
    class Program
    {
        static void Main(string[] args)
        {
           var dept = new ContextClass();
            
                Console.WriteLine("ADD DEPARTMENT");
                var deptObj= new CodeFirstDeptClass { Id=1,Name="IT",Location="Pune" };
                dept.Departments.Add(deptObj);
                dept.SaveChanges();
                Console.WriteLine("Record Added");

            

            Console.ReadLine();
        }
    }
}
