namespace ApiSdk.Models {
    /// <summary>A managed (MAM) application&apos;s availability.</summary>
    public enum ManagedAppAvailability {
        /// <summary>A globally available app to all tenants.</summary>
        Global,
        /// <summary>A line of business apps private to an organization.</summary>
        LineOfBusiness,
    }
}
