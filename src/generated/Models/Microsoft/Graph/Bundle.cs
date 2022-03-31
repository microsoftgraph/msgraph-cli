using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Bundle : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>If the bundle is an [album][], then the album property is included</summary>
        public ApiSdk.Models.Microsoft.Graph.Album Album { get; set; }
        /// <summary>Number of children contained immediately within this container.</summary>
        public int? ChildCount { get; set; }
        /// <summary>
        /// Instantiates a new bundle and sets the default values.
        /// </summary>
        public Bundle() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.Bundle CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Bundle();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"album", (o,n) => { (o as Bundle).Album = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Album>(ApiSdk.Models.Microsoft.Graph.Album.CreateFromDiscriminatorValue); } },
                {"childCount", (o,n) => { (o as Bundle).ChildCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.Album>("album", Album);
            writer.WriteIntValue("childCount", ChildCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
