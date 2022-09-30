using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    /// <summary>Casts the previous resource to group.</summary>
    public class TeamInfo : Entity, IParsable {
        /// <summary>The name of the team.</summary>
        public string DisplayName { get; set; }
        /// <summary>The team property</summary>
        public ApiSdk.Models.Team Team { get; set; }
        /// <summary>The ID of the Azure Active Directory tenant.</summary>
        public string TenantId { get; set; }
        /// <summary>
        /// Instantiates a new teamInfo and sets the default values.
        /// </summary>
        public TeamInfo() : base() {
            OdataType = "#microsoft.graph.teamInfo";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new TeamInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.associatedTeamInfo" => new AssociatedTeamInfo(),
                "#microsoft.graph.sharedWithChannelTeamInfo" => new SharedWithChannelTeamInfo(),
                _ => new TeamInfo(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"team", n => { Team = n.GetObjectValue<ApiSdk.Models.Team>(ApiSdk.Models.Team.CreateFromDiscriminatorValue); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<ApiSdk.Models.Team>("team", Team);
            writer.WriteStringValue("tenantId", TenantId);
        }
    }
}
