using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    /// <summary>Contains properties of the minimum operating system required for an iOS mobile app.</summary>
    public class IosMinimumOperatingSystem : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Version 10.0 or later.</summary>
        public bool? V10_0 { get; set; }
        /// <summary>Version 11.0 or later.</summary>
        public bool? V11_0 { get; set; }
        /// <summary>Version 12.0 or later.</summary>
        public bool? V12_0 { get; set; }
        /// <summary>Version 13.0 or later.</summary>
        public bool? V13_0 { get; set; }
        /// <summary>Version 14.0 or later.</summary>
        public bool? V14_0 { get; set; }
        /// <summary>Version 8.0 or later.</summary>
        public bool? V8_0 { get; set; }
        /// <summary>Version 9.0 or later.</summary>
        public bool? V9_0 { get; set; }
        /// <summary>
        /// Instantiates a new iosMinimumOperatingSystem and sets the default values.
        /// </summary>
        public IosMinimumOperatingSystem() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static IosMinimumOperatingSystem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IosMinimumOperatingSystem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"v10_0", n => { V10_0 = n.GetBoolValue(); } },
                {"v11_0", n => { V11_0 = n.GetBoolValue(); } },
                {"v12_0", n => { V12_0 = n.GetBoolValue(); } },
                {"v13_0", n => { V13_0 = n.GetBoolValue(); } },
                {"v14_0", n => { V14_0 = n.GetBoolValue(); } },
                {"v8_0", n => { V8_0 = n.GetBoolValue(); } },
                {"v9_0", n => { V9_0 = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("v10_0", V10_0);
            writer.WriteBoolValue("v11_0", V11_0);
            writer.WriteBoolValue("v12_0", V12_0);
            writer.WriteBoolValue("v13_0", V13_0);
            writer.WriteBoolValue("v14_0", V14_0);
            writer.WriteBoolValue("v8_0", V8_0);
            writer.WriteBoolValue("v9_0", V9_0);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
