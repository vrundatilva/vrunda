using EDMCrud.EDM;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDMCrud.Controllers
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
            return View(dc.Employees.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee obj)
        {
            dc.Employees.Add(obj);
            dc.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult EditEmp(int id)
        {
            return View(dc.Employees.Find(id));
        }
        [HttpPost]
        public IActionResult EditEmp(Employee obj)
        {
            dc.Employees.Update(obj);
            dc.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            return View(dc.Employees.Find(id));
        }
        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteRec(int id)
        {
            dc.Employees.Remove(dc.Employees.Find(id));
            dc.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Detail(int id)
        {
            return View(dc.Employees.Find(id));
        }
    }
}
