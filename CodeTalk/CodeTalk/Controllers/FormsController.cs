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
    public class FormsController : Controller
    {
        /// <summary>
        /// Sends input from form data to api and gets back a sentence representing the data sent
        /// </summary>
        /// <returns>Sentence that represents the data send</returns>
        [HttpGet]
        public  async Task<IActionResult> Index()
        {
            using (var client = new HttpClient())
            {


                client.BaseAddress = new Uri("https://codetalkapi.azurewebsites.net/api/");
                HttpResponseMessage response = await client.GetAsync($"default/4");

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
        public async Task<IActionResult> Create(int id/*[Bind("Option, MethodName, ArrayName, CodeName")] Results results*/)
        {
           // int Option = results.Option;
            if (ModelState.IsValid)
            {
                using (var client = new HttpClient())
                {


                    client.BaseAddress = new Uri("https://codetalkapi.azurewebsites.net/api/");
                    HttpResponseMessage response = await client.GetAsync($"default/{id}");

                    var stringResult = await response.Content.ReadAsStringAsync();
                    Results rawSentence = JsonConvert.DeserializeObject<Results>(stringResult);

                    return View("Index", new Results
                    {
                        ID = rawSentence.ID,
                        baseString = rawSentence.baseString,
                        Option = rawSentence.Option
                    });

                }
            }
            else
            {
                return null;    
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

        }
    }