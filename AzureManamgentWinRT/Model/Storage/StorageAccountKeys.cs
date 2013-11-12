using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureManamgentWinRT.Model.Storage
{
    /// <summary>
    /// Storage account keys type 
    /// enum.
    /// </summary>
    public enum StorageAccountKeyType
    {
        /// <summary>
        /// Primary account key.
        /// </summary>
        Primary,
        /// <summary>
        /// The backup key.
        /// </summary>
        Secondary
    }
}
