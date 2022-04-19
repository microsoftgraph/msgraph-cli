using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class ScopedRoleMembership : Entity, IParsable {
        /// <summary>Unique identifier for the administrative unit that the directory role is scoped to</summary>
        public string AdministrativeUnitId { get; set; }
        /// <summary>Unique identifier for the directory role that the member is in.</summary>
        public string RoleId { get; set; }
        /// <summary>The roleMemberInfo property</summary>
        public Identity RoleMemberInfo { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ScopedRoleMembership CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ScopedRoleMembership();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"administrativeUnitId", n => { AdministrativeUnitId = n.GetStringValue(); } },
                {"roleId", n => { RoleId = n.GetStringValue(); } },
                {"roleMemberInfo", n => { RoleMemberInfo = n.GetObjectValue<Identity>(Identity.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<Identity>("roleMemberInfo", RoleMemberInfo);
        }
    }
}
