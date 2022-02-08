// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The JSON object that contains the properties to validate a domain. </summary>
    public partial class DomainValidationProperties
    {
        /// <summary> Initializes a new instance of DomainValidationProperties. </summary>
        internal DomainValidationProperties()
        {
        }

        /// <summary> Initializes a new instance of DomainValidationProperties. </summary>
        /// <param name="validationToken"> Challenge used for DNS TXT record or file based validation. </param>
        /// <param name="expirationDate"> The date time that the token expires. </param>
        internal DomainValidationProperties(string validationToken, string expirationDate)
        {
            ValidationToken = validationToken;
            ExpirationDate = expirationDate;
        }

        /// <summary> Challenge used for DNS TXT record or file based validation. </summary>
        public string ValidationToken { get; }
        /// <summary> The date time that the token expires. </summary>
        public string ExpirationDate { get; }
    }
}
