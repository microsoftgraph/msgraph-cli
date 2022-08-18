using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class AadUserConversationMember : ConversationMember, IParsable {
        /// <summary>The email address of the user.</summary>
        public string Email { get; set; }
        /// <summary>TenantId which the Azure AD user belongs to.</summary>
        public string TenantId { get; set; }
        /// <summary>The user property</summary>
        public ApiSdk.Models.User User { get; set; }
        /// <summary>The guid of the user.</summary>
        public string UserId { get; set; }
        /// <summary>
        /// Instantiates a new AadUserConversationMember and sets the default values.
        /// </summary>
        public AadUserConversationMember() : base() {
            OdataType = "#microsoft.graph.aadUserConversationMember";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AadUserConversationMember CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AadUserConversationMember();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"email", n => { Email = n.GetStringValue(); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
                {"user", n => { User = n.GetObjectValue<ApiSdk.Models.User>(ApiSdk.Models.User.CreateFromDiscriminatorValue); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("email", Email);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteObjectValue<ApiSdk.Models.User>("user", User);
            writer.WriteStringValue("userId", UserId);
        }
    }
}
