using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class TeamsAppInstallation : Entity, IParsable {
        /// <summary>The app that is installed.</summary>
        public ApiSdk.Models.Microsoft.Graph.TeamsApp TeamsApp { get; set; }
        /// <summary>The details of this version of the app.</summary>
        public ApiSdk.Models.Microsoft.Graph.TeamsAppDefinition TeamsAppDefinition { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new TeamsAppInstallation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamsAppInstallation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"teamsApp", (o,n) => { (o as TeamsAppInstallation).TeamsApp = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.TeamsApp>(ApiSdk.Models.Microsoft.Graph.TeamsApp.CreateFromDiscriminatorValue); } },
                {"teamsAppDefinition", (o,n) => { (o as TeamsAppInstallation).TeamsAppDefinition = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.TeamsAppDefinition>(ApiSdk.Models.Microsoft.Graph.TeamsAppDefinition.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.TeamsApp>("teamsApp", TeamsApp);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.TeamsAppDefinition>("teamsAppDefinition", TeamsAppDefinition);
        }
    }
}
