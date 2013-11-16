using AzureManamgentWinRT.ErrorHandling;
using AzureManamgentWinRT.Model.CloudServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureManamgentWinRT.Clients.CloudServicesOperationResults
{
    /// <summary>
    /// The operation result returned
    /// by ListAvailableExtensionsAsync operation.
    /// </summary>
    public class ListAvailableExtensionsOperationResult : AsyncExecutionResult
    {
        /// <summary>
        /// Gets or sets the operation result.
        /// </summary>
        /// <value>The operation result.</value>
        public CloudServiceExtensionImagesRoot OperationResult { get; set; }
    }
}
