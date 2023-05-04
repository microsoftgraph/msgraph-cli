using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    /// <summary>
    /// Contains properties for the minimum operating system required for an Android mobile app.
    /// </summary>
    public class AndroidMinimumOperatingSystem : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>When TRUE, only Version 10.0 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.</summary>
        public bool? V10_0 { get; set; }
        /// <summary>When TRUE, only Version 11.0 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.</summary>
        public bool? V11_0 { get; set; }
        /// <summary>When TRUE, only Version 4.0 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.</summary>
        public bool? V4_0 { get; set; }
        /// <summary>When TRUE, only Version 4.0.3 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.</summary>
        public bool? V4_0_3 { get; set; }
        /// <summary>When TRUE, only Version 4.1 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.</summary>
        public bool? V4_1 { get; set; }
        /// <summary>When TRUE, only Version 4.2 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.</summary>
        public bool? V4_2 { get; set; }
        /// <summary>When TRUE, only Version 4.3 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.</summary>
        public bool? V4_3 { get; set; }
        /// <summary>When TRUE, only Version 4.4 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.</summary>
        public bool? V4_4 { get; set; }
        /// <summary>When TRUE, only Version 5.0 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.</summary>
        public bool? V5_0 { get; set; }
        /// <summary>When TRUE, only Version 5.1 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.</summary>
        public bool? V5_1 { get; set; }
        /// <summary>When TRUE, only Version 6.0 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.</summary>
        public bool? V6_0 { get; set; }
        /// <summary>When TRUE, only Version 7.0 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.</summary>
        public bool? V7_0 { get; set; }
        /// <summary>When TRUE, only Version 7.1 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.</summary>
        public bool? V7_1 { get; set; }
        /// <summary>When TRUE, only Version 8.0 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.</summary>
        public bool? V8_0 { get; set; }
        /// <summary>When TRUE, only Version 8.1 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.</summary>
        public bool? V8_1 { get; set; }
        /// <summary>When TRUE, only Version 9.0 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.</summary>
        public bool? V9_0 { get; set; }
        /// <summary>
        /// Instantiates a new androidMinimumOperatingSystem and sets the default values.
        /// </summary>
        public AndroidMinimumOperatingSystem() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AndroidMinimumOperatingSystem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidMinimumOperatingSystem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"v10_0", n => { V10_0 = n.GetBoolValue(); } },
                {"v11_0", n => { V11_0 = n.GetBoolValue(); } },
                {"v4_0", n => { V4_0 = n.GetBoolValue(); } },
                {"v4_0_3", n => { V4_0_3 = n.GetBoolValue(); } },
                {"v4_1", n => { V4_1 = n.GetBoolValue(); } },
                {"v4_2", n => { V4_2 = n.GetBoolValue(); } },
                {"v4_3", n => { V4_3 = n.GetBoolValue(); } },
                {"v4_4", n => { V4_4 = n.GetBoolValue(); } },
                {"v5_0", n => { V5_0 = n.GetBoolValue(); } },
                {"v5_1", n => { V5_1 = n.GetBoolValue(); } },
                {"v6_0", n => { V6_0 = n.GetBoolValue(); } },
                {"v7_0", n => { V7_0 = n.GetBoolValue(); } },
                {"v7_1", n => { V7_1 = n.GetBoolValue(); } },
                {"v8_0", n => { V8_0 = n.GetBoolValue(); } },
                {"v8_1", n => { V8_1 = n.GetBoolValue(); } },
                {"v9_0", n => { V9_0 = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteBoolValue("v10_0", V10_0);
            writer.WriteBoolValue("v11_0", V11_0);
            writer.WriteBoolValue("v4_0", V4_0);
            writer.WriteBoolValue("v4_0_3", V4_0_3);
            writer.WriteBoolValue("v4_1", V4_1);
            writer.WriteBoolValue("v4_2", V4_2);
            writer.WriteBoolValue("v4_3", V4_3);
            writer.WriteBoolValue("v4_4", V4_4);
            writer.WriteBoolValue("v5_0", V5_0);
            writer.WriteBoolValue("v5_1", V5_1);
            writer.WriteBoolValue("v6_0", V6_0);
            writer.WriteBoolValue("v7_0", V7_0);
            writer.WriteBoolValue("v7_1", V7_1);
            writer.WriteBoolValue("v8_0", V8_0);
            writer.WriteBoolValue("v8_1", V8_1);
            writer.WriteBoolValue("v9_0", V9_0);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
