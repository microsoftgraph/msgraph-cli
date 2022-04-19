using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class SharepointIds : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The unique identifier (guid) for the item&apos;s list in SharePoint.</summary>
        public string ListId { get; set; }
        /// <summary>An integer identifier for the item within the containing list.</summary>
        public string ListItemId { get; set; }
        /// <summary>The unique identifier (guid) for the item within OneDrive for Business or a SharePoint site.</summary>
        public string ListItemUniqueId { get; set; }
        /// <summary>The unique identifier (guid) for the item&apos;s site collection (SPSite).</summary>
        public string SiteId { get; set; }
        /// <summary>The SharePoint URL for the site that contains the item.</summary>
        public string SiteUrl { get; set; }
        /// <summary>The unique identifier (guid) for the tenancy.</summary>
        public string TenantId { get; set; }
        /// <summary>The unique identifier (guid) for the item&apos;s site (SPWeb).</summary>
        public string WebId { get; set; }
        /// <summary>
        /// Instantiates a new sharepointIds and sets the default values.
        /// </summary>
        public SharepointIds() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SharepointIds CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SharepointIds();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"listId", n => { ListId = n.GetStringValue(); } },
                {"listItemId", n => { ListItemId = n.GetStringValue(); } },
                {"listItemUniqueId", n => { ListItemUniqueId = n.GetStringValue(); } },
                {"siteId", n => { SiteId = n.GetStringValue(); } },
                {"siteUrl", n => { SiteUrl = n.GetStringValue(); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
                {"webId", n => { WebId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("listId", ListId);
            writer.WriteStringValue("listItemId", ListItemId);
            writer.WriteStringValue("listItemUniqueId", ListItemUniqueId);
            writer.WriteStringValue("siteId", SiteId);
            writer.WriteStringValue("siteUrl", SiteUrl);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteStringValue("webId", WebId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
