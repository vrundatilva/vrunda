using DependencyInjection.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IVisitorCounter _counter;
        public DefaultController(IVisitorCounter counter)
        {
            _counter = counter;
        }
        public IActionResult Index([FromServices] IVisitorCounter _cnt)
        {
            ViewBag.count = _counter.Getcount();
            ViewBag.cnt = _cnt.Getcount();//when we use only one controoler then we can use [FromServices] IVisitorCounter _cnt
            return View();
        }
    }
}
