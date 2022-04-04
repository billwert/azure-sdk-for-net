// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Deployment What-if operation parameters. </summary>
    internal partial class ScopedDeploymentWhatIf
    {
        /// <summary> Initializes a new instance of ScopedDeploymentWhatIf. </summary>
        /// <param name="location"> The location to store the deployment data. </param>
        /// <param name="properties"> The deployment properties. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="properties"/> is null. </exception>
        internal ScopedDeploymentWhatIf(string location, ArmDeploymentWhatIfProperties properties)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Location = location;
            Properties = properties;
        }

        /// <summary> The location to store the deployment data. </summary>
        public string Location { get; }
        /// <summary> The deployment properties. </summary>
        public ArmDeploymentWhatIfProperties Properties { get; }
    }
}
