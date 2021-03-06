﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AzureManamgentWinRT.Model.CloudServices
{
    /// <summary>
    /// The response generated by the
    /// API call to check availablity
    /// of a cloud service name.
    /// </summary>
    public class AvailabilityResponse
    {
        /// <summary>
        /// Gets or sets the result.
        /// </summary>
        /// <value>The result.</value>
        [XmlElement(ElementName = "Result")]
        public bool Result { get; set; }

        /// <summary>
        /// Gets or sets the reason.
        /// </summary>
        /// <value>The reason.</value>
        [XmlElement(ElementName = "Reason")]
        public string Reason { get; set; }
    }
}
