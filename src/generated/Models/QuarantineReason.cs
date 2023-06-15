using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum QuarantineReason {
        [EnumMember(Value = "EncounteredBaseEscrowThreshold")]
        EncounteredBaseEscrowThreshold,
        [EnumMember(Value = "EncounteredTotalEscrowThreshold")]
        EncounteredTotalEscrowThreshold,
        [EnumMember(Value = "EncounteredEscrowProportionThreshold")]
        EncounteredEscrowProportionThreshold,
        [EnumMember(Value = "EncounteredQuarantineException")]
        EncounteredQuarantineException,
        [EnumMember(Value = "Unknown")]
        Unknown,
        [EnumMember(Value = "QuarantinedOnDemand")]
        QuarantinedOnDemand,
        [EnumMember(Value = "TooManyDeletes")]
        TooManyDeletes,
        [EnumMember(Value = "IngestionInterrupted")]
        IngestionInterrupted,
    }
}
