using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class ServiceHostedMediaConfig : MediaConfig, IParsable {
        /// <summary>The list of media to pre-fetch.</summary>
        public List<MediaInfo> PreFetchMedia { get; set; }
        /// <summary>
        /// Instantiates a new ServiceHostedMediaConfig and sets the default values.
        /// </summary>
        public ServiceHostedMediaConfig() : base() {
            OdataType = "#microsoft.graph.serviceHostedMediaConfig";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ServiceHostedMediaConfig CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ServiceHostedMediaConfig();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"preFetchMedia", n => { PreFetchMedia = n.GetCollectionOfObjectValues<MediaInfo>(MediaInfo.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<MediaInfo>("preFetchMedia", PreFetchMedia);
        }
    }
}
