using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Users.Item.Presence.SetPresence {
    public class SetPresenceRequestBody : IParsable {
        public string Activity { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string Availability { get; set; }
        public TimeSpan? ExpirationDuration { get; set; }
        public string SessionId { get; set; }
        /// <summary>
        /// Instantiates a new setPresenceRequestBody and sets the default values.
        /// </summary>
        public SetPresenceRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"activity", (o,n) => { (o as SetPresenceRequestBody).Activity = n.GetStringValue(); } },
                {"availability", (o,n) => { (o as SetPresenceRequestBody).Availability = n.GetStringValue(); } },
                {"expirationDuration", (o,n) => { (o as SetPresenceRequestBody).ExpirationDuration = n.GetTimeSpanValue(); } },
                {"sessionId", (o,n) => { (o as SetPresenceRequestBody).SessionId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("activity", Activity);
            writer.WriteStringValue("availability", Availability);
            writer.WriteTimeSpanValue("expirationDuration", ExpirationDuration);
            writer.WriteStringValue("sessionId", SessionId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
