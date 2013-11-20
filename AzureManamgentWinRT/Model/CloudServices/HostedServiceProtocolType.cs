using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureManamgentWinRT.Model.CloudServices
{
    /// <summary>
    /// Specifies the transport protocol for the endpeoint.
    /// </summary>
    public enum HostedServiceProtocolType
    {
        /// <summary>
        /// TCP as the protocol.
        /// </summary>
        TCP,
        /// <summary>
        /// UDP as the protocol.
        /// </summary>
        UDP
    }
}
