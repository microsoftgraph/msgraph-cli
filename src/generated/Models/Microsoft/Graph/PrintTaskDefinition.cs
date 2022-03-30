using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class PrintTaskDefinition : Entity, IParsable {
        public ApiSdk.Models.Microsoft.Graph.AppIdentity CreatedBy { get; set; }
        /// <summary>The name of the printTaskDefinition.</summary>
        public string DisplayName { get; set; }
        /// <summary>A list of tasks that have been created based on this definition. The list includes currently running tasks and recently completed tasks. Read-only.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.PrintTask> Tasks { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.PrintTaskDefinition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrintTaskDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"createdBy", (o,n) => { (o as PrintTaskDefinition).CreatedBy = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.AppIdentity>(ApiSdk.Models.Microsoft.Graph.AppIdentity.CreateFromDiscriminatorValue); } },
                {"displayName", (o,n) => { (o as PrintTaskDefinition).DisplayName = n.GetStringValue(); } },
                {"tasks", (o,n) => { (o as PrintTaskDefinition).Tasks = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.PrintTask>(ApiSdk.Models.Microsoft.Graph.PrintTask.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.AppIdentity>("createdBy", CreatedBy);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.PrintTask>("tasks", Tasks);
        }
    }
}
