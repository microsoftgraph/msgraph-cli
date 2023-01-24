namespace ApiSdk.Models {
    /// <summary>Possible statuses associated with a generated report</summary>
    public enum DeviceManagementReportStatus {
        /// <summary>Report generation status is unknown</summary>
        Unknown,
        /// <summary>Report generation has not started</summary>
        NotStarted,
        /// <summary>Report generation is in progress</summary>
        InProgress,
        /// <summary>Report generation is completed</summary>
        Completed,
        /// <summary>Report generation has failed</summary>
        Failed,
    }
}
