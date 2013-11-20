using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureManamgentWinRT.Model.CloudServices
{
    /// <summary>
    /// Specifies the type of guest agent that is installed on the role
    /// instance.
    /// </summary>
    public enum HostedServiceGuestAgentType
    {
        /// <summary>
        /// Production general availability.
        /// </summary>
        ProdGA,
        /// <summary>
        /// Test general availablitly.
        /// </summary>
        TestGA
    }
}
