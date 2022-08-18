using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class ResponseStatus : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>The response type. Possible values are: none, organizer, tentativelyAccepted, accepted, declined, notResponded.To differentiate between none and notResponded:  none – from organizer&apos;s perspective. This value is used when the status of an attendee/participant is reported to the organizer of a meeting.  notResponded – from attendde&apos;s perspective. Indicates the attendee has not responded to the meeting request.  Clients can treat notResponded == none.  As an example, if attendee Alex hasn&apos;t responded to a meeting request, getting Alex&apos; response status for that event in Alex&apos; calendar returns notResponded. Getting Alex&apos; response from the calendar of any other attendee or the organizer&apos;s returns none. Getting the organizer&apos;s response for the event in anybody&apos;s calendar also returns none.</summary>
        public ResponseType? Response { get; set; }
        /// <summary>The date and time that the response was returned. It uses ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? Time { get; set; }
        /// <summary>
        /// Instantiates a new responseStatus and sets the default values.
        /// </summary>
        public ResponseStatus() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.responseStatus";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ResponseStatus CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ResponseStatus();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"response", n => { Response = n.GetEnumValue<ResponseType>(); } },
                {"time", n => { Time = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<ResponseType>("response", Response);
            writer.WriteDateTimeOffsetValue("time", Time);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
