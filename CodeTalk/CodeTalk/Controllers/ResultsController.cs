﻿using System;
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

            }
        }
        public async Task<IActionResult> Delete(int id)
        {
            using (var client = new HttpClient())
            {


                client.BaseAddress = new Uri("https://codetalkapi.azurewebsites.net/api/");
                HttpResponseMessage response = await client.DeleteAsync($"user/{id}");
                response.EnsureSuccessStatusCode();


                return RedirectToAction(nameof(Index));
            }

        }

        public async Task<IActionResult> Edit(int id)
        {
            using (var client = new HttpClient())
            {


                client.BaseAddress = new Uri("https://codetalkapi.azurewebsites.net/api/");
                HttpResponseMessage response = await client.GetAsync($"user/{id}");

                var stringResult = await response.Content.ReadAsStringAsync();
                var rawSentence = JsonConvert.DeserializeObject<Results>(stringResult);

                return View(rawSentence);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("baseString")] Results results)
        {
            return RedirectToAction(nameof(Index));

        }
    }
}