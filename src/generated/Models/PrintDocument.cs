using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the collection of application entities.</summary>
    public class PrintDocument : Entity, IParsable {
        /// <summary>The document&apos;s content (MIME) type. Read-only.</summary>
        public string ContentType { get; set; }
        /// <summary>The document&apos;s name. Read-only.</summary>
        public string DisplayName { get; set; }
        /// <summary>The document&apos;s size in bytes. Read-only.</summary>
        public long? Size { get; set; }
        /// <summary>
        /// Instantiates a new printDocument and sets the default values.
        /// </summary>
        public PrintDocument() : base() {
            OdataType = "#microsoft.graph.printDocument";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new PrintDocument CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrintDocument();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"contentType", n => { ContentType = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"size", n => { Size = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("contentType", ContentType);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteLongValue("size", Size);
        }
    }
}
