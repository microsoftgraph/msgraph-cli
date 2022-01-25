using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class OfficeGraphInsights : Entity, IParsable {
        /// <summary>Access this property from the derived type itemInsights.</summary>
        public List<SharedInsight> Shared { get; set; }
        /// <summary>Access this property from the derived type itemInsights.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.Trending> Trending { get; set; }
        /// <summary>Access this property from the derived type itemInsights.</summary>
        public List<UsedInsight> Used { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"shared", (o,n) => { (o as OfficeGraphInsights).Shared = n.GetCollectionOfObjectValues<SharedInsight>().ToList(); } },
                {"trending", (o,n) => { (o as OfficeGraphInsights).Trending = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Trending>().ToList(); } },
                {"used", (o,n) => { (o as OfficeGraphInsights).Used = n.GetCollectionOfObjectValues<UsedInsight>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<SharedInsight>("shared", Shared);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Trending>("trending", Trending);
            writer.WriteCollectionOfObjectValues<UsedInsight>("used", Used);
        }
    }
}
