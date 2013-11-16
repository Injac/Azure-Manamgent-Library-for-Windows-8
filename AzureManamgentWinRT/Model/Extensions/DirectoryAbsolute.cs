using System.Runtime.Serialization;

namespace AzureManamgentWinRT.Models.ConfDiag.Public
{
    [DataContract(Name = "DirectoryAbsolute", Namespace = "http://schemas.microsoft.com/ServiceHosting/2010/10/DiagnosticsConfiguration")]
    public partial class DirectoryAbsolute : DirectoryBase
    {

        private string pathField;

        private bool expandEnvironmentField;

        /// <summary>
        /// Gets or sets the
        /// path. This is a specific path on 
        /// the system.
        /// If you want to add and expand 
        /// environment variables (%SYSTEM%)
        /// You should set expandEnvironment 
        /// to true.
        /// </summary>
        [DataMember]
        public string path
        {
            get
            {
                return this.pathField;
            }
            set
            {
                this.pathField = value;
            }
        }

        /// <summary>
        /// Gets or sets enviroment
        /// variable expansion.
        /// </summary>
        [DataMember]
        public bool expandEnvironment
        {
            get
            {
                return this.expandEnvironmentField;
            }
            set
            {
                this.expandEnvironmentField = value;
            }
        }
    }
}