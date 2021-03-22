using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using learndotnetcore.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace learndotnetcore.controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            
            ViewBag.newMessage = "This is list of students";
            var students = new List<Student>() {

                new Student
                {
                    Id = 1,
                    Name = "Krishna",
                    Marks = 30
                },
                new Student
                {
                    Id = 2,
                    Name = "Janvi",
                    Marks = 95
                }
            };
            
            return View(students);
        }
        public IActionResult Welcome(object message)
        {
            //return View();
            return Json(new { message = "This is JSON response" });
        }
    }
}
