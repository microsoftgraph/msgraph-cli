namespace ApiSdk.Models {
    /// <summary>Possible values for when accounts are deleted on a shared PC.</summary>
    public enum SharedPCAccountDeletionPolicyType {
        /// <summary>Delete immediately.</summary>
        Immediate,
        /// <summary>Delete at disk space threshold.</summary>
        DiskSpaceThreshold,
        /// <summary>Delete at disk space threshold or inactive threshold.</summary>
        DiskSpaceThresholdOrInactiveThreshold,
    }
}
