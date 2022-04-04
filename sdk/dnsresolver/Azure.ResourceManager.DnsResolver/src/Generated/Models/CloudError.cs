// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DnsResolver.Models
{
    /// <summary> An error message. </summary>
    internal partial class CloudError
    {
        /// <summary> Initializes a new instance of CloudError. </summary>
        internal CloudError()
        {
        }

        /// <summary> Initializes a new instance of CloudError. </summary>
        /// <param name="error"> The error message body. </param>
        internal CloudError(CloudErrorBody error)
        {
            Error = error;
        }

        /// <summary> The error message body. </summary>
        public CloudErrorBody Error { get; }
    }
}
