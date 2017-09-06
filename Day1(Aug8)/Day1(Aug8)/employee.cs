using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Aug8_
{
    class employee
    {
        protected int salary;
        public employee(int sal)
        {
            salary = sal;
        }

        public virtual void calculate()
        {
            Console.WriteLine(salary);
        }
    }
    class trainer : employee
    {
        public trainer(int sal) : base(sal)
        {

        }

        public override void calculate()
        {
            Console.WriteLine(3 * base.salary);
        }
    }

    class admin : employee
    {
        public admin(int sal) : base(sal)
        {

        }

        public override void calculate()
        {
            Console.WriteLine(5 * base.salary);
        }
    }

    class hr : employee
    {
        public hr(int sal) : base(sal)
        {

        }

        public override void calculate()
        {
            Console.WriteLine(7 * base.salary);
        }
    }
}
