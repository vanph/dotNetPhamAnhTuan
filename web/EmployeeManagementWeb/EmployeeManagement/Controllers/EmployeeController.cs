using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccess;

namespace EmployeeManagement.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            var dbContext = new EmployeeEntities();
            var employees = dbContext.Employees.ToList();
            return View(employees);
        }
    }
}