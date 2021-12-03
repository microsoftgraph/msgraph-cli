using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Users.Item.GetMailTips {
    public class GetMailTipsRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<string> EmailAddresses { get; set; }
        public MailTipsType? MailTipsOptions { get; set; }
        /// <summary>
        /// Instantiates a new getMailTipsRequestBody and sets the default values.
        /// </summary>
        public GetMailTipsRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"emailAddresses", (o,n) => { (o as GetMailTipsRequestBody).EmailAddresses = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"mailTipsOptions", (o,n) => { (o as GetMailTipsRequestBody).MailTipsOptions = n.GetEnumValue<MailTipsType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("emailAddresses", EmailAddresses);
            writer.WriteEnumValue<MailTipsType>("mailTipsOptions", MailTipsOptions);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
