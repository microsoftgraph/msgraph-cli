using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class TargetResource : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Indicates the visible name defined for the resource. Typically specified when the resource is created.</summary>
        public string DisplayName { get; set; }
        /// <summary>When type is set to Group, this indicates the group type.  Possible values are: unifiedGroups, azureAD, and unknownFutureValue</summary>
        public GroupType? GroupType { get; set; }
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
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"displayName", (o,n) => { (o as TargetResource).DisplayName = n.GetStringValue(); } },
                {"groupType", (o,n) => { (o as TargetResource).GroupType = n.GetEnumValue<GroupType>(); } },
                {"id", (o,n) => { (o as TargetResource).Id = n.GetStringValue(); } },
                {"modifiedProperties", (o,n) => { (o as TargetResource).ModifiedProperties = n.GetCollectionOfObjectValues<ModifiedProperty>().ToList(); } },
                {"type", (o,n) => { (o as TargetResource).Type = n.GetStringValue(); } },
                {"userPrincipalName", (o,n) => { (o as TargetResource).UserPrincipalName = n.GetStringValue(); } },
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
