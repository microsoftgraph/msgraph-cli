namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the auditLogRoot singleton.</summary>
    public enum DiskType {
        /// <summary>Enum member for unknown or default diskType</summary>
        Unknown,
        /// <summary>Enum member for HDD devices</summary>
        Hdd,
        /// <summary>Enum member for SSD devices</summary>
        Ssd,
        /// <summary>Evolvable enum member</summary>
        UnknownFutureValue,
    }
}
