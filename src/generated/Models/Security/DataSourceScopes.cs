namespace ApiSdk.Models.Security {
    /// <summary>Provides operations to manage the collection of application entities.</summary>
    public enum DataSourceScopes {
        None,
        AllTenantMailboxes,
        AllTenantSites,
        AllCaseCustodians,
        AllCaseNoncustodialDataSources,
        UnknownFutureValue,
    }
}
