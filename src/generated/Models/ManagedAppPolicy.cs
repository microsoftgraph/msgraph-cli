using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    /// <summary>The ManagedAppPolicy resource represents a base type for platform specific policies.</summary>
    public class ManagedAppPolicy : Entity, IParsable {
        /// <summary>The date and time the policy was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The policy&apos;s description.</summary>
        public string Description { get; set; }
        /// <summary>Policy display name.</summary>
        public string DisplayName { get; set; }
        /// <summary>Last time the policy was modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Version of the entity.</summary>
        public string Version { get; set; }
        /// <summary>
        /// Instantiates a new managedAppPolicy and sets the default values.
        /// </summary>
        public ManagedAppPolicy() : base() {
            OdataType = "#microsoft.graph.managedAppPolicy";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ManagedAppPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.androidManagedAppProtection" => new AndroidManagedAppProtection(),
                "#microsoft.graph.defaultManagedAppProtection" => new DefaultManagedAppProtection(),
                "#microsoft.graph.iosManagedAppProtection" => new IosManagedAppProtection(),
                "#microsoft.graph.managedAppConfiguration" => new ManagedAppConfiguration(),
                "#microsoft.graph.managedAppProtection" => new ManagedAppProtection(),
                "#microsoft.graph.mdmWindowsInformationProtectionPolicy" => new MdmWindowsInformationProtectionPolicy(),
                "#microsoft.graph.targetedManagedAppConfiguration" => new TargetedManagedAppConfiguration(),
                "#microsoft.graph.targetedManagedAppProtection" => new TargetedManagedAppProtection(),
                "#microsoft.graph.windowsInformationProtection" => new WindowsInformationProtection(),
                "#microsoft.graph.windowsInformationProtectionPolicy" => new WindowsInformationProtectionPolicy(),
                _ => new ManagedAppPolicy(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"version", n => { Version = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("version", Version);
        }
    }
}
