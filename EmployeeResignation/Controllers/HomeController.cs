using EmployeeResignation.Departments.Interface;
using EmployeeResignation.Models;
using EmployeeResignation.Subject;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EmployeeResignation.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAsset _it;
        private readonly IFinance _finance;
        private readonly IResignation _resignation;
        private readonly IAccount _account;
        private readonly IHumanResource _hr;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IAsset it, IFinance finance,IAccount account, IHumanResource hr,
            IResignation resignation)
        {
            _logger = logger;
            _it = it;
            _hr = hr;
            _finance = finance;
            _account = account;
            _resignation = resignation;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult HRDept()
        {
            _hr.HandOverAssets();

            ViewBag.Dept = "if you are leaving hand over everything";
            return View("Index");
        }


        [HttpPost]
        public IActionResult ITDept()
        {
            _it.AllocateAsset();

            ViewBag.Dept = "IT - Allocated assets";
            return View("Index");
        }

        [HttpPost]
        public IActionResult Finance()
        {
            _finance.CalculateSalary();

            ViewBag.Dept = "Finance - Calculated salary";
            return View("Index");
        }
        [HttpPost]
        public IActionResult Account()
        {
            _account.GiveNoObjection();

            ViewBag.Dept = "Give No Objection after looking Account";
            return View("Index");
        }
        [HttpPost]
        public IActionResult EmployeeSeparate(string EmployeeId)
        {
            string Message = $"About page visited at {DateTime.UtcNow.ToLongTimeString()}";
            _resignation.NotifyObserver(EmployeeId);

            _logger.LogInformation(Message);
            return View("Index");


        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
