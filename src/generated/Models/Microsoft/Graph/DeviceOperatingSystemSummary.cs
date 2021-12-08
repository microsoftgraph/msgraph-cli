using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class DeviceOperatingSystemSummary : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Number of android device count.</summary>
        public int? AndroidCount { get; set; }
        /// <summary>Number of iOS device count.</summary>
        public int? IosCount { get; set; }
        /// <summary>Number of Mac OS X device count.</summary>
        public int? MacOSCount { get; set; }
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
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"androidCount", (o,n) => { (o as DeviceOperatingSystemSummary).AndroidCount = n.GetIntValue(); } },
                {"iosCount", (o,n) => { (o as DeviceOperatingSystemSummary).IosCount = n.GetIntValue(); } },
                {"macOSCount", (o,n) => { (o as DeviceOperatingSystemSummary).MacOSCount = n.GetIntValue(); } },
                {"unknownCount", (o,n) => { (o as DeviceOperatingSystemSummary).UnknownCount = n.GetIntValue(); } },
                {"windowsCount", (o,n) => { (o as DeviceOperatingSystemSummary).WindowsCount = n.GetIntValue(); } },
                {"windowsMobileCount", (o,n) => { (o as DeviceOperatingSystemSummary).WindowsMobileCount = n.GetIntValue(); } },
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
            writer.WriteIntValue("unknownCount", UnknownCount);
            writer.WriteIntValue("windowsCount", WindowsCount);
            writer.WriteIntValue("windowsMobileCount", WindowsMobileCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
