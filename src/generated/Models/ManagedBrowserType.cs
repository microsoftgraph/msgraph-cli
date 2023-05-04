using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Type of managed browser</summary>
    public enum ManagedBrowserType {
        /// <summary>Not configured</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Microsoft Edge</summary>
        [EnumMember(Value = "microsoftEdge")]
        MicrosoftEdge,
    }
}
