using System;
using System.Xml.Serialization;

namespace AzureManamgentWinRT.Model.HostedServices
{
    /// <summary>
    /// Specifies information about when the Virtual Machine has been started and stopped.
    /// </summary>
    public partial class HostedServiceDeploymentPersistentVMDowntime
    {
        private DateTime startTimeField;

        private DateTime endTimeField;

        private string statusField;

        /// <summary>
        /// Gets or sets the start time.
        /// </summary>
        /// <value>The start time.</value>
        [XmlElement(Order = 0)]
        public DateTime StartTime
        {
            get
            {
                return this.startTimeField;
            }
            set
            {
                this.startTimeField = value;
            }
        }

        /// <summary>
        /// Specifies the time that the Virtual Machine was stopped.
        /// </summary>
        /// <value>The end time.</value>
        [XmlElement(Order = 1)]
        public DateTime EndTime
        {
            get
            {
                return this.endTimeField;
            }
            set
            {
                this.endTimeField = value;
            }
        }

        /// <summary>
        /// Specifies the status of the Virtual Machine.
        /// </summary>
        /// <value>The status.</value>
        [XmlElement(Order = 2)]
        public string Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
    }
}