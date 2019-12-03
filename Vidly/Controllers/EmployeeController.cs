using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers {
    public class EmployeeController : Controller {

        EmployeeContext employeeContext = null;
        public EmployeeController() {
            employeeContext = new EmployeeContext();
        }

        // Get ll
        public ActionResult Index(int? departmentId) {

            List<Employee> employees = null;
            if (departmentId.HasValue) {
                employees = employeeContext.Employees.Where(t => t.DepartmentID == departmentId).ToList();
            }
            else {
                employees = employeeContext.Employees.ToList();
            }
            return View(employees);
        }

        // GET: Employee
        public ActionResult Details(int id) {

            Employee employee = employeeContext.Employees.Single(t => t.EmployeeID == id);

            return View(employee);
        }


        [HttpGet]
        [ActionName("Create")]
        public ActionResult Create_Get(FormCollection formCollection) {

            return View();
        }


        [HttpPost]
        [ActionName("Create")]
        public ActionResult Create_Post() {

            Employee employee = new Employee();
            TryUpdateModel(employee);

            if (ModelState.IsValid) {
                employeeContext.Employees.Add(employee);
                employeeContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }


        [HttpGet]
        [ActionName("Edit")]
        public ActionResult Edit_Get(int id) {
            Employee employee = employeeContext.Employees.Single(t => t.EmployeeID == id);
            return View(employee);
        }

        [HttpPost]
        [ActionName("Edit")]
        public ActionResult Edit_Post(int id) {
            Employee employee = employeeContext.Employees.Single(t => t.EmployeeID == id);

            UpdateModel(employee);

            if (ModelState.IsValid) {
                employeeContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        public ActionResult Delete(int id) {
            Employee employee = employeeContext.Employees.Single(t => t.EmployeeID == id);
            employeeContext.Employees.Remove(employee);
            employeeContext.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}