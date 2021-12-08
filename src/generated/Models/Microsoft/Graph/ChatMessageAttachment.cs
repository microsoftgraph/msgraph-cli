using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ChatMessageAttachment : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The content of the attachment. If the attachment is a rich card, set the property to the rich card object. This property and contentUrl are mutually exclusive.</summary>
        public string Content { get; set; }
        /// <summary>The media type of the content attachment. It can have the following values: reference: Attachment is a link to another file. Populate the contentURL with the link to the object.Any contentTypes supported by the Bot Framework's Attachment objectapplication/vnd.microsoft.card.codesnippet: A code snippet. application/vnd.microsoft.card.announcement: An announcement header.</summary>
        public string ContentType { get; set; }
        /// <summary>URL for the content of the attachment. Supported protocols: http, https, file and data.</summary>
        public string ContentUrl { get; set; }
        /// <summary>Read-only. Unique id of the attachment.</summary>
        public string Id { get; set; }
        /// <summary>Name of the attachment.</summary>
        public string Name { get; set; }
        /// <summary>URL to a thumbnail image that the channel can use if it supports using an alternative, smaller form of content or contentUrl. For example, if you set contentType to application/word and set contentUrl to the location of the Word document, you might include a thumbnail image that represents the document. The channel could display the thumbnail image instead of the document. When the user clicks the image, the channel would open the document.</summary>
        public string ThumbnailUrl { get; set; }
        /// <summary>
        /// Instantiates a new chatMessageAttachment and sets the default values.
        /// </summary>
        public ChatMessageAttachment() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"content", (o,n) => { (o as ChatMessageAttachment).Content = n.GetStringValue(); } },
                {"contentType", (o,n) => { (o as ChatMessageAttachment).ContentType = n.GetStringValue(); } },
                {"contentUrl", (o,n) => { (o as ChatMessageAttachment).ContentUrl = n.GetStringValue(); } },
                {"id", (o,n) => { (o as ChatMessageAttachment).Id = n.GetStringValue(); } },
                {"name", (o,n) => { (o as ChatMessageAttachment).Name = n.GetStringValue(); } },
                {"thumbnailUrl", (o,n) => { (o as ChatMessageAttachment).ThumbnailUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("content", Content);
            writer.WriteStringValue("contentType", ContentType);
            writer.WriteStringValue("contentUrl", ContentUrl);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("thumbnailUrl", ThumbnailUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
