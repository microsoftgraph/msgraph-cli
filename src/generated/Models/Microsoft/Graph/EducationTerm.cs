using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class EducationTerm : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Display name of the term.</summary>
        public string DisplayName { get; set; }
        /// <summary>End of the term.</summary>
        public string EndDate { get; set; }
        /// <summary>ID of term in the syncing system.</summary>
        public string ExternalId { get; set; }
        /// <summary>Start of the term.</summary>
        public string StartDate { get; set; }
        /// <summary>
        /// Instantiates a new educationTerm and sets the default values.
        /// </summary>
        public EducationTerm() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"displayName", (o,n) => { (o as EducationTerm).DisplayName = n.GetStringValue(); } },
                {"endDate", (o,n) => { (o as EducationTerm).EndDate = n.GetStringValue(); } },
                {"externalId", (o,n) => { (o as EducationTerm).ExternalId = n.GetStringValue(); } },
                {"startDate", (o,n) => { (o as EducationTerm).StartDate = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("endDate", EndDate);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteStringValue("startDate", StartDate);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
