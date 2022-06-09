using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the print singleton.</summary>
    public class PrintTaskDefinition : Entity, IParsable {
        /// <summary>The createdBy property</summary>
        public AppIdentity CreatedBy { get; set; }
        /// <summary>The name of the printTaskDefinition.</summary>
        public string DisplayName { get; set; }
        /// <summary>A list of tasks that have been created based on this definition. The list includes currently running tasks and recently completed tasks. Read-only.</summary>
        public List<PrintTask> Tasks { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new PrintTaskDefinition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrintTaskDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"createdBy", n => { CreatedBy = n.GetObjectValue<AppIdentity>(AppIdentity.CreateFromDiscriminatorValue); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"tasks", n => { Tasks = n.GetCollectionOfObjectValues<PrintTask>(PrintTask.CreateFromDiscriminatorValue).ToList(); } },
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
