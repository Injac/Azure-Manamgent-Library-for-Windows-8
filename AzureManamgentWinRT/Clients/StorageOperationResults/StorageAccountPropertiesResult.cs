using AzureManamgentWinRT.ErrorHandling;
using AzureManamgentWinRT.Model.Storage;

namespace AzureManamgentWinRT.Clients.StorageOperationResults
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