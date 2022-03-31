using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ManagedDeviceOverview : Entity, IParsable {
        /// <summary>Distribution of Exchange Access State in Intune</summary>
        public ApiSdk.Models.Microsoft.Graph.DeviceExchangeAccessStateSummary DeviceExchangeAccessStateSummary { get; set; }
        /// <summary>Device operating system summary.</summary>
        public ApiSdk.Models.Microsoft.Graph.DeviceOperatingSystemSummary DeviceOperatingSystemSummary { get; set; }
        /// <summary>The number of devices enrolled in both MDM and EAS</summary>
        public int? DualEnrolledDeviceCount { get; set; }
        /// <summary>Total enrolled device count. Does not include PC devices managed via Intune PC Agent</summary>
        public int? EnrolledDeviceCount { get; set; }
        /// <summary>The number of devices enrolled in MDM</summary>
        public int? MdmEnrolledCount { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.ManagedDeviceOverview CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagedDeviceOverview();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"deviceExchangeAccessStateSummary", (o,n) => { (o as ManagedDeviceOverview).DeviceExchangeAccessStateSummary = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.DeviceExchangeAccessStateSummary>(ApiSdk.Models.Microsoft.Graph.DeviceExchangeAccessStateSummary.CreateFromDiscriminatorValue); } },
                {"deviceOperatingSystemSummary", (o,n) => { (o as ManagedDeviceOverview).DeviceOperatingSystemSummary = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.DeviceOperatingSystemSummary>(ApiSdk.Models.Microsoft.Graph.DeviceOperatingSystemSummary.CreateFromDiscriminatorValue); } },
                {"dualEnrolledDeviceCount", (o,n) => { (o as ManagedDeviceOverview).DualEnrolledDeviceCount = n.GetIntValue(); } },
                {"enrolledDeviceCount", (o,n) => { (o as ManagedDeviceOverview).EnrolledDeviceCount = n.GetIntValue(); } },
                {"mdmEnrolledCount", (o,n) => { (o as ManagedDeviceOverview).MdmEnrolledCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.DeviceExchangeAccessStateSummary>("deviceExchangeAccessStateSummary", DeviceExchangeAccessStateSummary);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.DeviceOperatingSystemSummary>("deviceOperatingSystemSummary", DeviceOperatingSystemSummary);
            writer.WriteIntValue("dualEnrolledDeviceCount", DualEnrolledDeviceCount);
            writer.WriteIntValue("enrolledDeviceCount", EnrolledDeviceCount);
            writer.WriteIntValue("mdmEnrolledCount", MdmEnrolledCount);
        }
    }
}
