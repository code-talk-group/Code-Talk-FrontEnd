using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using CodeTalk.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CodeTalk.Controllers
{
    public class ResultsController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();

        //}

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            using (var client = new HttpClient())
            {


                client.BaseAddress = new Uri("https://codetalkapi.azurewebsites.net/api/");
                HttpResponseMessage response = await client.GetAsync($"user");

                var stringResult = await response.Content.ReadAsStringAsync();
                var rawSentence = JsonConvert.DeserializeObject<List<ApiResult>>(stringResult);

                return View(rawSentence);

                //return View("Index", new ApiResult
                //{
                    //ID = rawSentence.ID,
                    //returnString = rawSentence.returnString,
                    //Option = rawSentence.Option
                //});

            }
        }
    }
}