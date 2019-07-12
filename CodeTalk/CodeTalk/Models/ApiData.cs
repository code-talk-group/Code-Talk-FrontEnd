using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeTalk.Models
{
    public class ApiData
    {
        public int ID { get; set; }
        public string CodeName { get; set; }
        public string Inputs { get; set; }

        public ApiData(int id, string codeName, string inputs)
        {
            ID = id;
            CodeName = codeName;
            Inputs = inputs;
        }
    }
}
