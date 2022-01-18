using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class AndroidManagedAppProtection : TargetedManagedAppProtection, IParsable {
        /// <summary>List of apps to which the policy is deployed.</summary>
        public List<ManagedMobileApp> Apps { get; set; }
        /// <summary>Friendly name of the preferred custom browser to open weblink on Android.</summary>
        public string CustomBrowserDisplayName { get; set; }
        /// <summary>Unique identifier of a custom browser to open weblink on Android.</summary>
        public string CustomBrowserPackageId { get; set; }
        /// <summary>Count of apps to which the current policy is deployed.</summary>
        public int? DeployedAppCount { get; set; }
        /// <summary>Navigation property to deployment summary of the configuration.</summary>
        public ManagedAppPolicyDeploymentSummary DeploymentSummary { get; set; }
        /// <summary>When this setting is enabled, app level encryption is disabled if device level encryption is enabled</summary>
        public bool? DisableAppEncryptionIfDeviceEncryptionIsEnabled { get; set; }
        /// <summary>Indicates whether application data for managed apps should be encrypted</summary>
        public bool? EncryptAppData { get; set; }
        /// <summary>Define the oldest required Android security patch level a user can have to gain secure access to the app.</summary>
        public string MinimumRequiredPatchVersion { get; set; }
        /// <summary>Define the oldest recommended Android security patch level a user can have for secure access to the app.</summary>
        public string MinimumWarningPatchVersion { get; set; }
        /// <summary>Indicates whether a managed user can take screen captures of managed apps</summary>
        public bool? ScreenCaptureBlocked { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"apps", (o,n) => { (o as AndroidManagedAppProtection).Apps = n.GetCollectionOfObjectValues<ManagedMobileApp>().ToList(); } },
                {"customBrowserDisplayName", (o,n) => { (o as AndroidManagedAppProtection).CustomBrowserDisplayName = n.GetStringValue(); } },
                {"customBrowserPackageId", (o,n) => { (o as AndroidManagedAppProtection).CustomBrowserPackageId = n.GetStringValue(); } },
                {"deployedAppCount", (o,n) => { (o as AndroidManagedAppProtection).DeployedAppCount = n.GetIntValue(); } },
                {"deploymentSummary", (o,n) => { (o as AndroidManagedAppProtection).DeploymentSummary = n.GetObjectValue<ManagedAppPolicyDeploymentSummary>(); } },
                {"disableAppEncryptionIfDeviceEncryptionIsEnabled", (o,n) => { (o as AndroidManagedAppProtection).DisableAppEncryptionIfDeviceEncryptionIsEnabled = n.GetBoolValue(); } },
                {"encryptAppData", (o,n) => { (o as AndroidManagedAppProtection).EncryptAppData = n.GetBoolValue(); } },
                {"minimumRequiredPatchVersion", (o,n) => { (o as AndroidManagedAppProtection).MinimumRequiredPatchVersion = n.GetStringValue(); } },
                {"minimumWarningPatchVersion", (o,n) => { (o as AndroidManagedAppProtection).MinimumWarningPatchVersion = n.GetStringValue(); } },
                {"screenCaptureBlocked", (o,n) => { (o as AndroidManagedAppProtection).ScreenCaptureBlocked = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ManagedMobileApp>("apps", Apps);
            writer.WriteStringValue("customBrowserDisplayName", CustomBrowserDisplayName);
            writer.WriteStringValue("customBrowserPackageId", CustomBrowserPackageId);
            writer.WriteIntValue("deployedAppCount", DeployedAppCount);
            writer.WriteObjectValue<ManagedAppPolicyDeploymentSummary>("deploymentSummary", DeploymentSummary);
            writer.WriteBoolValue("disableAppEncryptionIfDeviceEncryptionIsEnabled", DisableAppEncryptionIfDeviceEncryptionIsEnabled);
            writer.WriteBoolValue("encryptAppData", EncryptAppData);
            writer.WriteStringValue("minimumRequiredPatchVersion", MinimumRequiredPatchVersion);
            writer.WriteStringValue("minimumWarningPatchVersion", MinimumWarningPatchVersion);
            writer.WriteBoolValue("screenCaptureBlocked", ScreenCaptureBlocked);
        }
    }
}
