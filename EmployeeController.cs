using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StronglyTypedViews;

namespace StronglyTypedViews.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult EmployeeData(int id)
        {
            using (EmployeeDBEntities edb = new EmployeeDBEntities())
            {
                Employee emp = edb.Employees.SingleOrDefault(x => x.ID == id);

                return View(emp);
            }
            
               
        }
    }
}