using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the collection of application entities.</summary>
    public class SharedInsight : Entity, IParsable {
        /// <summary>Details about the shared item. Read only.</summary>
        public SharingDetail LastShared { get; set; }
        /// <summary>The lastSharedMethod property</summary>
        public Entity LastSharedMethod { get; set; }
        /// <summary>Used for navigating to the item that was shared. For file attachments, the type is fileAttachment. For linked attachments, the type is driveItem.</summary>
        public Entity Resource { get; set; }
        /// <summary>Reference properties of the shared document, such as the url and type of the document. Read-only</summary>
        public ApiSdk.Models.ResourceReference ResourceReference { get; set; }
        /// <summary>Properties that you can use to visualize the document in your experience. Read-only</summary>
        public ApiSdk.Models.ResourceVisualization ResourceVisualization { get; set; }
        /// <summary>The sharingHistory property</summary>
        public List<SharingDetail> SharingHistory { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new SharedInsight CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SharedInsight();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"lastShared", n => { LastShared = n.GetObjectValue<SharingDetail>(SharingDetail.CreateFromDiscriminatorValue); } },
                {"lastSharedMethod", n => { LastSharedMethod = n.GetObjectValue<Entity>(Entity.CreateFromDiscriminatorValue); } },
                {"resource", n => { Resource = n.GetObjectValue<Entity>(Entity.CreateFromDiscriminatorValue); } },
                {"resourceReference", n => { ResourceReference = n.GetObjectValue<ApiSdk.Models.ResourceReference>(ApiSdk.Models.ResourceReference.CreateFromDiscriminatorValue); } },
                {"resourceVisualization", n => { ResourceVisualization = n.GetObjectValue<ApiSdk.Models.ResourceVisualization>(ApiSdk.Models.ResourceVisualization.CreateFromDiscriminatorValue); } },
                {"sharingHistory", n => { SharingHistory = n.GetCollectionOfObjectValues<SharingDetail>(SharingDetail.CreateFromDiscriminatorValue).ToList(); } },
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
            writer.WriteObjectValue<ApiSdk.Models.ResourceReference>("resourceReference", ResourceReference);
            writer.WriteObjectValue<ApiSdk.Models.ResourceVisualization>("resourceVisualization", ResourceVisualization);
            writer.WriteCollectionOfObjectValues<SharingDetail>("sharingHistory", SharingHistory);
        }
    }
}
