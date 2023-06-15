using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum SynchronizationJobRestartScope {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "ConnectorDataStore")]
        ConnectorDataStore,
        [EnumMember(Value = "Escrows")]
        Escrows,
        [EnumMember(Value = "Watermark")]
        Watermark,
        [EnumMember(Value = "QuarantineState")]
        QuarantineState,
        [EnumMember(Value = "Full")]
        Full,
        [EnumMember(Value = "ForceDeletes")]
        ForceDeletes,
    }
}
