using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class WindowsInformationProtectionAppLearningSummary : Entity, IParsable {
        /// <summary>Application Name</summary>
        public string ApplicationName { get; set; }
        /// <summary>Application Type. Possible values are: universal, desktop.</summary>
        public ApiSdk.Models.Microsoft.Graph.ApplicationType? ApplicationType { get; set; }
        /// <summary>Device Count</summary>
        public int? DeviceCount { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsInformationProtectionAppLearningSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsInformationProtectionAppLearningSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"applicationName", (o,n) => { (o as WindowsInformationProtectionAppLearningSummary).ApplicationName = n.GetStringValue(); } },
                {"applicationType", (o,n) => { (o as WindowsInformationProtectionAppLearningSummary).ApplicationType = n.GetEnumValue<ApplicationType>(); } },
                {"deviceCount", (o,n) => { (o as WindowsInformationProtectionAppLearningSummary).DeviceCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("applicationName", ApplicationName);
            writer.WriteEnumValue<ApplicationType>("applicationType", ApplicationType);
            writer.WriteIntValue("deviceCount", DeviceCount);
        }
    }
}
