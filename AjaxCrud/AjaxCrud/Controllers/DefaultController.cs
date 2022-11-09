using AjaxCrud.EDM;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjaxCrud.Controllers
{
    public class DefaultController : Controller
    {
        private CompanyContext dc = null;
        public DefaultController(CompanyContext _dc)
        {
            dc = _dc;
        }
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult GetEmployees()
        {
            return Json(dc.Employees.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public string Create(Employee obj)
        {
            dc.Employees.Add(obj);
            dc.SaveChanges();
            return "Record Inserted";
           
        }
        public IActionResult Edit(int id)
        {
            return View(dc.Employees.Find(id));
        }
        [HttpPost]
        public string Edit(Employee obj)
        {
            dc.Employees.Update(obj);
            dc.SaveChanges();
            return "Record Updated";

        }
        public IActionResult Delete(int id)
        {
            return View(dc.Employees.Find(id));
        }
        [HttpPost ,ActionName("Delete")]
        public string DeleteRec(int id)
        {
            dc.Employees.Remove(dc.Employees.Find(id));
            dc.SaveChanges();
            return "Record Deleted";

        }

    }
}
