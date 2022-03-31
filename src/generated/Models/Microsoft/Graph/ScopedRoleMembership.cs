using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ScopedRoleMembership : Entity, IParsable {
        /// <summary>Unique identifier for the administrative unit that the directory role is scoped to</summary>
        public string AdministrativeUnitId { get; set; }
        /// <summary>Unique identifier for the directory role that the member is in.</summary>
        public string RoleId { get; set; }
        public ApiSdk.Models.Microsoft.Graph.Identity RoleMemberInfo { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.ScopedRoleMembership CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ScopedRoleMembership();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"administrativeUnitId", (o,n) => { (o as ScopedRoleMembership).AdministrativeUnitId = n.GetStringValue(); } },
                {"roleId", (o,n) => { (o as ScopedRoleMembership).RoleId = n.GetStringValue(); } },
                {"roleMemberInfo", (o,n) => { (o as ScopedRoleMembership).RoleMemberInfo = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Identity>(ApiSdk.Models.Microsoft.Graph.Identity.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("administrativeUnitId", AdministrativeUnitId);
            writer.WriteStringValue("roleId", RoleId);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.Identity>("roleMemberInfo", RoleMemberInfo);
        }
    }
}
