using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.Security {
    public class RedundancyDetectionSettings : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Indicates whether email threading and near duplicate detection are enabled.</summary>
        public bool? IsEnabled { get; set; }
        /// <summary>Specifies the maximum number of words used for email threading and near duplicate detection. To learn more, see Minimum/maximum number of words.</summary>
        public int? MaxWords { get; set; }
        /// <summary>Specifies the minimum number of words used for email threading and near duplicate detection. To learn more, see Minimum/maximum number of words.</summary>
        public int? MinWords { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Specifies the similarity level for documents to be put in the same near duplicate set. To learn more, see Document and email similarity threshold.</summary>
        public int? SimilarityThreshold { get; set; }
        /// <summary>
        /// Instantiates a new redundancyDetectionSettings and sets the default values.
        /// </summary>
        public RedundancyDetectionSettings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RedundancyDetectionSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RedundancyDetectionSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
                {"maxWords", n => { MaxWords = n.GetIntValue(); } },
                {"minWords", n => { MinWords = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"similarityThreshold", n => { SimilarityThreshold = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteIntValue("maxWords", MaxWords);
            writer.WriteIntValue("minWords", MinWords);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("similarityThreshold", SimilarityThreshold);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
