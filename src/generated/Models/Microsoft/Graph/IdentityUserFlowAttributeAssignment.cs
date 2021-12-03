using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class IdentityUserFlowAttributeAssignment : Entity, IParsable {
        /// <summary>The display name of the identityUserFlowAttribute within a user flow.</summary>
        public string DisplayName { get; set; }
        /// <summary>Determines whether the identityUserFlowAttribute is optional. true means the user doesn't have to provide a value. false means the user cannot complete sign-up without providing a value.</summary>
        public bool? IsOptional { get; set; }
        /// <summary>Determines whether the identityUserFlowAttribute requires verification. This is only used for verifying the user's phone number or email address.</summary>
        public bool? RequiresVerification { get; set; }
        /// <summary>The user attribute that you want to add to your user flow.</summary>
        public IdentityUserFlowAttribute UserAttribute { get; set; }
        /// <summary>The input options for the user flow attribute. Only applicable when the userInputType is radioSingleSelect, dropdownSingleSelect, or checkboxMultiSelect.</summary>
        public List<UserAttributeValuesItem> UserAttributeValues { get; set; }
        /// <summary>The input type of the user flow attribute. Possible values are: textBox, dateTimeDropdown, radioSingleSelect, dropdownSingleSelect, emailBox, checkboxMultiSelect.</summary>
        public IdentityUserFlowAttributeInputType? UserInputType { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"displayName", (o,n) => { (o as IdentityUserFlowAttributeAssignment).DisplayName = n.GetStringValue(); } },
                {"isOptional", (o,n) => { (o as IdentityUserFlowAttributeAssignment).IsOptional = n.GetBoolValue(); } },
                {"requiresVerification", (o,n) => { (o as IdentityUserFlowAttributeAssignment).RequiresVerification = n.GetBoolValue(); } },
                {"userAttribute", (o,n) => { (o as IdentityUserFlowAttributeAssignment).UserAttribute = n.GetObjectValue<IdentityUserFlowAttribute>(); } },
                {"userAttributeValues", (o,n) => { (o as IdentityUserFlowAttributeAssignment).UserAttributeValues = n.GetCollectionOfObjectValues<UserAttributeValuesItem>().ToList(); } },
                {"userInputType", (o,n) => { (o as IdentityUserFlowAttributeAssignment).UserInputType = n.GetEnumValue<IdentityUserFlowAttributeInputType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("isOptional", IsOptional);
            writer.WriteBoolValue("requiresVerification", RequiresVerification);
            writer.WriteObjectValue<IdentityUserFlowAttribute>("userAttribute", UserAttribute);
            writer.WriteCollectionOfObjectValues<UserAttributeValuesItem>("userAttributeValues", UserAttributeValues);
            writer.WriteEnumValue<IdentityUserFlowAttributeInputType>("userInputType", UserInputType);
        }
    }
}
