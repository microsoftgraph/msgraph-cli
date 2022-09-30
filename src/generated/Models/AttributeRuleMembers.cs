using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class AttributeRuleMembers : SubjectSet, IParsable {
        /// <summary>A description of the membership rule.</summary>
        public string Description { get; set; }
        /// <summary>Determines the allowed target users for this policy. For more information about the syntax of the membership rule, see Membership Rules syntax.</summary>
        public string MembershipRule { get; set; }
        /// <summary>
        /// Instantiates a new AttributeRuleMembers and sets the default values.
        /// </summary>
        public AttributeRuleMembers() : base() {
            OdataType = "#microsoft.graph.attributeRuleMembers";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AttributeRuleMembers CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AttributeRuleMembers();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"description", n => { Description = n.GetStringValue(); } },
                {"membershipRule", n => { MembershipRule = n.GetStringValue(); } },
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
            writer.WriteStringValue("membershipRule", MembershipRule);
        }
    }
}
