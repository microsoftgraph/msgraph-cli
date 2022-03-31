using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Identity.ApiConnectors.Item.UploadClientCertificate {
    /// <summary>Provides operations to call the uploadClientCertificate method.</summary>
    public class UploadClientCertificateRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string Password { get; set; }
        public string Pkcs12Value { get; set; }
        /// <summary>
        /// Instantiates a new uploadClientCertificateRequestBody and sets the default values.
        /// </summary>
        public UploadClientCertificateRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Identity.ApiConnectors.Item.UploadClientCertificate.UploadClientCertificateRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UploadClientCertificateRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"password", (o,n) => { (o as UploadClientCertificateRequestBody).Password = n.GetStringValue(); } },
                {"pkcs12Value", (o,n) => { (o as UploadClientCertificateRequestBody).Pkcs12Value = n.GetStringValue(); } },
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
