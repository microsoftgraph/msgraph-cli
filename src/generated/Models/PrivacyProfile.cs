using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class PrivacyProfile : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A valid smtp email address for the privacy statement contact. Not required.</summary>
        public string ContactEmail { get; set; }
        /// <summary>A valid URL format that begins with http:// or https://. Maximum length is 255 characters. The URL that directs to the company&apos;s privacy statement. Not required.</summary>
        public string StatementUrl { get; set; }
        /// <summary>
        /// Instantiates a new privacyProfile and sets the default values.
        /// </summary>
        public PrivacyProfile() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static PrivacyProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrivacyProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"contactEmail", n => { ContactEmail = n.GetStringValue(); } },
                {"statementUrl", n => { StatementUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("contactEmail", ContactEmail);
            writer.WriteStringValue("statementUrl", StatementUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
