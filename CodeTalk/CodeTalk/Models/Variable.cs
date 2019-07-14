using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeTalk.Models
{
    /// <summary>
    /// Models for Variable
    /// </summary>
    public class Variable
    {
        /// <summary>
        /// Gets/sets the ID for the Variable
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets/sets the CodeName for the Variable
        /// </summary>
        public string CodeName { get; set; }

        /// <summary>
        /// Gets/sets the MethodName for the Variable
        /// </summary>
        public string MethodName { get; set; }

        /// <summary>
        /// Gets/sets the DataType for the Variable
        /// </summary>
        public string DataType { get; set; }

        /// <summary>
        /// Get/sets the VariableName for the Variable
        /// </summary>
        public string VariableName { get; set; }

        /// <summary>
        /// Gets/sets the VariableValue of the Variable
        /// </summary>
        public string VariableValue { get; set; }
    }
}
