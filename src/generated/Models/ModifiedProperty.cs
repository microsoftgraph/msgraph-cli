using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class ModifiedProperty : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Indicates the property name of the target attribute that was changed.</summary>
        public string DisplayName { get; set; }
        /// <summary>Indicates the updated value for the propery.</summary>
        public string NewValue { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>Indicates the previous value (before the update) for the property.</summary>
        public string OldValue { get; set; }
        /// <summary>
        /// Instantiates a new modifiedProperty and sets the default values.
        /// </summary>
        public ModifiedProperty() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.modifiedProperty";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ModifiedProperty CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ModifiedProperty();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"newValue", n => { NewValue = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"oldValue", n => { OldValue = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("newValue", NewValue);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("oldValue", OldValue);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
