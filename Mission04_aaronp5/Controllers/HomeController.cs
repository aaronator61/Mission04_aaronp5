using Microsoft.AspNetCore.Mvc;
using Mission04_aaronp5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission04_aaronp5.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Calculator()
        {
            return View();
        }

        [HttpPost] //Attribute that is attached to the method
        public IActionResult Calculator(CalculatorModel model)
        {
            return View();
        }
    }
}
