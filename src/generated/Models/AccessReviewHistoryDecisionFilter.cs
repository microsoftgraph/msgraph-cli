using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum AccessReviewHistoryDecisionFilter {
        [EnumMember(Value = "approve")]
        Approve,
        [EnumMember(Value = "deny")]
        Deny,
        [EnumMember(Value = "notReviewed")]
        NotReviewed,
        [EnumMember(Value = "dontKnow")]
        DontKnow,
        [EnumMember(Value = "notNotified")]
        NotNotified,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
