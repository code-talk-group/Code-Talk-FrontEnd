using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeTalk.Models.Interfaces
{
    interface IResultsManager
    {
        /// <summary>
        /// Adds new code snippet to the database
        /// </summary>
        /// <param name="form"></param>
        /// <returns></returns>
        Task AddCodeSnippet(Results results);

        Task DeleteCodeSnippet();
        Task UpdateCodeSnippet();
        Task<List<Form>> GetAllCodeSnippets();
        Task<Form> GetCodeSnippet();

    }
}
