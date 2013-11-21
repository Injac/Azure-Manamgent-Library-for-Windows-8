using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureManamgentWinRT.Model
{
    /// <summary>
    /// The instance size for the role.
    /// Copied from the original MS
    /// repo.
    /// </summary>
    public enum VirtualMachineRoleSize
    {
        Small = 0,

        ExtraSmall = 1,

        Large = 2,

        Medium = 3,

        ExtraLarge = 4,

        A5 = 5,

        A6 = 6,

        A7 = 7,
    }
}
