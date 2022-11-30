using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Project_Hospital.EDM;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Hospital.Areas.Hospital.Controllers
{
    [Area("Hospital")]

    public class HospitalController : Controller
    {
        private readonly Hospital_DetailContext _context = null;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IWebHostEnvironment _env;

        public HospitalController(Hospital_DetailContext context, IHttpContextAccessor contextAccessor, IWebHostEnvironment env)
        {
            _context = context;
            _contextAccessor = contextAccessor;
            _env = env;
        }

        public IActionResult HomePage()
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

            var data = _context.TblHospitals.Where(x => x.HospEmail == email && x.Password == pass).FirstOrDefault();
            if (data != null)
            {
                _contextAccessor.HttpContext.Session.SetString("HospitalId", data.HospId.ToString());
                _contextAccessor.HttpContext.Session.SetString("HospitanName", data.Hname);
                return RedirectToAction("HomePage");
            }
            else
            {
                ViewBag.loginerror = "Invalid Email or Password.!";
            }
            return View();
        }
        public IActionResult Appointment()
        {
            List<TblHospital> hosp = new List<TblHospital>();
            hosp = (from Hname in _context.TblHospitals select Hname).ToList();
            hosp.Insert(0, new TblHospital { HospId = 0, Hname = "Select Name" });

            List<Patient> pat = new List<Patient>();
            pat = (from Hname in _context.Patients select Hname).ToList();
            pat.Insert(0, new Patient { PatId = 0, Fname = "Select Name" });

            List<Doctor> doc = new List<Doctor>();
            doc = (from Hname in _context.Doctors select Hname).ToList();
            doc.Insert(0, new Doctor { Doc_Id = 0, Fname = "Select Name" });

            ViewBag.doc_id = doc;
            ViewBag.pat_id = pat;
            ViewBag.hospital_id = hosp;
            return View();
        }
        [HttpPost]
        public IActionResult Appointment(Appointment obj)
        {
            _context.Appointments.Add(obj);
            _context.SaveChanges();
            return RedirectToAction("Manage_Apointment");
        }
        public IActionResult Manage_Apointment(Appointment obj)
        {
            List<Appointment> appointments = new List<Appointment>();
            var data = _context.Appointments.ToList();
            if (data != null && data.Count() > 0)
            {
                foreach (var item in data)
                {
                    Appointment obj1 = new Appointment();
                    obj1.AppId = item.AppId;
                    obj1.PatientName = _context.Patients.ToList().Where(a => a.PatId == item.PtId).FirstOrDefault().Fname + " " + _context.Patients.ToList().Where(a => a.PatId == item.PtId).FirstOrDefault().Lname;
                    obj1.AppoStatus = item.AppoStatus;
                    obj1.HospitalName = _context.TblHospitals.ToList().Where(a => a.HospId == item.HopId).FirstOrDefault().Hname;
                    obj1.DoctorName = _context.Doctors.ToList().Where(a => a.Doc_Id == item.DId).FirstOrDefault().Fname + "" + _context.Doctors.ToList().Where(a => a.Doc_Id == item.PtId).FirstOrDefault().Lname;
                    obj1.AppoDate = item.AppoDate.Value;
                    appointments.Add(obj1);
                }
            }

            return View(appointments);
        }
        public IActionResult AppointmentEdit(int id)
        {
            List<TblHospital> hosp = new List<TblHospital>();
            hosp = (from Hname in _context.TblHospitals select Hname).ToList();
            hosp.Insert(0, new TblHospital { HospId = 0, Hname = "Select Name" });

            List<Patient> pat = new List<Patient>();
            pat = (from Hname in _context.Patients select Hname).ToList();
            pat.Insert(0, new Patient { PatId = 0, Fname = "Select Name" });

            List<Doctor> doc = new List<Doctor>();
            doc = (from Hname in _context.Doctors select Hname).ToList();
            doc.Insert(0, new Doctor { Doc_Id = 0, Fname = "Select Name" });

            ViewBag.doc_id = doc;
            ViewBag.pat_id = pat;
            ViewBag.hospital_id = hosp;
            return View(_context.Appointments.Find(id));
        }
        [HttpPost]
        public IActionResult AppointmentEdit(Appointment obj)
        {
            _context.Appointments.Update(obj);
            _context.SaveChanges();
            return RedirectToAction("Manage_Apointment");
        }
        public IActionResult AppointmentDelete(int id)
        {
            List<Appointment> appointments = new List<Appointment>();
            var data1 = _context.Appointments.Find(id);
            if (data1 != null)
            {

                Appointment obj1 = new Appointment();
                obj1.AppId = data1.AppId;
                obj1.PatientName = _context.Patients.Where(a => a.PatId == data1.PtId).FirstOrDefault().Fname + " " + _context.Patients.Where(a => a.PatId == data1.PtId).FirstOrDefault().Lname;
                obj1.AppoStatus = data1.AppoStatus;
                obj1.HospitalName = _context.TblHospitals.Where(a => a.HospId == data1.HopId).FirstOrDefault().Hname;
                obj1.DoctorName = _context.Doctors.Where(a => a.Doc_Id == data1.DId).FirstOrDefault().Fname + "" + _context.Doctors.Where(a => a.Doc_Id == data1.PtId).FirstOrDefault().Lname;
                obj1.AppoDate = data1.AppoDate.Value;
                appointments.Add(obj1);
            }
            return View(appointments);
        }
        [HttpPost]
        [ActionName("AppointmentDelete")]
        public IActionResult Appointment_Delete(int id)
        {
            _context.Appointments.Remove(_context.Appointments.Find(id));
            _context.SaveChanges();
            return View();
        }
        public IActionResult DoctorAdd(TblHospital obj)
        {

            string hospitalid = Convert.ToString(_contextAccessor.HttpContext.Session.GetString("HospitanName"));

            List<TblHospital> hosp = new List<TblHospital>();
            hosp = (from Hname in _context.TblHospitals select Hname).ToList();
            hosp.Insert(0, new TblHospital { HospId = 0, Hname = "Select Name" });

            ViewBag.hospital_id = hosp;
            return View();
        }
        [HttpPost]
        [ActionName("DoctorAdd")]
        public IActionResult Doctor_Add(Doctor obj)
        {
            _context.Doctors.Add(obj);
            _context.SaveChanges();
            return RedirectToAction("Manage_Doctor");
        }
        public IActionResult Manage_Doctor(Doctor obj)
        {
            return View(_context.Doctors.ToList());
        }
        public IActionResult DoctorEdit(int id)
        {
            List<TblHospital> hosp = new List<TblHospital>();
            hosp = (from Hname in _context.TblHospitals select Hname).ToList();
            hosp.Insert(0, new TblHospital { HospId = 0, Hname = "Name" });

            ViewBag.hospital_id = hosp;
            return View(_context.Doctors.Find(id));
        }
        [HttpPost]
        public IActionResult DoctorEdit(Doctor obj)
        {
            _context.Doctors.Update(obj);
            _context.SaveChanges();
            return RedirectToAction("Manage_Doctor");
        }
        public IActionResult DoctorDelete(int id)
        {
            return View(_context.Doctors.Find(id));
        }
        [HttpPost]
        [ActionName("DoctorDelete")]
        public IActionResult Doctor_Delete(int id)
        {
            _context.Doctors.Remove(_context.Doctors.Find(id));
            _context.SaveChanges();
            return RedirectToAction("Manage_Doctor");
        }
        private string UploadedFile(Patient model)
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
        public IActionResult PatientAdd()
        {
            List<State> st = new List<State>();
            st = (from Hname in _context.States select Hname).ToList();
            st.Insert(0, new State { StatId = 0, StateName = "--- Select State---" });


            List<City> city = new List<City>();
            city = (from Hname in _context.Cities select Hname).ToList();
            city.Insert(0, new City { CityId = 0, CityName = "---Select City--" });

            ViewBag.stat_id = st;
            ViewBag.city_id = city;
            return View();
        }
        [HttpPost]
        public IActionResult PatientAdd(Patient obj)
        {
            //string fileName = Path.GetFileName(postedFiles.FileName);
            string filename = UploadedFile(obj);
            obj.PImg = filename;
            _context.Patients.Add(obj);
            _context.SaveChanges();
            return RedirectToAction("HomePage");
        }
        public IActionResult Manage_Patient(Patient obj)
        {
            return View(_context.Patients.ToList());
        }
        public IActionResult PatientEdit(int id)
        {
            List<State> st = new List<State>();
            st = (from Hname in _context.States select Hname).ToList();
            st.Insert(0, new State { StatId = 0, StateName = "--- Select State---" });


            List<City> city = new List<City>();
            city = (from Hname in _context.Cities select Hname).ToList();
            city.Insert(0, new City { CityId = 0, CityName = "---Select City--" });

            ViewBag.stat_id = st;
            ViewBag.city_id = city;
            return View(_context.Patients.Find(id));
        }
        [HttpPost]
        public IActionResult PatientEdit(Patient obj)
        {
            string filename = UploadedFile(obj);
            obj.PImg = filename;
            _context.Patients.Update(obj);
            _context.SaveChanges();
            return RedirectToAction("Manage_Patient");
        }
        public IActionResult PatientDelete(int id)
        {
            return View(_context.Patients.Find(id));
        }
        [HttpPost]
        [ActionName("PatientDelete")]
        public IActionResult Patient_Delete(int id)
        {
            _context.Patients.Remove(_context.Patients.Find(id));
            _context.SaveChanges();
            return RedirectToAction("Manage_Patient");
        }
    }
}
