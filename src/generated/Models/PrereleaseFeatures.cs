namespace ApiSdk.Models {
    /// <summary>Possible values for pre-release features.</summary>
    public enum PrereleaseFeatures {
        /// <summary>User Defined, default value, no intent.</summary>
        UserDefined,
        /// <summary>Settings only pre-release features.</summary>
        SettingsOnly,
        /// <summary>Settings and experimentations pre-release features.</summary>
        SettingsAndExperimentations,
        /// <summary>Pre-release features not allowed.</summary>
        NotAllowed,
    }
}
