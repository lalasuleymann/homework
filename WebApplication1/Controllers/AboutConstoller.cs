using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class AboutConstoller : Controller
    {
        public string Index() 
        {
            return "About Index";
        }

        public IActionResult Create() 
        {
            return View();

            return RedirectToAction("Index");
            return RedirectToAction("Index", "Home");

            return RedirectToAction(nameof(Index));
        }
    }
}
