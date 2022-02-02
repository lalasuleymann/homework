using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Lala";
            ViewData["Surname"] = "Suleymanova";
            TempData["Age"] = "20";

            return View();

            return RedirectToAction(nameof(Detail));
        }

        public IActionResult Detail() 
        {
            var students = new List<Student>
            {
                new Student { Id = 1, Name = "Lala", Surname = "Suleymanova" },
                new Student { Id = 2, Name = "Lala", Surname = "Suleymanova" },
                new Student { Id = 3, Name = "Lala", Surname = "Suleymanova" }
            };
            return View(students);
            return View();
        }
    }
}
