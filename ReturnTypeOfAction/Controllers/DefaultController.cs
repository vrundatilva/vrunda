using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReturnTypeOfAction.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private IWebHostEnvironment _env;
        public DefaultController(IWebHostEnvironment env)
        {
            _env = env;
        }
        public ContentResult view()
        {
            return Content(_env.ContentRootPath);//content path return
           // return Content(_env.WebRootPath);//webroot ath return
        }
        public ViewResult SendMsg(string msg)
        {//Default/SendMsg?msg=hello
            ViewBag.msg = msg;
            return View();
        }
        public RedirectResult GotoUrl()
        {
            return Redirect("https://www.google.com");
        }
        public RedirectResult GotoNextUrl()
        {
            return RedirectPermanent("https://www.google.com");
        }
    }
}
