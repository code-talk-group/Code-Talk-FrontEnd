using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeTalk.Models
{
    public class Variable
    {
        public int ID { get; set; }
        public string CodeName { get; set; }

        public string MethodName { get; set; }

        public string DataType { get; set; }

        public string VariableName { get; set; }

        public string VariableValue { get; set; }
    }
}
