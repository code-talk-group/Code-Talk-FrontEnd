using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Display(Name = "Function")]
        Function,
        [Display(Name = "Variable")]
        Variable,
        [Display(Name = "If Statement")]
        IfStatement,
        [Display(Name = "For Loop")]
        ForLoop
    }
}
