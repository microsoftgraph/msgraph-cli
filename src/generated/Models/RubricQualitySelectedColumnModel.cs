using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class RubricQualitySelectedColumnModel : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>ID of the selected level for this quality.</summary>
        public string ColumnId { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>ID of the associated quality.</summary>
        public string QualityId { get; set; }
        /// <summary>
        /// Instantiates a new rubricQualitySelectedColumnModel and sets the default values.
        /// </summary>
        public RubricQualitySelectedColumnModel() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.rubricQualitySelectedColumnModel";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static RubricQualitySelectedColumnModel CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RubricQualitySelectedColumnModel();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"columnId", n => { ColumnId = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"qualityId", n => { QualityId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("columnId", ColumnId);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("qualityId", QualityId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
