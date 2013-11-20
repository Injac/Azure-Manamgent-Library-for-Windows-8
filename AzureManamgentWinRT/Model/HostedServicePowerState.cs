using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureManamgentWinRT.Model
{
    /// <summary>
    /// Indicated the running state of
    /// the role instance.
    /// </summary>
    public enum HostedServicePowerState
    {
        /// <summary>
        /// Role instance is starting.
        /// </summary>
        Starting,
        /// <summary>
        /// Role instance was started.
        /// </summary>
        Started,
        /// <summary>
        /// Role instance is being stopped.
        /// </summary>
        Stopping,
        /// <summary>
        /// Role instance was stopped.
        /// </summary>
        Stopped,
        /// <summary>
        /// The power state is unknown.
        /// </summary>
        Unknown
    }
}
