using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    /// <summary>The minimum operating system required for a Windows mobile app.</summary>
    public class WindowsMinimumOperatingSystem : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>Windows version 10.0 or later.</summary>
        public bool? V10_0 { get; set; }
        /// <summary>Windows version 8.0 or later.</summary>
        public bool? V8_0 { get; set; }
        /// <summary>Windows version 8.1 or later.</summary>
        public bool? V8_1 { get; set; }
        /// <summary>
        /// Instantiates a new windowsMinimumOperatingSystem and sets the default values.
        /// </summary>
        public WindowsMinimumOperatingSystem() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.windowsMinimumOperatingSystem";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static WindowsMinimumOperatingSystem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsMinimumOperatingSystem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"v10_0", n => { V10_0 = n.GetBoolValue(); } },
                {"v8_0", n => { V8_0 = n.GetBoolValue(); } },
                {"v8_1", n => { V8_1 = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteBoolValue("v10_0", V10_0);
            writer.WriteBoolValue("v8_0", V8_0);
            writer.WriteBoolValue("v8_1", V8_1);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
