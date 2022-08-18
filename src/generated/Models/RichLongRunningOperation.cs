using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class RichLongRunningOperation : LongRunningOperation, IParsable {
        /// <summary>Error that caused the operation to fail.</summary>
        public PublicError Error { get; set; }
        /// <summary>A value between 0 and 100 that indicates the progress of the operation.</summary>
        public int? PercentageComplete { get; set; }
        /// <summary>The unique identifier for the result.</summary>
        public string ResourceId { get; set; }
        /// <summary>The type of the operation.</summary>
        public string Type { get; set; }
        /// <summary>
        /// Instantiates a new RichLongRunningOperation and sets the default values.
        /// </summary>
        public RichLongRunningOperation() : base() {
            OdataType = "#microsoft.graph.richLongRunningOperation";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new RichLongRunningOperation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RichLongRunningOperation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"error", n => { Error = n.GetObjectValue<PublicError>(PublicError.CreateFromDiscriminatorValue); } },
                {"percentageComplete", n => { PercentageComplete = n.GetIntValue(); } },
                {"resourceId", n => { ResourceId = n.GetStringValue(); } },
                {"type", n => { Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<PublicError>("error", Error);
            writer.WriteIntValue("percentageComplete", PercentageComplete);
            writer.WriteStringValue("resourceId", ResourceId);
            writer.WriteStringValue("type", Type);
        }
    }
}
