using Microsoft.AspNetCore.Mvc;
using BaiThucHanh0703.Models;
using BaiThucHanh0703.Models.Process;
namespace BaiThucHanh0703.Controllers;

    public class PersonController: Controller
    {
    public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee std)
        {
            string trave = std.EmployeeCode + "-" + std.EmployeeName + "- " + std.Address;
            ViewBag.m = trave;
            return View();
        }
    }

