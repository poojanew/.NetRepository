using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16thAugAssignment
{
    class employee
    {
        int ID;
        string Name;
        string DepartmentName;
        string ProjectName;

        public void displayEmpList()
        {
            List<employee> emp_list=new List<employee>();
            emp_list.Add(
                new employee
                {
                    ID = 1,
                    Name = "Kirti",
                    DepartmentName = "Trainer",
                    ProjectName = "Java"
                }
            );
            emp_list.Add(
               new employee
               {
                   ID = 2,
                   Name = "Pooja",
                   DepartmentName = "Trainer",
                   ProjectName = "C#"
               }
           );
            emp_list.Add(
               new employee
               {
                   ID = 3,
                   Name = "Sneha",
                   DepartmentName = "HR",
                   ProjectName = "Fresher2017"
               }
           );

            Console.WriteLine("FindAll\n\n");
            foreach(employee emp in emp_list.FindAll(e => e.ID > 0))
            {
                Console.WriteLine("Employee ID : {0}\nEmployee Name : {1}\nDepartment : {2}\nProjectName : {3}", emp.ID, emp.Name, emp.DepartmentName, emp.ProjectName);
                Console.WriteLine("--------------------\n");
            }
            Console.WriteLine("Take\n\n");

            foreach (employee emp in emp_list.FindAll(e => e.ID > 0).Take(2).ToList())
            {
                Console.WriteLine("Employee ID : {0}\nEmployee Name : {1}\nDepartment : {2}\nProjectName : {3}", emp.ID, emp.Name, emp.DepartmentName, emp.ProjectName);
                Console.WriteLine("--------------------\n");
            }


            Console.WriteLine("All\n\n");

            if (emp_list.All(e => e.ProjectName != null))
            {
                Console.WriteLine("All have projects");
            }

            Console.WriteLine("--------------------\n");

            Console.WriteLine("Exists\n\n");

            if (emp_list.Exists(e => e.Name == "Kirti"))
            {
                Console.WriteLine("Employee named Kirti Exists");
            }

            Console.WriteLine("--------------------\n");


            Console.WriteLine("Any\n\n");

            if (emp_list.Any())
            {
                Console.WriteLine("Employee works here");
            }

            Console.WriteLine("--------------------\n");

            Console.WriteLine("Where\n\n");

            foreach (employee emp in emp_list.Where(e=>e.ID==3))
            {
                Console.WriteLine("Employee ID : {0}\nEmployee Name : {1}\nDepartment : {2}\nProjectName : {3}", emp.ID, emp.Name, emp.DepartmentName, emp.ProjectName);
                Console.WriteLine("--------------------\n");
            }

            Console.WriteLine("--------------------\n");

            Console.WriteLine("Select\n\n");

            var result = emp_list.Select(e=>e.Name);

            foreach (var item in result)
            {
                Console.WriteLine(item);

            }

            Console.WriteLine("--------------------\n");

            Console.WriteLine("Group By\n\n");
            IEnumerable<IGrouping<string, employee>> groups = emp_list.GroupBy(b => b.DepartmentName);

            //var groupedEmp = emp_list.GroupBy(e => e.DepartmentName);

            foreach (IGrouping<string, employee> item1 in groups)
            {


                Console.Write("\nEmployee in " + item1.Key + " department : ");

                foreach (employee e in item1)

                {

                    Console.Write(e.DepartmentName + " ");

                }


            }

     /*.GroupBy(u => u.GroupID)
     .Select(grp => grp.ToList())
     .ToList();*/







        }
    }
}
