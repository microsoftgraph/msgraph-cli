using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum Tone {
        [EnumMember(Value = "tone0")]
        Tone0,
        [EnumMember(Value = "tone1")]
        Tone1,
        [EnumMember(Value = "tone2")]
        Tone2,
        [EnumMember(Value = "tone3")]
        Tone3,
        [EnumMember(Value = "tone4")]
        Tone4,
        [EnumMember(Value = "tone5")]
        Tone5,
        [EnumMember(Value = "tone6")]
        Tone6,
        [EnumMember(Value = "tone7")]
        Tone7,
        [EnumMember(Value = "tone8")]
        Tone8,
        [EnumMember(Value = "tone9")]
        Tone9,
        [EnumMember(Value = "star")]
        Star,
        [EnumMember(Value = "pound")]
        Pound,
        [EnumMember(Value = "a")]
        A,
        [EnumMember(Value = "b")]
        B,
        [EnumMember(Value = "c")]
        C,
        [EnumMember(Value = "d")]
        D,
        [EnumMember(Value = "flash")]
        Flash,
    }
}
