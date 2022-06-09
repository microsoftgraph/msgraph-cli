using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the identityGovernance singleton.</summary>
    public class UnifiedRoleEligibilitySchedule : UnifiedRoleScheduleBase, IParsable {
        /// <summary>Membership type of the eligible assignment. It can either be Inherited, Direct, or Group.</summary>
        public string MemberType { get; set; }
        /// <summary>The schedule object of the eligible role assignment request.</summary>
        public RequestSchedule ScheduleInfo { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UnifiedRoleEligibilitySchedule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UnifiedRoleEligibilitySchedule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"memberType", n => { MemberType = n.GetStringValue(); } },
                {"scheduleInfo", n => { ScheduleInfo = n.GetObjectValue<RequestSchedule>(RequestSchedule.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("memberType", MemberType);
            writer.WriteObjectValue<RequestSchedule>("scheduleInfo", ScheduleInfo);
        }
    }
}
