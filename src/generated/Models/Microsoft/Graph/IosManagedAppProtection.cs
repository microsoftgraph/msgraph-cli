using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class IosManagedAppProtection : TargetedManagedAppProtection, IParsable {
        /// <summary>Type of encryption which should be used for data in a managed app. Possible values are: useDeviceSettings, afterDeviceRestart, whenDeviceLockedExceptOpenFiles, whenDeviceLocked.</summary>
        public ManagedAppDataEncryptionType? AppDataEncryptionType { get; set; }
        /// <summary>List of apps to which the policy is deployed.</summary>
        public List<ManagedMobileApp> Apps { get; set; }
        /// <summary>A custom browser protocol to open weblink on iOS.</summary>
        public string CustomBrowserProtocol { get; set; }
        /// <summary>Count of apps to which the current policy is deployed.</summary>
        public int? DeployedAppCount { get; set; }
        /// <summary>Navigation property to deployment summary of the configuration.</summary>
        public ManagedAppPolicyDeploymentSummary DeploymentSummary { get; set; }
        /// <summary>Indicates whether use of the FaceID is allowed in place of a pin if PinRequired is set to True.</summary>
        public bool? FaceIdBlocked { get; set; }
        /// <summary>Versions less than the specified version will block the managed app from accessing company data.</summary>
        public string MinimumRequiredSdkVersion { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"appDataEncryptionType", (o,n) => { (o as IosManagedAppProtection).AppDataEncryptionType = n.GetEnumValue<ManagedAppDataEncryptionType>(); } },
                {"apps", (o,n) => { (o as IosManagedAppProtection).Apps = n.GetCollectionOfObjectValues<ManagedMobileApp>().ToList(); } },
                {"customBrowserProtocol", (o,n) => { (o as IosManagedAppProtection).CustomBrowserProtocol = n.GetStringValue(); } },
                {"deployedAppCount", (o,n) => { (o as IosManagedAppProtection).DeployedAppCount = n.GetIntValue(); } },
                {"deploymentSummary", (o,n) => { (o as IosManagedAppProtection).DeploymentSummary = n.GetObjectValue<ManagedAppPolicyDeploymentSummary>(); } },
                {"faceIdBlocked", (o,n) => { (o as IosManagedAppProtection).FaceIdBlocked = n.GetBoolValue(); } },
                {"minimumRequiredSdkVersion", (o,n) => { (o as IosManagedAppProtection).MinimumRequiredSdkVersion = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<ManagedAppDataEncryptionType>("appDataEncryptionType", AppDataEncryptionType);
            writer.WriteCollectionOfObjectValues<ManagedMobileApp>("apps", Apps);
            writer.WriteStringValue("customBrowserProtocol", CustomBrowserProtocol);
            writer.WriteIntValue("deployedAppCount", DeployedAppCount);
            writer.WriteObjectValue<ManagedAppPolicyDeploymentSummary>("deploymentSummary", DeploymentSummary);
            writer.WriteBoolValue("faceIdBlocked", FaceIdBlocked);
            writer.WriteStringValue("minimumRequiredSdkVersion", MinimumRequiredSdkVersion);
        }
    }
}
