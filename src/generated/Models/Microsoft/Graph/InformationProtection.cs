using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class InformationProtection : Entity, IParsable {
        public Bitlocker Bitlocker { get; set; }
        public List<ThreatAssessmentRequest> ThreatAssessmentRequests { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"bitlocker", (o,n) => { (o as InformationProtection).Bitlocker = n.GetObjectValue<Bitlocker>(); } },
                {"threatAssessmentRequests", (o,n) => { (o as InformationProtection).ThreatAssessmentRequests = n.GetCollectionOfObjectValues<ThreatAssessmentRequest>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Bitlocker>("bitlocker", Bitlocker);
            writer.WriteCollectionOfObjectValues<ThreatAssessmentRequest>("threatAssessmentRequests", ThreatAssessmentRequests);
        }
    }
}
