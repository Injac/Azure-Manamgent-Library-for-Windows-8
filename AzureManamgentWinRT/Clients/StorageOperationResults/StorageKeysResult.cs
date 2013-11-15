using AzureManamgentWinRT.ErrorHandling;
using AzureManamgentWinRT.Model.Storage;

namespace AzureManamgentWinRT.Clients.StorageOperationResults
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
