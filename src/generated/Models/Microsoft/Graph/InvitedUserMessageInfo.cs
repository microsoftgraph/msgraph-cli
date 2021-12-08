using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class InvitedUserMessageInfo : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Additional recipients the invitation message should be sent to. Currently only 1 additional recipient is supported.</summary>
        public List<Recipient> CcRecipients { get; set; }
        /// <summary>Customized message body you want to send if you don't want the default message.</summary>
        public string CustomizedMessageBody { get; set; }
        /// <summary>The language you want to send the default message in. If the customizedMessageBody is specified, this property is ignored, and the message is sent using the customizedMessageBody. The language format should be in ISO 639. The default is en-US.</summary>
        public string MessageLanguage { get; set; }
        /// <summary>
        /// Instantiates a new invitedUserMessageInfo and sets the default values.
        /// </summary>
        public InvitedUserMessageInfo() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"ccRecipients", (o,n) => { (o as InvitedUserMessageInfo).CcRecipients = n.GetCollectionOfObjectValues<Recipient>().ToList(); } },
                {"customizedMessageBody", (o,n) => { (o as InvitedUserMessageInfo).CustomizedMessageBody = n.GetStringValue(); } },
                {"messageLanguage", (o,n) => { (o as InvitedUserMessageInfo).MessageLanguage = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<Recipient>("ccRecipients", CcRecipients);
            writer.WriteStringValue("customizedMessageBody", CustomizedMessageBody);
            writer.WriteStringValue("messageLanguage", MessageLanguage);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
