namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the deviceAppManagement singleton.</summary>
    public enum Win32LobAppFileSystemOperationType {
        /// <summary>Not configured.</summary>
        NotConfigured,
        /// <summary>Whether the specified file or folder exists.</summary>
        Exists,
        /// <summary>Last modified date.</summary>
        ModifiedDate,
        /// <summary>Created date.</summary>
        CreatedDate,
        /// <summary>Version value type.</summary>
        Version,
        /// <summary>Size detection type.</summary>
        SizeInMB,
    }
}
