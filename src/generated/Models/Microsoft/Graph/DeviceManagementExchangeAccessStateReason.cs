namespace ApiSdk.Models.Microsoft.Graph {
    public enum DeviceManagementExchangeAccessStateReason {
        None,
        Unknown,
        ExchangeGlobalRule,
        ExchangeIndividualRule,
        ExchangeDeviceRule,
        ExchangeUpgrade,
        ExchangeMailboxPolicy,
        Other,
        Compliant,
        NotCompliant,
        NotEnrolled,
        UnknownLocation,
        MfaRequired,
        AzureADBlockDueToAccessPolicy,
        CompromisedPassword,
        DeviceNotKnownWithManagedApp,
    }
}
