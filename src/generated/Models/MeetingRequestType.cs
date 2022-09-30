namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the auditLogRoot singleton.</summary>
    public enum MeetingRequestType {
        None,
        NewMeetingRequest,
        FullUpdate,
        InformationalUpdate,
        SilentUpdate,
        Outdated,
        PrincipalWantsCopy,
    }
}
