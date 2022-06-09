using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.ExternalConnectors {
    /// <summary>Provides operations to manage the collection of externalConnection entities.</summary>
    public class ExternalConnection : Entity, IParsable {
        /// <summary>Specifies additional application IDs that are allowed to manage the connection and to index content in the connection. Optional.</summary>
        public ApiSdk.Models.ExternalConnectors.Configuration Configuration { get; set; }
        /// <summary>Description of the connection displayed in the Microsoft 365 admin center. Optional.</summary>
        public string Description { get; set; }
        /// <summary>The groups property</summary>
        public List<ExternalGroup> Groups { get; set; }
        /// <summary>The items property</summary>
        public List<ExternalItem> Items { get; set; }
        /// <summary>The display name of the connection to be displayed in the Microsoft 365 admin center. Maximum length of 128 characters. Required.</summary>
        public string Name { get; set; }
        /// <summary>The operations property</summary>
        public List<ConnectionOperation> Operations { get; set; }
        /// <summary>The schema property</summary>
        public ApiSdk.Models.ExternalConnectors.Schema Schema { get; set; }
        /// <summary>Indicates the current state of the connection. Possible values are draft, ready, obsolete, and limitExceeded. Required.</summary>
        public ConnectionState? State { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ExternalConnection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExternalConnection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"configuration", n => { Configuration = n.GetObjectValue<ApiSdk.Models.ExternalConnectors.Configuration>(ApiSdk.Models.ExternalConnectors.Configuration.CreateFromDiscriminatorValue); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"groups", n => { Groups = n.GetCollectionOfObjectValues<ExternalGroup>(ExternalGroup.CreateFromDiscriminatorValue).ToList(); } },
                {"items", n => { Items = n.GetCollectionOfObjectValues<ExternalItem>(ExternalItem.CreateFromDiscriminatorValue).ToList(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"operations", n => { Operations = n.GetCollectionOfObjectValues<ConnectionOperation>(ConnectionOperation.CreateFromDiscriminatorValue).ToList(); } },
                {"schema", n => { Schema = n.GetObjectValue<ApiSdk.Models.ExternalConnectors.Schema>(ApiSdk.Models.ExternalConnectors.Schema.CreateFromDiscriminatorValue); } },
                {"state", n => { State = n.GetEnumValue<ConnectionState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ApiSdk.Models.ExternalConnectors.Configuration>("configuration", Configuration);
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfObjectValues<ExternalGroup>("groups", Groups);
            writer.WriteCollectionOfObjectValues<ExternalItem>("items", Items);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfObjectValues<ConnectionOperation>("operations", Operations);
            writer.WriteObjectValue<ApiSdk.Models.ExternalConnectors.Schema>("schema", Schema);
            writer.WriteEnumValue<ConnectionState>("state", State);
        }
    }
}
