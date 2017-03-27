namespace EmployeeManager.Migrations
{
  using DAL;
  using Models;
  using System;
  using System.Collections.Generic;
  using System.Data.Entity;
  using System.Data.Entity.Migrations;
  using System.Linq;

  internal sealed class Configuration : DbMigrationsConfiguration<EmployeeManager.DAL.ManagerContext>
  {
    public Configuration()
    {
      AutomaticMigrationsEnabled = true;
      ContextKey = "EmployeeManager.DAL.ManagerContext";
    }

    protected override void Seed(ManagerContext context)
    {
      AddOriginalSeriesCast(context);
      AddTNGCast(context);
      AddDS9Cast(context);
      AddMITCast(context);
    }

    private void AddMITCast(ManagerContext aContext)
    {
      List<Person> vPersonList = new List<Person>
      {
        new Person {FirstName="Cary",LastName="Elwes",BirthDate= new DateTime(1962, 10, 26)},
        new Person {FirstName="Richard",LastName="Lewis",BirthDate= new DateTime(1947, 6, 29)},
        new Person {FirstName="Roger",LastName="Rees",BirthDate= new DateTime(1944, 5, 5)},
        new Person {FirstName="Amy",LastName="Yasbeck",BirthDate= new DateTime(1962, 9, 12)},
        new Person {FirstName="Mark",LastName="Blankfield",BirthDate= new DateTime(1950, 5, 8)},
        new Person {FirstName="Dave",LastName="Chappelle",BirthDate= new DateTime(1973, 8, 24)},
        new Person {FirstName="Megan",LastName="Cavanagh",BirthDate= new DateTime(1960, 11, 8)},
        new Person {FirstName="Eric",LastName="Kramer",BirthDate= new DateTime(1962, 3, 26)},
        new Person {FirstName="Matthew",LastName="Porrette",BirthDate= new DateTime(1965, 5, 29)},
        new Person {FirstName="Tracey",LastName="Ullman",BirthDate= new DateTime(1959, 12, 30)},
      };
      List<Employee> vEmployeeList = new List<Employee>();
      foreach (Person vPerson in vPersonList)
      {
        aContext.Persons.AddOrUpdate(
          person => person.LastName,
          vPerson
        );
        vEmployeeList.Add(
          new Employee { EmployeeNum = (vPersonList.IndexOf(vPerson) + 1).ToString(), EmployedDate = new DateTime(1993, 1, 1), TerminatedDate = new DateTime(1999, 1, 1), Person = vPerson }
        );
      }

      foreach (Employee vEmployee in vEmployeeList)
      {
        aContext.Employees.AddOrUpdate(
          emp => emp.PersonId,
          vEmployee
        );
      }

      aContext.SaveChanges();
    }

    private void AddDS9Cast(ManagerContext aContext)
    {
      List<Person> vPersonList = new List<Person>
      {
        new Person {FirstName="Avery",LastName="Brooks",BirthDate= new DateTime(1948, 10, 2)},
        new Person {FirstName="Rene",LastName="Auberjonois",BirthDate= new DateTime(1940, 6, 1)},
        new Person {FirstName="Cirroc",LastName="Lofton",BirthDate= new DateTime(1978, 8, 7)},
        new Person {FirstName="Alexander",LastName="Siddig",BirthDate= new DateTime(1965, 11, 21)},
        new Person {FirstName="Colm",LastName="Meaney",BirthDate= new DateTime(1953, 5, 30)},
        new Person {FirstName="Nana",LastName="Visitor",BirthDate= new DateTime(1957, 7, 26)},
        new Person {FirstName="Armin",LastName="Shimerman",BirthDate= new DateTime(1949, 11, 5)},
        new Person {FirstName="Terry",LastName="Farrell",BirthDate= new DateTime(1963, 11, 19)},
      };
      List<Employee> vEmployeeList = new List<Employee>();
      foreach (Person vPerson in vPersonList)
      {
        aContext.Persons.AddOrUpdate(
          person => person.LastName,
          vPerson
        );
        vEmployeeList.Add(
          new Employee { EmployeeNum = (vPersonList.IndexOf(vPerson) + 1).ToString(), EmployedDate = new DateTime(1993, 1, 1), TerminatedDate = new DateTime(1999, 1, 1), Person = vPerson }
        );
      }

      foreach (Employee vEmployee in vEmployeeList)
      {
        aContext.Employees.AddOrUpdate(
          emp => emp.PersonId,
          vEmployee
        );
      }

      aContext.SaveChanges();
    }

    private void AddTNGCast(ManagerContext aContext)
    {
      List<Person> vPersonList = new List<Person>
      {
        new Person {FirstName="Patrick",LastName="Stewart",BirthDate= new DateTime(1940, 7, 13)},
        new Person {FirstName="Jonathan",LastName="Frakes",BirthDate= new DateTime(1952, 8, 19)},
        new Person {FirstName="LeVar",LastName="Burton",BirthDate= new DateTime(1957, 2, 16)},
        new Person {FirstName="Marina",LastName="Sirtis",BirthDate= new DateTime(1955, 3, 29)},
        new Person {FirstName="Brent",LastName="Spiner",BirthDate= new DateTime(1949, 2, 2)},
        new Person {FirstName="Michael",LastName="Dorn",BirthDate= new DateTime(1952, 12, 9)},
        new Person {FirstName="Gates",LastName="McFadden",BirthDate= new DateTime(1949, 3, 2)},
        new Person {FirstName="Majel",LastName="Barrett",BirthDate= new DateTime(1949, 3, 2)},
      };
      List<Employee> vEmployeeList = new List<Employee>();
      foreach (Person vPerson in vPersonList)
      {
        aContext.Persons.AddOrUpdate(
          person => person.LastName,
          vPerson
        );
        vEmployeeList.Add(
          new Employee { EmployeeNum = (vPersonList.IndexOf(vPerson) + 1).ToString(), EmployedDate = new DateTime(1987, 1, 1), TerminatedDate = new DateTime(1994, 1, 1), Person = vPerson }
        );
      }

      foreach (Employee vEmployee in vEmployeeList)
      {
        aContext.Employees.AddOrUpdate(
          emp => emp.PersonId,
          vEmployee
        );
      }

      aContext.SaveChanges();
    }

    private void AddOriginalSeriesCast(ManagerContext aContext)
    {
      List<Person> vPersonList = new List<Person>
      {
        new Person {FirstName="Leonard",LastName="Nimoy",BirthDate= new DateTime(1932, 4, 26)},
        new Person {FirstName="William",LastName="Shatner",BirthDate= new DateTime(1931, 3, 22)},
        new Person {FirstName="DeForest",LastName="Kelley",BirthDate= new DateTime(1920, 1, 20)},
        new Person {FirstName="Nichelle",LastName="Nichols",BirthDate= new DateTime(1932, 12, 28)},
        new Person {FirstName="James",LastName="Doohan",BirthDate= new DateTime(1920, 3, 3)},
        new Person {FirstName="George",LastName="Takei",BirthDate= new DateTime(1937, 4, 20)},
        new Person {FirstName="Walter",LastName="Koenig",BirthDate= new DateTime(1936, 9, 14)},
      };
      List<Employee> vEmployeeList = new List<Employee>();
      foreach (Person vPerson in vPersonList)
      {
        aContext.Persons.AddOrUpdate(
          person => person.LastName,
          vPerson
        );
        vEmployeeList.Add(
          new Employee { EmployeeNum = (vPersonList.IndexOf(vPerson) + 1).ToString(), EmployedDate = new DateTime(1966, 1, 1), TerminatedDate = new DateTime(1969, 1, 1), Person = vPerson }
        );
      }

      foreach (Employee vEmployee in vEmployeeList)
      {
        aContext.Employees.AddOrUpdate(
          emp => emp.PersonId,
          vEmployee
        );
      }

      aContext.SaveChanges();
    }
  }
}
