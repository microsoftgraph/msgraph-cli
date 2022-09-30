namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the auditLogRoot singleton.</summary>
    public enum MeetingMessageType {
        None,
        MeetingRequest,
        MeetingCancelled,
        MeetingAccepted,
        MeetingTenativelyAccepted,
        MeetingDeclined,
    }
}
