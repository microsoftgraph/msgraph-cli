using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models.CallRecords {
    public enum ServiceRole {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "customBot")]
        CustomBot,
        [EnumMember(Value = "skypeForBusinessMicrosoftTeamsGateway")]
        SkypeForBusinessMicrosoftTeamsGateway,
        [EnumMember(Value = "skypeForBusinessAudioVideoMcu")]
        SkypeForBusinessAudioVideoMcu,
        [EnumMember(Value = "skypeForBusinessApplicationSharingMcu")]
        SkypeForBusinessApplicationSharingMcu,
        [EnumMember(Value = "skypeForBusinessCallQueues")]
        SkypeForBusinessCallQueues,
        [EnumMember(Value = "skypeForBusinessAutoAttendant")]
        SkypeForBusinessAutoAttendant,
        [EnumMember(Value = "mediationServer")]
        MediationServer,
        [EnumMember(Value = "mediationServerCloudConnectorEdition")]
        MediationServerCloudConnectorEdition,
        [EnumMember(Value = "exchangeUnifiedMessagingService")]
        ExchangeUnifiedMessagingService,
        [EnumMember(Value = "mediaController")]
        MediaController,
        [EnumMember(Value = "conferencingAnnouncementService")]
        ConferencingAnnouncementService,
        [EnumMember(Value = "conferencingAttendant")]
        ConferencingAttendant,
        [EnumMember(Value = "audioTeleconferencerController")]
        AudioTeleconferencerController,
        [EnumMember(Value = "skypeForBusinessUnifiedCommunicationApplicationPlatform")]
        SkypeForBusinessUnifiedCommunicationApplicationPlatform,
        [EnumMember(Value = "responseGroupServiceAnnouncementService")]
        ResponseGroupServiceAnnouncementService,
        [EnumMember(Value = "gateway")]
        Gateway,
        [EnumMember(Value = "skypeTranslator")]
        SkypeTranslator,
        [EnumMember(Value = "skypeForBusinessAttendant")]
        SkypeForBusinessAttendant,
        [EnumMember(Value = "responseGroupService")]
        ResponseGroupService,
        [EnumMember(Value = "voicemail")]
        Voicemail,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
