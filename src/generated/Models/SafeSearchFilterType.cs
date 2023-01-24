namespace ApiSdk.Models {
    /// <summary>Specifies what level of safe search (filtering adult content) is required</summary>
    public enum SafeSearchFilterType {
        /// <summary>User Defined, default value, no intent.</summary>
        UserDefined,
        /// <summary>Strict, highest filtering against adult content.</summary>
        Strict,
        /// <summary>Moderate filtering against adult content (valid search results will not be filtered).</summary>
        Moderate,
    }
}
