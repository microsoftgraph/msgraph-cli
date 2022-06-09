using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    /// <summary>Contains properties used to assign a eBook to a group.</summary>
    public class ManagedEBookAssignment : Entity, IParsable {
        /// <summary>The install intent for eBook. Possible values are: available, required, uninstall, availableWithoutEnrollment.</summary>
        public ApiSdk.Models.InstallIntent? InstallIntent { get; set; }
        /// <summary>The assignment target for eBook.</summary>
        public DeviceAndAppManagementAssignmentTarget Target { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ManagedEBookAssignment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.iosVppEBookAssignment" => new IosVppEBookAssignment(),
                _ => new ManagedEBookAssignment(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"installIntent", n => { InstallIntent = n.GetEnumValue<InstallIntent>(); } },
                {"target", n => { Target = n.GetObjectValue<DeviceAndAppManagementAssignmentTarget>(DeviceAndAppManagementAssignmentTarget.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<InstallIntent>("installIntent", InstallIntent);
            writer.WriteObjectValue<DeviceAndAppManagementAssignmentTarget>("target", Target);
        }
    }
}
