using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ItemAnalytics : Entity, IParsable {
        public ItemActivityStat AllTime { get; set; }
        public List<ItemActivityStat> ItemActivityStats { get; set; }
        public ItemActivityStat LastSevenDays { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ItemAnalytics CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ItemAnalytics();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"allTime", (o,n) => { (o as ItemAnalytics).AllTime = n.GetObjectValue<ItemActivityStat>(ItemActivityStat.CreateFromDiscriminatorValue); } },
                {"itemActivityStats", (o,n) => { (o as ItemAnalytics).ItemActivityStats = n.GetCollectionOfObjectValues<ItemActivityStat>(ItemActivityStat.CreateFromDiscriminatorValue).ToList(); } },
                {"lastSevenDays", (o,n) => { (o as ItemAnalytics).LastSevenDays = n.GetObjectValue<ItemActivityStat>(ItemActivityStat.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ItemActivityStat>("allTime", AllTime);
            writer.WriteCollectionOfObjectValues<ItemActivityStat>("itemActivityStats", ItemActivityStats);
            writer.WriteObjectValue<ItemActivityStat>("lastSevenDays", LastSevenDays);
        }
    }
}
