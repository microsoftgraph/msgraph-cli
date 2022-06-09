using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class UnifiedRoleManagementPolicyExpirationRule : UnifiedRoleManagementPolicyRule, IParsable {
        /// <summary>Indicates whether expiration is required or if it&apos;s a permanently active assignment or eligibility.</summary>
        public bool? IsExpirationRequired { get; set; }
        /// <summary>The maximum duration allowed for eligibility or assignment which is not permanent. Required when isExpirationRequired is true.</summary>
        public TimeSpan? MaximumDuration { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UnifiedRoleManagementPolicyExpirationRule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UnifiedRoleManagementPolicyExpirationRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"isExpirationRequired", n => { IsExpirationRequired = n.GetBoolValue(); } },
                {"maximumDuration", n => { MaximumDuration = n.GetTimeSpanValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("isExpirationRequired", IsExpirationRequired);
            writer.WriteTimeSpanValue("maximumDuration", MaximumDuration);
        }
    }
}
