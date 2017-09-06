using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var studentDb=new studentDemoEntities())
            {
                var stddb = new studentTable()
                {
                    RollNo = 1,
                    Name = "Pooja",
                    Marks = 90
                };

                studentDb.studentTables.Add(stddb);
                studentDb.SaveChanges();
                Console.WriteLine("Entry added successfully");
                Console.ReadLine();
            }
        }
    }
}
