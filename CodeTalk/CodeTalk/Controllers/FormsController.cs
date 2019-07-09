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
    [Route("api/[controller]")]
    public class FormsController : Controller
    {
        [HttpGet]
        public static async Task<JObject> Index()
        {
            using (var client = new HttpClient())
            {


                client.BaseAddress = new Uri("https://codetalkapi.azurewebsites.net/api/");
                HttpResponseMessage response = await client.GetAsync($"default/0");

                if (response.IsSuccessStatusCode)
                {
                    return JObject.Parse(await response.Content.ReadAsStringAsync());
                }
                else
                {
                    return null;
                }
            }
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