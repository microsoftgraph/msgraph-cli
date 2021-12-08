using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class AutomaticRepliesMailTips : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The automatic reply message.</summary>
        public string Message { get; set; }
        /// <summary>The language that the automatic reply message is in.</summary>
        public LocaleInfo MessageLanguage { get; set; }
        /// <summary>The date and time that automatic replies are set to end.</summary>
        public DateTimeTimeZone ScheduledEndTime { get; set; }
        /// <summary>The date and time that automatic replies are set to begin.</summary>
        public DateTimeTimeZone ScheduledStartTime { get; set; }
        /// <summary>
        /// Instantiates a new automaticRepliesMailTips and sets the default values.
        /// </summary>
        public AutomaticRepliesMailTips() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"message", (o,n) => { (o as AutomaticRepliesMailTips).Message = n.GetStringValue(); } },
                {"messageLanguage", (o,n) => { (o as AutomaticRepliesMailTips).MessageLanguage = n.GetObjectValue<LocaleInfo>(); } },
                {"scheduledEndTime", (o,n) => { (o as AutomaticRepliesMailTips).ScheduledEndTime = n.GetObjectValue<DateTimeTimeZone>(); } },
                {"scheduledStartTime", (o,n) => { (o as AutomaticRepliesMailTips).ScheduledStartTime = n.GetObjectValue<DateTimeTimeZone>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("message", Message);
            writer.WriteObjectValue<LocaleInfo>("messageLanguage", MessageLanguage);
            writer.WriteObjectValue<DateTimeTimeZone>("scheduledEndTime", ScheduledEndTime);
            writer.WriteObjectValue<DateTimeTimeZone>("scheduledStartTime", ScheduledStartTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
