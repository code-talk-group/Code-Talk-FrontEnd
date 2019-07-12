using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CodeTalk.Models
{
    public class Results
    {
        public List<ApiResult> ApiResult { get; set; }
        public string Code { get; set; }
        public string baseString { get; set; }

        public string returnString { get; set; }

        public int ID { get; set; }

        public int Option { get; set; }
        public string CodeName { get; set; }

    }
    public class ApiResult
    {
        public int ID { get; set; }
        public string returnString { get; set; }
        public string Code { get; set; }
        public string CodeName { get; set; }
    }

}
