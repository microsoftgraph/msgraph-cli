using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the auditLogRoot singleton.</summary>
    public class SchedulingGroup : ChangeTrackedEntity, IParsable {
        /// <summary>The display name for the schedulingGroup. Required.</summary>
        public string DisplayName { get; set; }
        /// <summary>Indicates whether the schedulingGroup can be used when creating new entities or updating existing ones. Required.</summary>
        public bool? IsActive { get; set; }
        /// <summary>The list of user IDs that are a member of the schedulingGroup. Required.</summary>
        public List<string> UserIds { get; set; }
        /// <summary>
        /// Instantiates a new schedulingGroup and sets the default values.
        /// </summary>
        public SchedulingGroup() : base() {
            OdataType = "#microsoft.graph.schedulingGroup";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new SchedulingGroup CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SchedulingGroup();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"isActive", n => { IsActive = n.GetBoolValue(); } },
                {"userIds", n => { UserIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
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
            writer.WriteBoolValue("isActive", IsActive);
            writer.WriteCollectionOfPrimitiveValues<string>("userIds", UserIds);
        }
    }
}
