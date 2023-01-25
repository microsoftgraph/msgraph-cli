namespace ApiSdk.Models {
    /// <summary>Possible values for the install intent chosen by the admin.</summary>
    public enum InstallIntent {
        /// <summary>Available install intent.</summary>
        Available,
        /// <summary>Required install intent.</summary>
        Required,
        /// <summary>Uninstall install intent.</summary>
        Uninstall,
        /// <summary>Available without enrollment install intent.</summary>
        AvailableWithoutEnrollment,
    }
}
