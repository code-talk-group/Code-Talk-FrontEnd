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
                HttpResponseMessage response = await client.GetAsync($"user");

                var stringResult = await response.Content.ReadAsStringAsync();
                Results rawSentence = JsonConvert.DeserializeObject<Results>(stringResult);

                return View(new Results
                {ID = rawSentence.ID,
                baseString = rawSentence.baseString,
                Option = rawSentence.Option
                });

            }
        }

        /// <summary>
        /// Takes in form data and sends serialized JSON object to the api endpoint associated with the id
        /// </summary>
        /// <param name="id">End point option for the api</param>
        /// <returns>New page with sentence populated with data sent</returns>
        [HttpPost]
        public async Task<IActionResult> Create(int id/*[Bind("Option, MethodName, ArrayName, CodeName")] Results results*/)
        {
            Results sendResults = new Results();
            sendResults.MethodName = "Method name from form";
            sendResults.CodeName = "Code name from form";
            sendResults.ArrayName = "Array name from form";

            string apiSend = JsonConvert.SerializeObject(sendResults); 

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


        /// <summary>
        /// Directs to Function Form View from Home View drop down
        /// </summary>
        /// <returns></returns>
        public IActionResult Function()
            {
                return View();
            }

        /// <summary>
        /// Directs to Variable Form View from Home View drop down
        /// </summary>
        /// <returns></returns>
        public IActionResult Variable()
        {
            return View();
        }

        /// <summary>
        /// Directs to IfStatement Form View from Home View drop down
        /// </summary>
        /// <returns></returns>
        public IActionResult IfStatement()
        {
            return View();
        }

        /// <summary>
        /// Directs to ForLoop Form View from Home View drop down
        /// </summary>
        /// <returns></returns>
        public IActionResult ForLoop()
        {
            return View();
        }

        }
    }