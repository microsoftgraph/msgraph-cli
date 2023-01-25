namespace ApiSdk.Models {
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
