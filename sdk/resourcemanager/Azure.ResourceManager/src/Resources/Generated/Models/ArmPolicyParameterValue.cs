// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> The value of a parameter. </summary>
    public partial class ArmPolicyParameterValue
    {
        /// <summary> Initializes a new instance of ArmPolicyParameterValue. </summary>
        public ArmPolicyParameterValue()
        {
        }

        /// <summary> Initializes a new instance of ArmPolicyParameterValue. </summary>
        /// <param name="value"> The value of the parameter. </param>
        internal ArmPolicyParameterValue(BinaryData value)
        {
            Value = value;
        }

        /// <summary> The value of the parameter. </summary>
        public BinaryData Value { get; set; }
    }
}
