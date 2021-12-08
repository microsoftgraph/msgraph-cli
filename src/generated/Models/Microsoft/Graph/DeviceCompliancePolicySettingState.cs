using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class DeviceCompliancePolicySettingState : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Current value of setting on device</summary>
        public string CurrentValue { get; set; }
        /// <summary>Error code for the setting</summary>
        public long? ErrorCode { get; set; }
        /// <summary>Error description</summary>
        public string ErrorDescription { get; set; }
        /// <summary>Name of setting instance that is being reported.</summary>
        public string InstanceDisplayName { get; set; }
        /// <summary>The setting that is being reported</summary>
        public string Setting { get; set; }
        /// <summary>Localized/user friendly setting name that is being reported</summary>
        public string SettingName { get; set; }
        /// <summary>Contributing policies</summary>
        public List<SettingSource> Sources { get; set; }
        /// <summary>The compliance state of the setting. Possible values are: unknown, notApplicable, compliant, remediated, nonCompliant, error, conflict, notAssigned.</summary>
        public ComplianceStatus? State { get; set; }
        /// <summary>UserEmail</summary>
        public string UserEmail { get; set; }
        /// <summary>UserId</summary>
        public string UserId { get; set; }
        /// <summary>UserName</summary>
        public string UserName { get; set; }
        /// <summary>UserPrincipalName.</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>
        /// Instantiates a new deviceCompliancePolicySettingState and sets the default values.
        /// </summary>
        public DeviceCompliancePolicySettingState() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"currentValue", (o,n) => { (o as DeviceCompliancePolicySettingState).CurrentValue = n.GetStringValue(); } },
                {"errorCode", (o,n) => { (o as DeviceCompliancePolicySettingState).ErrorCode = n.GetLongValue(); } },
                {"errorDescription", (o,n) => { (o as DeviceCompliancePolicySettingState).ErrorDescription = n.GetStringValue(); } },
                {"instanceDisplayName", (o,n) => { (o as DeviceCompliancePolicySettingState).InstanceDisplayName = n.GetStringValue(); } },
                {"setting", (o,n) => { (o as DeviceCompliancePolicySettingState).Setting = n.GetStringValue(); } },
                {"settingName", (o,n) => { (o as DeviceCompliancePolicySettingState).SettingName = n.GetStringValue(); } },
                {"sources", (o,n) => { (o as DeviceCompliancePolicySettingState).Sources = n.GetCollectionOfObjectValues<SettingSource>().ToList(); } },
                {"state", (o,n) => { (o as DeviceCompliancePolicySettingState).State = n.GetEnumValue<ComplianceStatus>(); } },
                {"userEmail", (o,n) => { (o as DeviceCompliancePolicySettingState).UserEmail = n.GetStringValue(); } },
                {"userId", (o,n) => { (o as DeviceCompliancePolicySettingState).UserId = n.GetStringValue(); } },
                {"userName", (o,n) => { (o as DeviceCompliancePolicySettingState).UserName = n.GetStringValue(); } },
                {"userPrincipalName", (o,n) => { (o as DeviceCompliancePolicySettingState).UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("currentValue", CurrentValue);
            writer.WriteLongValue("errorCode", ErrorCode);
            writer.WriteStringValue("errorDescription", ErrorDescription);
            writer.WriteStringValue("instanceDisplayName", InstanceDisplayName);
            writer.WriteStringValue("setting", Setting);
            writer.WriteStringValue("settingName", SettingName);
            writer.WriteCollectionOfObjectValues<SettingSource>("sources", Sources);
            writer.WriteEnumValue<ComplianceStatus>("state", State);
            writer.WriteStringValue("userEmail", UserEmail);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("userName", UserName);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
