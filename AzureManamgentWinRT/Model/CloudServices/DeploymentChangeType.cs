using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureManamgentWinRT.Model.CloudServices
{
    /// <summary>
    /// The type of the 
    /// deployment change to happen.
    /// </summary>
    public enum DeploymentChangeType
    {
        /// <summary>
        /// Change via slot, production or staging
        /// </summary>
        ChangeByDeploymentSlot,
        /// <summary>
        /// Change using the deployment name GUID
        /// </summary>
        ChangeByDeploymentName
    }
}
