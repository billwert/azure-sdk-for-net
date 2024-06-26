// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.Maps.Search.Models
{
    public partial class MapsDataSource
    {
        internal static MapsDataSource DeserializeMapsDataSource(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            GeometryIdentifier geometry = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("geometry"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    geometry = GeometryIdentifier.DeserializeGeometryIdentifier(property.Value);
                    continue;
                }
            }
            return new MapsDataSource(geometry);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static MapsDataSource FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeMapsDataSource(document.RootElement);
        }
    }
}
