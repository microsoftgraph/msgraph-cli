using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the auditLogRoot singleton.</summary>
    public class LinkedResource : Entity, IParsable {
        /// <summary>Field indicating the app name of the source that is sending the linkedResource.</summary>
        public string ApplicationName { get; set; }
        /// <summary>Field indicating the title of the linkedResource.</summary>
        public string DisplayName { get; set; }
        /// <summary>Id of the object that is associated with this task on the third-party/partner system.</summary>
        public string ExternalId { get; set; }
        /// <summary>Deep link to the linkedResource.</summary>
        public string WebUrl { get; set; }
        /// <summary>
        /// Instantiates a new linkedResource and sets the default values.
        /// </summary>
        public LinkedResource() : base() {
            OdataType = "#microsoft.graph.linkedResource";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new LinkedResource CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new LinkedResource();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"applicationName", n => { ApplicationName = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"externalId", n => { ExternalId = n.GetStringValue(); } },
                {"webUrl", n => { WebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("applicationName", ApplicationName);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteStringValue("webUrl", WebUrl);
        }
    }
}
