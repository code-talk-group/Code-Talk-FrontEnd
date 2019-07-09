using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CodeTalk.Controllers
{
    public class FormsController : Controller
    {
        public IActionResult Function()
        {
            return View();
        }

        public IActionResult Variable()
        {
            return View();
        }

        public IActionResult IfStatement()
        {
            return View();
        }

        public IActionResult ForLoop()
        {
            return View();
        }
    }
}