// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class VpnProfileResponse
    {
        internal static VpnProfileResponse DeserializeVpnProfileResponse(JsonElement element)
        {
            Optional<Uri> profileUrl = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("profileUrl"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        profileUrl = null;
                        continue;
                    }
                    profileUrl = new Uri(property.Value.GetString());
                    continue;
                }
            }
            return new VpnProfileResponse(profileUrl.Value);
        }
    }
}
