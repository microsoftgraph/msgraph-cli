using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class EducationTerm : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Display name of the term.</summary>
        public string DisplayName { get; set; }
        /// <summary>End of the term.</summary>
        public Date? EndDate { get; set; }
        /// <summary>ID of term in the syncing system.</summary>
        public string ExternalId { get; set; }
        /// <summary>Start of the term.</summary>
        public Date? StartDate { get; set; }
        /// <summary>
        /// Instantiates a new educationTerm and sets the default values.
        /// </summary>
        public EducationTerm() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.EducationTerm CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationTerm();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"displayName", (o,n) => { (o as EducationTerm).DisplayName = n.GetStringValue(); } },
                {"endDate", (o,n) => { (o as EducationTerm).EndDate = n.GetDateValue(); } },
                {"externalId", (o,n) => { (o as EducationTerm).ExternalId = n.GetStringValue(); } },
                {"startDate", (o,n) => { (o as EducationTerm).StartDate = n.GetDateValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateValue("endDate", EndDate);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteDateValue("startDate", StartDate);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
