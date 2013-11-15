using AzureManamgentWinRT.ErrorHandling;

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
