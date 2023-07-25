using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.Security {
    public class RegistryValueEvidence : AlertEvidence, IParsable {
        /// <summary>The mdeDeviceId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MdeDeviceId { get; set; }
#nullable restore
#else
        public string MdeDeviceId { get; set; }
#endif
        /// <summary>Registry hive of the key that the recorded action was applied to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RegistryHive { get; set; }
#nullable restore
#else
        public string RegistryHive { get; set; }
#endif
        /// <summary>Registry key that the recorded action was applied to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RegistryKey { get; set; }
#nullable restore
#else
        public string RegistryKey { get; set; }
#endif
        /// <summary>Data of the registry value that the recorded action was applied to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RegistryValue { get; set; }
#nullable restore
#else
        public string RegistryValue { get; set; }
#endif
        /// <summary>Name of the registry value that the recorded action was applied to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RegistryValueName { get; set; }
#nullable restore
#else
        public string RegistryValueName { get; set; }
#endif
        /// <summary>Data type, such as binary or string, of the registry value that the recorded action was applied to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RegistryValueType { get; set; }
#nullable restore
#else
        public string RegistryValueType { get; set; }
#endif
        /// <summary>
        /// Instantiates a new registryValueEvidence and sets the default values.
        /// </summary>
        public RegistryValueEvidence() : base() {
            OdataType = "#microsoft.graph.security.registryValueEvidence";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new RegistryValueEvidence CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RegistryValueEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"mdeDeviceId", n => { MdeDeviceId = n.GetStringValue(); } },
                {"registryHive", n => { RegistryHive = n.GetStringValue(); } },
                {"registryKey", n => { RegistryKey = n.GetStringValue(); } },
                {"registryValue", n => { RegistryValue = n.GetStringValue(); } },
                {"registryValueName", n => { RegistryValueName = n.GetStringValue(); } },
                {"registryValueType", n => { RegistryValueType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("mdeDeviceId", MdeDeviceId);
            writer.WriteStringValue("registryHive", RegistryHive);
            writer.WriteStringValue("registryKey", RegistryKey);
            writer.WriteStringValue("registryValue", RegistryValue);
            writer.WriteStringValue("registryValueName", RegistryValueName);
            writer.WriteStringValue("registryValueType", RegistryValueType);
        }
    }
}
