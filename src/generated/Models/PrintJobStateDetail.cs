namespace ApiSdk.Models {
    public enum PrintJobStateDetail {
        UploadPending,
        Transforming,
        CompletedSuccessfully,
        CompletedWithWarnings,
        CompletedWithErrors,
        ReleaseWait,
        Interpreting,
        UnknownFutureValue,
    }
}
