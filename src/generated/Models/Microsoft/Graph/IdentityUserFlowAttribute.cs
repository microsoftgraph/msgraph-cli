using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class IdentityUserFlowAttribute : Entity, IParsable {
        /// <summary>The data type of the user flow attribute. This cannot be modified after the custom user flow attribute is created. The supported values for dataType are: string , boolean , int64 , stringCollection , dateTime.</summary>
        public IdentityUserFlowAttributeDataType? DataType { get; set; }
        /// <summary>The description of the user flow attribute that's shown to the user at the time of sign-up.</summary>
        public string Description { get; set; }
        /// <summary>The display name of the user flow attribute.</summary>
        public string DisplayName { get; set; }
        /// <summary>The type of the user flow attribute. This is a read-only attribute that is automatically set. Depending on the type of attribute, the values for this property will be builtIn, custom, or required.</summary>
        public IdentityUserFlowAttributeType? UserFlowAttributeType { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"dataType", (o,n) => { (o as IdentityUserFlowAttribute).DataType = n.GetEnumValue<IdentityUserFlowAttributeDataType>(); } },
                {"description", (o,n) => { (o as IdentityUserFlowAttribute).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as IdentityUserFlowAttribute).DisplayName = n.GetStringValue(); } },
                {"userFlowAttributeType", (o,n) => { (o as IdentityUserFlowAttribute).UserFlowAttributeType = n.GetEnumValue<IdentityUserFlowAttributeType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<IdentityUserFlowAttributeDataType>("dataType", DataType);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<IdentityUserFlowAttributeType>("userFlowAttributeType", UserFlowAttributeType);
        }
    }
}
