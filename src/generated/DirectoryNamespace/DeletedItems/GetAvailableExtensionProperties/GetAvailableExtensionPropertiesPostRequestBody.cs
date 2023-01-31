using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.DirectoryNamespace.DeletedItems.GetAvailableExtensionProperties {
    public class GetAvailableExtensionPropertiesPostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public bool? IsSyncedFromOnPremises { get; set; }
        /// <summary>
        /// Instantiates a new getAvailableExtensionPropertiesPostRequestBody and sets the default values.
        /// </summary>
        public GetAvailableExtensionPropertiesPostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public static GetAvailableExtensionPropertiesPostRequestBody CreateFromDiscriminatorValue(IParseNode? parseNode) {
#nullable restore
#else
        public static GetAvailableExtensionPropertiesPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
#endif
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GetAvailableExtensionPropertiesPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"isSyncedFromOnPremises", n => { IsSyncedFromOnPremises = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("isSyncedFromOnPremises", IsSyncedFromOnPremises);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
