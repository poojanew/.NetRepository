using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApproach
{
    public class ContextClass : DbContext
    {
        public DbSet<CodeFirstDeptClass> Departments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           modelBuilder.Entity<CodeFirstDeptClass>().Property(u=>u.Name).HasColumnName("Id");
        }
    }
}
