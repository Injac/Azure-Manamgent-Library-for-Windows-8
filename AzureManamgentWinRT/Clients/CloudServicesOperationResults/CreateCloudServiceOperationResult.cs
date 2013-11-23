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
    /// This class is used to return the operational result for
    /// <see cref="CloudServicesManagmentClient.CreateCloudServiceAsync"/>
    /// method.
    /// </summary>
    public class CreateCloudServiceOperationResult : AsyncExecutionResult
    {
        /// <summary>
        /// Gets or sets the operation result.
        /// </summary>
        /// <value>The operation result.</value>
        public string OperationResult { get; set; }
    }
}
