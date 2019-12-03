using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers {
    public class DepartmentController : Controller {

        EmployeeContext employeeContext = null;
        public DepartmentController() {
            employeeContext = new EmployeeContext();
        }

        // GET: Department
        public ActionResult Index() {
            List<Department> departments = employeeContext.Departments.ToList();
            return View(departments);
            
        }

        [HttpGet]
        [ActionName("Create")]
        public ActionResult Create_Get() {
            return View();
        }

        [HttpGet]
        public ActionResult Details(int id) {
            Department department = employeeContext.Departments.Single(t => t.Id == id);
            return View(department);
        }


        [HttpPost]
        [ActionName("Create")]
        //public ActionResult Create(FormCollection formCollection) {
        public ActionResult Create_Post() {

            Department department = new Department();
            TryUpdateModel(department);

            if (ModelState.IsValid) {
                employeeContext.Departments.Add(department);
                employeeContext.SaveChanges();
                return RedirectToAction("Index");
            }
                
            return View();

        }

        [HttpGet]
        [ActionName("Edit")]
        public ActionResult Edit_Get(int id) {

            Department department = employeeContext.Departments.Single(t=> t.Id == id);
            return View(department);
            
        }

        [HttpPost]
        [ActionName("Edit")]
        public ActionResult Edit_Post(int id) {

            Department department = employeeContext.Departments.Single(t => t.Id == id);

            UpdateModel(department, new string[] { "Name" }); // Inclue Properties you want only to update

            if (ModelState.IsValid) {
                employeeContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        
        public ActionResult Delete(int id) {
            Department department = employeeContext.Departments.Single(t => t.Id == id);
            employeeContext.Departments.Remove(department);
            employeeContext.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}