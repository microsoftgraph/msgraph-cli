using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ItemActivity : Entity, IParsable {
        /// <summary>An item was accessed.</summary>
        public ApiSdk.Models.Microsoft.Graph.AccessAction Access { get; set; }
        /// <summary>Details about when the activity took place. Read-only.</summary>
        public DateTimeOffset? ActivityDateTime { get; set; }
        /// <summary>Identity of who performed the action. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.IdentitySet Actor { get; set; }
        /// <summary>Exposes the driveItem that was the target of this activity.</summary>
        public ApiSdk.Models.Microsoft.Graph.DriveItem DriveItem { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.ItemActivity CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ItemActivity();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"access", (o,n) => { (o as ItemActivity).Access = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.AccessAction>(ApiSdk.Models.Microsoft.Graph.AccessAction.CreateFromDiscriminatorValue); } },
                {"activityDateTime", (o,n) => { (o as ItemActivity).ActivityDateTime = n.GetDateTimeOffsetValue(); } },
                {"actor", (o,n) => { (o as ItemActivity).Actor = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.IdentitySet>(ApiSdk.Models.Microsoft.Graph.IdentitySet.CreateFromDiscriminatorValue); } },
                {"driveItem", (o,n) => { (o as ItemActivity).DriveItem = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.DriveItem>(ApiSdk.Models.Microsoft.Graph.DriveItem.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.AccessAction>("access", Access);
            writer.WriteDateTimeOffsetValue("activityDateTime", ActivityDateTime);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.IdentitySet>("actor", Actor);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.DriveItem>("driveItem", DriveItem);
        }
    }
}
