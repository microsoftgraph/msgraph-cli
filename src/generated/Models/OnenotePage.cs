using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the collection of authenticationMethodConfiguration entities.</summary>
    public class OnenotePage : OnenoteEntitySchemaObjectModel, IParsable {
        /// <summary>The page&apos;s HTML content.</summary>
        public byte[] Content { get; set; }
        /// <summary>The URL for the page&apos;s HTML content.  Read-only.</summary>
        public string ContentUrl { get; set; }
        /// <summary>The unique identifier of the application that created the page. Read-only.</summary>
        public string CreatedByAppId { get; set; }
        /// <summary>The date and time when the page was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The indentation level of the page. Read-only.</summary>
        public int? Level { get; set; }
        /// <summary>Links for opening the page. The oneNoteClientURL link opens the page in the OneNote native client if it &apos;s installed. The oneNoteWebUrl link opens the page in OneNote on the web. Read-only.</summary>
        public PageLinks Links { get; set; }
        /// <summary>The order of the page within its parent section. Read-only.</summary>
        public int? Order { get; set; }
        /// <summary>The notebook that contains the page.  Read-only.</summary>
        public Notebook ParentNotebook { get; set; }
        /// <summary>The section that contains the page. Read-only.</summary>
        public OnenoteSection ParentSection { get; set; }
        /// <summary>The title of the page.</summary>
        public string Title { get; set; }
        /// <summary>The userTags property</summary>
        public List<string> UserTags { get; set; }
        /// <summary>
        /// Instantiates a new onenotePage and sets the default values.
        /// </summary>
        public OnenotePage() : base() {
            OdataType = "#microsoft.graph.onenotePage";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new OnenotePage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OnenotePage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"content", n => { Content = n.GetByteArrayValue(); } },
                {"contentUrl", n => { ContentUrl = n.GetStringValue(); } },
                {"createdByAppId", n => { CreatedByAppId = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"level", n => { Level = n.GetIntValue(); } },
                {"links", n => { Links = n.GetObjectValue<PageLinks>(PageLinks.CreateFromDiscriminatorValue); } },
                {"order", n => { Order = n.GetIntValue(); } },
                {"parentNotebook", n => { ParentNotebook = n.GetObjectValue<Notebook>(Notebook.CreateFromDiscriminatorValue); } },
                {"parentSection", n => { ParentSection = n.GetObjectValue<OnenoteSection>(OnenoteSection.CreateFromDiscriminatorValue); } },
                {"title", n => { Title = n.GetStringValue(); } },
                {"userTags", n => { UserTags = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteByteArrayValue("content", Content);
            writer.WriteStringValue("contentUrl", ContentUrl);
            writer.WriteStringValue("createdByAppId", CreatedByAppId);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteIntValue("level", Level);
            writer.WriteObjectValue<PageLinks>("links", Links);
            writer.WriteIntValue("order", Order);
            writer.WriteObjectValue<Notebook>("parentNotebook", ParentNotebook);
            writer.WriteObjectValue<OnenoteSection>("parentSection", ParentSection);
            writer.WriteStringValue("title", Title);
            writer.WriteCollectionOfPrimitiveValues<string>("userTags", UserTags);
        }
    }
}
