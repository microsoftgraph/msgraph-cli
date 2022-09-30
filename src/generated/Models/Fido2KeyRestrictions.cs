using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class Fido2KeyRestrictions : IAdditionalDataHolder, IParsable {
        /// <summary>A collection of Authenticator Attestation GUIDs. AADGUIDs define key types and manufacturers.</summary>
        public List<string> AaGuids { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Enforcement type. Possible values are: allow, block.</summary>
        public Fido2RestrictionEnforcementType? EnforcementType { get; set; }
        /// <summary>Determines if the configured key enforcement is enabled.</summary>
        public bool? IsEnforced { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>
        /// Instantiates a new fido2KeyRestrictions and sets the default values.
        /// </summary>
        public Fido2KeyRestrictions() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.fido2KeyRestrictions";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static Fido2KeyRestrictions CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Fido2KeyRestrictions();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"aaGuids", n => { AaGuids = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"enforcementType", n => { EnforcementType = n.GetEnumValue<Fido2RestrictionEnforcementType>(); } },
                {"isEnforced", n => { IsEnforced = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("aaGuids", AaGuids);
            writer.WriteEnumValue<Fido2RestrictionEnforcementType>("enforcementType", EnforcementType);
            writer.WriteBoolValue("isEnforced", IsEnforced);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
