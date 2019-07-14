using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeTalk.Models
{
    /// <summary>
    /// Model for Function
    /// </summary>
    public class Function
    {
        /// <summary>
        /// Gets/sets ID for Function
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets/sets the CodeName for Function
        /// </summary>
        public string CodeName { get; set; }

        /// <summary>
        /// Gets/sets the MethodName for Function
        /// </summary>
        public string MethodName { get; set; }

        /// <summary>
        /// Gets/sets the DataType for Function
        /// </summary>
        public string DataType { get; set; }

        /// <summary>
        /// Gets/sets the ParameterName for Function
        /// </summary>
        public string ParameterName { get; set; }
    }
}
