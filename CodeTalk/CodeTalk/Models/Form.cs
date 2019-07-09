using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeTalk.Models
{
    public class Form
    {
        public FormType FormType { get; set; }
    }

    public enum FormType
    {
        Function,
        Variable,
        IfStatement,
        ForLoop
    }
}
