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
    /// Contains the storage account properties after
    /// a successfull servicec-call.
    /// </summary>
    public class StorageAccountPropertiesResult : AsyncExecutionResult
    {
        /// <summary>
        /// Gets or sets the operation result.
        /// </summary>
        /// <value>The operation result.</value>
        public StorageAccountProperties OperationResult { get; set; }
    }
}