using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AzureManamgentWinRT.ErrorHandling;
using AzureManamgentWinRT.Model.HostedServices;

namespace AzureManamgentWinRT.Clients.CloudServicesOperationResults
{
    /// <summary>
    /// Represents an operation result
    /// after a cloud serivce properties request.
    /// </summary>
    public class GetCloudServicePropertiesOperationResult : AsyncExecutionResult
    {
        public HostedService OperationResult { get; set; } 
    }
}
