using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph.ExternalConnectors {
    public class Acl : IAdditionalDataHolder, IParsable {
        /// <summary>The access granted to the identity. Possible values are: grant, deny, unknownFutureValue.</summary>
        public ApiSdk.Models.Microsoft.Graph.ExternalConnectors.AccessType? AccessType { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The type of identity. Possible values are: user, group, everyone, everyoneExceptGuests, externalGroup, unknownFutureValue.</summary>
        public AclType? Type { get; set; }
        /// <summary>The unique identifer of the identity. In case of Azure Active Directory identities, value is set to the object identifier of the user, group or tenant for types user, group and everyone (and everyoneExceptGuests) respectively. In case of external groups value is set to the ID of the externalGroup</summary>
        public string Value { get; set; }
        /// <summary>
        /// Instantiates a new acl and sets the default values.
        /// </summary>
        public Acl() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.ExternalConnectors.Acl CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Acl();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"accessType", (o,n) => { (o as Acl).AccessType = n.GetEnumValue<AccessType>(); } },
                {"type", (o,n) => { (o as Acl).Type = n.GetEnumValue<AclType>(); } },
                {"value", (o,n) => { (o as Acl).Value = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<AccessType>("accessType", AccessType);
            writer.WriteEnumValue<AclType>("type", Type);
            writer.WriteStringValue("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
