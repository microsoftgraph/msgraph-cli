namespace ApiSdk.Models {
    /// <summary>The reason for which a user has been flagged</summary>
    public enum ManagedAppFlaggedReason {
        /// <summary>No issue.</summary>
        None,
        /// <summary>The app registration is running on a rooted/unlocked device.</summary>
        RootedDevice,
    }
}
