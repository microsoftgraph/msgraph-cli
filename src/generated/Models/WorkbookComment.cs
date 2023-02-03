using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class WorkbookComment : Entity, IParsable {
        /// <summary>The content of comment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Content { get; set; }
#nullable restore
#else
        public string Content { get; set; }
#endif
        /// <summary>Indicates the type for the comment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContentType { get; set; }
#nullable restore
#else
        public string ContentType { get; set; }
#endif
        /// <summary>The replies property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WorkbookCommentReply>? Replies { get; set; }
#nullable restore
#else
        public List<WorkbookCommentReply> Replies { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WorkbookComment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkbookComment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"content", n => { Content = n.GetStringValue(); } },
                {"contentType", n => { ContentType = n.GetStringValue(); } },
                {"replies", n => { Replies = n.GetCollectionOfObjectValues<WorkbookCommentReply>(WorkbookCommentReply.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("content", Content);
            writer.WriteStringValue("contentType", ContentType);
            writer.WriteCollectionOfObjectValues<WorkbookCommentReply>("replies", Replies);
        }
    }
}
