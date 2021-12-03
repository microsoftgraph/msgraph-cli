using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class SharedInsight : Entity, IParsable {
        /// <summary>Details about the shared item. Read only.</summary>
        public SharingDetail LastShared { get; set; }
        public Entity LastSharedMethod { get; set; }
        /// <summary>Used for navigating to the item that was shared. For file attachments, the type is fileAttachment. For linked attachments, the type is driveItem.</summary>
        public Entity Resource { get; set; }
        /// <summary>Reference properties of the shared document, such as the url and type of the document. Read-only</summary>
        public ResourceReference ResourceReference { get; set; }
        /// <summary>Properties that you can use to visualize the document in your experience. Read-only</summary>
        public ResourceVisualization ResourceVisualization { get; set; }
        public List<SharingDetail> SharingHistory { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"lastShared", (o,n) => { (o as SharedInsight).LastShared = n.GetObjectValue<SharingDetail>(); } },
                {"lastSharedMethod", (o,n) => { (o as SharedInsight).LastSharedMethod = n.GetObjectValue<Entity>(); } },
                {"resource", (o,n) => { (o as SharedInsight).Resource = n.GetObjectValue<Entity>(); } },
                {"resourceReference", (o,n) => { (o as SharedInsight).ResourceReference = n.GetObjectValue<ResourceReference>(); } },
                {"resourceVisualization", (o,n) => { (o as SharedInsight).ResourceVisualization = n.GetObjectValue<ResourceVisualization>(); } },
                {"sharingHistory", (o,n) => { (o as SharedInsight).SharingHistory = n.GetCollectionOfObjectValues<SharingDetail>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<SharingDetail>("lastShared", LastShared);
            writer.WriteObjectValue<Entity>("lastSharedMethod", LastSharedMethod);
            writer.WriteObjectValue<Entity>("resource", Resource);
            writer.WriteObjectValue<ResourceReference>("resourceReference", ResourceReference);
            writer.WriteObjectValue<ResourceVisualization>("resourceVisualization", ResourceVisualization);
            writer.WriteCollectionOfObjectValues<SharingDetail>("sharingHistory", SharingHistory);
        }
    }
}
