using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataFirstApproachDemo;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var empObj = new EmployeeEntities()) //mapper class(inherited from db context class)
            {
                /*  var emp = new EmpTable(); //tablename
                  emp.EmpId = 1;
                  emp.Name = "Pooja";
                  emp.Salary = 10000;
                  empObj.EmpTables.Add(emp);

                  var emp1 = new EmpTable(); 
                  emp1.EmpId = 2;
                  emp1.Name = "Kirti";
                  emp1.Salary = 15000;
                  empObj.EmpTables.Add(emp1);

                  var emp2 = new EmpTable();
                  emp2.EmpId = 3;
                  emp2.Name = "Sneha";
                  emp2.Salary = 12000;
                  empObj.EmpTables.Add(emp2);*/

                EmpTable emp1obj = empObj.EmpTables.First(i => i.EmpId == 2);
                emp1obj.Name = "Khushi";


                empObj.SaveChanges();

                Console.WriteLine("Entries added in table");
            }

            Console.ReadLine();
        }
    }
}
