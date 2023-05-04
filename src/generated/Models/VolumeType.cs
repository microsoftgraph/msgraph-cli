using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum VolumeType {
        [EnumMember(Value = "operatingSystemVolume")]
        OperatingSystemVolume,
        [EnumMember(Value = "fixedDataVolume")]
        FixedDataVolume,
        [EnumMember(Value = "removableDataVolume")]
        RemovableDataVolume,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
