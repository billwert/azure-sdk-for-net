// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.Chat
{
    /// <summary> Details of the CPM message to send. </summary>
    internal partial class SendThreadlessChatMessageRequest
    {
        /// <summary> Initializes a new instance of SendThreadlessChatMessageRequest. </summary>
        public SendThreadlessChatMessageRequest()
        {
        }

        /// <summary> The from identifier that is owned by the authenticated account. </summary>
        public string From { get; set; }
        /// <summary> The channel user identifiers of the recipient. </summary>
        public string To { get; set; }
        /// <summary> The threadless chat message type. </summary>
        public ThreadlessChatMessageType? Type { get; set; }
        /// <summary> Chat message content. </summary>
        public string Content { get; set; }
        /// <summary> The media Object. </summary>
        public ChatMedia Media { get; set; }
        /// <summary> The template object used to create message templates. </summary>
        public ChatTemplate Template { get; set; }
    }
}
