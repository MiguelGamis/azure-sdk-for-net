// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Management.Resources.Models
{
    /// <summary> Subscription list operation response. </summary>
    public partial class SubscriptionListResult
    {
        /// <summary> Initializes a new instance of SubscriptionListResult. </summary>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal SubscriptionListResult(string nextLink)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            NextLink = nextLink;
        }

        /// <summary> Initializes a new instance of SubscriptionListResult. </summary>
        /// <param name="value"> An array of subscriptions. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal SubscriptionListResult(IReadOnlyList<Subscription> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> An array of subscriptions. </summary>
        public IReadOnlyList<Subscription> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
