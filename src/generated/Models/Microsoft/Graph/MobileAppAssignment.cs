using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class MobileAppAssignment : Entity, IParsable {
        /// <summary>The install intent defined by the admin. Possible values are: available, required, uninstall, availableWithoutEnrollment.</summary>
        public InstallIntent? Intent { get; set; }
        /// <summary>The settings for target assignment defined by the admin.</summary>
        public ApiSdk.Models.Microsoft.Graph.MobileAppAssignmentSettings Settings { get; set; }
        /// <summary>The target group assignment defined by the admin.</summary>
        public ApiSdk.Models.Microsoft.Graph.DeviceAndAppManagementAssignmentTarget Target { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.MobileAppAssignment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MobileAppAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"intent", (o,n) => { (o as MobileAppAssignment).Intent = n.GetEnumValue<InstallIntent>(); } },
                {"settings", (o,n) => { (o as MobileAppAssignment).Settings = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.MobileAppAssignmentSettings>(ApiSdk.Models.Microsoft.Graph.MobileAppAssignmentSettings.CreateFromDiscriminatorValue); } },
                {"target", (o,n) => { (o as MobileAppAssignment).Target = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.DeviceAndAppManagementAssignmentTarget>(ApiSdk.Models.Microsoft.Graph.DeviceAndAppManagementAssignmentTarget.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<InstallIntent>("intent", Intent);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.MobileAppAssignmentSettings>("settings", Settings);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.DeviceAndAppManagementAssignmentTarget>("target", Target);
        }
    }
}
