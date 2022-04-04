// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class SharedPrivateLinkResourceProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PrivateLink))
            {
                writer.WritePropertyName("privateLink");
                JsonSerializer.Serialize(writer, PrivateLink);
            }
            if (Optional.IsDefined(PrivateLinkLocation))
            {
                writer.WritePropertyName("privateLinkLocation");
                writer.WriteStringValue(PrivateLinkLocation);
            }
            if (Optional.IsDefined(GroupId))
            {
                writer.WritePropertyName("groupId");
                writer.WriteStringValue(GroupId);
            }
            if (Optional.IsDefined(RequestMessage))
            {
                writer.WritePropertyName("requestMessage");
                writer.WriteStringValue(RequestMessage);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status");
                writer.WriteStringValue(Status.Value.ToSerialString());
            }
            writer.WriteEndObject();
        }

        internal static SharedPrivateLinkResourceProperties DeserializeSharedPrivateLinkResourceProperties(JsonElement element)
        {
            Optional<WritableSubResource> privateLink = default;
            Optional<string> privateLinkLocation = default;
            Optional<string> groupId = default;
            Optional<string> requestMessage = default;
            Optional<SharedPrivateLinkResourceStatus> status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("privateLink"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    privateLink = JsonSerializer.Deserialize<WritableSubResource>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("privateLinkLocation"))
                {
                    privateLinkLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("groupId"))
                {
                    groupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requestMessage"))
                {
                    requestMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    status = property.Value.GetString().ToSharedPrivateLinkResourceStatus();
                    continue;
                }
            }
            return new SharedPrivateLinkResourceProperties(privateLink, privateLinkLocation.Value, groupId.Value, requestMessage.Value, Optional.ToNullable(status));
        }
    }
}
