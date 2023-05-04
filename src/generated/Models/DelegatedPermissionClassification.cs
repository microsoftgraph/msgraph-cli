using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class DelegatedPermissionClassification : Entity, IParsable {
        /// <summary>The classification value being given. Possible value: low. Does not support $filter.</summary>
        public PermissionClassificationType? Classification { get; set; }
        /// <summary>The unique identifier (id) for the delegated permission listed in the oauth2PermissionScopes collection of the servicePrincipal. Required on create. Does not support $filter.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PermissionId { get; set; }
#nullable restore
#else
        public string PermissionId { get; set; }
#endif
        /// <summary>The claim value (value) for the delegated permission listed in the oauth2PermissionScopes collection of the servicePrincipal. Does not support $filter.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PermissionName { get; set; }
#nullable restore
#else
        public string PermissionName { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DelegatedPermissionClassification CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DelegatedPermissionClassification();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"classification", n => { Classification = n.GetEnumValue<PermissionClassificationType>(); } },
                {"permissionId", n => { PermissionId = n.GetStringValue(); } },
                {"permissionName", n => { PermissionName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<PermissionClassificationType>("classification", Classification);
            writer.WriteStringValue("permissionId", PermissionId);
            writer.WriteStringValue("permissionName", PermissionName);
        }
    }
}
