using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class ThumbnailSet : Entity, IParsable {
        /// <summary>A 1920x1920 scaled thumbnail.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Thumbnail? Large { get; set; }
#nullable restore
#else
        public Thumbnail Large { get; set; }
#endif
        /// <summary>A 176x176 scaled thumbnail.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Thumbnail? Medium { get; set; }
#nullable restore
#else
        public Thumbnail Medium { get; set; }
#endif
        /// <summary>A 48x48 cropped thumbnail.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Thumbnail? Small { get; set; }
#nullable restore
#else
        public Thumbnail Small { get; set; }
#endif
        /// <summary>A custom thumbnail image or the original image used to generate other thumbnails.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Thumbnail? Source { get; set; }
#nullable restore
#else
        public Thumbnail Source { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public static new ThumbnailSet CreateFromDiscriminatorValue(IParseNode? parseNode) {
#nullable restore
#else
        public static new ThumbnailSet CreateFromDiscriminatorValue(IParseNode parseNode) {
#endif
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ThumbnailSet();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"large", n => { Large = n.GetObjectValue<Thumbnail>(Thumbnail.CreateFromDiscriminatorValue); } },
                {"medium", n => { Medium = n.GetObjectValue<Thumbnail>(Thumbnail.CreateFromDiscriminatorValue); } },
                {"small", n => { Small = n.GetObjectValue<Thumbnail>(Thumbnail.CreateFromDiscriminatorValue); } },
                {"source", n => { Source = n.GetObjectValue<Thumbnail>(Thumbnail.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Thumbnail>("large", Large);
            writer.WriteObjectValue<Thumbnail>("medium", Medium);
            writer.WriteObjectValue<Thumbnail>("small", Small);
            writer.WriteObjectValue<Thumbnail>("source", Source);
        }
    }
}
