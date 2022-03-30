namespace ApiSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum IosUpdatesInstallStatus {
        DeviceOsHigherThanDesiredOsVersion,
        SharedDeviceUserLoggedInError,
        NotSupportedOperation,
        InstallFailed,
        InstallPhoneCallInProgress,
        InstallInsufficientPower,
        InstallInsufficientSpace,
        Installing,
        DownloadInsufficientNetwork,
        DownloadInsufficientPower,
        DownloadInsufficientSpace,
        DownloadRequiresComputer,
        DownloadFailed,
        Downloading,
        Success,
        Available,
        Idle,
        Unknown,
    }
}
