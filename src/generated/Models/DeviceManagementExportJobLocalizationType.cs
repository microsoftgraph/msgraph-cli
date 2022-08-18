namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the auditLogRoot singleton.</summary>
    public enum DeviceManagementExportJobLocalizationType {
        /// <summary>Configures the export job to expose localized values as an additional column</summary>
        LocalizedValuesAsAdditionalColumn,
        /// <summary>Configures the export job to replace enumerable values with their localized values</summary>
        ReplaceLocalizableValues,
    }
}
