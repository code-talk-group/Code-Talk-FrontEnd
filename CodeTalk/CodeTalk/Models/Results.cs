using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CodeTalk.Models
{
    /// <summary>
    /// Model for Results
    /// </summary>
    public class Results
    {
        /// <summary>
        /// Creates a list of the ApiResults to emumerate over
        /// </summary>
        public List<ApiResult> ApiResult { get; set; }

        /// <summary>
        /// Gets/sets the Code for Results
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Gets/sets the baseString for the Results
        /// </summary>
        public string baseString { get; set; }

        /// <summary>
        /// Gets/sets the returnString for the Results
        /// </summary>
        public string returnString { get; set; }

        /// <summary>
        /// Gets/sets the ID for the Results
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets/sets the Option for the Results
        /// </summary>
        public int Option { get; set; }

        /// <summary>
        /// Gets/sets the CodeName for the Results
        /// </summary>
        public string CodeName { get; set; }

    }

    /// <summary>
    /// Model for the ApiResults that is expected
    /// </summary>
    public class ApiResult
    {
        /// <summary>
        /// Gets/sets the ID for the ApiResults
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets/sets the returnString for the ApiResults
        /// </summary>
        public string returnString { get; set; }

        /// <summary>
        /// Gets/sets the Code for ApiResults
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Gets/sets the CodeName for ApiResults
        /// </summary>
        public string CodeName { get; set; }
    }

}
