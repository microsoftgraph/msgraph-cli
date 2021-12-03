using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class OnenotePage : OnenoteEntitySchemaObjectModel, IParsable {
        /// <summary>The page's HTML content.</summary>
        public byte[] Content { get; set; }
        /// <summary>The URL for the page's HTML content.  Read-only.</summary>
        public string ContentUrl { get; set; }
        /// <summary>The unique identifier of the application that created the page. Read-only.</summary>
        public string CreatedByAppId { get; set; }
        /// <summary>The date and time when the page was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The indentation level of the page. Read-only.</summary>
        public int? Level { get; set; }
        /// <summary>Links for opening the page. The oneNoteClientURL link opens the page in the OneNote native client if it 's installed. The oneNoteWebUrl link opens the page in OneNote on the web. Read-only.</summary>
        public PageLinks Links { get; set; }
        /// <summary>The order of the page within its parent section. Read-only.</summary>
        public int? Order { get; set; }
        /// <summary>The notebook that contains the page.  Read-only.</summary>
        public Notebook ParentNotebook { get; set; }
        /// <summary>The section that contains the page. Read-only.</summary>
        public OnenoteSection ParentSection { get; set; }
        /// <summary>The title of the page.</summary>
        public string Title { get; set; }
        public List<string> UserTags { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"content", (o,n) => { (o as OnenotePage).Content = n.GetByteArrayValue(); } },
                {"contentUrl", (o,n) => { (o as OnenotePage).ContentUrl = n.GetStringValue(); } },
                {"createdByAppId", (o,n) => { (o as OnenotePage).CreatedByAppId = n.GetStringValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as OnenotePage).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"level", (o,n) => { (o as OnenotePage).Level = n.GetIntValue(); } },
                {"links", (o,n) => { (o as OnenotePage).Links = n.GetObjectValue<PageLinks>(); } },
                {"order", (o,n) => { (o as OnenotePage).Order = n.GetIntValue(); } },
                {"parentNotebook", (o,n) => { (o as OnenotePage).ParentNotebook = n.GetObjectValue<Notebook>(); } },
                {"parentSection", (o,n) => { (o as OnenotePage).ParentSection = n.GetObjectValue<OnenoteSection>(); } },
                {"title", (o,n) => { (o as OnenotePage).Title = n.GetStringValue(); } },
                {"userTags", (o,n) => { (o as OnenotePage).UserTags = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
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
