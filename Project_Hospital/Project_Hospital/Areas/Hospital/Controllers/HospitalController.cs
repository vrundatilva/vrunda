using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project_Hospital.EDM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Hospital.Areas.Hospital.Controllers
{
    [Area("Hospital")]
    
    public class HospitalController : Controller
    {
        private readonly Hospital_DetailContext _context = null;
        private readonly IHttpContextAccessor _contextAccessor;
        public HospitalController(Hospital_DetailContext context, IHttpContextAccessor contextAccessor)
        {
            _context = context;
            _contextAccessor = contextAccessor;
        }

        public IActionResult HomePage()
        {
            return View();
        }
        public IActionResult Login(IFormCollection fc)
        {
            string email = fc["email"];
            string pass = fc["pass"];

            var data = _context.TblHospitals.Where(x => x.HospEmail==email && x.Password==pass).FirstOrDefault();
            if (data!=null)
            {
                _contextAccessor.HttpContext.Session.SetString("HospitalId",data.HospId.ToString());
                _contextAccessor.HttpContext.Session.SetString("HospitanName",data.Hname);
                return RedirectToAction("HomePage");
            }

            return View();
        }
    }
}
