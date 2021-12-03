using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class VisualInfo : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Optional. JSON object used to represent an icon which represents the application used to generate the activity</summary>
        public ImageInfo Attribution { get; set; }
        /// <summary>Optional. Background color used to render the activity in the UI - brand color for the application source of the activity. Must be a valid hex color</summary>
        public string BackgroundColor { get; set; }
        /// <summary>Optional. Custom piece of data - JSON object used to provide custom content to render the activity in the Windows Shell UI</summary>
        public Json Content { get; set; }
        /// <summary>Optional. Longer text description of the user's unique activity (example: document name, first sentence, and/or metadata)</summary>
        public string Description { get; set; }
        /// <summary>Required. Short text description of the user's unique activity (for example, document name in cases where an activity refers to document creation)</summary>
        public string DisplayText { get; set; }
        /// <summary>
        /// Instantiates a new visualInfo and sets the default values.
        /// </summary>
        public VisualInfo() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"attribution", (o,n) => { (o as VisualInfo).Attribution = n.GetObjectValue<ImageInfo>(); } },
                {"backgroundColor", (o,n) => { (o as VisualInfo).BackgroundColor = n.GetStringValue(); } },
                {"content", (o,n) => { (o as VisualInfo).Content = n.GetObjectValue<Json>(); } },
                {"description", (o,n) => { (o as VisualInfo).Description = n.GetStringValue(); } },
                {"displayText", (o,n) => { (o as VisualInfo).DisplayText = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ImageInfo>("attribution", Attribution);
            writer.WriteStringValue("backgroundColor", BackgroundColor);
            writer.WriteObjectValue<Json>("content", Content);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayText", DisplayText);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
