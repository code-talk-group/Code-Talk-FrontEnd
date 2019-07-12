using CodeTalk.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeTalk.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
      public  IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Form form)
        {
            switch (form.FormType)
            {
                case FormType.Function:
                    return RedirectToAction("Function", "Forms");

                case FormType.Variable:
                    return RedirectToAction("Variable", "Forms");

                case FormType.IfStatement:
                    return RedirectToAction("IfStatement", "Forms");

                case FormType.ForLoop:
                    return RedirectToAction("ForLoop", "Forms");

                default:
                    return RedirectToAction("Index", "Home");
            }
        }
    }
}
