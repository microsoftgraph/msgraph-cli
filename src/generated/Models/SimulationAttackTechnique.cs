using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum SimulationAttackTechnique {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "credentialHarvesting")]
        CredentialHarvesting,
        [EnumMember(Value = "attachmentMalware")]
        AttachmentMalware,
        [EnumMember(Value = "driveByUrl")]
        DriveByUrl,
        [EnumMember(Value = "linkInAttachment")]
        LinkInAttachment,
        [EnumMember(Value = "linkToMalwareFile")]
        LinkToMalwareFile,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
