using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;

using EmployeeManager.DAL;
using EmployeeManager.Models;
using System.Threading.Tasks;

namespace EmployeeManager.ehnds
{
  public static class ehnd_Employees
  {
    #region --- GetEmployees ---
    public static List<Employee> GetEmployeeList(
      ManagerContext aDbContext,
      string aFilterQuery
    )
    {
      var vEmployees = aDbContext.Employees
        .Include(emp => emp.Person);

      if (!String.IsNullOrEmpty(aFilterQuery))
      {
        aFilterQuery = aFilterQuery.ToLower();

        vEmployees = vEmployees.Where(emp => emp.Person.FirstName.ToLower().Contains(aFilterQuery) || emp.Person.LastName.ToLower().Contains(aFilterQuery));
      }
      
      vEmployees = vEmployees.OrderBy(emp => emp.Person.LastName);

      return vEmployees.ToList();
    }
    #endregion --- GetEmployees ---

    #region --- AddEmployee ---
    public static void AddEmployee(
      ManagerContext aDbContext,
      Employee aNewEmployee
    )
    {
      aDbContext.Employees.Add(aNewEmployee);

      aDbContext.SaveChanges();
    }
    #endregion --- AddEmployee ---

    #region --- EditEmployee ---
    public static Employee EditEmployee(
      ManagerContext aDbContext,
      Employee aNewEmployee
    )
    {
      aDbContext.Entry(aNewEmployee).State = EntityState.Modified;
      aDbContext.SaveChanges();
      return aNewEmployee;
    }
    #endregion --- EditEmployee ---
  }
}