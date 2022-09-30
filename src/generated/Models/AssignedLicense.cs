using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class AssignedLicense : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A collection of the unique identifiers for plans that have been disabled.</summary>
        public List<string> DisabledPlans { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>The unique identifier for the SKU.</summary>
        public string SkuId { get; set; }
        /// <summary>
        /// Instantiates a new assignedLicense and sets the default values.
        /// </summary>
        public AssignedLicense() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.assignedLicense";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AssignedLicense CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AssignedLicense();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"disabledPlans", n => { DisabledPlans = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"skuId", n => { SkuId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("disabledPlans", DisabledPlans);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("skuId", SkuId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
