using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class TargetResource : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Indicates the visible name defined for the resource. Typically specified when the resource is created.</summary>
        public string DisplayName { get; set; }
        /// <summary>When type is set to Group, this indicates the group type. Possible values are: unifiedGroups, azureAD, and unknownFutureValue</summary>
        public ApiSdk.Models.GroupType? GroupType { get; set; }
        /// <summary>Indicates the unique ID of the resource.</summary>
        public string Id { get; set; }
        /// <summary>Indicates name, old value and new value of each attribute that changed. Property values depend on the operation type.</summary>
        public List<ModifiedProperty> ModifiedProperties { get; set; }
        /// <summary>Describes the resource type.  Example values include Application, Group, ServicePrincipal, and User.</summary>
        public string Type { get; set; }
        /// <summary>When type is set to User, this includes the user name that initiated the action; null for other types.</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>
        /// Instantiates a new targetResource and sets the default values.
        /// </summary>
        public TargetResource() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TargetResource CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TargetResource();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"groupType", n => { GroupType = n.GetEnumValue<GroupType>(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"modifiedProperties", n => { ModifiedProperties = n.GetCollectionOfObjectValues<ModifiedProperty>(ModifiedProperty.CreateFromDiscriminatorValue).ToList(); } },
                {"type", n => { Type = n.GetStringValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<GroupType>("groupType", GroupType);
            writer.WriteStringValue("id", Id);
            writer.WriteCollectionOfObjectValues<ModifiedProperty>("modifiedProperties", ModifiedProperties);
            writer.WriteStringValue("type", Type);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
