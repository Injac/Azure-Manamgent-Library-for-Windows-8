using AzureManamgentWinRT.ErrorHandling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureManamgentWinRT.Clients.StorageOperationResults
{
    /// <summary>
    /// The result returned by service creation.
    /// </summary>
    public class StorageServiceCreateResult : AsyncExecutionResult
    {
        /// <summary>
        /// Gets or sets the operation result.
        /// </summary>
        /// <value>The operation result.</value>
        public string OperationResult { get; set; }
    }
}
