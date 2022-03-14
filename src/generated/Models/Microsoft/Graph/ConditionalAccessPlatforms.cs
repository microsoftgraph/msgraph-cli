using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ConditionalAccessPlatforms : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Possible values are: android, iOS, windows, windowsPhone, macOS, all, unknownFutureValue.</summary>
        public List<ConditionalAccessDevicePlatform?> ExcludePlatforms { get; set; }
        /// <summary>Possible values are: android, iOS, windows, windowsPhone, macOS, all, unknownFutureValue.</summary>
        public List<ConditionalAccessDevicePlatform?> IncludePlatforms { get; set; }
        /// <summary>
        /// Instantiates a new conditionalAccessPlatforms and sets the default values.
        /// </summary>
        public ConditionalAccessPlatforms() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ConditionalAccessPlatforms CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConditionalAccessPlatforms();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"excludePlatforms", (o,n) => { (o as ConditionalAccessPlatforms).ExcludePlatforms = n.GetCollectionOfEnumValues<ConditionalAccessDevicePlatform>().ToList(); } },
                {"includePlatforms", (o,n) => { (o as ConditionalAccessPlatforms).IncludePlatforms = n.GetCollectionOfEnumValues<ConditionalAccessDevicePlatform>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfEnumValues<ConditionalAccessDevicePlatform>("excludePlatforms", ExcludePlatforms);
            writer.WriteCollectionOfEnumValues<ConditionalAccessDevicePlatform>("includePlatforms", IncludePlatforms);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
