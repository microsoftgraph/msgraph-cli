namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the collection of application entities.</summary>
    public enum ManagedAppFlaggedReason {
        /// <summary>No issue.</summary>
        None,
        /// <summary>The app registration is running on a rooted/unlocked device.</summary>
        RootedDevice,
    }
}
