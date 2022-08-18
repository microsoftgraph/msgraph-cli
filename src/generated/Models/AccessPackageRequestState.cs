namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the auditLogRoot singleton.</summary>
    public enum AccessPackageRequestState {
        Submitted,
        PendingApproval,
        Delivering,
        Delivered,
        DeliveryFailed,
        Denied,
        Scheduled,
        Canceled,
        PartiallyDelivered,
        UnknownFutureValue,
    }
}
