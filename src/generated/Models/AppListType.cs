namespace ApiSdk.Models {
    /// <summary>Possible values of the compliance app list.</summary>
    public enum AppListType {
        /// <summary>Default value, no intent.</summary>
        None,
        /// <summary>The list represents the apps that will be considered compliant (only apps on the list are compliant).</summary>
        AppsInListCompliant,
        /// <summary>The list represents the apps that will be considered non compliant (all apps are compliant except apps on the list).</summary>
        AppsNotInListCompliant,
    }
}
