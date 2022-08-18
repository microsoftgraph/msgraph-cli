using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class PersonOrGroupColumn : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Indicates whether multiple values can be selected from the source.</summary>
        public bool? AllowMultipleSelection { get; set; }
        /// <summary>Whether to allow selection of people only, or people and groups. Must be one of peopleAndGroups or peopleOnly.</summary>
        public string ChooseFromType { get; set; }
        /// <summary>How to display the information about the person or group chosen. See below.</summary>
        public string DisplayAs { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>
        /// Instantiates a new personOrGroupColumn and sets the default values.
        /// </summary>
        public PersonOrGroupColumn() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.personOrGroupColumn";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static PersonOrGroupColumn CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PersonOrGroupColumn();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"allowMultipleSelection", n => { AllowMultipleSelection = n.GetBoolValue(); } },
                {"chooseFromType", n => { ChooseFromType = n.GetStringValue(); } },
                {"displayAs", n => { DisplayAs = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowMultipleSelection", AllowMultipleSelection);
            writer.WriteStringValue("chooseFromType", ChooseFromType);
            writer.WriteStringValue("displayAs", DisplayAs);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
