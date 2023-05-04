using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Groups.Item.Sites.Item.Onenote.Notebooks.Item.CopyNotebook {
    public class CopyNotebookPostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The groupId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GroupId { get; set; }
#nullable restore
#else
        public string GroupId { get; set; }
#endif
        /// <summary>The notebookFolder property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NotebookFolder { get; set; }
#nullable restore
#else
        public string NotebookFolder { get; set; }
#endif
        /// <summary>The renameAs property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RenameAs { get; set; }
#nullable restore
#else
        public string RenameAs { get; set; }
#endif
        /// <summary>The siteCollectionId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SiteCollectionId { get; set; }
#nullable restore
#else
        public string SiteCollectionId { get; set; }
#endif
        /// <summary>The siteId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SiteId { get; set; }
#nullable restore
#else
        public string SiteId { get; set; }
#endif
        /// <summary>
        /// Instantiates a new copyNotebookPostRequestBody and sets the default values.
        /// </summary>
        public CopyNotebookPostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CopyNotebookPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CopyNotebookPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"groupId", n => { GroupId = n.GetStringValue(); } },
                {"notebookFolder", n => { NotebookFolder = n.GetStringValue(); } },
                {"renameAs", n => { RenameAs = n.GetStringValue(); } },
                {"siteCollectionId", n => { SiteCollectionId = n.GetStringValue(); } },
                {"siteId", n => { SiteId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("groupId", GroupId);
            writer.WriteStringValue("notebookFolder", NotebookFolder);
            writer.WriteStringValue("renameAs", RenameAs);
            writer.WriteStringValue("siteCollectionId", SiteCollectionId);
            writer.WriteStringValue("siteId", SiteId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
