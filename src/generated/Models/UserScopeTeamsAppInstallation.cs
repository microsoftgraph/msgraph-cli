using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class UserScopeTeamsAppInstallation : TeamsAppInstallation, IParsable {
        /// <summary>The chat between the user and Teams app.</summary>
        public ApiSdk.Models.Chat Chat { get; set; }
        /// <summary>
        /// Instantiates a new UserScopeTeamsAppInstallation and sets the default values.
        /// </summary>
        public UserScopeTeamsAppInstallation() : base() {
            OdataType = "#microsoft.graph.userScopeTeamsAppInstallation";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UserScopeTeamsAppInstallation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserScopeTeamsAppInstallation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"chat", n => { Chat = n.GetObjectValue<ApiSdk.Models.Chat>(ApiSdk.Models.Chat.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ApiSdk.Models.Chat>("chat", Chat);
        }
    }
}
