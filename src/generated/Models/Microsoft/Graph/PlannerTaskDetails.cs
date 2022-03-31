using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class PlannerTaskDetails : Entity, IParsable {
        /// <summary>The collection of checklist items on the task.</summary>
        public ApiSdk.Models.Microsoft.Graph.PlannerChecklistItems Checklist { get; set; }
        /// <summary>Description of the task.</summary>
        public string Description { get; set; }
        /// <summary>This sets the type of preview that shows up on the task. The possible values are: automatic, noPreview, checklist, description, reference. When set to automatic the displayed preview is chosen by the app viewing the task.</summary>
        public PlannerPreviewType? PreviewType { get; set; }
        /// <summary>The collection of references on the task.</summary>
        public ApiSdk.Models.Microsoft.Graph.PlannerExternalReferences References { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.PlannerTaskDetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PlannerTaskDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"checklist", (o,n) => { (o as PlannerTaskDetails).Checklist = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.PlannerChecklistItems>(ApiSdk.Models.Microsoft.Graph.PlannerChecklistItems.CreateFromDiscriminatorValue); } },
                {"description", (o,n) => { (o as PlannerTaskDetails).Description = n.GetStringValue(); } },
                {"previewType", (o,n) => { (o as PlannerTaskDetails).PreviewType = n.GetEnumValue<PlannerPreviewType>(); } },
                {"references", (o,n) => { (o as PlannerTaskDetails).References = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.PlannerExternalReferences>(ApiSdk.Models.Microsoft.Graph.PlannerExternalReferences.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.PlannerChecklistItems>("checklist", Checklist);
            writer.WriteStringValue("description", Description);
            writer.WriteEnumValue<PlannerPreviewType>("previewType", PreviewType);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.PlannerExternalReferences>("references", References);
        }
    }
}
