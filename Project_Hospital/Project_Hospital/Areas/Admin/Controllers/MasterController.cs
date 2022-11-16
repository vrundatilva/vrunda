using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project_Hospital.EDM;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Project_Hospital.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MasterController : Controller
    {
        private readonly Hospital_DetailContext _context = null;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IWebHostEnvironment _env;
        public MasterController(Hospital_DetailContext context, IHttpContextAccessor contextAccessor,
            IWebHostEnvironment env)
        {
            _context = context;
            _contextAccessor = contextAccessor;
            _env = env;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(IFormCollection fc)
        {
            string email = fc["email"];
            string pass = fc["pass"];

            var data = _context.HAdmins.Where(x => x.Email == email && x.Password == pass).FirstOrDefault();
            if (data != null)
            {
                _contextAccessor.HttpContext.Session.SetString("AdminId", data.AdminId.ToString());
                _contextAccessor.HttpContext.Session.SetString("AdminName", data.Fname);
                return RedirectToAction("Dashboard");
            }
            ViewBag.loginerror = "Invalid Email or Password.!";
            return View();
        }
        public IActionResult Dashboard()
        {
            return View();
        }
        public IActionResult Logout()
        {
            _contextAccessor.HttpContext.Session.Remove("AdminId");
            _contextAccessor.HttpContext.Session.Remove("AdminName");
            _contextAccessor.HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
        public IActionResult HospitalAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult HospitalAdd(TblHospital obj)
        {
            //string fileName = Path.GetFileName(postedFiles.FileName);
            string filename= UploadedFile(obj);
            obj.HLogImg = filename;
            _context.TblHospitals.Add(obj);
            _context.SaveChanges();
            return RedirectToAction("Hospital_Display");
        }
        public IActionResult Hospital_Display()
        {
            return View(_context.TblHospitals.ToList());
        }
        private string UploadedFile(TblHospital model)
        {
            string uniqueFileName = null;

            if (model.ImageFile != null)
            {
                string uploadsFolder = Path.Combine(_env.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ImageFile.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.ImageFile.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }
        public IActionResult HospitalEdit(int id)
        {
            return View(_context.TblHospitals.Find(id));
        }
        [HttpPost]
        public IActionResult HospitalEdit(TblHospital obj)
        {
            //string fileName = Path.GetFileName(postedFiles.FileName);
            string filename = UploadedFile(obj);
            obj.HLogImg = filename;
            _context.TblHospitals.Update(obj);
            _context.SaveChanges();
            return RedirectToAction("Hospital_Display");
        }
        public IActionResult HospitalDelete(int id)
        {
            return View(_context.TblHospitals.Find(id));
        }
        [HttpPost]
        [ActionName("HospitalDelete")]
        public IActionResult Hospital_Delete(int id)
        {
            //string fileName = Path.GetFileName(postedFiles.FileName);
            _context.TblHospitals.Remove(_context.TblHospitals.Find(id));
            _context.SaveChanges();
            return RedirectToAction("Hospital_Display");
        }

    }
}
