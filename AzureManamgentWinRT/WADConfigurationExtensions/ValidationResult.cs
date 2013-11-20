using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureManamgentWinRT.WADConfigurationExtensions
{
    /// <summary>
    /// Validation result,
    /// when validating XML files
    /// manually.
    /// </summary>
    public class ValidationResult
    {
        /// <summary>
        /// Gets or sets the is valid.
        /// </summary>
        /// <value>The is valid.</value>
        public bool IsValid { get; set; }

        /// <summary>
        /// Gets or sets the validation message.
        /// </summary>
        /// <value>The validation message.</value>
        public string ValidationMessage { get; set; }
    }
}
