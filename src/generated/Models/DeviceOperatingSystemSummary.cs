using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    /// <summary>Device operating system summary.</summary>
    public class DeviceOperatingSystemSummary : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Number of android device count.</summary>
        public int? AndroidCount { get; set; }
        /// <summary>Number of iOS device count.</summary>
        public int? IosCount { get; set; }
        /// <summary>Number of Mac OS X device count.</summary>
        public int? MacOSCount { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>Number of unknown device count.</summary>
        public int? UnknownCount { get; set; }
        /// <summary>Number of Windows device count.</summary>
        public int? WindowsCount { get; set; }
        /// <summary>Number of Windows mobile device count.</summary>
        public int? WindowsMobileCount { get; set; }
        /// <summary>
        /// Instantiates a new deviceOperatingSystemSummary and sets the default values.
        /// </summary>
        public DeviceOperatingSystemSummary() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.deviceOperatingSystemSummary";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeviceOperatingSystemSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceOperatingSystemSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"androidCount", n => { AndroidCount = n.GetIntValue(); } },
                {"iosCount", n => { IosCount = n.GetIntValue(); } },
                {"macOSCount", n => { MacOSCount = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"unknownCount", n => { UnknownCount = n.GetIntValue(); } },
                {"windowsCount", n => { WindowsCount = n.GetIntValue(); } },
                {"windowsMobileCount", n => { WindowsMobileCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("androidCount", AndroidCount);
            writer.WriteIntValue("iosCount", IosCount);
            writer.WriteIntValue("macOSCount", MacOSCount);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("unknownCount", UnknownCount);
            writer.WriteIntValue("windowsCount", WindowsCount);
            writer.WriteIntValue("windowsMobileCount", WindowsMobileCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
