using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class SelfSignedCertificate : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Custom key identifier.</summary>
        public byte[] CustomKeyIdentifier { get; set; }
        /// <summary>The friendly name for the key.</summary>
        public string DisplayName { get; set; }
        /// <summary>The date and time at which the credential expires. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? EndDateTime { get; set; }
        /// <summary>The value for the key credential. Should be a base-64 encoded value.</summary>
        public byte[] Key { get; set; }
        /// <summary>The unique identifier (GUID) for the key.</summary>
        public string KeyId { get; set; }
        /// <summary>The date and time at which the credential becomes valid. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>The thumbprint value for the key.</summary>
        public string Thumbprint { get; set; }
        /// <summary>The type of key credential. 'AsymmetricX509Cert'.</summary>
        public string Type { get; set; }
        /// <summary>A string that describes the purpose for which the key can be used. For example, 'Verify'.</summary>
        public string Usage { get; set; }
        /// <summary>
        /// Instantiates a new SelfSignedCertificate and sets the default values.
        /// </summary>
        public SelfSignedCertificate() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.SelfSignedCertificate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SelfSignedCertificate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"customKeyIdentifier", (o,n) => { (o as SelfSignedCertificate).CustomKeyIdentifier = n.GetByteArrayValue(); } },
                {"displayName", (o,n) => { (o as SelfSignedCertificate).DisplayName = n.GetStringValue(); } },
                {"endDateTime", (o,n) => { (o as SelfSignedCertificate).EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"key", (o,n) => { (o as SelfSignedCertificate).Key = n.GetByteArrayValue(); } },
                {"keyId", (o,n) => { (o as SelfSignedCertificate).KeyId = n.GetStringValue(); } },
                {"startDateTime", (o,n) => { (o as SelfSignedCertificate).StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"thumbprint", (o,n) => { (o as SelfSignedCertificate).Thumbprint = n.GetStringValue(); } },
                {"type", (o,n) => { (o as SelfSignedCertificate).Type = n.GetStringValue(); } },
                {"usage", (o,n) => { (o as SelfSignedCertificate).Usage = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteByteArrayValue("customKeyIdentifier", CustomKeyIdentifier);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteByteArrayValue("key", Key);
            writer.WriteStringValue("keyId", KeyId);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteStringValue("thumbprint", Thumbprint);
            writer.WriteStringValue("type", Type);
            writer.WriteStringValue("usage", Usage);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
