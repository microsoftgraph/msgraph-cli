// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models
{
    /// <summary>Partner state of this tenant.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum MobileThreatPartnerTenantState
    {
        /// <summary>Partner is unavailable.</summary>
        [EnumMember(Value = "unavailable")]
        Unavailable,
        /// <summary>Partner is available.</summary>
        [EnumMember(Value = "available")]
        Available,
        /// <summary>Partner is enabled.</summary>
        [EnumMember(Value = "enabled")]
        Enabled,
        /// <summary>Partner is unresponsive.</summary>
        [EnumMember(Value = "unresponsive")]
        Unresponsive,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
