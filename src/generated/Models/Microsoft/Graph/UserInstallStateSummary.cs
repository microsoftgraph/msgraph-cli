using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class UserInstallStateSummary : Entity, IParsable {
        /// <summary>The install state of the eBook.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.DeviceInstallState> DeviceStates { get; set; }
        /// <summary>Failed Device Count.</summary>
        public int? FailedDeviceCount { get; set; }
        /// <summary>Installed Device Count.</summary>
        public int? InstalledDeviceCount { get; set; }
        /// <summary>Not installed device count.</summary>
        public int? NotInstalledDeviceCount { get; set; }
        /// <summary>User name.</summary>
        public string UserName { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.UserInstallStateSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserInstallStateSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"deviceStates", (o,n) => { (o as UserInstallStateSummary).DeviceStates = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DeviceInstallState>(ApiSdk.Models.Microsoft.Graph.DeviceInstallState.CreateFromDiscriminatorValue).ToList(); } },
                {"failedDeviceCount", (o,n) => { (o as UserInstallStateSummary).FailedDeviceCount = n.GetIntValue(); } },
                {"installedDeviceCount", (o,n) => { (o as UserInstallStateSummary).InstalledDeviceCount = n.GetIntValue(); } },
                {"notInstalledDeviceCount", (o,n) => { (o as UserInstallStateSummary).NotInstalledDeviceCount = n.GetIntValue(); } },
                {"userName", (o,n) => { (o as UserInstallStateSummary).UserName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DeviceInstallState>("deviceStates", DeviceStates);
            writer.WriteIntValue("failedDeviceCount", FailedDeviceCount);
            writer.WriteIntValue("installedDeviceCount", InstalledDeviceCount);
            writer.WriteIntValue("notInstalledDeviceCount", NotInstalledDeviceCount);
            writer.WriteStringValue("userName", UserName);
        }
    }
}
