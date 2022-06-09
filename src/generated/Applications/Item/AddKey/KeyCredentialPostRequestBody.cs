using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Applications.Item.AddKey {
    /// <summary>Provides operations to call the addKey method.</summary>
    public class KeyCredentialPostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The keyCredential property</summary>
        public ApiSdk.Models.KeyCredential KeyCredential { get; set; }
        /// <summary>The passwordCredential property</summary>
        public ApiSdk.Models.PasswordCredential PasswordCredential { get; set; }
        /// <summary>The proof property</summary>
        public string Proof { get; set; }
        /// <summary>
        /// Instantiates a new KeyCredentialPostRequestBody and sets the default values.
        /// </summary>
        public KeyCredentialPostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static KeyCredentialPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KeyCredentialPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"keyCredential", n => { KeyCredential = n.GetObjectValue<ApiSdk.Models.KeyCredential>(ApiSdk.Models.KeyCredential.CreateFromDiscriminatorValue); } },
                {"passwordCredential", n => { PasswordCredential = n.GetObjectValue<ApiSdk.Models.PasswordCredential>(ApiSdk.Models.PasswordCredential.CreateFromDiscriminatorValue); } },
                {"proof", n => { Proof = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ApiSdk.Models.KeyCredential>("keyCredential", KeyCredential);
            writer.WriteObjectValue<ApiSdk.Models.PasswordCredential>("passwordCredential", PasswordCredential);
            writer.WriteStringValue("proof", Proof);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
