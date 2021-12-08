using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ConditionalAccessPolicy : Entity, IParsable {
        public ConditionalAccessConditionSet Conditions { get; set; }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Readonly.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Not used.</summary>
        public string Description { get; set; }
        /// <summary>Specifies a display name for the conditionalAccessPolicy object.</summary>
        public string DisplayName { get; set; }
        /// <summary>Specifies the grant controls that must be fulfilled to pass the policy.</summary>
        public ConditionalAccessGrantControls GrantControls { get; set; }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Readonly.</summary>
        public DateTimeOffset? ModifiedDateTime { get; set; }
        /// <summary>Specifies the session controls that are enforced after sign-in.</summary>
        public ConditionalAccessSessionControls SessionControls { get; set; }
        /// <summary>Specifies the state of the conditionalAccessPolicy object. Possible values are: enabled, disabled, enabledForReportingButNotEnforced. Required.</summary>
        public ConditionalAccessPolicyState? State { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"conditions", (o,n) => { (o as ConditionalAccessPolicy).Conditions = n.GetObjectValue<ConditionalAccessConditionSet>(); } },
                {"createdDateTime", (o,n) => { (o as ConditionalAccessPolicy).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", (o,n) => { (o as ConditionalAccessPolicy).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as ConditionalAccessPolicy).DisplayName = n.GetStringValue(); } },
                {"grantControls", (o,n) => { (o as ConditionalAccessPolicy).GrantControls = n.GetObjectValue<ConditionalAccessGrantControls>(); } },
                {"modifiedDateTime", (o,n) => { (o as ConditionalAccessPolicy).ModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"sessionControls", (o,n) => { (o as ConditionalAccessPolicy).SessionControls = n.GetObjectValue<ConditionalAccessSessionControls>(); } },
                {"state", (o,n) => { (o as ConditionalAccessPolicy).State = n.GetEnumValue<ConditionalAccessPolicyState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ConditionalAccessConditionSet>("conditions", Conditions);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<ConditionalAccessGrantControls>("grantControls", GrantControls);
            writer.WriteDateTimeOffsetValue("modifiedDateTime", ModifiedDateTime);
            writer.WriteObjectValue<ConditionalAccessSessionControls>("sessionControls", SessionControls);
            writer.WriteEnumValue<ConditionalAccessPolicyState>("state", State);
        }
    }
}
