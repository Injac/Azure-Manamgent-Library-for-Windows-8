using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using AzureManamgentWinRT.Configuration;
using AzureManamgentWinRT.Model.CloudServices;

namespace AzureManamgentWinRT.Model.ExtensionMethods
{
    /// <summary>
    /// Extensions to be used to 
    /// create a ChangeConfiguration xml file
    /// using fluid configuration.
    /// </summary>
    public static class ChangeConfigurationExtensionMethods
    {
        /// <summary>
        /// Adds the configuration.
        /// </summary>
        /// <param name="config">The config.</param>
        /// <param name="base64EncodedConfiguration">The base64 encoded configuration.</param>
        /// <returns></returns>
        public static ChangeConfiguration AddConfiguration(this ChangeConfiguration config, string base64EncodedConfiguration)
        {
            if (string.IsNullOrEmpty(base64EncodedConfiguration) || string.IsNullOrWhiteSpace(base64EncodedConfiguration))
            {
                throw new ArgumentException("Paramter base64EncodedConfiguration must be a valid string.",
                    base64EncodedConfiguration);
            }

            config.Configuration = base64EncodedConfiguration;

            return config;
        }

        /// <summary>
        /// Adds the treat warningsas errors.
        /// </summary>
        /// <param name="config">The config.</param>
        /// <param name="treatAsErrors">The treat as errors.</param>
        /// <returns></returns>
        public static ChangeConfiguration AddTreatWarningsasErrors(this ChangeConfiguration config, bool treatAsErrors)
        {
            config.TreatWarningsAsError = treatAsErrors.ToString();
            return config;
        }

        /// <summary>
        /// Adds the mode.
        /// </summary>
        /// <param name="config">The config.</param>
        /// <param name="mode">The mode.</param>
        /// <returns></returns>
        public static ChangeConfiguration AddMode(this ChangeConfiguration config, ChangeConfigurationModes mode)
        {
            config.Mode = mode;
            return config;
        }

        /// <summary>
        /// Adds the extended proptery.
        /// </summary>
        /// <param name="config">The config.</param>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static ChangeConfiguration AddExtendedProptery(this ChangeConfiguration config, string name, string value)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Paramter value must be a valid string.",
                    "value");
            }

            config.ExtendedProperties.Add(new ChangeConfigurationExtendedProperty()
            {
                Name = name,
                Value = value
            });

            return config;
        }

        /// <summary>
        /// Adds the extension configuration all roles.
        /// </summary>
        /// <param name="config">The config.</param>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        public static ChangeConfiguration AddExtensionConfigurationAllRoles(this ChangeConfiguration config, string id)
        {
            if (string.IsNullOrEmpty(id) || string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentException("Paramter id must be a valid string.",
                    "id");
            }

            config.ExtensionConfiguration.AllRoles.Add(new ChangeConfigurationExtensionConfigurationExtension()
            {
                Id = id
            });

            return config;
        }

        /// <summary>
        /// Adds the extension configuration named roles.
        /// </summary>
        /// <param name="config">The config.</param>
        /// <param name="roleName">Name of the role.</param>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        public static ChangeConfiguration AddExtensionConfigurationNamedRoles(this ChangeConfiguration config, string roleName, string id)
        {

            if (string.IsNullOrEmpty(id) || string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentException("Paramter id must be a valid string.",
                    "id");
            }
            if (string.IsNullOrEmpty(roleName) || string.IsNullOrWhiteSpace(roleName))
            {
                throw new ArgumentException("Paramter id must be a valid string.",
                    "id");
            }

            var ext = new ChangeConfigurationExtensionConfigurationNamedRolesRoleExtension() { Id = id };

            var role = new ChangeConfigurationExtensionConfigurationNamedRolesRole()
            {
                RoleName = roleName
            };

            role.Extensions.Add(ext);

            config.ExtensionConfiguration.NamedRoles.Add(role);
           
            
            return config;
        }

    }
}