namespace ApiSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the drive singleton.</summary>
    public enum CalendarRoleType {
        None,
        FreeBusyRead,
        LimitedRead,
        Read,
        Write,
        DelegateWithoutPrivateEventAccess,
        DelegateWithPrivateEventAccess,
        Custom,
    }
}
