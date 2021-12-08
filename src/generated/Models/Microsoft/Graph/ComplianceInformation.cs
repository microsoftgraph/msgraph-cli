using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ComplianceInformation : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Collection of the certification controls associated with certification</summary>
        public List<CertificationControl> CertificationControls { get; set; }
        /// <summary>Compliance certification name (for example, ISO 27018:2014, GDPR, FedRAMP, NIST 800-171)</summary>
        public string CertificationName { get; set; }
        /// <summary>
        /// Instantiates a new complianceInformation and sets the default values.
        /// </summary>
        public ComplianceInformation() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"certificationControls", (o,n) => { (o as ComplianceInformation).CertificationControls = n.GetCollectionOfObjectValues<CertificationControl>().ToList(); } },
                {"certificationName", (o,n) => { (o as ComplianceInformation).CertificationName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<CertificationControl>("certificationControls", CertificationControls);
            writer.WriteStringValue("certificationName", CertificationName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
