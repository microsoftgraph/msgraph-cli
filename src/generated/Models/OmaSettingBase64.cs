using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class OmaSettingBase64 : OmaSetting, IParsable {
        /// <summary>File name associated with the Value property (.cer</summary>
        public string FileName { get; set; }
        /// <summary>Value. (Base64 encoded string)</summary>
        public string Value { get; set; }
        /// <summary>
        /// Instantiates a new OmaSettingBase64 and sets the default values.
        /// </summary>
        public OmaSettingBase64() : base() {
            OdataType = "#microsoft.graph.omaSettingBase64";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new OmaSettingBase64 CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OmaSettingBase64();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"fileName", n => { FileName = n.GetStringValue(); } },
                {"value", n => { Value = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("fileName", FileName);
            writer.WriteStringValue("value", Value);
        }
    }
}
