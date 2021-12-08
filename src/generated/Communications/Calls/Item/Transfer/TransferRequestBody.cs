using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Communications.Calls.Item.Transfer {
    public class TransferRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public ParticipantInfo Transferee { get; set; }
        public InvitationParticipantInfo TransferTarget { get; set; }
        /// <summary>
        /// Instantiates a new transferRequestBody and sets the default values.
        /// </summary>
        public TransferRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"transferee", (o,n) => { (o as TransferRequestBody).Transferee = n.GetObjectValue<ParticipantInfo>(); } },
                {"transferTarget", (o,n) => { (o as TransferRequestBody).TransferTarget = n.GetObjectValue<InvitationParticipantInfo>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ParticipantInfo>("transferee", Transferee);
            writer.WriteObjectValue<InvitationParticipantInfo>("transferTarget", TransferTarget);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
