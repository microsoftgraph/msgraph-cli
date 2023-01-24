namespace ApiSdk.Models {
    /// <summary>Windows Update Notification Display Options</summary>
    public enum WindowsUpdateNotificationDisplayOption {
        /// <summary>Not configured</summary>
        NotConfigured,
        /// <summary>Use the default Windows Update notifications.</summary>
        DefaultNotifications,
        /// <summary>Turn off all notifications, excluding restart warnings.</summary>
        RestartWarningsOnly,
        /// <summary>Turn off all notifications, including restart warnings.</summary>
        DisableAllNotifications,
        /// <summary>Evolvable enum member</summary>
        UnknownFutureValue,
    }
}
