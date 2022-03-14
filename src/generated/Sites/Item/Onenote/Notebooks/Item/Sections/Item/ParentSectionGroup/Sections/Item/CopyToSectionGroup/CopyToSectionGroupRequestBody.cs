using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Sites.Item.Onenote.Notebooks.Item.Sections.Item.ParentSectionGroup.Sections.Item.CopyToSectionGroup {
    public class CopyToSectionGroupRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string GroupId { get; set; }
        public string Id { get; set; }
        public string RenameAs { get; set; }
        public string SiteCollectionId { get; set; }
        public string SiteId { get; set; }
        /// <summary>
        /// Instantiates a new copyToSectionGroupRequestBody and sets the default values.
        /// </summary>
        public CopyToSectionGroupRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CopyToSectionGroupRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CopyToSectionGroupRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"groupId", (o,n) => { (o as CopyToSectionGroupRequestBody).GroupId = n.GetStringValue(); } },
                {"id", (o,n) => { (o as CopyToSectionGroupRequestBody).Id = n.GetStringValue(); } },
                {"renameAs", (o,n) => { (o as CopyToSectionGroupRequestBody).RenameAs = n.GetStringValue(); } },
                {"siteCollectionId", (o,n) => { (o as CopyToSectionGroupRequestBody).SiteCollectionId = n.GetStringValue(); } },
                {"siteId", (o,n) => { (o as CopyToSectionGroupRequestBody).SiteId = n.GetStringValue(); } },
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
