using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Users.Item.Messages.Item.Forward {
    /// <summary>Provides operations to call the forward method.</summary>
    public class ForwardPostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Comment property</summary>
        public string Comment { get; set; }
        /// <summary>The Message property</summary>
        public ApiSdk.Models.Message Message { get; set; }
        /// <summary>The ToRecipients property</summary>
        public List<Recipient> ToRecipients { get; set; }
        /// <summary>
        /// Instantiates a new forwardPostRequestBody and sets the default values.
        /// </summary>
        public ForwardPostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ForwardPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ForwardPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"comment", n => { Comment = n.GetStringValue(); } },
                {"message", n => { Message = n.GetObjectValue<ApiSdk.Models.Message>(ApiSdk.Models.Message.CreateFromDiscriminatorValue); } },
                {"toRecipients", n => { ToRecipients = n.GetCollectionOfObjectValues<Recipient>(Recipient.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("comment", Comment);
            writer.WriteObjectValue<ApiSdk.Models.Message>("message", Message);
            writer.WriteCollectionOfObjectValues<Recipient>("toRecipients", ToRecipients);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
