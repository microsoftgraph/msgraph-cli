using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Me.Onenote.Notebooks.Item.Sections.Item.Pages.Item.ParentSection.CopyToNotebook {
    public class CopyToNotebookRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string GroupId { get; set; }
        public string Id { get; set; }
        public string RenameAs { get; set; }
        public string SiteCollectionId { get; set; }
        public string SiteId { get; set; }
        /// <summary>
        /// Instantiates a new copyToNotebookRequestBody and sets the default values.
        /// </summary>
        public CopyToNotebookRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CopyToNotebookRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CopyToNotebookRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"groupId", (o,n) => { (o as CopyToNotebookRequestBody).GroupId = n.GetStringValue(); } },
                {"id", (o,n) => { (o as CopyToNotebookRequestBody).Id = n.GetStringValue(); } },
                {"renameAs", (o,n) => { (o as CopyToNotebookRequestBody).RenameAs = n.GetStringValue(); } },
                {"siteCollectionId", (o,n) => { (o as CopyToNotebookRequestBody).SiteCollectionId = n.GetStringValue(); } },
                {"siteId", (o,n) => { (o as CopyToNotebookRequestBody).SiteId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("groupId", GroupId);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("renameAs", RenameAs);
            writer.WriteStringValue("siteCollectionId", SiteCollectionId);
            writer.WriteStringValue("siteId", SiteId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
