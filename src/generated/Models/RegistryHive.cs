using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum RegistryHive {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "currentConfig")]
        CurrentConfig,
        [EnumMember(Value = "currentUser")]
        CurrentUser,
        [EnumMember(Value = "localMachineSam")]
        LocalMachineSam,
        [EnumMember(Value = "localMachineSecurity")]
        LocalMachineSecurity,
        [EnumMember(Value = "localMachineSoftware")]
        LocalMachineSoftware,
        [EnumMember(Value = "localMachineSystem")]
        LocalMachineSystem,
        [EnumMember(Value = "usersDefault")]
        UsersDefault,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
