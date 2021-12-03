using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class WindowsInformationProtectionNetworkLearningSummary : Entity, IParsable {
        /// <summary>Device Count</summary>
        public int? DeviceCount { get; set; }
        /// <summary>Website url</summary>
        public string Url { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"deviceCount", (o,n) => { (o as WindowsInformationProtectionNetworkLearningSummary).DeviceCount = n.GetIntValue(); } },
                {"url", (o,n) => { (o as WindowsInformationProtectionNetworkLearningSummary).Url = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("deviceCount", DeviceCount);
            writer.WriteStringValue("url", Url);
        }
    }
}
