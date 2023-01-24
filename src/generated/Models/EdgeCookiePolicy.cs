namespace ApiSdk.Models {
    /// <summary>Possible values to specify which cookies are allowed in Microsoft Edge.</summary>
    public enum EdgeCookiePolicy {
        /// <summary>Allow the user to set.</summary>
        UserDefined,
        /// <summary>Allow.</summary>
        Allow,
        /// <summary>Block only third party cookies.</summary>
        BlockThirdParty,
        /// <summary>Block all cookies.</summary>
        BlockAll,
    }
}
