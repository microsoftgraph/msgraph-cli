using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Users.Item.GetMailTips {
    /// <summary>Provides operations to call the getMailTips method.</summary>
    public class GetMailTipsPostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The EmailAddresses property</summary>
        public List<string> EmailAddresses { get; set; }
        /// <summary>The MailTipsOptions property</summary>
        public MailTipsType? MailTipsOptions { get; set; }
        /// <summary>
        /// Instantiates a new getMailTipsPostRequestBody and sets the default values.
        /// </summary>
        public GetMailTipsPostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static GetMailTipsPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GetMailTipsPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"emailAddresses", n => { EmailAddresses = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"mailTipsOptions", n => { MailTipsOptions = n.GetEnumValue<MailTipsType>(); } },
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
