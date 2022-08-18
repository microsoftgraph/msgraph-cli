using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class SigningCertificateUpdateStatus : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Status of the last certificate update. Read-only. For a list of statuses, see certificateUpdateResult status.</summary>
        public string CertificateUpdateResult { get; set; }
        /// <summary>Date and time in ISO 8601 format and in UTC time when the certificate was last updated. Read-only.</summary>
        public DateTimeOffset? LastRunDateTime { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>
        /// Instantiates a new signingCertificateUpdateStatus and sets the default values.
        /// </summary>
        public SigningCertificateUpdateStatus() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.signingCertificateUpdateStatus";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SigningCertificateUpdateStatus CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SigningCertificateUpdateStatus();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"certificateUpdateResult", n => { CertificateUpdateResult = n.GetStringValue(); } },
                {"lastRunDateTime", n => { LastRunDateTime = n.GetDateTimeOffsetValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("certificateUpdateResult", CertificateUpdateResult);
            writer.WriteDateTimeOffsetValue("lastRunDateTime", LastRunDateTime);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
