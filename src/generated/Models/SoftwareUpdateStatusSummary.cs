using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class SoftwareUpdateStatusSummary : Entity, IParsable {
        /// <summary>Number of compliant devices.</summary>
        public int? CompliantDeviceCount { get; set; }
        /// <summary>Number of compliant users.</summary>
        public int? CompliantUserCount { get; set; }
        /// <summary>Number of conflict devices.</summary>
        public int? ConflictDeviceCount { get; set; }
        /// <summary>Number of conflict users.</summary>
        public int? ConflictUserCount { get; set; }
        /// <summary>The name of the policy.</summary>
        public string DisplayName { get; set; }
        /// <summary>Number of devices had error.</summary>
        public int? ErrorDeviceCount { get; set; }
        /// <summary>Number of users had error.</summary>
        public int? ErrorUserCount { get; set; }
        /// <summary>Number of non compliant devices.</summary>
        public int? NonCompliantDeviceCount { get; set; }
        /// <summary>Number of non compliant users.</summary>
        public int? NonCompliantUserCount { get; set; }
        /// <summary>Number of not applicable devices.</summary>
        public int? NotApplicableDeviceCount { get; set; }
        /// <summary>Number of not applicable users.</summary>
        public int? NotApplicableUserCount { get; set; }
        /// <summary>Number of remediated devices.</summary>
        public int? RemediatedDeviceCount { get; set; }
        /// <summary>Number of remediated users.</summary>
        public int? RemediatedUserCount { get; set; }
        /// <summary>Number of unknown devices.</summary>
        public int? UnknownDeviceCount { get; set; }
        /// <summary>Number of unknown users.</summary>
        public int? UnknownUserCount { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new SoftwareUpdateStatusSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SoftwareUpdateStatusSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"compliantDeviceCount", n => { CompliantDeviceCount = n.GetIntValue(); } },
                {"compliantUserCount", n => { CompliantUserCount = n.GetIntValue(); } },
                {"conflictDeviceCount", n => { ConflictDeviceCount = n.GetIntValue(); } },
                {"conflictUserCount", n => { ConflictUserCount = n.GetIntValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"errorDeviceCount", n => { ErrorDeviceCount = n.GetIntValue(); } },
                {"errorUserCount", n => { ErrorUserCount = n.GetIntValue(); } },
                {"nonCompliantDeviceCount", n => { NonCompliantDeviceCount = n.GetIntValue(); } },
                {"nonCompliantUserCount", n => { NonCompliantUserCount = n.GetIntValue(); } },
                {"notApplicableDeviceCount", n => { NotApplicableDeviceCount = n.GetIntValue(); } },
                {"notApplicableUserCount", n => { NotApplicableUserCount = n.GetIntValue(); } },
                {"remediatedDeviceCount", n => { RemediatedDeviceCount = n.GetIntValue(); } },
                {"remediatedUserCount", n => { RemediatedUserCount = n.GetIntValue(); } },
                {"unknownDeviceCount", n => { UnknownDeviceCount = n.GetIntValue(); } },
                {"unknownUserCount", n => { UnknownUserCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("compliantDeviceCount", CompliantDeviceCount);
            writer.WriteIntValue("compliantUserCount", CompliantUserCount);
            writer.WriteIntValue("conflictDeviceCount", ConflictDeviceCount);
            writer.WriteIntValue("conflictUserCount", ConflictUserCount);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteIntValue("errorDeviceCount", ErrorDeviceCount);
            writer.WriteIntValue("errorUserCount", ErrorUserCount);
            writer.WriteIntValue("nonCompliantDeviceCount", NonCompliantDeviceCount);
            writer.WriteIntValue("nonCompliantUserCount", NonCompliantUserCount);
            writer.WriteIntValue("notApplicableDeviceCount", NotApplicableDeviceCount);
            writer.WriteIntValue("notApplicableUserCount", NotApplicableUserCount);
            writer.WriteIntValue("remediatedDeviceCount", RemediatedDeviceCount);
            writer.WriteIntValue("remediatedUserCount", RemediatedUserCount);
            writer.WriteIntValue("unknownDeviceCount", UnknownDeviceCount);
            writer.WriteIntValue("unknownUserCount", UnknownUserCount);
        }
    }
}
