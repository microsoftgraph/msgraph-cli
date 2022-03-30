using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class AuthenticationFlowsPolicy : Entity, IParsable {
        /// <summary>Inherited property. A description of the policy. Optional. Read-only.</summary>
        public string Description { get; set; }
        /// <summary>Inherited property. The human-readable name of the policy. Optional. Read-only.</summary>
        public string DisplayName { get; set; }
        /// <summary>Contains selfServiceSignUpAuthenticationFlowConfiguration settings that convey whether self-service sign-up is enabled or disabled. Optional. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.SelfServiceSignUpAuthenticationFlowConfiguration SelfServiceSignUp { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.AuthenticationFlowsPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AuthenticationFlowsPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"description", (o,n) => { (o as AuthenticationFlowsPolicy).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as AuthenticationFlowsPolicy).DisplayName = n.GetStringValue(); } },
                {"selfServiceSignUp", (o,n) => { (o as AuthenticationFlowsPolicy).SelfServiceSignUp = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.SelfServiceSignUpAuthenticationFlowConfiguration>(ApiSdk.Models.Microsoft.Graph.SelfServiceSignUpAuthenticationFlowConfiguration.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.SelfServiceSignUpAuthenticationFlowConfiguration>("selfServiceSignUp", SelfServiceSignUp);
        }
    }
}
