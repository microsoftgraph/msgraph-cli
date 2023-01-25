namespace ApiSdk.Models {
    /// <summary>Windows Hello for Business pin usage options</summary>
    public enum WindowsHelloForBusinessPinUsage {
        /// <summary>Allowed the usage of certain pin rule</summary>
        Allowed,
        /// <summary>Enforce the usage of certain pin rule</summary>
        Required,
        /// <summary>Forbit the usage of certain pin rule</summary>
        Disallowed,
    }
}
