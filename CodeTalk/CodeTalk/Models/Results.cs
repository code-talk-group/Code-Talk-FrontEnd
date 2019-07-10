using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CodeTalk.Models
{
    [Bind("Option, MethodName, ArrayName, CodeName")]
    public class Results
    {
        public string Code { get; set; }

        public string baseString { get; set; }

        public int ID { get; set; }

        public int Option { get; set; }
        public string MethodName { get; set; }
        public string ArrayName { get; set; }
        public string CodeName { get; set; }

    }

}
