using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeTalk.Models
{
    public class ForLoopForm
    {
        public string MethodName { get; set; }

        public string ArrayName { get; set; }

        public ForLoopForm(string methodName, string arrayName)
        {
            MethodName = methodName;
            ArrayName = arrayName;
        }
    }
}
