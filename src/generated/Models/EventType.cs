using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum EventType {
        [EnumMember(Value = "singleInstance")]
        SingleInstance,
        [EnumMember(Value = "occurrence")]
        Occurrence,
        [EnumMember(Value = "exception")]
        Exception,
        [EnumMember(Value = "seriesMaster")]
        SeriesMaster,
    }
}
