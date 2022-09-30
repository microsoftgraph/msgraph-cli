using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Me.Messages.Item.CreateForward {
    /// <summary>Provides operations to call the createForward method.</summary>
    public class CreateForwardPostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Comment property</summary>
        public string Comment { get; set; }
        /// <summary>The Message property</summary>
        public ApiSdk.Models.Message Message { get; set; }
        /// <summary>The ToRecipients property</summary>
        public List<Recipient> ToRecipients { get; set; }
        /// <summary>
        /// Instantiates a new createForwardPostRequestBody and sets the default values.
        /// </summary>
        public CreateForwardPostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CreateForwardPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CreateForwardPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Comment", n => { Comment = n.GetStringValue(); } },
                {"Message", n => { Message = n.GetObjectValue<ApiSdk.Models.Message>(ApiSdk.Models.Message.CreateFromDiscriminatorValue); } },
                {"ToRecipients", n => { ToRecipients = n.GetCollectionOfObjectValues<Recipient>(Recipient.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("Comment", Comment);
            writer.WriteObjectValue<ApiSdk.Models.Message>("Message", Message);
            writer.WriteCollectionOfObjectValues<Recipient>("ToRecipients", ToRecipients);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
