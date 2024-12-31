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
    /// Device Configuration Setting State for a given device.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DeviceConfigurationSettingState : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Current value of setting on device</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CurrentValue { get; set; }
#nullable restore
#else
        public string CurrentValue { get; set; }
#endif
        /// <summary>Error code for the setting</summary>
        public long? ErrorCode { get; set; }
        /// <summary>Error description</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ErrorDescription { get; set; }
#nullable restore
#else
        public string ErrorDescription { get; set; }
#endif
        /// <summary>Name of setting instance that is being reported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InstanceDisplayName { get; set; }
#nullable restore
#else
        public string InstanceDisplayName { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The setting that is being reported</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Setting { get; set; }
#nullable restore
#else
        public string Setting { get; set; }
#endif
        /// <summary>Localized/user friendly setting name that is being reported</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SettingName { get; set; }
#nullable restore
#else
        public string SettingName { get; set; }
#endif
        /// <summary>Contributing policies</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.SettingSource>? Sources { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.SettingSource> Sources { get; set; }
#endif
        /// <summary>The state property</summary>
        public global::ApiSdk.Models.ComplianceStatus? State { get; set; }
        /// <summary>UserEmail</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserEmail { get; set; }
#nullable restore
#else
        public string UserEmail { get; set; }
#endif
        /// <summary>UserId</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId { get; set; }
#nullable restore
#else
        public string UserId { get; set; }
#endif
        /// <summary>UserName</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserName { get; set; }
#nullable restore
#else
        public string UserName { get; set; }
#endif
        /// <summary>UserPrincipalName.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserPrincipalName { get; set; }
#nullable restore
#else
        public string UserPrincipalName { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.DeviceConfigurationSettingState"/> and sets the default values.
        /// </summary>
        public DeviceConfigurationSettingState()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.DeviceConfigurationSettingState"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.DeviceConfigurationSettingState CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.DeviceConfigurationSettingState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "currentValue", n => { CurrentValue = n.GetStringValue(); } },
                { "errorCode", n => { ErrorCode = n.GetLongValue(); } },
                { "errorDescription", n => { ErrorDescription = n.GetStringValue(); } },
                { "instanceDisplayName", n => { InstanceDisplayName = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "setting", n => { Setting = n.GetStringValue(); } },
                { "settingName", n => { SettingName = n.GetStringValue(); } },
                { "sources", n => { Sources = n.GetCollectionOfObjectValues<global::ApiSdk.Models.SettingSource>(global::ApiSdk.Models.SettingSource.CreateFromDiscriminatorValue)?.AsList(); } },
                { "state", n => { State = n.GetEnumValue<global::ApiSdk.Models.ComplianceStatus>(); } },
                { "userEmail", n => { UserEmail = n.GetStringValue(); } },
                { "userId", n => { UserId = n.GetStringValue(); } },
                { "userName", n => { UserName = n.GetStringValue(); } },
                { "userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("currentValue", CurrentValue);
            writer.WriteLongValue("errorCode", ErrorCode);
            writer.WriteStringValue("errorDescription", ErrorDescription);
            writer.WriteStringValue("instanceDisplayName", InstanceDisplayName);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("setting", Setting);
            writer.WriteStringValue("settingName", SettingName);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.SettingSource>("sources", Sources);
            writer.WriteEnumValue<global::ApiSdk.Models.ComplianceStatus>("state", State);
            writer.WriteStringValue("userEmail", UserEmail);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("userName", UserName);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
