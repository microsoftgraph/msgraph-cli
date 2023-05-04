using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum TeamsAsyncOperationType {
        [EnumMember(Value = "invalid")]
        Invalid,
        [EnumMember(Value = "cloneTeam")]
        CloneTeam,
        [EnumMember(Value = "archiveTeam")]
        ArchiveTeam,
        [EnumMember(Value = "unarchiveTeam")]
        UnarchiveTeam,
        [EnumMember(Value = "createTeam")]
        CreateTeam,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
        [EnumMember(Value = "teamifyGroup")]
        TeamifyGroup,
        [EnumMember(Value = "createChannel")]
        CreateChannel,
    }
}
