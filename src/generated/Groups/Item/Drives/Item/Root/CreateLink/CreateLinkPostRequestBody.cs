using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Groups.Item.Drives.Item.Root.CreateLink {
    /// <summary>Provides operations to call the createLink method.</summary>
    public class CreateLinkPostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The expirationDateTime property</summary>
        public DateTimeOffset? ExpirationDateTime { get; set; }
        /// <summary>The message property</summary>
        public string Message { get; set; }
        /// <summary>The password property</summary>
        public string Password { get; set; }
        /// <summary>The retainInheritedPermissions property</summary>
        public bool? RetainInheritedPermissions { get; set; }
        /// <summary>The scope property</summary>
        public string Scope { get; set; }
        /// <summary>The type property</summary>
        public string Type { get; set; }
        /// <summary>
        /// Instantiates a new createLinkPostRequestBody and sets the default values.
        /// </summary>
        public CreateLinkPostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CreateLinkPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CreateLinkPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"message", n => { Message = n.GetStringValue(); } },
                {"password", n => { Password = n.GetStringValue(); } },
                {"retainInheritedPermissions", n => { RetainInheritedPermissions = n.GetBoolValue(); } },
                {"scope", n => { Scope = n.GetStringValue(); } },
                {"type", n => { Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteStringValue("message", Message);
            writer.WriteStringValue("password", Password);
            writer.WriteBoolValue("retainInheritedPermissions", RetainInheritedPermissions);
            writer.WriteStringValue("scope", Scope);
            writer.WriteStringValue("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
