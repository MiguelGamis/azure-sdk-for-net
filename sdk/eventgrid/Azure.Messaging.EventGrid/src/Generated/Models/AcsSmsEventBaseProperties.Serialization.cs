// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class AcsSmsEventBaseProperties
    {
        internal static AcsSmsEventBaseProperties DeserializeAcsSmsEventBaseProperties(JsonElement element)
        {
            Optional<string> messageId = default;
            Optional<string> @from = default;
            Optional<string> to = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("messageId"))
                {
                    messageId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("from"))
                {
                    @from = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("to"))
                {
                    to = property.Value.GetString();
                    continue;
                }
            }
            return new AcsSmsEventBaseProperties(messageId.Value, @from.Value, to.Value);
        }
    }
}
