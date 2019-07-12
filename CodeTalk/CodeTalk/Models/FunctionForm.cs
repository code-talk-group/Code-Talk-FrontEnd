using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeTalk.Models
{
    public class FunctionForm
    {
        public string MethodName { get; set; }

        public string ParameterName { get; set; }

        public string DataType { get; set; }

        public FunctionForm(string methodName, string parameterName, string dataType)
        {
            MethodName = methodName;
            ParameterName = parameterName;
            DataType = dataType;
         
        }
    }

}
