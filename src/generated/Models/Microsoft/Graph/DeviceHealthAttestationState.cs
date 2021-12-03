using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class DeviceHealthAttestationState : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>TWhen an Attestation Identity Key (AIK) is present on a device, it indicates that the device has an endorsement key (EK) certificate.</summary>
        public string AttestationIdentityKey { get; set; }
        /// <summary>On or Off of BitLocker Drive Encryption</summary>
        public string BitLockerStatus { get; set; }
        /// <summary>The security version number of the Boot Application</summary>
        public string BootAppSecurityVersion { get; set; }
        /// <summary>When bootDebugging is enabled, the device is used in development and testing</summary>
        public string BootDebugging { get; set; }
        /// <summary>The security version number of the Boot Application</summary>
        public string BootManagerSecurityVersion { get; set; }
        /// <summary>The version of the Boot Manager</summary>
        public string BootManagerVersion { get; set; }
        /// <summary>The Boot Revision List that was loaded during initial boot on the attested device</summary>
        public string BootRevisionListInfo { get; set; }
        /// <summary>When code integrity is enabled, code execution is restricted to integrity verified code</summary>
        public string CodeIntegrity { get; set; }
        /// <summary>The version of the Boot Manager</summary>
        public string CodeIntegrityCheckVersion { get; set; }
        /// <summary>The Code Integrity policy that is controlling the security of the boot environment</summary>
        public string CodeIntegrityPolicy { get; set; }
        /// <summary>The DHA report version. (Namespace version)</summary>
        public string ContentNamespaceUrl { get; set; }
        /// <summary>The HealthAttestation state schema version</summary>
        public string ContentVersion { get; set; }
        /// <summary>DEP Policy defines a set of hardware and software technologies that perform additional checks on memory</summary>
        public string DataExcutionPolicy { get; set; }
        /// <summary>The DHA report version. (Namespace version)</summary>
        public string DeviceHealthAttestationStatus { get; set; }
        /// <summary>ELAM provides protection for the computers in your network when they start up</summary>
        public string EarlyLaunchAntiMalwareDriverProtection { get; set; }
        /// <summary>This attribute indicates if DHA is supported for the device</summary>
        public string HealthAttestationSupportedStatus { get; set; }
        /// <summary>This attribute appears if DHA-Service detects an integrity issue</summary>
        public string HealthStatusMismatchInfo { get; set; }
        /// <summary>The DateTime when device was evaluated or issued to MDM</summary>
        public DateTimeOffset? IssuedDateTime { get; set; }
        /// <summary>The Timestamp of the last update.</summary>
        public string LastUpdateDateTime { get; set; }
        /// <summary>When operatingSystemKernelDebugging is enabled, the device is used in development and testing</summary>
        public string OperatingSystemKernelDebugging { get; set; }
        /// <summary>The Operating System Revision List that was loaded during initial boot on the attested device</summary>
        public string OperatingSystemRevListInfo { get; set; }
        /// <summary>The measurement that is captured in PCR[0]</summary>
        public string Pcr0 { get; set; }
        /// <summary>Informational attribute that identifies the HASH algorithm that was used by TPM</summary>
        public string PcrHashAlgorithm { get; set; }
        /// <summary>The number of times a PC device has hibernated or resumed</summary>
        public long? ResetCount { get; set; }
        /// <summary>The number of times a PC device has rebooted</summary>
        public long? RestartCount { get; set; }
        /// <summary>Safe mode is a troubleshooting option for Windows that starts your computer in a limited state</summary>
        public string SafeMode { get; set; }
        /// <summary>When Secure Boot is enabled, the core components must have the correct cryptographic signatures</summary>
        public string SecureBoot { get; set; }
        /// <summary>Fingerprint of the Custom Secure Boot Configuration Policy</summary>
        public string SecureBootConfigurationPolicyFingerPrint { get; set; }
        /// <summary>When test signing is allowed, the device does not enforce signature validation during boot</summary>
        public string TestSigning { get; set; }
        /// <summary>The security version number of the Boot Application</summary>
        public string TpmVersion { get; set; }
        /// <summary>VSM is a container that protects high value assets from a compromised kernel</summary>
        public string VirtualSecureMode { get; set; }
        /// <summary>Operating system running with limited services that is used to prepare a computer for Windows</summary>
        public string WindowsPE { get; set; }
        /// <summary>
        /// Instantiates a new deviceHealthAttestationState and sets the default values.
        /// </summary>
        public DeviceHealthAttestationState() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"attestationIdentityKey", (o,n) => { (o as DeviceHealthAttestationState).AttestationIdentityKey = n.GetStringValue(); } },
                {"bitLockerStatus", (o,n) => { (o as DeviceHealthAttestationState).BitLockerStatus = n.GetStringValue(); } },
                {"bootAppSecurityVersion", (o,n) => { (o as DeviceHealthAttestationState).BootAppSecurityVersion = n.GetStringValue(); } },
                {"bootDebugging", (o,n) => { (o as DeviceHealthAttestationState).BootDebugging = n.GetStringValue(); } },
                {"bootManagerSecurityVersion", (o,n) => { (o as DeviceHealthAttestationState).BootManagerSecurityVersion = n.GetStringValue(); } },
                {"bootManagerVersion", (o,n) => { (o as DeviceHealthAttestationState).BootManagerVersion = n.GetStringValue(); } },
                {"bootRevisionListInfo", (o,n) => { (o as DeviceHealthAttestationState).BootRevisionListInfo = n.GetStringValue(); } },
                {"codeIntegrity", (o,n) => { (o as DeviceHealthAttestationState).CodeIntegrity = n.GetStringValue(); } },
                {"codeIntegrityCheckVersion", (o,n) => { (o as DeviceHealthAttestationState).CodeIntegrityCheckVersion = n.GetStringValue(); } },
                {"codeIntegrityPolicy", (o,n) => { (o as DeviceHealthAttestationState).CodeIntegrityPolicy = n.GetStringValue(); } },
                {"contentNamespaceUrl", (o,n) => { (o as DeviceHealthAttestationState).ContentNamespaceUrl = n.GetStringValue(); } },
                {"contentVersion", (o,n) => { (o as DeviceHealthAttestationState).ContentVersion = n.GetStringValue(); } },
                {"dataExcutionPolicy", (o,n) => { (o as DeviceHealthAttestationState).DataExcutionPolicy = n.GetStringValue(); } },
                {"deviceHealthAttestationStatus", (o,n) => { (o as DeviceHealthAttestationState).DeviceHealthAttestationStatus = n.GetStringValue(); } },
                {"earlyLaunchAntiMalwareDriverProtection", (o,n) => { (o as DeviceHealthAttestationState).EarlyLaunchAntiMalwareDriverProtection = n.GetStringValue(); } },
                {"healthAttestationSupportedStatus", (o,n) => { (o as DeviceHealthAttestationState).HealthAttestationSupportedStatus = n.GetStringValue(); } },
                {"healthStatusMismatchInfo", (o,n) => { (o as DeviceHealthAttestationState).HealthStatusMismatchInfo = n.GetStringValue(); } },
                {"issuedDateTime", (o,n) => { (o as DeviceHealthAttestationState).IssuedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastUpdateDateTime", (o,n) => { (o as DeviceHealthAttestationState).LastUpdateDateTime = n.GetStringValue(); } },
                {"operatingSystemKernelDebugging", (o,n) => { (o as DeviceHealthAttestationState).OperatingSystemKernelDebugging = n.GetStringValue(); } },
                {"operatingSystemRevListInfo", (o,n) => { (o as DeviceHealthAttestationState).OperatingSystemRevListInfo = n.GetStringValue(); } },
                {"pcr0", (o,n) => { (o as DeviceHealthAttestationState).Pcr0 = n.GetStringValue(); } },
                {"pcrHashAlgorithm", (o,n) => { (o as DeviceHealthAttestationState).PcrHashAlgorithm = n.GetStringValue(); } },
                {"resetCount", (o,n) => { (o as DeviceHealthAttestationState).ResetCount = n.GetLongValue(); } },
                {"restartCount", (o,n) => { (o as DeviceHealthAttestationState).RestartCount = n.GetLongValue(); } },
                {"safeMode", (o,n) => { (o as DeviceHealthAttestationState).SafeMode = n.GetStringValue(); } },
                {"secureBoot", (o,n) => { (o as DeviceHealthAttestationState).SecureBoot = n.GetStringValue(); } },
                {"secureBootConfigurationPolicyFingerPrint", (o,n) => { (o as DeviceHealthAttestationState).SecureBootConfigurationPolicyFingerPrint = n.GetStringValue(); } },
                {"testSigning", (o,n) => { (o as DeviceHealthAttestationState).TestSigning = n.GetStringValue(); } },
                {"tpmVersion", (o,n) => { (o as DeviceHealthAttestationState).TpmVersion = n.GetStringValue(); } },
                {"virtualSecureMode", (o,n) => { (o as DeviceHealthAttestationState).VirtualSecureMode = n.GetStringValue(); } },
                {"windowsPE", (o,n) => { (o as DeviceHealthAttestationState).WindowsPE = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("attestationIdentityKey", AttestationIdentityKey);
            writer.WriteStringValue("bitLockerStatus", BitLockerStatus);
            writer.WriteStringValue("bootAppSecurityVersion", BootAppSecurityVersion);
            writer.WriteStringValue("bootDebugging", BootDebugging);
            writer.WriteStringValue("bootManagerSecurityVersion", BootManagerSecurityVersion);
            writer.WriteStringValue("bootManagerVersion", BootManagerVersion);
            writer.WriteStringValue("bootRevisionListInfo", BootRevisionListInfo);
            writer.WriteStringValue("codeIntegrity", CodeIntegrity);
            writer.WriteStringValue("codeIntegrityCheckVersion", CodeIntegrityCheckVersion);
            writer.WriteStringValue("codeIntegrityPolicy", CodeIntegrityPolicy);
            writer.WriteStringValue("contentNamespaceUrl", ContentNamespaceUrl);
            writer.WriteStringValue("contentVersion", ContentVersion);
            writer.WriteStringValue("dataExcutionPolicy", DataExcutionPolicy);
            writer.WriteStringValue("deviceHealthAttestationStatus", DeviceHealthAttestationStatus);
            writer.WriteStringValue("earlyLaunchAntiMalwareDriverProtection", EarlyLaunchAntiMalwareDriverProtection);
            writer.WriteStringValue("healthAttestationSupportedStatus", HealthAttestationSupportedStatus);
            writer.WriteStringValue("healthStatusMismatchInfo", HealthStatusMismatchInfo);
            writer.WriteDateTimeOffsetValue("issuedDateTime", IssuedDateTime);
            writer.WriteStringValue("lastUpdateDateTime", LastUpdateDateTime);
            writer.WriteStringValue("operatingSystemKernelDebugging", OperatingSystemKernelDebugging);
            writer.WriteStringValue("operatingSystemRevListInfo", OperatingSystemRevListInfo);
            writer.WriteStringValue("pcr0", Pcr0);
            writer.WriteStringValue("pcrHashAlgorithm", PcrHashAlgorithm);
            writer.WriteLongValue("resetCount", ResetCount);
            writer.WriteLongValue("restartCount", RestartCount);
            writer.WriteStringValue("safeMode", SafeMode);
            writer.WriteStringValue("secureBoot", SecureBoot);
            writer.WriteStringValue("secureBootConfigurationPolicyFingerPrint", SecureBootConfigurationPolicyFingerPrint);
            writer.WriteStringValue("testSigning", TestSigning);
            writer.WriteStringValue("tpmVersion", TpmVersion);
            writer.WriteStringValue("virtualSecureMode", VirtualSecureMode);
            writer.WriteStringValue("windowsPE", WindowsPE);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
