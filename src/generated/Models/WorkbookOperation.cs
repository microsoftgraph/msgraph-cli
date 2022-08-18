using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the auditLogRoot singleton.</summary>
    public class WorkbookOperation : Entity, IParsable {
        /// <summary>The error returned by the operation.</summary>
        public WorkbookOperationError Error { get; set; }
        /// <summary>The resource URI for the result.</summary>
        public string ResourceLocation { get; set; }
        /// <summary>The status property</summary>
        public WorkbookOperationStatus? Status { get; set; }
        /// <summary>
        /// Instantiates a new workbookOperation and sets the default values.
        /// </summary>
        public WorkbookOperation() : base() {
            OdataType = "#microsoft.graph.workbookOperation";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WorkbookOperation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkbookOperation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"error", n => { Error = n.GetObjectValue<WorkbookOperationError>(WorkbookOperationError.CreateFromDiscriminatorValue); } },
                {"resourceLocation", n => { ResourceLocation = n.GetStringValue(); } },
                {"status", n => { Status = n.GetEnumValue<WorkbookOperationStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<WorkbookOperationError>("error", Error);
            writer.WriteStringValue("resourceLocation", ResourceLocation);
            writer.WriteEnumValue<WorkbookOperationStatus>("status", Status);
        }
    }
}
