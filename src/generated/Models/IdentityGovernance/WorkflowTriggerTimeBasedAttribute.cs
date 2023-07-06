using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models.IdentityGovernance {
    public enum WorkflowTriggerTimeBasedAttribute {
        [EnumMember(Value = "employeeHireDate")]
        EmployeeHireDate,
        [EnumMember(Value = "employeeLeaveDateTime")]
        EmployeeLeaveDateTime,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
        [EnumMember(Value = "createdDateTime")]
        CreatedDateTime,
    }
}
