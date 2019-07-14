using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeTalk.Models
{
    /// <summary>
    /// Model for a Code Form. 
    /// </summary>
    public class Form
    {
        /// <summary>
        /// Gets/Sets the Form Type based off the FormType enum
        /// </summary>
        public FormType FormType { get; set; }
    }

    /// <summary>
    /// Enum table for FormType that allows selection of what type of form to be filled out
    /// </summary>
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
