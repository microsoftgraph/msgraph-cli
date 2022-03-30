using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class EntitlementManagementSettings : Entity, IParsable {
        /// <summary>If externalUserLifecycleAction is blockSignInAndDelete, the duration, typically a number of days, after an external user is blocked from sign in before their account is deleted.</summary>
        public TimeSpan? DurationUntilExternalUserDeletedAfterBlocked { get; set; }
        /// <summary>Automatic action that the service should take when an external user's last access package assignment is removed. The possible values are: none, blockSignIn, blockSignInAndDelete, unknownFutureValue.</summary>
        public AccessPackageExternalUserLifecycleAction? ExternalUserLifecycleAction { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.EntitlementManagementSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EntitlementManagementSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"durationUntilExternalUserDeletedAfterBlocked", (o,n) => { (o as EntitlementManagementSettings).DurationUntilExternalUserDeletedAfterBlocked = n.GetTimeSpanValue(); } },
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
            writer.WriteTimeSpanValue("durationUntilExternalUserDeletedAfterBlocked", DurationUntilExternalUserDeletedAfterBlocked);
            writer.WriteEnumValue<AccessPackageExternalUserLifecycleAction>("externalUserLifecycleAction", ExternalUserLifecycleAction);
        }
    }
}
