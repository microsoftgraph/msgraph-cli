namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the collection of application entities.</summary>
    public enum AutoRestartNotificationDismissalMethod {
        /// <summary>Not configured</summary>
        NotConfigured,
        /// <summary>Auto dismissal Indicates that the notification is automatically dismissed without user intervention</summary>
        Automatic,
        /// <summary>User dismissal. Allows the user to dismiss the notification</summary>
        User,
        /// <summary>Evolvable enum member</summary>
        UnknownFutureValue,
    }
}
