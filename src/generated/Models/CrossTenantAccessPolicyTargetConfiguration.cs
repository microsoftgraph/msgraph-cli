using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class CrossTenantAccessPolicyTargetConfiguration : IAdditionalDataHolder, IParsable {
        /// <summary>Defines whether access is allowed or blocked. The possible values are: allowed, blocked, unknownFutureValue.</summary>
        public CrossTenantAccessPolicyTargetConfigurationAccessType? AccessType { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>Specifies whether to target users, groups, or applications with this rule.</summary>
        public List<CrossTenantAccessPolicyTarget> Targets { get; set; }
        /// <summary>
        /// Instantiates a new crossTenantAccessPolicyTargetConfiguration and sets the default values.
        /// </summary>
        public CrossTenantAccessPolicyTargetConfiguration() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.crossTenantAccessPolicyTargetConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CrossTenantAccessPolicyTargetConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CrossTenantAccessPolicyTargetConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"accessType", n => { AccessType = n.GetEnumValue<CrossTenantAccessPolicyTargetConfigurationAccessType>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"targets", n => { Targets = n.GetCollectionOfObjectValues<CrossTenantAccessPolicyTarget>(CrossTenantAccessPolicyTarget.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<CrossTenantAccessPolicyTargetConfigurationAccessType>("accessType", AccessType);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<CrossTenantAccessPolicyTarget>("targets", Targets);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
