using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class EBookInstallSummary : Entity, IParsable {
        /// <summary>Number of Devices that have failed to install this book.</summary>
        public int? FailedDeviceCount { get; set; }
        /// <summary>Number of Users that have 1 or more device that failed to install this book.</summary>
        public int? FailedUserCount { get; set; }
        /// <summary>Number of Devices that have successfully installed this book.</summary>
        public int? InstalledDeviceCount { get; set; }
        /// <summary>Number of Users whose devices have all succeeded to install this book.</summary>
        public int? InstalledUserCount { get; set; }
        /// <summary>Number of Devices that does not have this book installed.</summary>
        public int? NotInstalledDeviceCount { get; set; }
        /// <summary>Number of Users that did not install this book.</summary>
        public int? NotInstalledUserCount { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"failedDeviceCount", (o,n) => { (o as EBookInstallSummary).FailedDeviceCount = n.GetIntValue(); } },
                {"failedUserCount", (o,n) => { (o as EBookInstallSummary).FailedUserCount = n.GetIntValue(); } },
                {"installedDeviceCount", (o,n) => { (o as EBookInstallSummary).InstalledDeviceCount = n.GetIntValue(); } },
                {"installedUserCount", (o,n) => { (o as EBookInstallSummary).InstalledUserCount = n.GetIntValue(); } },
                {"notInstalledDeviceCount", (o,n) => { (o as EBookInstallSummary).NotInstalledDeviceCount = n.GetIntValue(); } },
                {"notInstalledUserCount", (o,n) => { (o as EBookInstallSummary).NotInstalledUserCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("failedDeviceCount", FailedDeviceCount);
            writer.WriteIntValue("failedUserCount", FailedUserCount);
            writer.WriteIntValue("installedDeviceCount", InstalledDeviceCount);
            writer.WriteIntValue("installedUserCount", InstalledUserCount);
            writer.WriteIntValue("notInstalledDeviceCount", NotInstalledDeviceCount);
            writer.WriteIntValue("notInstalledUserCount", NotInstalledUserCount);
        }
    }
}
