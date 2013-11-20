using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureManamgentWinRT.Model.CloudServices
{
    /// <summary>
    /// The configuration modes for the Mode
    /// element of the Change deployment document.
    /// </summary>
    public enum ChangeConfigurationModes
    {
        /// <summary>
        /// Update is applied to each update domain for the service (default)
        /// </summary>
        Auto,
        /// <summary>
        /// WalkUpgradeDomain must be called to apply the update.
        /// </summary>
        Manual,
        /// <summary>
        /// No documentation available.
        /// </summary>
        Simultaneous
    }
}
