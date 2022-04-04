// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> The billing tier of this particular SKU. </summary>
    public readonly partial struct EventHubsSkuTier : IEquatable<EventHubsSkuTier>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EventHubsSkuTier"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EventHubsSkuTier(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BasicValue = "Basic";
        private const string StandardValue = "Standard";
        private const string PremiumValue = "Premium";

        /// <summary> Basic. </summary>
        public static EventHubsSkuTier Basic { get; } = new EventHubsSkuTier(BasicValue);
        /// <summary> Standard. </summary>
        public static EventHubsSkuTier Standard { get; } = new EventHubsSkuTier(StandardValue);
        /// <summary> Premium. </summary>
        public static EventHubsSkuTier Premium { get; } = new EventHubsSkuTier(PremiumValue);
        /// <summary> Determines if two <see cref="EventHubsSkuTier"/> values are the same. </summary>
        public static bool operator ==(EventHubsSkuTier left, EventHubsSkuTier right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EventHubsSkuTier"/> values are not the same. </summary>
        public static bool operator !=(EventHubsSkuTier left, EventHubsSkuTier right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EventHubsSkuTier"/>. </summary>
        public static implicit operator EventHubsSkuTier(string value) => new EventHubsSkuTier(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EventHubsSkuTier other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EventHubsSkuTier other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
