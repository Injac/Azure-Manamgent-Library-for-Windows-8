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
    /// Contains the storage account access keys,
    /// after the accesss key request.
    /// </summary>
    public class StorageKeysResult : AsyncExecutionResult
    {
        /// <summary>
        /// Gets or sets the operation result.
        /// </summary>
        /// <value>The operation result.</value>
        public StorageServiceReply OperationResult { get; set; }
    }
}
