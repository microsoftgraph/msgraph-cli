using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class OnenotePatchContentCommand : IParsable {
        /// <summary>The action to perform on the target element. Possible values are: replace, append, delete, insert, or prepend.</summary>
        public OnenotePatchActionType? Action { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A string of well-formed HTML to add to the page, and any image or file binary data. If the content contains binary data, the request must be sent using the multipart/form-data content type with a 'Commands' part.</summary>
        public string Content { get; set; }
        /// <summary>The location to add the supplied content, relative to the target element. Possible values are: after (default) or before.</summary>
        public OnenotePatchInsertPosition? Position { get; set; }
        /// <summary>The element to update. Must be the #<data-id> or the generated {id} of the element, or the body or title keyword.</summary>
        public string Target { get; set; }
        /// <summary>
        /// Instantiates a new onenotePatchContentCommand and sets the default values.
        /// </summary>
        public OnenotePatchContentCommand() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"action", (o,n) => { (o as OnenotePatchContentCommand).Action = n.GetEnumValue<OnenotePatchActionType>(); } },
                {"content", (o,n) => { (o as OnenotePatchContentCommand).Content = n.GetStringValue(); } },
                {"position", (o,n) => { (o as OnenotePatchContentCommand).Position = n.GetEnumValue<OnenotePatchInsertPosition>(); } },
                {"target", (o,n) => { (o as OnenotePatchContentCommand).Target = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<OnenotePatchActionType>("action", Action);
            writer.WriteStringValue("content", Content);
            writer.WriteEnumValue<OnenotePatchInsertPosition>("position", Position);
            writer.WriteStringValue("target", Target);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
