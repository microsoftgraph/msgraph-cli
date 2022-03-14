using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ThumbnailSet : Entity, IParsable {
        /// <summary>A 1920x1920 scaled thumbnail.</summary>
        public Thumbnail Large { get; set; }
        /// <summary>A 176x176 scaled thumbnail.</summary>
        public Thumbnail Medium { get; set; }
        /// <summary>A 48x48 cropped thumbnail.</summary>
        public Thumbnail Small { get; set; }
        /// <summary>A custom thumbnail image or the original image used to generate other thumbnails.</summary>
        public Thumbnail Source { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ThumbnailSet CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ThumbnailSet();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"large", (o,n) => { (o as ThumbnailSet).Large = n.GetObjectValue<Thumbnail>(Thumbnail.CreateFromDiscriminatorValue); } },
                {"medium", (o,n) => { (o as ThumbnailSet).Medium = n.GetObjectValue<Thumbnail>(Thumbnail.CreateFromDiscriminatorValue); } },
                {"small", (o,n) => { (o as ThumbnailSet).Small = n.GetObjectValue<Thumbnail>(Thumbnail.CreateFromDiscriminatorValue); } },
                {"source", (o,n) => { (o as ThumbnailSet).Source = n.GetObjectValue<Thumbnail>(Thumbnail.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
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
