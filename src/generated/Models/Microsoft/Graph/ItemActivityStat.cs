using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ItemActivityStat : Entity, IParsable {
        /// <summary>Statistics about the access actions in this interval. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.ItemActionStat Access { get; set; }
        /// <summary>Exposes the itemActivities represented in this itemActivityStat resource.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.ItemActivity> Activities { get; set; }
        /// <summary>Statistics about the create actions in this interval. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.ItemActionStat Create { get; set; }
        /// <summary>Statistics about the delete actions in this interval. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.ItemActionStat Delete { get; set; }
        /// <summary>Statistics about the edit actions in this interval. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.ItemActionStat Edit { get; set; }
        /// <summary>When the interval ends. Read-only.</summary>
        public DateTimeOffset? EndDateTime { get; set; }
        /// <summary>Indicates that the statistics in this interval are based on incomplete data. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.IncompleteData IncompleteData { get; set; }
        /// <summary>Indicates whether the item is 'trending.' Read-only.</summary>
        public bool? IsTrending { get; set; }
        /// <summary>Statistics about the move actions in this interval. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.ItemActionStat Move { get; set; }
        /// <summary>When the interval starts. Read-only.</summary>
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.ItemActivityStat CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ItemActivityStat();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"access", (o,n) => { (o as ItemActivityStat).Access = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ItemActionStat>(ApiSdk.Models.Microsoft.Graph.ItemActionStat.CreateFromDiscriminatorValue); } },
                {"activities", (o,n) => { (o as ItemActivityStat).Activities = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ItemActivity>(ApiSdk.Models.Microsoft.Graph.ItemActivity.CreateFromDiscriminatorValue).ToList(); } },
                {"create", (o,n) => { (o as ItemActivityStat).Create = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ItemActionStat>(ApiSdk.Models.Microsoft.Graph.ItemActionStat.CreateFromDiscriminatorValue); } },
                {"delete", (o,n) => { (o as ItemActivityStat).Delete = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ItemActionStat>(ApiSdk.Models.Microsoft.Graph.ItemActionStat.CreateFromDiscriminatorValue); } },
                {"edit", (o,n) => { (o as ItemActivityStat).Edit = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ItemActionStat>(ApiSdk.Models.Microsoft.Graph.ItemActionStat.CreateFromDiscriminatorValue); } },
                {"endDateTime", (o,n) => { (o as ItemActivityStat).EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"incompleteData", (o,n) => { (o as ItemActivityStat).IncompleteData = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.IncompleteData>(ApiSdk.Models.Microsoft.Graph.IncompleteData.CreateFromDiscriminatorValue); } },
                {"isTrending", (o,n) => { (o as ItemActivityStat).IsTrending = n.GetBoolValue(); } },
                {"move", (o,n) => { (o as ItemActivityStat).Move = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ItemActionStat>(ApiSdk.Models.Microsoft.Graph.ItemActionStat.CreateFromDiscriminatorValue); } },
                {"startDateTime", (o,n) => { (o as ItemActivityStat).StartDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ItemActionStat>("access", Access);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ItemActivity>("activities", Activities);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ItemActionStat>("create", Create);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ItemActionStat>("delete", Delete);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ItemActionStat>("edit", Edit);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.IncompleteData>("incompleteData", IncompleteData);
            writer.WriteBoolValue("isTrending", IsTrending);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ItemActionStat>("move", Move);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
        }
    }
}
