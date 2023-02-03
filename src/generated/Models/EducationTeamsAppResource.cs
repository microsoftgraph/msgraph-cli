using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class EducationTeamsAppResource : EducationResource, IParsable {
        /// <summary>URL that points to the icon of the app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppIconWebUrl { get; set; }
#nullable restore
#else
        public string AppIconWebUrl { get; set; }
#endif
        /// <summary>Teams app ID of the application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppId { get; set; }
#nullable restore
#else
        public string AppId { get; set; }
#endif
        /// <summary>URL for the app resource that will be opened by Teams.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TeamsEmbeddedContentUrl { get; set; }
#nullable restore
#else
        public string TeamsEmbeddedContentUrl { get; set; }
#endif
        /// <summary>URL for the app resource that can be opened in the browser.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebUrl { get; set; }
#nullable restore
#else
        public string WebUrl { get; set; }
#endif
        /// <summary>
        /// Instantiates a new EducationTeamsAppResource and sets the default values.
        /// </summary>
        public EducationTeamsAppResource() : base() {
            OdataType = "#microsoft.graph.educationTeamsAppResource";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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
