using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class WindowsProtectionState : Entity, IParsable {
        /// <summary>Current anti malware version</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AntiMalwareVersion { get; set; }
#nullable restore
#else
        public string AntiMalwareVersion { get; set; }
#endif
        /// <summary>Device malware list</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WindowsDeviceMalwareState>? DetectedMalwareState { get; set; }
#nullable restore
#else
        public List<WindowsDeviceMalwareState> DetectedMalwareState { get; set; }
#endif
        /// <summary>Computer&apos;s state (like clean or pending full scan or pending reboot etc). Possible values are: clean, fullScanPending, rebootPending, manualStepsPending, offlineScanPending, critical.</summary>
        public WindowsDeviceHealthState? DeviceState { get; set; }
        /// <summary>Current endpoint protection engine&apos;s version</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EngineVersion { get; set; }
#nullable restore
#else
        public string EngineVersion { get; set; }
#endif
        /// <summary>Full scan overdue or not?</summary>
        public bool? FullScanOverdue { get; set; }
        /// <summary>Full scan required or not?</summary>
        public bool? FullScanRequired { get; set; }
        /// <summary>Indicates whether the device is a virtual machine.</summary>
        public bool? IsVirtualMachine { get; set; }
        /// <summary>Last quick scan datetime</summary>
        public DateTimeOffset? LastFullScanDateTime { get; set; }
        /// <summary>Last full scan signature version</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastFullScanSignatureVersion { get; set; }
#nullable restore
#else
        public string LastFullScanSignatureVersion { get; set; }
#endif
        /// <summary>Last quick scan datetime</summary>
        public DateTimeOffset? LastQuickScanDateTime { get; set; }
        /// <summary>Last quick scan signature version</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastQuickScanSignatureVersion { get; set; }
#nullable restore
#else
        public string LastQuickScanSignatureVersion { get; set; }
#endif
        /// <summary>Last device health status reported time</summary>
        public DateTimeOffset? LastReportedDateTime { get; set; }
        /// <summary>Anti malware is enabled or not</summary>
        public bool? MalwareProtectionEnabled { get; set; }
        /// <summary>Network inspection system enabled or not?</summary>
        public bool? NetworkInspectionSystemEnabled { get; set; }
        /// <summary>Product Status of Windows Defender Antivirus. Possible values are: noStatus, serviceNotRunning, serviceStartedWithoutMalwareProtection, pendingFullScanDueToThreatAction, pendingRebootDueToThreatAction, pendingManualStepsDueToThreatAction, avSignaturesOutOfDate, asSignaturesOutOfDate, noQuickScanHappenedForSpecifiedPeriod, noFullScanHappenedForSpecifiedPeriod, systemInitiatedScanInProgress, systemInitiatedCleanInProgress, samplesPendingSubmission, productRunningInEvaluationMode, productRunningInNonGenuineMode, productExpired, offlineScanRequired, serviceShutdownAsPartOfSystemShutdown, threatRemediationFailedCritically, threatRemediationFailedNonCritically, noStatusFlagsSet, platformOutOfDate, platformUpdateInProgress, platformAboutToBeOutdated, signatureOrPlatformEndOfLifeIsPastOrIsImpending, windowsSModeSignaturesInUseOnNonWin10SInstall.</summary>
        public WindowsDefenderProductStatus? ProductStatus { get; set; }
        /// <summary>Quick scan overdue or not?</summary>
        public bool? QuickScanOverdue { get; set; }
        /// <summary>Real time protection is enabled or not?</summary>
        public bool? RealTimeProtectionEnabled { get; set; }
        /// <summary>Reboot required or not?</summary>
        public bool? RebootRequired { get; set; }
        /// <summary>Signature out of date or not?</summary>
        public bool? SignatureUpdateOverdue { get; set; }
        /// <summary>Current malware definitions version</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SignatureVersion { get; set; }
#nullable restore
#else
        public string SignatureVersion { get; set; }
#endif
        /// <summary>Indicates whether the Windows Defender tamper protection feature is enabled.</summary>
        public bool? TamperProtectionEnabled { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WindowsProtectionState CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsProtectionState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"antiMalwareVersion", n => { AntiMalwareVersion = n.GetStringValue(); } },
                {"detectedMalwareState", n => { DetectedMalwareState = n.GetCollectionOfObjectValues<WindowsDeviceMalwareState>(WindowsDeviceMalwareState.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceState", n => { DeviceState = n.GetEnumValue<WindowsDeviceHealthState>(); } },
                {"engineVersion", n => { EngineVersion = n.GetStringValue(); } },
                {"fullScanOverdue", n => { FullScanOverdue = n.GetBoolValue(); } },
                {"fullScanRequired", n => { FullScanRequired = n.GetBoolValue(); } },
                {"isVirtualMachine", n => { IsVirtualMachine = n.GetBoolValue(); } },
                {"lastFullScanDateTime", n => { LastFullScanDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastFullScanSignatureVersion", n => { LastFullScanSignatureVersion = n.GetStringValue(); } },
                {"lastQuickScanDateTime", n => { LastQuickScanDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastQuickScanSignatureVersion", n => { LastQuickScanSignatureVersion = n.GetStringValue(); } },
                {"lastReportedDateTime", n => { LastReportedDateTime = n.GetDateTimeOffsetValue(); } },
                {"malwareProtectionEnabled", n => { MalwareProtectionEnabled = n.GetBoolValue(); } },
                {"networkInspectionSystemEnabled", n => { NetworkInspectionSystemEnabled = n.GetBoolValue(); } },
                {"productStatus", n => { ProductStatus = n.GetEnumValue<WindowsDefenderProductStatus>(); } },
                {"quickScanOverdue", n => { QuickScanOverdue = n.GetBoolValue(); } },
                {"realTimeProtectionEnabled", n => { RealTimeProtectionEnabled = n.GetBoolValue(); } },
                {"rebootRequired", n => { RebootRequired = n.GetBoolValue(); } },
                {"signatureUpdateOverdue", n => { SignatureUpdateOverdue = n.GetBoolValue(); } },
                {"signatureVersion", n => { SignatureVersion = n.GetStringValue(); } },
                {"tamperProtectionEnabled", n => { TamperProtectionEnabled = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("antiMalwareVersion", AntiMalwareVersion);
            writer.WriteCollectionOfObjectValues<WindowsDeviceMalwareState>("detectedMalwareState", DetectedMalwareState);
            writer.WriteEnumValue<WindowsDeviceHealthState>("deviceState", DeviceState);
            writer.WriteStringValue("engineVersion", EngineVersion);
            writer.WriteBoolValue("fullScanOverdue", FullScanOverdue);
            writer.WriteBoolValue("fullScanRequired", FullScanRequired);
            writer.WriteBoolValue("isVirtualMachine", IsVirtualMachine);
            writer.WriteDateTimeOffsetValue("lastFullScanDateTime", LastFullScanDateTime);
            writer.WriteStringValue("lastFullScanSignatureVersion", LastFullScanSignatureVersion);
            writer.WriteDateTimeOffsetValue("lastQuickScanDateTime", LastQuickScanDateTime);
            writer.WriteStringValue("lastQuickScanSignatureVersion", LastQuickScanSignatureVersion);
            writer.WriteDateTimeOffsetValue("lastReportedDateTime", LastReportedDateTime);
            writer.WriteBoolValue("malwareProtectionEnabled", MalwareProtectionEnabled);
            writer.WriteBoolValue("networkInspectionSystemEnabled", NetworkInspectionSystemEnabled);
            writer.WriteEnumValue<WindowsDefenderProductStatus>("productStatus", ProductStatus);
            writer.WriteBoolValue("quickScanOverdue", QuickScanOverdue);
            writer.WriteBoolValue("realTimeProtectionEnabled", RealTimeProtectionEnabled);
            writer.WriteBoolValue("rebootRequired", RebootRequired);
            writer.WriteBoolValue("signatureUpdateOverdue", SignatureUpdateOverdue);
            writer.WriteStringValue("signatureVersion", SignatureVersion);
            writer.WriteBoolValue("tamperProtectionEnabled", TamperProtectionEnabled);
        }
    }
}
