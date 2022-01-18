using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class IncomingContext : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The id of the participant that is under observation. Read-only.</summary>
        public string ObservedParticipantId { get; set; }
        /// <summary>The identity that the call is happening on behalf of.</summary>
        public IdentitySet OnBehalfOf { get; set; }
        /// <summary>The id of the participant that triggered the incoming call. Read-only.</summary>
        public string SourceParticipantId { get; set; }
        /// <summary>The identity that transferred the call.</summary>
        public IdentitySet Transferor { get; set; }
        /// <summary>
        /// Instantiates a new incomingContext and sets the default values.
        /// </summary>
        public IncomingContext() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"observedParticipantId", (o,n) => { (o as IncomingContext).ObservedParticipantId = n.GetStringValue(); } },
                {"onBehalfOf", (o,n) => { (o as IncomingContext).OnBehalfOf = n.GetObjectValue<IdentitySet>(); } },
                {"sourceParticipantId", (o,n) => { (o as IncomingContext).SourceParticipantId = n.GetStringValue(); } },
                {"transferor", (o,n) => { (o as IncomingContext).Transferor = n.GetObjectValue<IdentitySet>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("observedParticipantId", ObservedParticipantId);
            writer.WriteObjectValue<IdentitySet>("onBehalfOf", OnBehalfOf);
            writer.WriteStringValue("sourceParticipantId", SourceParticipantId);
            writer.WriteObjectValue<IdentitySet>("transferor", Transferor);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
