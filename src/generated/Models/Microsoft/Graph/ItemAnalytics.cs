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
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"allTime", (o,n) => { (o as ItemAnalytics).AllTime = n.GetObjectValue<ItemActivityStat>(); } },
                {"itemActivityStats", (o,n) => { (o as ItemAnalytics).ItemActivityStats = n.GetCollectionOfObjectValues<ItemActivityStat>().ToList(); } },
                {"lastSevenDays", (o,n) => { (o as ItemAnalytics).LastSevenDays = n.GetObjectValue<ItemActivityStat>(); } },
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
