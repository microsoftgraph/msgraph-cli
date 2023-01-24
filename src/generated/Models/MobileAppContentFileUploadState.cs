namespace ApiSdk.Models {
    /// <summary>Contains properties for upload request states.</summary>
    public enum MobileAppContentFileUploadState {
        Success,
        TransientError,
        Error,
        Unknown,
        AzureStorageUriRequestSuccess,
        AzureStorageUriRequestPending,
        AzureStorageUriRequestFailed,
        AzureStorageUriRequestTimedOut,
        AzureStorageUriRenewalSuccess,
        AzureStorageUriRenewalPending,
        AzureStorageUriRenewalFailed,
        AzureStorageUriRenewalTimedOut,
        CommitFileSuccess,
        CommitFilePending,
        CommitFileFailed,
        CommitFileTimedOut,
    }
}
