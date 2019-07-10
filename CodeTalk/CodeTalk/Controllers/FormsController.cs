using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using CodeTalk.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CodeTalk.Controllers
{
    //[Route("api/[controller]")]
    public class FormsController : Controller
    {
        [HttpGet]
        public  async Task<IActionResult> Index()
        {
            using (var client = new HttpClient())
            {


                client.BaseAddress = new Uri("https://codetalkapi.azurewebsites.net/api/");
                HttpResponseMessage response = await client.GetAsync($"default");

                var stringResult = await response.Content.ReadAsStringAsync();
                Results rawSentence = JsonConvert.DeserializeObject<Results>(stringResult);

                return View(new Results
                {ID = rawSentence.ID,
                baseString = rawSentence.baseString,
                Option = rawSentence.Option
                });
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create()
        {
            return RedirectToAction(nameof(Index));
        }

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
            //public async Task<IActionResult> CodeSnippetsFromApi()
            //{
            //    return View(await client.GetAllCodeSnippets());
            //}
        }
    }