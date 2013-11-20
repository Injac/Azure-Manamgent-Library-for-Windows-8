using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AzureManamgentWinRT.ErrorHandling;
using AzureManamgentWinRT.Model.CloudServices;

namespace AzureManamgentWinRT.Clients.CloudServicesOperationResults
{
    /// <summary>
    /// List the extensions, that are currently
    /// active for the specific cloud service.
    /// </summary>
    public class ListExtensionsOperationResult : AsyncExecutionResult
    {
        /// <summary>
        /// Gets or sets the operation result.
        /// </summary>
        /// <value>The operation result.</value>
        public CloudServiceExtensions OperationResult { get; set; }
    }
}
