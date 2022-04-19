namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the security singleton.</summary>
    public enum RegistryHive {
        Unknown,
        CurrentConfig,
        CurrentUser,
        LocalMachineSam,
        LocalMachineSecurity,
        LocalMachineSoftware,
        LocalMachineSystem,
        UsersDefault,
        UnknownFutureValue,
    }
}
