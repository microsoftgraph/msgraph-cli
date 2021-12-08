using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class DeviceInstallState : Entity, IParsable {
        /// <summary>Device Id.</summary>
        public string DeviceId { get; set; }
        /// <summary>Device name.</summary>
        public string DeviceName { get; set; }
        /// <summary>The error code for install failures.</summary>
        public string ErrorCode { get; set; }
        /// <summary>The install state of the eBook. Possible values are: notApplicable, installed, failed, notInstalled, uninstallFailed, unknown.</summary>
        public InstallState? InstallState { get; set; }
        /// <summary>Last sync date and time.</summary>
        public DateTimeOffset? LastSyncDateTime { get; set; }
        /// <summary>OS Description.</summary>
        public string OsDescription { get; set; }
        /// <summary>OS Version.</summary>
        public string OsVersion { get; set; }
        /// <summary>Device User Name.</summary>
        public string UserName { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"deviceId", (o,n) => { (o as DeviceInstallState).DeviceId = n.GetStringValue(); } },
                {"deviceName", (o,n) => { (o as DeviceInstallState).DeviceName = n.GetStringValue(); } },
                {"errorCode", (o,n) => { (o as DeviceInstallState).ErrorCode = n.GetStringValue(); } },
                {"installState", (o,n) => { (o as DeviceInstallState).InstallState = n.GetEnumValue<InstallState>(); } },
                {"lastSyncDateTime", (o,n) => { (o as DeviceInstallState).LastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"osDescription", (o,n) => { (o as DeviceInstallState).OsDescription = n.GetStringValue(); } },
                {"osVersion", (o,n) => { (o as DeviceInstallState).OsVersion = n.GetStringValue(); } },
                {"userName", (o,n) => { (o as DeviceInstallState).UserName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteStringValue("errorCode", ErrorCode);
            writer.WriteEnumValue<InstallState>("installState", InstallState);
            writer.WriteDateTimeOffsetValue("lastSyncDateTime", LastSyncDateTime);
            writer.WriteStringValue("osDescription", OsDescription);
            writer.WriteStringValue("osVersion", OsVersion);
            writer.WriteStringValue("userName", UserName);
        }
    }
}
