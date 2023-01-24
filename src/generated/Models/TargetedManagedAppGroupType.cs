namespace ApiSdk.Models {
    /// <summary>Indicates a collection of apps to target which can be one of several pre-defined lists of apps or a manually selected list of apps</summary>
    public enum TargetedManagedAppGroupType {
        /// <summary>Target the collection of apps manually selected by the admin.</summary>
        SelectedPublicApps,
        /// <summary>Target the core set of Microsoft apps (Office, Edge, etc).</summary>
        AllCoreMicrosoftApps,
        /// <summary>Target all apps with Microsoft as publisher.</summary>
        AllMicrosoftApps,
        /// <summary>Target all apps with an available assignment.</summary>
        AllApps,
    }
}
