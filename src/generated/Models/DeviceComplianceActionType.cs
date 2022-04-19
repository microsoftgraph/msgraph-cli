namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum DeviceComplianceActionType {
        NoAction,
        Notification,
        Block,
        Retire,
        Wipe,
        RemoveResourceAccessProfiles,
        PushNotification,
    }
}
