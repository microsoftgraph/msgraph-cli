using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class CrossTenantAccessPolicyTarget : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>The unique identifier of the user, group, or application; one of the following keywords: AllUsers and AllApplications; or for targets that are applications, you may use reserved values.</summary>
        public string Target { get; set; }
        /// <summary>The type of resource that you want to target. The possible values are: user, group, application, unknownFutureValue.</summary>
        public CrossTenantAccessPolicyTargetType? TargetType { get; set; }
        /// <summary>
        /// Instantiates a new crossTenantAccessPolicyTarget and sets the default values.
        /// </summary>
        public CrossTenantAccessPolicyTarget() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.crossTenantAccessPolicyTarget";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CrossTenantAccessPolicyTarget CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CrossTenantAccessPolicyTarget();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"target", n => { Target = n.GetStringValue(); } },
                {"targetType", n => { TargetType = n.GetEnumValue<CrossTenantAccessPolicyTargetType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("target", Target);
            writer.WriteEnumValue<CrossTenantAccessPolicyTargetType>("targetType", TargetType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
