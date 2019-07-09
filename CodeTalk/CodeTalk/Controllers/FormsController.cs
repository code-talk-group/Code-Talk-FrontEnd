using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CodeTalk.Controllers
{
    //static HttpClient client = new HttpClient();
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

        //Get: Code Results From API
        public async Task<IActionResult> CodeFromApi()
        {
             return View(await _context.GetResultsAsync());
        }
    }
}