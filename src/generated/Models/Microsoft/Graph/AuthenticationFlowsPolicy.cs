using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class AuthenticationFlowsPolicy : Entity, IParsable {
        /// <summary>Inherited property. A description of the policy. This property is not a key. Optional. Read-only.</summary>
        public string Description { get; set; }
        /// <summary>Inherited property. The human-readable name of the policy. This property is not a key. Optional. Read-only.</summary>
        public string DisplayName { get; set; }
        /// <summary>Contains selfServiceSignUpAuthenticationFlowConfiguration settings that convey whether self-service sign-up is enabled or disabled. This property is not a key. Optional. Read-only.</summary>
        public SelfServiceSignUpAuthenticationFlowConfiguration SelfServiceSignUp { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"description", (o,n) => { (o as AuthenticationFlowsPolicy).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as AuthenticationFlowsPolicy).DisplayName = n.GetStringValue(); } },
                {"selfServiceSignUp", (o,n) => { (o as AuthenticationFlowsPolicy).SelfServiceSignUp = n.GetObjectValue<SelfServiceSignUpAuthenticationFlowConfiguration>(); } },
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
