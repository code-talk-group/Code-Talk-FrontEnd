using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
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
        public async Task<IActionResult> CreateForLoop(int id, [Bind("ID, MethodName, ArrayName, CodeName")] ForLoop forLoop)
        {
            ForLoop sendForLoop = new ForLoop();
            sendForLoop.ID = 2;
            sendForLoop.MethodName = forLoop.MethodName;
            sendForLoop.ArrayName = forLoop.ArrayName;
            sendForLoop.CodeName = forLoop.CodeName;

            string inputs = JsonConvert.SerializeObject(sendForLoop);

            if (ModelState.IsValid)
            {
                using (var client = new HttpClient())
                {


                    client.BaseAddress = new Uri("https://codetalkapi.azurewebsites.net/api/default/");
                    string uri = "https://codetalkapi.azurewebsites.net/api/default/";
                    HttpResponseMessage response = await client.PostAsync(uri, new StringContent(inputs, Encoding.UTF8, "application/json"));


                    var stringResult = await response.Content.ReadAsStringAsync();
                    Results rawSentence = JsonConvert.DeserializeObject<Results>(stringResult);

                    return View("Index", new Results
                    {
                        ID = rawSentence.ID,
                        returnString = rawSentence.returnString,
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
        /// Takes in form data and sends serialized JSON object to the api endpoint associated with the id
        /// </summary>
        /// <param name="id">End point option for the api</param>
        /// <returns>New page with sentence populated with data sent</returns>
        [HttpPost]
        public async Task<IActionResult> CreateFunction(int id, [Bind("ID, MethodName, DataType, CodeName, ParameterName")] Function function)
        {
            Function sendFunction = new Function();
            sendFunction.ID = 1;
            sendFunction.CodeName = function.CodeName;
            sendFunction.MethodName = function.MethodName;
            sendFunction.DataType = function.DataType;
            sendFunction.ParameterName = function.ParameterName;


            string inputs = JsonConvert.SerializeObject(sendFunction);


            if (ModelState.IsValid)
            {
                using (var client = new HttpClient())
                {


                    client.BaseAddress = new Uri("https://codetalkapi.azurewebsites.net/api/default/");
                    string uri = "https://codetalkapi.azurewebsites.net/api/default/";
                    HttpResponseMessage response = await client.PostAsync(uri, new StringContent(inputs, Encoding.UTF8, "application/json"));


                    var stringResult = await response.Content.ReadAsStringAsync();
                    Results rawSentence = JsonConvert.DeserializeObject<Results>(stringResult);

                    return View("Index", new Results
                    {
                        ID = rawSentence.ID,
                        returnString = rawSentence.returnString,
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
        /// Takes in form data and sends serialized JSON object to the api endpoint associated with the id
        /// </summary>
        /// <param name="id">End point option for the api</param>
        /// <returns>New page with sentence populated with data sent</returns>
        [HttpPost]
        public async Task<IActionResult> CreateIfStatement(int id, [Bind("MethodName, CodeName, IntegerValue, ParameterName")] IfStatement ifStatement)
        {
            IfStatement sendResults = new IfStatement();
            sendResults.ID = 3;
            sendResults.MethodName = ifStatement.MethodName;
            sendResults.CodeName = ifStatement.CodeName;
            sendResults.IntegerValue = ifStatement.IntegerValue;
            sendResults.ParameterName = ifStatement.ParameterName;

            string inputs = JsonConvert.SerializeObject(sendResults);

            if (ModelState.IsValid)
            {
                using (var client = new HttpClient())
                {


                    client.BaseAddress = new Uri("https://codetalkapi.azurewebsites.net/api/default/");
                    string uri = "https://codetalkapi.azurewebsites.net/api/default/";
                    HttpResponseMessage response = await client.PostAsync(uri, new StringContent(inputs, Encoding.UTF8, "application/json"));


                    var stringResult = await response.Content.ReadAsStringAsync();
                    Results rawSentence = JsonConvert.DeserializeObject<Results>(stringResult);

                    return View("Index", new Results
                    {
                        ID = rawSentence.ID,
                        returnString = rawSentence.returnString,
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
        /// Takes in form data and sends serialized JSON object to the api endpoint associated with the id
        /// </summary>
        /// <param name="id">End point option for the api</param>
        /// <returns>New page with sentence populated with data sent</returns>
        [HttpPost]
        public async Task<IActionResult> CreateVariable(int id, [Bind("MethodName, CodeName, DataType, VariableName, VariableValue")] Variable variable)
        {
            Variable sendResults = new Variable();
            sendResults.ID = 4;
            sendResults.MethodName = variable.MethodName;
            sendResults.CodeName = variable.CodeName;
            sendResults.DataType = variable.DataType;
            sendResults.VariableName = variable.VariableName;
            sendResults.VariableValue = variable.VariableValue;

            string inputs = JsonConvert.SerializeObject(sendResults);

            if (ModelState.IsValid)
            {
                using (var client = new HttpClient())
                {


                    client.BaseAddress = new Uri("https://codetalkapi.azurewebsites.net/api/default/");
                    string uri = "https://codetalkapi.azurewebsites.net/api/default/";
                    HttpResponseMessage response = await client.PostAsync(uri, new StringContent(inputs, Encoding.UTF8, "application/json"));


                    var stringResult = await response.Content.ReadAsStringAsync();
                    Results rawSentence = JsonConvert.DeserializeObject<Results>(stringResult);

                    return View("Index", new Results
                    {
                        ID = rawSentence.ID,
                        returnString = rawSentence.returnString,
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