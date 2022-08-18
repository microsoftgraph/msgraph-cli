using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class IPv4Range : IpRange, IParsable {
        /// <summary>Lower address.</summary>
        public string LowerAddress { get; set; }
        /// <summary>Upper address.</summary>
        public string UpperAddress { get; set; }
        /// <summary>
        /// Instantiates a new IPv4Range and sets the default values.
        /// </summary>
        public IPv4Range() : base() {
            OdataType = "#microsoft.graph.iPv4Range";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new IPv4Range CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IPv4Range();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"lowerAddress", n => { LowerAddress = n.GetStringValue(); } },
                {"upperAddress", n => { UpperAddress = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("lowerAddress", LowerAddress);
            writer.WriteStringValue("upperAddress", UpperAddress);
        }
    }
}
