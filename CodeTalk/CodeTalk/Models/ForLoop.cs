using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeTalk.Models
{
    /// <summary>
    /// Model for For Loop to be sent to api
    /// </summary>
    public class ForLoop
    {
        /// <summary>
        /// Gets/sets ID for ForLoop
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets/sets the CodeName for ForLoop
        /// </summary>
        public string CodeName { get; set; }

        /// <summary>
        /// Get/sets the MethodName for ForLoop
        /// </summary>
        public string MethodName { get; set; }

        /// <summary>
        /// Gets/sets ArrayName for ForLoop
        /// </summary>
        public string ArrayName { get; set; }

    }
}
