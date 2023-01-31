using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    /// <summary>
    /// Device Compilance Policy and Configuration for a Setting State summary
    /// </summary>
    public class SettingStateDeviceSummary : Entity, IParsable {
        /// <summary>Device Compliant count for the setting</summary>
        public int? CompliantDeviceCount { get; set; }
        /// <summary>Device conflict error count for the setting</summary>
        public int? ConflictDeviceCount { get; set; }
        /// <summary>Device error count for the setting</summary>
        public int? ErrorDeviceCount { get; set; }
        /// <summary>Name of the InstancePath for the setting</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InstancePath { get; set; }
#nullable restore
#else
        public string InstancePath { get; set; }
#endif
        /// <summary>Device NonCompliant count for the setting</summary>
        public int? NonCompliantDeviceCount { get; set; }
        /// <summary>Device Not Applicable count for the setting</summary>
        public int? NotApplicableDeviceCount { get; set; }
        /// <summary>Device Compliant count for the setting</summary>
        public int? RemediatedDeviceCount { get; set; }
        /// <summary>Name of the setting</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SettingName { get; set; }
#nullable restore
#else
        public string SettingName { get; set; }
#endif
        /// <summary>Device Unkown count for the setting</summary>
        public int? UnknownDeviceCount { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public static new SettingStateDeviceSummary CreateFromDiscriminatorValue(IParseNode? parseNode) {
#nullable restore
#else
        public static new SettingStateDeviceSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
#endif
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SettingStateDeviceSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"compliantDeviceCount", n => { CompliantDeviceCount = n.GetIntValue(); } },
                {"conflictDeviceCount", n => { ConflictDeviceCount = n.GetIntValue(); } },
                {"errorDeviceCount", n => { ErrorDeviceCount = n.GetIntValue(); } },
                {"instancePath", n => { InstancePath = n.GetStringValue(); } },
                {"nonCompliantDeviceCount", n => { NonCompliantDeviceCount = n.GetIntValue(); } },
                {"notApplicableDeviceCount", n => { NotApplicableDeviceCount = n.GetIntValue(); } },
                {"remediatedDeviceCount", n => { RemediatedDeviceCount = n.GetIntValue(); } },
                {"settingName", n => { SettingName = n.GetStringValue(); } },
                {"unknownDeviceCount", n => { UnknownDeviceCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("compliantDeviceCount", CompliantDeviceCount);
            writer.WriteIntValue("conflictDeviceCount", ConflictDeviceCount);
            writer.WriteIntValue("errorDeviceCount", ErrorDeviceCount);
            writer.WriteStringValue("instancePath", InstancePath);
            writer.WriteIntValue("nonCompliantDeviceCount", NonCompliantDeviceCount);
            writer.WriteIntValue("notApplicableDeviceCount", NotApplicableDeviceCount);
            writer.WriteIntValue("remediatedDeviceCount", RemediatedDeviceCount);
            writer.WriteStringValue("settingName", SettingName);
            writer.WriteIntValue("unknownDeviceCount", UnknownDeviceCount);
        }
    }
}
