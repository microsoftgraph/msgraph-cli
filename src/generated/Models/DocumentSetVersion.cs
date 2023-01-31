using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class DocumentSetVersion : ListItemVersion, IParsable {
        /// <summary>Comment about the captured version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Comment { get; set; }
#nullable restore
#else
        public string Comment { get; set; }
#endif
        /// <summary>User who captured the version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? CreatedBy { get; set; }
#nullable restore
#else
        public IdentitySet CreatedBy { get; set; }
#endif
        /// <summary>Date and time when this version was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Items within the document set that are captured as part of this version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DocumentSetVersionItem>? Items { get; set; }
#nullable restore
#else
        public List<DocumentSetVersionItem> Items { get; set; }
#endif
        /// <summary>If true, minor versions of items are also captured; otherwise, only major versions will be captured. Default value is false.</summary>
        public bool? ShouldCaptureMinorVersion { get; set; }
        /// <summary>
        /// Instantiates a new DocumentSetVersion and sets the default values.
        /// </summary>
        public DocumentSetVersion() : base() {
            OdataType = "#microsoft.graph.documentSetVersion";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public static new DocumentSetVersion CreateFromDiscriminatorValue(IParseNode? parseNode) {
#nullable restore
#else
        public static new DocumentSetVersion CreateFromDiscriminatorValue(IParseNode parseNode) {
#endif
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DocumentSetVersion();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"comment", n => { Comment = n.GetStringValue(); } },
                {"createdBy", n => { CreatedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"items", n => { Items = n.GetCollectionOfObjectValues<DocumentSetVersionItem>(DocumentSetVersionItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"shouldCaptureMinorVersion", n => { ShouldCaptureMinorVersion = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("comment", Comment);
            writer.WriteObjectValue<IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfObjectValues<DocumentSetVersionItem>("items", Items);
            writer.WriteBoolValue("shouldCaptureMinorVersion", ShouldCaptureMinorVersion);
        }
    }
}
