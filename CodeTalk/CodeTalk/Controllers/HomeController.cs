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

    /// <summary>
    /// Directs to the home page of Application
    /// </summary>
        [HttpGet]
      public  IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Redirects to forms controller based off drop down selection. 
        /// </summary>
        /// <param name="form"></param>
        /// <returns></returns>
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
