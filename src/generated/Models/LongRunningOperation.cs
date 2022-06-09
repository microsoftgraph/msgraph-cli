using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the collection of application entities.</summary>
    public class LongRunningOperation : Entity, IParsable {
        /// <summary>The createdDateTime property</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The lastActionDateTime property</summary>
        public DateTimeOffset? LastActionDateTime { get; set; }
        /// <summary>The resourceLocation property</summary>
        public string ResourceLocation { get; set; }
        /// <summary>The status property</summary>
        public LongRunningOperationStatus? Status { get; set; }
        /// <summary>The statusDetail property</summary>
        public string StatusDetail { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new LongRunningOperation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.richLongRunningOperation" => new RichLongRunningOperation(),
                _ => new LongRunningOperation(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastActionDateTime", n => { LastActionDateTime = n.GetDateTimeOffsetValue(); } },
                {"resourceLocation", n => { ResourceLocation = n.GetStringValue(); } },
                {"status", n => { Status = n.GetEnumValue<LongRunningOperationStatus>(); } },
                {"statusDetail", n => { StatusDetail = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteDateTimeOffsetValue("lastActionDateTime", LastActionDateTime);
            writer.WriteStringValue("resourceLocation", ResourceLocation);
            writer.WriteEnumValue<LongRunningOperationStatus>("status", Status);
            writer.WriteStringValue("statusDetail", StatusDetail);
        }
    }
}
