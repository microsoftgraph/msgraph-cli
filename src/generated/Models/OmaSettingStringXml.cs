using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class OmaSettingStringXml : OmaSetting, IParsable {
        /// <summary>File name associated with the Value property (.xml).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FileName { get; set; }
#nullable restore
#else
        public string FileName { get; set; }
#endif
        /// <summary>Value. (UTF8 encoded byte array)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? Value { get; set; }
#nullable restore
#else
        public byte[] Value { get; set; }
#endif
        /// <summary>
        /// Instantiates a new OmaSettingStringXml and sets the default values.
        /// </summary>
        public OmaSettingStringXml() : base() {
            OdataType = "#microsoft.graph.omaSettingStringXml";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public static new OmaSettingStringXml CreateFromDiscriminatorValue(IParseNode? parseNode) {
#nullable restore
#else
        public static new OmaSettingStringXml CreateFromDiscriminatorValue(IParseNode parseNode) {
#endif
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OmaSettingStringXml();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"fileName", n => { FileName = n.GetStringValue(); } },
                {"value", n => { Value = n.GetByteArrayValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("fileName", FileName);
            writer.WriteByteArrayValue("value", Value);
        }
    }
}
