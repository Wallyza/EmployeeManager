using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EmployeeManager.DAL;
using EmployeeManager.Models;

namespace EmployeeManager.Controllers
{
  public class EmployeesController : Controller
  {
    private ManagerContext db = new ManagerContext();

    // GET: Employees
    public ActionResult Index(string searchstring)
    {
      List<Employee> vEmployeeList = ehnds.ehnd_Employees.GetEmployeeList(db, searchstring);
      return View(vEmployeeList);
    }

    // GET: Employees/Details/5
    public ActionResult Details(int? id)
    {
      if (id == null)
      {
        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
      }
      Employee employee = db.Employees.Find(id);
      if (employee == null)
      {
        return HttpNotFound();
      }
      return View(employee);
    }

    // GET: Employees/Create
    public ActionResult Create()
    {
      ViewBag.PersonId = new SelectList(db.Persons, "PersonId", "LastName");
      return View();
    }

    // POST: Employees/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create([Bind(Include = "EmployeeId,PersonId,EmployeeNum,EmployedDate,TerminatedDate")] Employee employee)
    {
      if (ModelState.IsValid)
      {
        ehnds.ehnd_Employees.AddEmployee(
          db,
          employee
        );
        return RedirectToAction("Index");
      }

      ViewBag.PersonId = new SelectList(db.Persons, "PersonId", "LastName", employee.PersonId);
      return View(employee);
    }

    // GET: Employees/Edit/5
    public ActionResult Edit(int? id)
    {
      if (id == null)
      {
        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
      }
      Employee employee = db.Employees.Find(id);
      if (employee == null)
      {
        return HttpNotFound();
      }
      ViewBag.PersonId = new SelectList(db.Persons, "PersonId", "LastName", employee.PersonId);
      return View(employee);
    }

    // POST: Employees/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit([Bind(Include = "EmployeeId,PersonId,EmployeeNum,EmployedDate,TerminatedDate")] Employee employee)
    {
      if (ModelState.IsValid)
      {
        ehnds.ehnd_Employees.EditEmployee(
          db,
          employee
        );
        return RedirectToAction("Index");
      }
      ViewBag.PersonId = new SelectList(db.Persons, "PersonId", "LastName", employee.PersonId);
      return View(employee);
    }

    // GET: Employees/Delete/5
    public ActionResult Delete(int? id)
    {
      if (id == null)
      {
        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
      }
      Employee employee = db.Employees.Find(id);
      if (employee == null)
      {
        return HttpNotFound();
      }
      return View(employee);
    }

    // POST: Employees/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public ActionResult DeleteConfirmed(int id)
    {
      Employee employee = db.Employees.Find(id);
      db.Employees.Remove(employee);
      db.SaveChanges();
      return RedirectToAction("Index");
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing)
      {
        db.Dispose();
      }
      base.Dispose(disposing);
    }
  }
}
