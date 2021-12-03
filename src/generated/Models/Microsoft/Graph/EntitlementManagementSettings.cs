using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class EntitlementManagementSettings : Entity, IParsable {
        public string DurationUntilExternalUserDeletedAfterBlocked { get; set; }
        /// <summary>One of None, BlockSignIn, or BlockSignInAndDelete.</summary>
        public AccessPackageExternalUserLifecycleAction? ExternalUserLifecycleAction { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"durationUntilExternalUserDeletedAfterBlocked", (o,n) => { (o as EntitlementManagementSettings).DurationUntilExternalUserDeletedAfterBlocked = n.GetStringValue(); } },
                {"externalUserLifecycleAction", (o,n) => { (o as EntitlementManagementSettings).ExternalUserLifecycleAction = n.GetEnumValue<AccessPackageExternalUserLifecycleAction>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("durationUntilExternalUserDeletedAfterBlocked", DurationUntilExternalUserDeletedAfterBlocked);
            writer.WriteEnumValue<AccessPackageExternalUserLifecycleAction>("externalUserLifecycleAction", ExternalUserLifecycleAction);
        }
    }
}
