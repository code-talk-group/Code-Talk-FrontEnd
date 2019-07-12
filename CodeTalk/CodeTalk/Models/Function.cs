using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeTalk.Models
{
    public class Function
    {
        public int ID { get; set; }
        public string CodeName { get; set; }

        public string MethodName { get; set; }

        public string DataType { get; set; }

        public string ParameterName { get; set; }
    }
}
