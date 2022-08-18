namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the collection of agreementAcceptance entities.</summary>
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
