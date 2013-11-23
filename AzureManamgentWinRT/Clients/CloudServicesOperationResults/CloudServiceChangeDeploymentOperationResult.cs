using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AzureManamgentWinRT.ErrorHandling;

namespace AzureManamgentWinRT.Clients.CloudServicesOperationResults
{
    /// <summary>
    /// Specifies the result delivered by the 
    /// <see cref="CloudServicesManagmentClient.ChangeDeploymentUsingDeploymentSlotAsync"/>
    /// method.
    /// </summary>
    public class CloudServiceChangeDeploymentOperationResult : AsyncExecutionResult
    {
        /// <summary>
        /// Gets or sets the operation result.
        /// </summary>
        /// <value>The operation result.</value>
        public string OperationResult { get; set; }
    }
}
