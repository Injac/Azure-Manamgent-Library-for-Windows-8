using AzureManamgentWinRT.ErrorHandling;
using AzureManamgentWinRT.Model.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureManamgentWinRT.Clients
{
    /// <summary>
    /// The result returned by the storage list operation.
    /// </summary>
    public class StorageListResult : AsyncExecutionResult
    {
        /// <summary>
        /// Gets or sets the operation result.
        /// </summary>
        /// <value>The operation result.</value>
        public StorageServiceRoot OperationResult { get; set; }
    }
}
