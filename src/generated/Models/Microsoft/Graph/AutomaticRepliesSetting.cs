using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class AutomaticRepliesSetting : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The set of audience external to the signed-in user's organization who will receive the ExternalReplyMessage, if Status is AlwaysEnabled or Scheduled. Possible values are: none, contactsOnly, all.</summary>
        public ExternalAudienceScope? ExternalAudience { get; set; }
        /// <summary>The automatic reply to send to the specified external audience, if Status is AlwaysEnabled or Scheduled.</summary>
        public string ExternalReplyMessage { get; set; }
        /// <summary>The automatic reply to send to the audience internal to the signed-in user's organization, if Status is AlwaysEnabled or Scheduled.</summary>
        public string InternalReplyMessage { get; set; }
        /// <summary>The date and time that automatic replies are set to end, if Status is set to Scheduled.</summary>
        public DateTimeTimeZone ScheduledEndDateTime { get; set; }
        /// <summary>The date and time that automatic replies are set to begin, if Status is set to Scheduled.</summary>
        public DateTimeTimeZone ScheduledStartDateTime { get; set; }
        /// <summary>Configurations status for automatic replies. Possible values are: disabled, alwaysEnabled, scheduled.</summary>
        public AutomaticRepliesStatus? Status { get; set; }
        /// <summary>
        /// Instantiates a new automaticRepliesSetting and sets the default values.
        /// </summary>
        public AutomaticRepliesSetting() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"externalAudience", (o,n) => { (o as AutomaticRepliesSetting).ExternalAudience = n.GetEnumValue<ExternalAudienceScope>(); } },
                {"externalReplyMessage", (o,n) => { (o as AutomaticRepliesSetting).ExternalReplyMessage = n.GetStringValue(); } },
                {"internalReplyMessage", (o,n) => { (o as AutomaticRepliesSetting).InternalReplyMessage = n.GetStringValue(); } },
                {"scheduledEndDateTime", (o,n) => { (o as AutomaticRepliesSetting).ScheduledEndDateTime = n.GetObjectValue<DateTimeTimeZone>(); } },
                {"scheduledStartDateTime", (o,n) => { (o as AutomaticRepliesSetting).ScheduledStartDateTime = n.GetObjectValue<DateTimeTimeZone>(); } },
                {"status", (o,n) => { (o as AutomaticRepliesSetting).Status = n.GetEnumValue<AutomaticRepliesStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<ExternalAudienceScope>("externalAudience", ExternalAudience);
            writer.WriteStringValue("externalReplyMessage", ExternalReplyMessage);
            writer.WriteStringValue("internalReplyMessage", InternalReplyMessage);
            writer.WriteObjectValue<DateTimeTimeZone>("scheduledEndDateTime", ScheduledEndDateTime);
            writer.WriteObjectValue<DateTimeTimeZone>("scheduledStartDateTime", ScheduledStartDateTime);
            writer.WriteEnumValue<AutomaticRepliesStatus>("status", Status);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
