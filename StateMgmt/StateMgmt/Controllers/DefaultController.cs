using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StateMgmt.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public DefaultController(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public IActionResult Index()
        {
            CookieOptions options = new CookieOptions();
            options.Expires = DateTimeOffset.Now.AddMinutes(2);
            _httpContextAccessor.HttpContext.Response.Cookies.Append("uname","vrunda",options);

            return View();
        }
        public IActionResult Sendmsg(string msg)
        {
            ViewBag.msg = msg;
            return View();
        }
        public IActionResult Create()
        {
            _httpContextAccessor.HttpContext.Session.SetString("uname", "vrunda");
            return View();
        }
        public IActionResult next()
        {
            return View();
        }
        public IActionResult svar()
        {
            ViewBag.message = "";
            ViewData["msg"] = "from ViewData";

            TempData["info"] = "from TempData";
            return View();
        }
        public IActionResult second()
        {
            return View();
        }
    }
}
