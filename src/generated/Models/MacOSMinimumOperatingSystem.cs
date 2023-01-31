using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    /// <summary>
    /// The minimum operating system required for a macOS app.
    /// </summary>
    public class MacOSMinimumOperatingSystem : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>When TRUE, indicates OS X 10.10 or later is required to install the app. When FALSE, indicates some other OS version is the minimum OS to install the app. Default value is FALSE.</summary>
        public bool? V10_10 { get; set; }
        /// <summary>When TRUE, indicates OS X 10.11 or later is required to install the app. When FALSE, indicates some other OS version is the minimum OS to install the app. Default value is FALSE.</summary>
        public bool? V10_11 { get; set; }
        /// <summary>When TRUE, indicates macOS 10.12 or later is required to install the app. When FALSE, indicates some other OS version is the minimum OS to install the app. Default value is FALSE.</summary>
        public bool? V10_12 { get; set; }
        /// <summary>When TRUE, indicates macOS 10.13 or later is required to install the app. When FALSE, indicates some other OS version is the minimum OS to install the app. Default value is FALSE.</summary>
        public bool? V10_13 { get; set; }
        /// <summary>When TRUE, indicates macOS 10.14 or later is required to install the app. When FALSE, indicates some other OS version is the minimum OS to install the app. Default value is FALSE.</summary>
        public bool? V10_14 { get; set; }
        /// <summary>When TRUE, indicates macOS 10.15 or later is required to install the app. When FALSE, indicates some other OS version is the minimum OS to install the app. Default value is FALSE.</summary>
        public bool? V10_15 { get; set; }
        /// <summary>When TRUE, indicates Mac OS X 10.7 or later is required to install the app. When FALSE, indicates some other OS version is the minimum OS to install the app. Default value is FALSE.</summary>
        public bool? V10_7 { get; set; }
        /// <summary>When TRUE, indicates OS X 10.8 or later is required to install the app. When FALSE, indicates some other OS version is the minimum OS to install the app. Default value is FALSE.</summary>
        public bool? V10_8 { get; set; }
        /// <summary>When TRUE, indicates OS X 10.9 or later is required to install the app. When FALSE, indicates some other OS version is the minimum OS to install the app. Default value is FALSE.</summary>
        public bool? V10_9 { get; set; }
        /// <summary>When TRUE, indicates macOS 11.0 or later is required to install the app. When FALSE, indicates some other OS version is the minimum OS to install the app. Default value is FALSE.</summary>
        public bool? V11_0 { get; set; }
        /// <summary>When TRUE, indicates macOS 12.0 or later is required to install the app. When FALSE, indicates some other OS version is the minimum OS to install the app. Default value is FALSE.</summary>
        public bool? V12_0 { get; set; }
        /// <summary>When TRUE, indicates macOS 13.0 or later is required to install the app. When FALSE, indicates some other OS version is the minimum OS to install the app. Default value is FALSE.</summary>
        public bool? V13_0 { get; set; }
        /// <summary>
        /// Instantiates a new macOSMinimumOperatingSystem and sets the default values.
        /// </summary>
        public MacOSMinimumOperatingSystem() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public static MacOSMinimumOperatingSystem CreateFromDiscriminatorValue(IParseNode? parseNode) {
#nullable restore
#else
        public static MacOSMinimumOperatingSystem CreateFromDiscriminatorValue(IParseNode parseNode) {
#endif
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MacOSMinimumOperatingSystem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"v10_10", n => { V10_10 = n.GetBoolValue(); } },
                {"v10_11", n => { V10_11 = n.GetBoolValue(); } },
                {"v10_12", n => { V10_12 = n.GetBoolValue(); } },
                {"v10_13", n => { V10_13 = n.GetBoolValue(); } },
                {"v10_14", n => { V10_14 = n.GetBoolValue(); } },
                {"v10_15", n => { V10_15 = n.GetBoolValue(); } },
                {"v10_7", n => { V10_7 = n.GetBoolValue(); } },
                {"v10_8", n => { V10_8 = n.GetBoolValue(); } },
                {"v10_9", n => { V10_9 = n.GetBoolValue(); } },
                {"v11_0", n => { V11_0 = n.GetBoolValue(); } },
                {"v12_0", n => { V12_0 = n.GetBoolValue(); } },
                {"v13_0", n => { V13_0 = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteBoolValue("v10_10", V10_10);
            writer.WriteBoolValue("v10_11", V10_11);
            writer.WriteBoolValue("v10_12", V10_12);
            writer.WriteBoolValue("v10_13", V10_13);
            writer.WriteBoolValue("v10_14", V10_14);
            writer.WriteBoolValue("v10_15", V10_15);
            writer.WriteBoolValue("v10_7", V10_7);
            writer.WriteBoolValue("v10_8", V10_8);
            writer.WriteBoolValue("v10_9", V10_9);
            writer.WriteBoolValue("v11_0", V11_0);
            writer.WriteBoolValue("v12_0", V12_0);
            writer.WriteBoolValue("v13_0", V13_0);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
