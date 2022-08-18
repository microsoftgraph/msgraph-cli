using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class CallStartedEventMessageDetail : EventMessageDetail, IParsable {
        /// <summary>Represents the call event type. Possible values are: call, meeting, screenShare, unknownFutureValue.</summary>
        public TeamworkCallEventType? CallEventType { get; set; }
        /// <summary>Unique identifier of the call.</summary>
        public string CallId { get; set; }
        /// <summary>Initiator of the event.</summary>
        public IdentitySet Initiator { get; set; }
        /// <summary>
        /// Instantiates a new CallStartedEventMessageDetail and sets the default values.
        /// </summary>
        public CallStartedEventMessageDetail() : base() {
            OdataType = "#microsoft.graph.callStartedEventMessageDetail";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new CallStartedEventMessageDetail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CallStartedEventMessageDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"callEventType", n => { CallEventType = n.GetEnumValue<TeamworkCallEventType>(); } },
                {"callId", n => { CallId = n.GetStringValue(); } },
                {"initiator", n => { Initiator = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<TeamworkCallEventType>("callEventType", CallEventType);
            writer.WriteStringValue("callId", CallId);
            writer.WriteObjectValue<IdentitySet>("initiator", Initiator);
        }
    }
}
