using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Product Status of Windows Defender</summary>
    public enum WindowsDefenderProductStatus {
        /// <summary>No status</summary>
        [EnumMember(Value = "noStatus")]
        NoStatus,
        /// <summary>Service not running</summary>
        [EnumMember(Value = "serviceNotRunning")]
        ServiceNotRunning,
        /// <summary>Service started without any malware protection engine</summary>
        [EnumMember(Value = "serviceStartedWithoutMalwareProtection")]
        ServiceStartedWithoutMalwareProtection,
        /// <summary>Pending full scan due to threat action</summary>
        [EnumMember(Value = "pendingFullScanDueToThreatAction")]
        PendingFullScanDueToThreatAction,
        /// <summary>Pending reboot due to threat action</summary>
        [EnumMember(Value = "pendingRebootDueToThreatAction")]
        PendingRebootDueToThreatAction,
        /// <summary>Pending manual steps due to threat action </summary>
        [EnumMember(Value = "pendingManualStepsDueToThreatAction")]
        PendingManualStepsDueToThreatAction,
        /// <summary>AV signatures out of date</summary>
        [EnumMember(Value = "avSignaturesOutOfDate")]
        AvSignaturesOutOfDate,
        /// <summary>AS signatures out of date</summary>
        [EnumMember(Value = "asSignaturesOutOfDate")]
        AsSignaturesOutOfDate,
        /// <summary>No quick scan has happened for a specified period</summary>
        [EnumMember(Value = "noQuickScanHappenedForSpecifiedPeriod")]
        NoQuickScanHappenedForSpecifiedPeriod,
        /// <summary>No full scan has happened for a specified period</summary>
        [EnumMember(Value = "noFullScanHappenedForSpecifiedPeriod")]
        NoFullScanHappenedForSpecifiedPeriod,
        /// <summary>System initiated scan in progress</summary>
        [EnumMember(Value = "systemInitiatedScanInProgress")]
        SystemInitiatedScanInProgress,
        /// <summary>System initiated clean in progress</summary>
        [EnumMember(Value = "systemInitiatedCleanInProgress")]
        SystemInitiatedCleanInProgress,
        /// <summary>There are samples pending submission</summary>
        [EnumMember(Value = "samplesPendingSubmission")]
        SamplesPendingSubmission,
        /// <summary>Product running in evaluation mode</summary>
        [EnumMember(Value = "productRunningInEvaluationMode")]
        ProductRunningInEvaluationMode,
        /// <summary>Product running in non-genuine Windows mode</summary>
        [EnumMember(Value = "productRunningInNonGenuineMode")]
        ProductRunningInNonGenuineMode,
        /// <summary>Product expired</summary>
        [EnumMember(Value = "productExpired")]
        ProductExpired,
        /// <summary>Off-line scan required</summary>
        [EnumMember(Value = "offlineScanRequired")]
        OfflineScanRequired,
        /// <summary>Service is shutting down as part of system shutdown</summary>
        [EnumMember(Value = "serviceShutdownAsPartOfSystemShutdown")]
        ServiceShutdownAsPartOfSystemShutdown,
        /// <summary>Threat remediation failed critically</summary>
        [EnumMember(Value = "threatRemediationFailedCritically")]
        ThreatRemediationFailedCritically,
        /// <summary>Threat remediation failed non-critically</summary>
        [EnumMember(Value = "threatRemediationFailedNonCritically")]
        ThreatRemediationFailedNonCritically,
        /// <summary>No status flags set (well initialized state)</summary>
        [EnumMember(Value = "noStatusFlagsSet")]
        NoStatusFlagsSet,
        /// <summary>Platform is out of date</summary>
        [EnumMember(Value = "platformOutOfDate")]
        PlatformOutOfDate,
        /// <summary>Platform update is in progress</summary>
        [EnumMember(Value = "platformUpdateInProgress")]
        PlatformUpdateInProgress,
        /// <summary>Platform is about to be outdated</summary>
        [EnumMember(Value = "platformAboutToBeOutdated")]
        PlatformAboutToBeOutdated,
        /// <summary>Signature or platform end of life is past or is impending</summary>
        [EnumMember(Value = "signatureOrPlatformEndOfLifeIsPastOrIsImpending")]
        SignatureOrPlatformEndOfLifeIsPastOrIsImpending,
        /// <summary>Windows SMode signatures still in use on non-Win10S install</summary>
        [EnumMember(Value = "windowsSModeSignaturesInUseOnNonWin10SInstall")]
        WindowsSModeSignaturesInUseOnNonWin10SInstall,
    }
}
