using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ItemActivityStat : Entity, IParsable {
        /// <summary>Statistics about the access actions in this interval. Read-only.</summary>
        public ItemActionStat Access { get; set; }
        /// <summary>Exposes the itemActivities represented in this itemActivityStat resource.</summary>
        public List<ItemActivity> Activities { get; set; }
        /// <summary>Statistics about the create actions in this interval. Read-only.</summary>
        public ItemActionStat Create { get; set; }
        /// <summary>Statistics about the delete actions in this interval. Read-only.</summary>
        public ItemActionStat Delete { get; set; }
        /// <summary>Statistics about the edit actions in this interval. Read-only.</summary>
        public ItemActionStat Edit { get; set; }
        /// <summary>When the interval ends. Read-only.</summary>
        public DateTimeOffset? EndDateTime { get; set; }
        /// <summary>Indicates that the statistics in this interval are based on incomplete data. Read-only.</summary>
        public IncompleteData IncompleteData { get; set; }
        /// <summary>Indicates whether the item is 'trending.' Read-only.</summary>
        public bool? IsTrending { get; set; }
        /// <summary>Statistics about the move actions in this interval. Read-only.</summary>
        public ItemActionStat Move { get; set; }
        /// <summary>When the interval starts. Read-only.</summary>
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"access", (o,n) => { (o as ItemActivityStat).Access = n.GetObjectValue<ItemActionStat>(); } },
                {"activities", (o,n) => { (o as ItemActivityStat).Activities = n.GetCollectionOfObjectValues<ItemActivity>().ToList(); } },
                {"create", (o,n) => { (o as ItemActivityStat).Create = n.GetObjectValue<ItemActionStat>(); } },
                {"delete", (o,n) => { (o as ItemActivityStat).Delete = n.GetObjectValue<ItemActionStat>(); } },
                {"edit", (o,n) => { (o as ItemActivityStat).Edit = n.GetObjectValue<ItemActionStat>(); } },
                {"endDateTime", (o,n) => { (o as ItemActivityStat).EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"incompleteData", (o,n) => { (o as ItemActivityStat).IncompleteData = n.GetObjectValue<IncompleteData>(); } },
                {"isTrending", (o,n) => { (o as ItemActivityStat).IsTrending = n.GetBoolValue(); } },
                {"move", (o,n) => { (o as ItemActivityStat).Move = n.GetObjectValue<ItemActionStat>(); } },
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
            writer.WriteObjectValue<ItemActionStat>("access", Access);
            writer.WriteCollectionOfObjectValues<ItemActivity>("activities", Activities);
            writer.WriteObjectValue<ItemActionStat>("create", Create);
            writer.WriteObjectValue<ItemActionStat>("delete", Delete);
            writer.WriteObjectValue<ItemActionStat>("edit", Edit);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteObjectValue<IncompleteData>("incompleteData", IncompleteData);
            writer.WriteBoolValue("isTrending", IsTrending);
            writer.WriteObjectValue<ItemActionStat>("move", Move);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
        }
    }
}
