using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the collection of chat entities.</summary>
    public class TeamsAppInstallation : Entity, IParsable {
        /// <summary>The app that is installed.</summary>
        public ApiSdk.Models.TeamsApp TeamsApp { get; set; }
        /// <summary>The details of this version of the app.</summary>
        public ApiSdk.Models.TeamsAppDefinition TeamsAppDefinition { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new TeamsAppInstallation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.userScopeTeamsAppInstallation" => new UserScopeTeamsAppInstallation(),
                _ => new TeamsAppInstallation(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"teamsApp", n => { TeamsApp = n.GetObjectValue<ApiSdk.Models.TeamsApp>(ApiSdk.Models.TeamsApp.CreateFromDiscriminatorValue); } },
                {"teamsAppDefinition", n => { TeamsAppDefinition = n.GetObjectValue<ApiSdk.Models.TeamsAppDefinition>(ApiSdk.Models.TeamsAppDefinition.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ApiSdk.Models.TeamsApp>("teamsApp", TeamsApp);
            writer.WriteObjectValue<ApiSdk.Models.TeamsAppDefinition>("teamsAppDefinition", TeamsAppDefinition);
        }
    }
}
