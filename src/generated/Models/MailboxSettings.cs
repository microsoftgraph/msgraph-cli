using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class MailboxSettings : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Folder ID of an archive folder for the user.</summary>
        public string ArchiveFolder { get; set; }
        /// <summary>Configuration settings to automatically notify the sender of an incoming email with a message from the signed-in user.</summary>
        public ApiSdk.Models.AutomaticRepliesSetting AutomaticRepliesSetting { get; set; }
        /// <summary>The date format for the user&apos;s mailbox.</summary>
        public string DateFormat { get; set; }
        /// <summary>If the user has a calendar delegate, this specifies whether the delegate, mailbox owner, or both receive meeting messages and meeting responses. Possible values are: sendToDelegateAndInformationToPrincipal, sendToDelegateAndPrincipal, sendToDelegateOnly.</summary>
        public ApiSdk.Models.DelegateMeetingMessageDeliveryOptions? DelegateMeetingMessageDeliveryOptions { get; set; }
        /// <summary>The locale information for the user, including the preferred language and country/region.</summary>
        public LocaleInfo Language { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>The time format for the user&apos;s mailbox.</summary>
        public string TimeFormat { get; set; }
        /// <summary>The default time zone for the user&apos;s mailbox.</summary>
        public string TimeZone { get; set; }
        /// <summary>The userPurpose property</summary>
        public ApiSdk.Models.UserPurpose? UserPurpose { get; set; }
        /// <summary>The days of the week and hours in a specific time zone that the user works.</summary>
        public ApiSdk.Models.WorkingHours WorkingHours { get; set; }
        /// <summary>
        /// Instantiates a new mailboxSettings and sets the default values.
        /// </summary>
        public MailboxSettings() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.mailboxSettings";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static MailboxSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MailboxSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"archiveFolder", n => { ArchiveFolder = n.GetStringValue(); } },
                {"automaticRepliesSetting", n => { AutomaticRepliesSetting = n.GetObjectValue<ApiSdk.Models.AutomaticRepliesSetting>(ApiSdk.Models.AutomaticRepliesSetting.CreateFromDiscriminatorValue); } },
                {"dateFormat", n => { DateFormat = n.GetStringValue(); } },
                {"delegateMeetingMessageDeliveryOptions", n => { DelegateMeetingMessageDeliveryOptions = n.GetEnumValue<DelegateMeetingMessageDeliveryOptions>(); } },
                {"language", n => { Language = n.GetObjectValue<LocaleInfo>(LocaleInfo.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"timeFormat", n => { TimeFormat = n.GetStringValue(); } },
                {"timeZone", n => { TimeZone = n.GetStringValue(); } },
                {"userPurpose", n => { UserPurpose = n.GetEnumValue<UserPurpose>(); } },
                {"workingHours", n => { WorkingHours = n.GetObjectValue<ApiSdk.Models.WorkingHours>(ApiSdk.Models.WorkingHours.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("archiveFolder", ArchiveFolder);
            writer.WriteObjectValue<ApiSdk.Models.AutomaticRepliesSetting>("automaticRepliesSetting", AutomaticRepliesSetting);
            writer.WriteStringValue("dateFormat", DateFormat);
            writer.WriteEnumValue<DelegateMeetingMessageDeliveryOptions>("delegateMeetingMessageDeliveryOptions", DelegateMeetingMessageDeliveryOptions);
            writer.WriteObjectValue<LocaleInfo>("language", Language);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("timeFormat", TimeFormat);
            writer.WriteStringValue("timeZone", TimeZone);
            writer.WriteEnumValue<UserPurpose>("userPurpose", UserPurpose);
            writer.WriteObjectValue<ApiSdk.Models.WorkingHours>("workingHours", WorkingHours);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
