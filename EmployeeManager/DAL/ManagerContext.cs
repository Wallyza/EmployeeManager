using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

using EmployeeManager.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EmployeeManager.DAL
{
  public class ManagerContext: DbContext
  {
    public ManagerContext(): base("ManagerContext")
    {

    }

    public DbSet<Person> Persons { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
    }

    public System.Data.Entity.DbSet<EmployeeManager.Models.Employee> Employees { get; set; }
  }
}