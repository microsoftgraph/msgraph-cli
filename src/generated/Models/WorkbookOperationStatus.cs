using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum WorkbookOperationStatus {
        [EnumMember(Value = "notStarted")]
        NotStarted,
        [EnumMember(Value = "running")]
        Running,
        [EnumMember(Value = "succeeded")]
        Succeeded,
        [EnumMember(Value = "failed")]
        Failed,
    }
}
