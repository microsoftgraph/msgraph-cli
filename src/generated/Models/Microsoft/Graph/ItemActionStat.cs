using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ItemActionStat : IParsable {
        /// <summary>The number of times the action took place. Read-only.</summary>
        public int? ActionCount { get; set; }
        /// <summary>The number of distinct actors that performed the action. Read-only.</summary>
        public int? ActorCount { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>
        /// Instantiates a new itemActionStat and sets the default values.
        /// </summary>
        public ItemActionStat() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"actionCount", (o,n) => { (o as ItemActionStat).ActionCount = n.GetIntValue(); } },
                {"actorCount", (o,n) => { (o as ItemActionStat).ActorCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("actionCount", ActionCount);
            writer.WriteIntValue("actorCount", ActorCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
