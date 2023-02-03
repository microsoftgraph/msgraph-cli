namespace ApiSdk.Models {
    /// <summary>The current status of the Exchange Connector.</summary>
    public enum DeviceManagementExchangeConnectorStatus {
        /// <summary>No Connector exists.</summary>
        None,
        /// <summary>Pending Connection to the Exchange Environment.</summary>
        ConnectionPending,
        /// <summary>Connected to the Exchange Environment</summary>
        Connected,
        /// <summary>Disconnected from the Exchange Environment</summary>
        Disconnected,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        UnknownFutureValue,
    }
}
