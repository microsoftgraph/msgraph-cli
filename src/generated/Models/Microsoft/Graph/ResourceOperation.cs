using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ResourceOperation : Entity, IParsable {
        /// <summary>Type of action this operation is going to perform. The actionName should be concise and limited to as few words as possible.</summary>
        public string ActionName { get; set; }
        /// <summary>Description of the resource operation. The description is used in mouse-over text for the operation when shown in the Azure Portal.</summary>
        public string Description { get; set; }
        /// <summary>Name of the Resource this operation is performed on.</summary>
        public string ResourceName { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"actionName", (o,n) => { (o as ResourceOperation).ActionName = n.GetStringValue(); } },
                {"description", (o,n) => { (o as ResourceOperation).Description = n.GetStringValue(); } },
                {"resourceName", (o,n) => { (o as ResourceOperation).ResourceName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("actionName", ActionName);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("resourceName", ResourceName);
        }
    }
}
