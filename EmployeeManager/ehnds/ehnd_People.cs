using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;

using EmployeeManager.DAL;
using EmployeeManager.Models;

namespace EmployeeManager.ehnds
{
  public static class ehnd_People
  {
    public static List<Person> GetPersonList(
      ManagerContext aDbContext,
      string aFilterQuery
    )
    {
      List<Person> vPersonList = new List<Person>();

      if (!String.IsNullOrEmpty(aFilterQuery))
      {
        aFilterQuery = aFilterQuery.ToLower();
        vPersonList = aDbContext.Persons
        .Where(person => person.FirstName.ToLower().Contains(aFilterQuery) || person.LastName.ToLower().Contains(aFilterQuery))
        .ToList();
      }
      else
      {
        vPersonList = aDbContext.Persons.ToList();
      }

      return vPersonList;
    }
  }
}