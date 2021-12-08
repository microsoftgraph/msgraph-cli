using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ScoredEmailAddress : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The email address.</summary>
        public string Address { get; set; }
        public string ItemId { get; set; }
        /// <summary>The relevance score of the email address. A relevance score is used as a sort key, in relation to the other returned results. A higher relevance score value corresponds to a more relevant result. Relevance is determined by the user’s communication and collaboration patterns and business relationships.</summary>
        public double? RelevanceScore { get; set; }
        public SelectionLikelihoodInfo? SelectionLikelihood { get; set; }
        /// <summary>
        /// Instantiates a new scoredEmailAddress and sets the default values.
        /// </summary>
        public ScoredEmailAddress() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"address", (o,n) => { (o as ScoredEmailAddress).Address = n.GetStringValue(); } },
                {"itemId", (o,n) => { (o as ScoredEmailAddress).ItemId = n.GetStringValue(); } },
                {"relevanceScore", (o,n) => { (o as ScoredEmailAddress).RelevanceScore = n.GetDoubleValue(); } },
                {"selectionLikelihood", (o,n) => { (o as ScoredEmailAddress).SelectionLikelihood = n.GetEnumValue<SelectionLikelihoodInfo>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("address", Address);
            writer.WriteStringValue("itemId", ItemId);
            writer.WriteDoubleValue("relevanceScore", RelevanceScore);
            writer.WriteEnumValue<SelectionLikelihoodInfo>("selectionLikelihood", SelectionLikelihood);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
