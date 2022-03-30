using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class OfficeGraphInsights : Entity, IParsable {
        /// <summary>Calculated relationship identifying documents shared with or by the user. This includes URLs, file attachments, and reference attachments to OneDrive for Business and SharePoint files found in Outlook messages and meetings. This also includes URLs and reference attachments to Teams conversations. Ordered by recency of share.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.SharedInsight> Shared { get; set; }
        /// <summary>Calculated relationship identifying documents trending around a user. Trending documents are calculated based on activity of the user's closest network of people and include files stored in OneDrive for Business and SharePoint. Trending insights help the user to discover potentially useful content that the user has access to, but has never viewed before.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.Trending> Trending { get; set; }
        /// <summary>Calculated relationship identifying the latest documents viewed or modified by a user, including OneDrive for Business and SharePoint documents, ranked by recency of use.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.UsedInsight> Used { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.OfficeGraphInsights CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OfficeGraphInsights();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"shared", (o,n) => { (o as OfficeGraphInsights).Shared = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.SharedInsight>(ApiSdk.Models.Microsoft.Graph.SharedInsight.CreateFromDiscriminatorValue).ToList(); } },
                {"trending", (o,n) => { (o as OfficeGraphInsights).Trending = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Trending>(ApiSdk.Models.Microsoft.Graph.Trending.CreateFromDiscriminatorValue).ToList(); } },
                {"used", (o,n) => { (o as OfficeGraphInsights).Used = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.UsedInsight>(ApiSdk.Models.Microsoft.Graph.UsedInsight.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.SharedInsight>("shared", Shared);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Trending>("trending", Trending);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.UsedInsight>("used", Used);
        }
    }
}
