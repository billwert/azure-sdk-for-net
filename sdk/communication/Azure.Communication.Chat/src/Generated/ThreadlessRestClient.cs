// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Communication.Chat
{
    internal partial class ThreadlessRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly string _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of ThreadlessRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The endpoint of the Azure Communication resource. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/> or <paramref name="endpoint"/> is null. </exception>
        public ThreadlessRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint)
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? throw new ArgumentNullException(nameof(endpoint));
        }

        internal HttpMessage CreateSendChatMessageRequest(string @from, string to, ThreadlessChatMessageType? type, string content, ChatMedia media, ChatTemplate template)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/chat/threadless/messages", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var model = new SendThreadlessChatMessageRequest()
            {
                From = @from,
                To = to,
                Type = type,
                Content = content,
                Media = media,
                Template = template
            };
            var content0 = new Utf8JsonRequestContent();
            content0.JsonWriter.WriteObjectValue(model);
            request.Content = content0;
            return message;
        }

        /// <summary> Sends a Fire and Forget/Threadless/CPM message. </summary>
        /// <param name="from"> The from identifier that is owned by the authenticated account. </param>
        /// <param name="to"> The channel user identifiers of the recipient. </param>
        /// <param name="type"> The threadless chat message type. </param>
        /// <param name="content"> Chat message content. </param>
        /// <param name="media"> The media Object. </param>
        /// <param name="template"> The template object used to create message templates. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<SendThreadlessChatMessageResult>> SendChatMessageAsync(string @from = null, string to = null, ThreadlessChatMessageType? type = null, string content = null, ChatMedia media = null, ChatTemplate template = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateSendChatMessageRequest(@from, to, type, content, media, template);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SendThreadlessChatMessageResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SendThreadlessChatMessageResult.DeserializeSendThreadlessChatMessageResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Sends a Fire and Forget/Threadless/CPM message. </summary>
        /// <param name="from"> The from identifier that is owned by the authenticated account. </param>
        /// <param name="to"> The channel user identifiers of the recipient. </param>
        /// <param name="type"> The threadless chat message type. </param>
        /// <param name="content"> Chat message content. </param>
        /// <param name="media"> The media Object. </param>
        /// <param name="template"> The template object used to create message templates. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<SendThreadlessChatMessageResult> SendChatMessage(string @from = null, string to = null, ThreadlessChatMessageType? type = null, string content = null, ChatMedia media = null, ChatTemplate template = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateSendChatMessageRequest(@from, to, type, content, media, template);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SendThreadlessChatMessageResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SendThreadlessChatMessageResult.DeserializeSendThreadlessChatMessageResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
