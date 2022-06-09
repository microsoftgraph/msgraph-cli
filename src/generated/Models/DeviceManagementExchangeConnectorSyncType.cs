namespace ApiSdk.Models {
    /// <summary>Provides operations to call the sync method.</summary>
    public enum DeviceManagementExchangeConnectorSyncType {
        /// <summary>Discover all the device in Exchange.</summary>
        FullSync,
        /// <summary>Discover only the device in Exchange which have updated during the delta sync window.</summary>
        DeltaSync,
    }
}
