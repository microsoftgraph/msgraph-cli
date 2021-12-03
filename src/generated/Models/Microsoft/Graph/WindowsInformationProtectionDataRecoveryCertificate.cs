using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class WindowsInformationProtectionDataRecoveryCertificate : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Data recovery Certificate</summary>
        public byte[] Certificate { get; set; }
        /// <summary>Data recovery Certificate description</summary>
        public string Description { get; set; }
        /// <summary>Data recovery Certificate expiration datetime</summary>
        public DateTimeOffset? ExpirationDateTime { get; set; }
        /// <summary>Data recovery Certificate subject name</summary>
        public string SubjectName { get; set; }
        /// <summary>
        /// Instantiates a new windowsInformationProtectionDataRecoveryCertificate and sets the default values.
        /// </summary>
        public WindowsInformationProtectionDataRecoveryCertificate() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"certificate", (o,n) => { (o as WindowsInformationProtectionDataRecoveryCertificate).Certificate = n.GetByteArrayValue(); } },
                {"description", (o,n) => { (o as WindowsInformationProtectionDataRecoveryCertificate).Description = n.GetStringValue(); } },
                {"expirationDateTime", (o,n) => { (o as WindowsInformationProtectionDataRecoveryCertificate).ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"subjectName", (o,n) => { (o as WindowsInformationProtectionDataRecoveryCertificate).SubjectName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteByteArrayValue("certificate", Certificate);
            writer.WriteStringValue("description", Description);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteStringValue("subjectName", SubjectName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
