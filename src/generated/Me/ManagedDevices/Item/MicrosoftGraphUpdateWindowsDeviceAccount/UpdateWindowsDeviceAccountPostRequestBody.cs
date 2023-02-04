using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Me.ManagedDevices.Item.MicrosoftGraphUpdateWindowsDeviceAccount {
    public class UpdateWindowsDeviceAccountPostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The updateWindowsDeviceAccountActionParameter property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.UpdateWindowsDeviceAccountActionParameter? UpdateWindowsDeviceAccountActionParameter { get; set; }
#nullable restore
#else
        public ApiSdk.Models.UpdateWindowsDeviceAccountActionParameter UpdateWindowsDeviceAccountActionParameter { get; set; }
#endif
        /// <summary>
        /// Instantiates a new updateWindowsDeviceAccountPostRequestBody and sets the default values.
        /// </summary>
        public UpdateWindowsDeviceAccountPostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UpdateWindowsDeviceAccountPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UpdateWindowsDeviceAccountPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"updateWindowsDeviceAccountActionParameter", n => { UpdateWindowsDeviceAccountActionParameter = n.GetObjectValue<ApiSdk.Models.UpdateWindowsDeviceAccountActionParameter>(ApiSdk.Models.UpdateWindowsDeviceAccountActionParameter.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ApiSdk.Models.UpdateWindowsDeviceAccountActionParameter>("updateWindowsDeviceAccountActionParameter", UpdateWindowsDeviceAccountActionParameter);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
