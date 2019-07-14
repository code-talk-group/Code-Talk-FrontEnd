using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeTalk.Models
{
    /// <summary>
    /// Model for If Statement 
    /// </summary>
    public class IfStatement
    {
        /// <summary>
        /// Gets/sets the ID for IfStatement
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets/sets the CodeName for IfStatement
        /// </summary>
        public string CodeName { get; set; }

        /// <summary>
        /// Gets/sets the MethodName for IfStatement
        /// </summary>
        public string MethodName { get; set; }

        /// <summary>
        /// Gets/sets the ParameterName for IfStatement
        /// </summary>
        public string ParameterName { get; set; }

        /// <summary>
        /// Gets/sets the IntegerValue for IfStatment 
        /// </summary>
        public string IntegerValue { get; set; }
    }
}
