// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> The read behavior for the operation. Default is Query. </summary>
    public readonly partial struct SalesforceSourceReadBehavior : IEquatable<SalesforceSourceReadBehavior>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SalesforceSourceReadBehavior"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SalesforceSourceReadBehavior(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string QueryValue = "Query";
        private const string QueryAllValue = "QueryAll";

        /// <summary> Query. </summary>
        public static SalesforceSourceReadBehavior Query { get; } = new SalesforceSourceReadBehavior(QueryValue);
        /// <summary> QueryAll. </summary>
        public static SalesforceSourceReadBehavior QueryAll { get; } = new SalesforceSourceReadBehavior(QueryAllValue);
        /// <summary> Determines if two <see cref="SalesforceSourceReadBehavior"/> values are the same. </summary>
        public static bool operator ==(SalesforceSourceReadBehavior left, SalesforceSourceReadBehavior right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SalesforceSourceReadBehavior"/> values are not the same. </summary>
        public static bool operator !=(SalesforceSourceReadBehavior left, SalesforceSourceReadBehavior right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SalesforceSourceReadBehavior"/>. </summary>
        public static implicit operator SalesforceSourceReadBehavior(string value) => new SalesforceSourceReadBehavior(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SalesforceSourceReadBehavior other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SalesforceSourceReadBehavior other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
