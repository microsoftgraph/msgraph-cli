using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class IncomingContext : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The ID of the participant that is under observation. Read-only.</summary>
        public string ObservedParticipantId { get; set; }
        /// <summary>The identity that the call is happening on behalf of.</summary>
        public ApiSdk.Models.Microsoft.Graph.IdentitySet OnBehalfOf { get; set; }
        /// <summary>The ID of the participant that triggered the incoming call. Read-only.</summary>
        public string SourceParticipantId { get; set; }
        /// <summary>The identity that transferred the call.</summary>
        public ApiSdk.Models.Microsoft.Graph.IdentitySet Transferor { get; set; }
        /// <summary>
        /// Instantiates a new incomingContext and sets the default values.
        /// </summary>
        public IncomingContext() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.IncomingContext CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IncomingContext();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"observedParticipantId", (o,n) => { (o as IncomingContext).ObservedParticipantId = n.GetStringValue(); } },
                {"onBehalfOf", (o,n) => { (o as IncomingContext).OnBehalfOf = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.IdentitySet>(ApiSdk.Models.Microsoft.Graph.IdentitySet.CreateFromDiscriminatorValue); } },
                {"sourceParticipantId", (o,n) => { (o as IncomingContext).SourceParticipantId = n.GetStringValue(); } },
                {"transferor", (o,n) => { (o as IncomingContext).Transferor = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.IdentitySet>(ApiSdk.Models.Microsoft.Graph.IdentitySet.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("observedParticipantId", ObservedParticipantId);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.IdentitySet>("onBehalfOf", OnBehalfOf);
            writer.WriteStringValue("sourceParticipantId", SourceParticipantId);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.IdentitySet>("transferor", Transferor);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
