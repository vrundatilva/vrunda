using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WebAPICalling.EDM;

namespace WebAPICalling.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly CompanyContext _context;
        private readonly HttpClient client = null;
        private string employeeApiUrl = "";

        public EmployeesController(IConfiguration config,HttpClient client)
        {
            this.client = client;
            employeeApiUrl = config.GetValue<string>("AppSettings:EmployeesApiUrl");
        }

        // GET: Employees
        public async Task<IActionResult> Index()
        {
            HttpResponseMessage response = await client.GetAsync(employeeApiUrl);
            string stringdata = await response.Content.ReadAsStringAsync();
            var option = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            List<Employee> data = JsonSerializer.Deserialize<List<Employee>>(stringdata,option);

            return View(data);
        }

        // GET: Employees/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees
                .FirstOrDefaultAsync(m => m.EmpId == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // GET: Employees/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create(Employee obj)
        {
            if (ModelState.IsValid)
            {
                string stringdata = JsonSerializer.Serialize(obj);
                var contentdata = new StringContent(stringdata, System.Text.Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(employeeApiUrl, contentdata);

                if (response.IsSuccessStatusCode)
                {
                    ViewBag.Message = "Employee Inserted Successfully!";
                }
                else
                {
                    ViewBag.Message = "Error while calling Web Api!";
                }
              
            }
            return RedirectToAction("Index");
        }

        // GET: Employees/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            HttpResponseMessage response = await client.GetAsync($"{employeeApiUrl}/{id}");
            string stringData = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            Employee obj = JsonSerializer.Deserialize<Employee>(stringData, options);

            return View(obj);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Edit(Employee obj)
        {
            if (ModelState.IsValid)
            {
                string stringData = JsonSerializer.Serialize(obj);
                var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PutAsync($"{employeeApiUrl}/{obj.EmpId}", contentData);

                if (response.IsSuccessStatusCode)
                {
                    ViewBag.Message = "Employee Updated Successfully!";
                }
                else
                {
                    ViewBag.Message = "Error while calling Web Api!";
                }
            }
            return RedirectToAction("Index");
        }

        // GET: Employees/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            HttpResponseMessage response = await client.GetAsync($"{employeeApiUrl}/{id}");
            string stringData = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            Employee obj = JsonSerializer.Deserialize<Employee>(stringData, options);

            return View(obj);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync($"{employeeApiUrl}/{id}");

            if (response.IsSuccessStatusCode)
            {
                ViewBag.Message = "Employee Deleted Successfully!";
            }
            else
            {
                ViewBag.Message = "Error while calling Web Api!";
            }

            return RedirectToAction("Index");
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employees.Any(e => e.EmpId == id);
        }
    }
}
