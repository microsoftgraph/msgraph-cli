using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class IdentityProtection : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Risk detection in Azure AD Identity Protection and the associated information about the detection.</summary>
        public List<RiskDetection> RiskDetections { get; set; }
        /// <summary>Users that are flagged as at-risk by Azure AD Identity Protection.</summary>
        public List<RiskyUser> RiskyUsers { get; set; }
        /// <summary>
        /// Instantiates a new identityProtection and sets the default values.
        /// </summary>
        public IdentityProtection() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"riskDetections", (o,n) => { (o as IdentityProtection).RiskDetections = n.GetCollectionOfObjectValues<RiskDetection>().ToList(); } },
                {"riskyUsers", (o,n) => { (o as IdentityProtection).RiskyUsers = n.GetCollectionOfObjectValues<RiskyUser>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<RiskDetection>("riskDetections", RiskDetections);
            writer.WriteCollectionOfObjectValues<RiskyUser>("riskyUsers", RiskyUsers);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
