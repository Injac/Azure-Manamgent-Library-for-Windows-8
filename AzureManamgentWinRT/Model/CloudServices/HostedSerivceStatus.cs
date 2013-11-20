using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureManamgentWinRT.Model.CloudServices
{
    /// <summary>
    /// Specifies the status of the cloud service.
    /// </summary>
    public enum HostedSerivceStatus
    {
        /// <summary>
        /// Cloud serivce is
        /// beeing created.
        /// </summary>
        Creating,
        /// <summary>
        /// Cloud service was created.
        /// </summary>
        Created,
        /// <summary>
        /// Cloud service is being deleted.
        /// </summary>
        Deleting,
        /// <summary>
        /// Cloud service was deleted.
        /// </summary>
        Deleted,
        /// <summary>
        /// Cloud service status is 
        /// transitioning.
        /// </summary>
        Changing,
        /// <summary>
        /// The DNS for the cloudservice
        /// is being resolved.
        /// </summary>
        ResolvingDns
    }
}
