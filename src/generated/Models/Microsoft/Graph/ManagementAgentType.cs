namespace ApiSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum ManagementAgentType {
        Eas,
        Mdm,
        EasMdm,
        IntuneClient,
        EasIntuneClient,
        ConfigurationManagerClient,
        ConfigurationManagerClientMdm,
        ConfigurationManagerClientMdmEas,
        Unknown,
        Jamf,
        GoogleCloudDevicePolicyController,
        Microsoft365ManagedMdm,
        MsSense,
    }
}
