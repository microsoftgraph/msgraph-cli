using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Me.ChangePassword {
    /// <summary>Provides operations to call the changePassword method.</summary>
    public class ChangePasswordPostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The currentPassword property</summary>
        public string CurrentPassword { get; set; }
        /// <summary>The newPassword property</summary>
        public string NewPassword { get; set; }
        /// <summary>
        /// Instantiates a new changePasswordPostRequestBody and sets the default values.
        /// </summary>
        public ChangePasswordPostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ChangePasswordPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ChangePasswordPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"currentPassword", n => { CurrentPassword = n.GetStringValue(); } },
                {"newPassword", n => { NewPassword = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("currentPassword", CurrentPassword);
            writer.WriteStringValue("newPassword", NewPassword);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
