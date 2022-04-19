using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Communications.Calls.Item.Transfer {
    /// <summary>Provides operations to call the transfer method.</summary>
    public class TransferRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The transferee property</summary>
        public ParticipantInfo Transferee { get; set; }
        /// <summary>The transferTarget property</summary>
        public InvitationParticipantInfo TransferTarget { get; set; }
        /// <summary>
        /// Instantiates a new transferRequestBody and sets the default values.
        /// </summary>
        public TransferRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TransferRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TransferRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"transferee", n => { Transferee = n.GetObjectValue<ParticipantInfo>(ParticipantInfo.CreateFromDiscriminatorValue); } },
                {"transferTarget", n => { TransferTarget = n.GetObjectValue<InvitationParticipantInfo>(InvitationParticipantInfo.CreateFromDiscriminatorValue); } },
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
