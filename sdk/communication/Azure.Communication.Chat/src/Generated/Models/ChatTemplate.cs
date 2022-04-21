// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.Chat
{
    /// <summary> The template object used to create message templates. </summary>
    public partial class ChatTemplate
    {
        /// <summary> Initializes a new instance of ChatTemplate. </summary>
        public ChatTemplate()
        {
            Parameters = new ChangeTrackingList<string>();
        }

        /// <summary> Name of the template. </summary>
        public string Name { get; set; }
        /// <summary> The codes for the supported languages for message templates. </summary>
        public LanguageCode? Language { get; set; }
        /// <summary> Array of parameters for the content of the message. </summary>
        public IList<string> Parameters { get; }
    }
}
