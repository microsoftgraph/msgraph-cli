namespace ApiSdk.Models {
    /// <summary>Possible sync statuses associated with an Apple Volume Purchase Program token.</summary>
    public enum VppTokenSyncStatus {
        /// <summary>Default status.</summary>
        None,
        /// <summary>Last Sync in progress.</summary>
        InProgress,
        /// <summary>Last Sync completed successfully.</summary>
        Completed,
        /// <summary>Last Sync failed.</summary>
        Failed,
    }
}
