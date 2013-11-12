using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureManamgentWinRT.Model.Storage
{
    /// <summary>
    /// Known location names for Windows Azure.  You can obtain a complete list
    /// of the latest locations available to your subscription from the List
    /// Locations Operation.
    /// Taken from the Azure .NET SDK. License: Apache License 2.0
    /// </summary>
    public static  class LocationNames
    {
        public const string WestEurope = "West Europe";

        public const string SoutheastAsia = "Southeast Asia";

        public const string EastAsia = "East Asia";

        public const string NorthCentralUS = "North Central US";

        public const string NorthEurope = "North Europe";

        public const string SouthCentralUS = "South Central US";

        public const string WestUS = "West US";

        public const string EastUS = "East US";
    }
}
