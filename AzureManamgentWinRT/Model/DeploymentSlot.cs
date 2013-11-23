using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureManamgentWinRT.Model
{
    /// <summary>
    /// The deployment slot 
    /// to be used.
    /// </summary>
    public enum DeploymentSlot
    {
        /// <summary>
        /// Install to the production environment.
        /// </summary>
        Production,
        /// <summary>
        /// Install to the staging environment.
        /// </summary>
        Staging
    }
}
