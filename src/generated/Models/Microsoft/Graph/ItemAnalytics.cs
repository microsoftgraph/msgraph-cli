using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ItemAnalytics : Entity, IParsable {
        public ApiSdk.Models.Microsoft.Graph.ItemActivityStat AllTime { get; set; }
        public List<ApiSdk.Models.Microsoft.Graph.ItemActivityStat> ItemActivityStats { get; set; }
        public ApiSdk.Models.Microsoft.Graph.ItemActivityStat LastSevenDays { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.ItemAnalytics CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ItemAnalytics();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"allTime", (o,n) => { (o as ItemAnalytics).AllTime = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ItemActivityStat>(ApiSdk.Models.Microsoft.Graph.ItemActivityStat.CreateFromDiscriminatorValue); } },
                {"itemActivityStats", (o,n) => { (o as ItemAnalytics).ItemActivityStats = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ItemActivityStat>(ApiSdk.Models.Microsoft.Graph.ItemActivityStat.CreateFromDiscriminatorValue).ToList(); } },
                {"lastSevenDays", (o,n) => { (o as ItemAnalytics).LastSevenDays = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ItemActivityStat>(ApiSdk.Models.Microsoft.Graph.ItemActivityStat.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ItemActivityStat>("allTime", AllTime);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ItemActivityStat>("itemActivityStats", ItemActivityStats);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ItemActivityStat>("lastSevenDays", LastSevenDays);
        }
    }
}
