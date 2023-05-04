using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models.Security {
    public enum DeviceHealthStatus {
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "inactive")]
        Inactive,
        [EnumMember(Value = "impairedCommunication")]
        ImpairedCommunication,
        [EnumMember(Value = "noSensorData")]
        NoSensorData,
        [EnumMember(Value = "noSensorDataImpairedCommunication")]
        NoSensorDataImpairedCommunication,
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
