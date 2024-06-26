// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Maintenance.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Configuration Assignment
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ConfigurationAssignment : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ConfigurationAssignment class.
        /// </summary>
        public ConfigurationAssignment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConfigurationAssignment class.
        /// </summary>
        /// <param name="id">Fully qualified identifier of the resource</param>
        /// <param name="name">Name of the resource</param>
        /// <param name="type">Type of the resource</param>
        /// <param name="systemData">Azure Resource Manager metadata containing
        /// createdBy and modifiedBy information.</param>
        /// <param name="location">Location of the resource</param>
        /// <param name="maintenanceConfigurationId">The maintenance
        /// configuration Id</param>
        /// <param name="resourceId">The unique resourceId</param>
        /// <param name="filter">Properties of the configuration
        /// assignment</param>
        public ConfigurationAssignment(string id = default(string), string name = default(string), string type = default(string), SystemData systemData = default(SystemData), string location = default(string), string maintenanceConfigurationId = default(string), string resourceId = default(string), ConfigurationAssignmentFilterProperties filter = default(ConfigurationAssignmentFilterProperties))
            : base(id, name, type, systemData)
        {
            Location = location;
            MaintenanceConfigurationId = maintenanceConfigurationId;
            ResourceId = resourceId;
            Filter = filter;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets location of the resource
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the maintenance configuration Id
        /// </summary>
        [JsonProperty(PropertyName = "properties.maintenanceConfigurationId")]
        public string MaintenanceConfigurationId { get; set; }

        /// <summary>
        /// Gets or sets the unique resourceId
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceId")]
        public string ResourceId { get; set; }

        /// <summary>
        /// Gets or sets properties of the configuration assignment
        /// </summary>
        [JsonProperty(PropertyName = "properties.filter")]
        public ConfigurationAssignmentFilterProperties Filter { get; set; }

    }
}
