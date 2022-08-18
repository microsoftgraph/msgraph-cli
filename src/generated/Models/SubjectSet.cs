using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class SubjectSet : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>
        /// Instantiates a new subjectSet and sets the default values.
        /// </summary>
        public SubjectSet() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.subjectSet";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SubjectSet CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.attributeRuleMembers" => new AttributeRuleMembers(),
                "#microsoft.graph.connectedOrganizationMembers" => new ConnectedOrganizationMembers(),
                "#microsoft.graph.externalSponsors" => new ExternalSponsors(),
                "#microsoft.graph.groupMembers" => new GroupMembers(),
                "#microsoft.graph.internalSponsors" => new InternalSponsors(),
                "#microsoft.graph.requestorManager" => new RequestorManager(),
                "#microsoft.graph.singleServicePrincipal" => new SingleServicePrincipal(),
                "#microsoft.graph.singleUser" => new SingleUser(),
                "#microsoft.graph.targetApplicationOwners" => new TargetApplicationOwners(),
                "#microsoft.graph.targetManager" => new TargetManager(),
                _ => new SubjectSet(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
