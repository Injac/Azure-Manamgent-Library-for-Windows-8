using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureManamgentWinRT.Model.CloudServices
{
    /// <summary>
    /// Specifies the platform caching behaviour of the operating 
    /// system disk blob for read/write efficency.
    /// </summary>
    public enum HostedServiceHostCaching
    {
        /// <summary>
        /// Read only.
        /// </summary>
        ReadOnly,
        /// <summary>
        /// Read and write operations.
        /// </summary>
        ReadWrite
    }
}
