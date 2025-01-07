// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models
{
    /// <summary>
    /// Device Configuration State for a given device.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DeviceConfigurationState : global::ApiSdk.Models.Entity, IParsable
    {
        /// <summary>The name of the policy for this policyBase</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Supported platform types for policies.</summary>
        public global::ApiSdk.Models.PolicyPlatformType? PlatformType { get; set; }
        /// <summary>Count of how many setting a policy holds</summary>
        public int? SettingCount { get; set; }
        /// <summary>The settingStates property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.DeviceConfigurationSettingState>? SettingStates { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.DeviceConfigurationSettingState> SettingStates { get; set; }
#endif
        /// <summary>The state property</summary>
        public global::ApiSdk.Models.ComplianceStatus? State { get; set; }
        /// <summary>The version of the policy</summary>
        public int? Version { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.DeviceConfigurationState"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.DeviceConfigurationState CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.DeviceConfigurationState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "platformType", n => { PlatformType = n.GetEnumValue<global::ApiSdk.Models.PolicyPlatformType>(); } },
                { "settingCount", n => { SettingCount = n.GetIntValue(); } },
                { "settingStates", n => { SettingStates = n.GetCollectionOfObjectValues<global::ApiSdk.Models.DeviceConfigurationSettingState>(global::ApiSdk.Models.DeviceConfigurationSettingState.CreateFromDiscriminatorValue)?.AsList(); } },
                { "state", n => { State = n.GetEnumValue<global::ApiSdk.Models.ComplianceStatus>(); } },
                { "version", n => { Version = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<global::ApiSdk.Models.PolicyPlatformType>("platformType", PlatformType);
            writer.WriteIntValue("settingCount", SettingCount);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.DeviceConfigurationSettingState>("settingStates", SettingStates);
            writer.WriteEnumValue<global::ApiSdk.Models.ComplianceStatus>("state", State);
            writer.WriteIntValue("version", Version);
        }
    }
}
#pragma warning restore CS0618
