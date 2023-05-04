using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>App configuration key types.</summary>
    public enum MdmAppConfigKeyType {
        [EnumMember(Value = "stringType")]
        StringType,
        [EnumMember(Value = "integerType")]
        IntegerType,
        [EnumMember(Value = "realType")]
        RealType,
        [EnumMember(Value = "booleanType")]
        BooleanType,
        [EnumMember(Value = "tokenType")]
        TokenType,
    }
}
