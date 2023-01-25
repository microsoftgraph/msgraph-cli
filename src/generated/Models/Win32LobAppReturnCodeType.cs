namespace ApiSdk.Models {
    /// <summary>Indicates the type of return code.</summary>
    public enum Win32LobAppReturnCodeType {
        /// <summary>Failed.</summary>
        Failed,
        /// <summary>Success.</summary>
        Success,
        /// <summary>Soft-reboot is required.</summary>
        SoftReboot,
        /// <summary>Hard-reboot is required.</summary>
        HardReboot,
        /// <summary>Retry.</summary>
        Retry,
    }
}
