using Microsoft.AspNetCore.Mvc;
using PartialView_EmpData.EDM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialView_EmpData.Controllers
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
    }
}
