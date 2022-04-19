using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class AuthenticationFlowsPolicy : Entity, IParsable {
        /// <summary>Inherited property. A description of the policy. Optional. Read-only.</summary>
        public string Description { get; set; }
        /// <summary>Inherited property. The human-readable name of the policy. Optional. Read-only.</summary>
        public string DisplayName { get; set; }
        /// <summary>Contains selfServiceSignUpAuthenticationFlowConfiguration settings that convey whether self-service sign-up is enabled or disabled. Optional. Read-only.</summary>
        public SelfServiceSignUpAuthenticationFlowConfiguration SelfServiceSignUp { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AuthenticationFlowsPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AuthenticationFlowsPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"selfServiceSignUp", n => { SelfServiceSignUp = n.GetObjectValue<SelfServiceSignUpAuthenticationFlowConfiguration>(SelfServiceSignUpAuthenticationFlowConfiguration.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<SelfServiceSignUpAuthenticationFlowConfiguration>("selfServiceSignUp", SelfServiceSignUp);
        }
    }
}
