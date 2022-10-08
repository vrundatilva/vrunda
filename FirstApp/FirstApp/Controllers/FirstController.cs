using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApp.Controllers
{
    public class FirstController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            List<Employee> li = new List<Employee>();
            li.Add(new Employee { FirstName="Akash" ,LastName="Patel",Salary=20000,Department="IT"});
            li.Add(new Employee { FirstName="Chirag" ,LastName="Shah",Salary=20000,Department="Support Person"});
            li.Add(new Employee { FirstName="Mukesh" ,LastName="Patel",Salary=20000,Department="ME"});
            li.Add(new Employee { FirstName="Nidhi" ,LastName="Patel",Salary=20000,Department="IT"});
            return View(li);
        }
        public IActionResult RoutValues()
        {
            ViewBag.Controller = RouteData.Values["Controller"].ToString();
            ViewBag.Action = RouteData.Values["Action"].ToString();
            ViewBag.id = RouteData.Values["id"].ToString();

            return View();
        }
    }
}
