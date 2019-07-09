using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeTalk.Models.Interfaces
{
    interface IFormManager
    {
        /// <summary>
        /// Adds new code snippet to the database
        /// </summary>
        /// <param name="form"></param>
        /// <returns></returns>
        Task AddCodeSnippet(Form form);

        /// <summary>
        /// Deletes a specific code snippet
        /// </summary>
        /// <returns></returns>
        Task DeleteCodeSnippet();

        /// <summary>
        /// Edits a code snippet and saves the edit to the data base
        /// </summary>
        /// <returns></returns>
        Task UpdateCodeSnippet();

        /// <summary>
        /// Gets all code snippets in the data base
        /// </summary>
        /// <returns></returns>
        Task<List<Form>> GetAllCodeSnippets();

        /// <summary>
        /// Gets a specific code snippet from the database
        /// </summary>
        /// <returns></returns>
        Task<Form> GetCodeSnippet();
    }
}
