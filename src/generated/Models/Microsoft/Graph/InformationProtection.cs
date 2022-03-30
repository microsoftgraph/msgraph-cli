using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the informationProtection singleton.</summary>
    public class InformationProtection : Entity, IParsable {
        public ApiSdk.Models.Microsoft.Graph.Bitlocker Bitlocker { get; set; }
        public List<ApiSdk.Models.Microsoft.Graph.ThreatAssessmentRequest> ThreatAssessmentRequests { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.InformationProtection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InformationProtection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"bitlocker", (o,n) => { (o as InformationProtection).Bitlocker = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Bitlocker>(ApiSdk.Models.Microsoft.Graph.Bitlocker.CreateFromDiscriminatorValue); } },
                {"threatAssessmentRequests", (o,n) => { (o as InformationProtection).ThreatAssessmentRequests = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ThreatAssessmentRequest>(ApiSdk.Models.Microsoft.Graph.ThreatAssessmentRequest.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.Bitlocker>("bitlocker", Bitlocker);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ThreatAssessmentRequest>("threatAssessmentRequests", ThreatAssessmentRequests);
        }
    }
}
