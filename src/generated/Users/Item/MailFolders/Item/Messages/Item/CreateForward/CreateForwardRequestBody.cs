using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Users.Item.MailFolders.Item.Messages.Item.CreateForward {
    public class CreateForwardRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string Comment { get; set; }
        public Message Message { get; set; }
        public List<Recipient> ToRecipients { get; set; }
        /// <summary>
        /// Instantiates a new createForwardRequestBody and sets the default values.
        /// </summary>
        public CreateForwardRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"comment", (o,n) => { (o as CreateForwardRequestBody).Comment = n.GetStringValue(); } },
                {"message", (o,n) => { (o as CreateForwardRequestBody).Message = n.GetObjectValue<Message>(); } },
                {"toRecipients", (o,n) => { (o as CreateForwardRequestBody).ToRecipients = n.GetCollectionOfObjectValues<Recipient>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("comment", Comment);
            writer.WriteObjectValue<Message>("message", Message);
            writer.WriteCollectionOfObjectValues<Recipient>("toRecipients", ToRecipients);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
