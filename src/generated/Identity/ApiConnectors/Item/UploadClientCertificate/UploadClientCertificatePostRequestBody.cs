using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Identity.ApiConnectors.Item.UploadClientCertificate {
    /// <summary>Provides operations to call the uploadClientCertificate method.</summary>
    public class UploadClientCertificatePostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The password property</summary>
        public string Password { get; set; }
        /// <summary>The pkcs12Value property</summary>
        public string Pkcs12Value { get; set; }
        /// <summary>
        /// Instantiates a new uploadClientCertificatePostRequestBody and sets the default values.
        /// </summary>
        public UploadClientCertificatePostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static UploadClientCertificatePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UploadClientCertificatePostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"password", n => { Password = n.GetStringValue(); } },
                {"pkcs12Value", n => { Pkcs12Value = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("password", Password);
            writer.WriteStringValue("pkcs12Value", Pkcs12Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
