using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class DelegatedPermissionClassification : Entity, IParsable {
        /// <summary>The classification value being given. Possible value: low. Does not support $filter.</summary>
        public PermissionClassificationType? Classification { get; set; }
        /// <summary>The unique identifier (id) for the delegated permission listed in the publishedPermissionScopes collection of the servicePrincipal. Required on create. Does not support $filter.</summary>
        public string PermissionId { get; set; }
        /// <summary>The claim value (value) for the delegated permission listed in the publishedPermissionScopes collection of the servicePrincipal. Does not support $filter.</summary>
        public string PermissionName { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"classification", (o,n) => { (o as DelegatedPermissionClassification).Classification = n.GetEnumValue<PermissionClassificationType>(); } },
                {"permissionId", (o,n) => { (o as DelegatedPermissionClassification).PermissionId = n.GetStringValue(); } },
                {"permissionName", (o,n) => { (o as DelegatedPermissionClassification).PermissionName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<PermissionClassificationType>("classification", Classification);
            writer.WriteStringValue("permissionId", PermissionId);
            writer.WriteStringValue("permissionName", PermissionName);
        }
    }
}
