using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class ScoredEmailAddress : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The email address.</summary>
        public string Address { get; set; }
        /// <summary>The itemId property</summary>
        public string ItemId { get; set; }
        /// <summary>The relevance score of the email address. A relevance score is used as a sort key, in relation to the other returned results. A higher relevance score value corresponds to a more relevant result. Relevance is determined by the user’s communication and collaboration patterns and business relationships.</summary>
        public double? RelevanceScore { get; set; }
        /// <summary>The selectionLikelihood property</summary>
        public SelectionLikelihoodInfo? SelectionLikelihood { get; set; }
        /// <summary>
        /// Instantiates a new scoredEmailAddress and sets the default values.
        /// </summary>
        public ScoredEmailAddress() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ScoredEmailAddress CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ScoredEmailAddress();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"address", n => { Address = n.GetStringValue(); } },
                {"itemId", n => { ItemId = n.GetStringValue(); } },
                {"relevanceScore", n => { RelevanceScore = n.GetDoubleValue(); } },
                {"selectionLikelihood", n => { SelectionLikelihood = n.GetEnumValue<SelectionLikelihoodInfo>(); } },
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
