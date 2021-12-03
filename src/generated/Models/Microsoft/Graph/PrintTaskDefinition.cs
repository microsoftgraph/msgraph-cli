using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class PrintTaskDefinition : Entity, IParsable {
        public AppIdentity CreatedBy { get; set; }
        /// <summary>The name of the printTaskDefinition.</summary>
        public string DisplayName { get; set; }
        /// <summary>A list of tasks that have been created based on this definition. The list includes currently running tasks and recently completed tasks. Read-only.</summary>
        public List<PrintTask> Tasks { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"createdBy", (o,n) => { (o as PrintTaskDefinition).CreatedBy = n.GetObjectValue<AppIdentity>(); } },
                {"displayName", (o,n) => { (o as PrintTaskDefinition).DisplayName = n.GetStringValue(); } },
                {"tasks", (o,n) => { (o as PrintTaskDefinition).Tasks = n.GetCollectionOfObjectValues<PrintTask>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<AppIdentity>("createdBy", CreatedBy);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<PrintTask>("tasks", Tasks);
        }
    }
}
