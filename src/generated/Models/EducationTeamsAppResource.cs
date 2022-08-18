using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class EducationTeamsAppResource : EducationResource, IParsable {
        /// <summary>The appIconWebUrl property</summary>
        public string AppIconWebUrl { get; set; }
        /// <summary>The appId property</summary>
        public string AppId { get; set; }
        /// <summary>The teamsEmbeddedContentUrl property</summary>
        public string TeamsEmbeddedContentUrl { get; set; }
        /// <summary>The webUrl property</summary>
        public string WebUrl { get; set; }
        /// <summary>
        /// Instantiates a new EducationTeamsAppResource and sets the default values.
        /// </summary>
        public EducationTeamsAppResource() : base() {
            OdataType = "#microsoft.graph.educationTeamsAppResource";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new EducationTeamsAppResource CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationTeamsAppResource();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appIconWebUrl", n => { AppIconWebUrl = n.GetStringValue(); } },
                {"appId", n => { AppId = n.GetStringValue(); } },
                {"teamsEmbeddedContentUrl", n => { TeamsEmbeddedContentUrl = n.GetStringValue(); } },
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
            writer.WriteStringValue("appIconWebUrl", AppIconWebUrl);
            writer.WriteStringValue("appId", AppId);
            writer.WriteStringValue("teamsEmbeddedContentUrl", TeamsEmbeddedContentUrl);
            writer.WriteStringValue("webUrl", WebUrl);
        }
    }
}
