using AzureManamgentWinRT.ErrorHandling;
using AzureManamgentWinRT.Model.Storage;

namespace AzureManamgentWinRT.Clients.StorageOperationResults
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
