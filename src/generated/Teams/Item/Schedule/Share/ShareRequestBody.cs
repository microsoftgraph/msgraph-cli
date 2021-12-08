using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Teams.Item.Schedule.Share {
    public class ShareRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public DateTimeOffset? EndDateTime { get; set; }
        public bool? NotifyTeam { get; set; }
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>
        /// Instantiates a new shareRequestBody and sets the default values.
        /// </summary>
        public ShareRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"endDateTime", (o,n) => { (o as ShareRequestBody).EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"notifyTeam", (o,n) => { (o as ShareRequestBody).NotifyTeam = n.GetBoolValue(); } },
                {"startDateTime", (o,n) => { (o as ShareRequestBody).StartDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteBoolValue("notifyTeam", NotifyTeam);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
