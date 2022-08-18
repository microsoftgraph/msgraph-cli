using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class MacOSCustomConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Payload. (UTF8 encoded byte array)</summary>
        public byte[] Payload { get; set; }
        /// <summary>Payload file name (.mobileconfig</summary>
        public string PayloadFileName { get; set; }
        /// <summary>Name that is displayed to the user.</summary>
        public string PayloadName { get; set; }
        /// <summary>
        /// Instantiates a new MacOSCustomConfiguration and sets the default values.
        /// </summary>
        public MacOSCustomConfiguration() : base() {
            OdataType = "#microsoft.graph.macOSCustomConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MacOSCustomConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MacOSCustomConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"payload", n => { Payload = n.GetByteArrayValue(); } },
                {"payloadFileName", n => { PayloadFileName = n.GetStringValue(); } },
                {"payloadName", n => { PayloadName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteByteArrayValue("payload", Payload);
            writer.WriteStringValue("payloadFileName", PayloadFileName);
            writer.WriteStringValue("payloadName", PayloadName);
        }
    }
}
