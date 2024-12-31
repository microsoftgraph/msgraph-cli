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
    /// Contains properties used to assign an Win32 LOB mobile app to a group.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Win32LobAppAssignmentSettings : global::ApiSdk.Models.MobileAppAssignmentSettings, IParsable
    {
        /// <summary>The auto-update settings to apply for this app assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Win32LobAppAutoUpdateSettings? AutoUpdateSettings { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Win32LobAppAutoUpdateSettings AutoUpdateSettings { get; set; }
#endif
        /// <summary>Contains value for delivery optimization priority.</summary>
        public global::ApiSdk.Models.Win32LobAppDeliveryOptimizationPriority? DeliveryOptimizationPriority { get; set; }
        /// <summary>The install time settings to apply for this app assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.MobileAppInstallTimeSettings? InstallTimeSettings { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.MobileAppInstallTimeSettings InstallTimeSettings { get; set; }
#endif
        /// <summary>Contains value for notification status.</summary>
        public global::ApiSdk.Models.Win32LobAppNotification? Notifications { get; set; }
        /// <summary>The reboot settings to apply for this app assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Win32LobAppRestartSettings? RestartSettings { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Win32LobAppRestartSettings RestartSettings { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.Win32LobAppAssignmentSettings"/> and sets the default values.
        /// </summary>
        public Win32LobAppAssignmentSettings() : base()
        {
            OdataType = "#microsoft.graph.win32LobAppAssignmentSettings";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.Win32LobAppAssignmentSettings"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.Win32LobAppAssignmentSettings CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.Win32LobAppAssignmentSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "autoUpdateSettings", n => { AutoUpdateSettings = n.GetObjectValue<global::ApiSdk.Models.Win32LobAppAutoUpdateSettings>(global::ApiSdk.Models.Win32LobAppAutoUpdateSettings.CreateFromDiscriminatorValue); } },
                { "deliveryOptimizationPriority", n => { DeliveryOptimizationPriority = n.GetEnumValue<global::ApiSdk.Models.Win32LobAppDeliveryOptimizationPriority>(); } },
                { "installTimeSettings", n => { InstallTimeSettings = n.GetObjectValue<global::ApiSdk.Models.MobileAppInstallTimeSettings>(global::ApiSdk.Models.MobileAppInstallTimeSettings.CreateFromDiscriminatorValue); } },
                { "notifications", n => { Notifications = n.GetEnumValue<global::ApiSdk.Models.Win32LobAppNotification>(); } },
                { "restartSettings", n => { RestartSettings = n.GetObjectValue<global::ApiSdk.Models.Win32LobAppRestartSettings>(global::ApiSdk.Models.Win32LobAppRestartSettings.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::ApiSdk.Models.Win32LobAppAutoUpdateSettings>("autoUpdateSettings", AutoUpdateSettings);
            writer.WriteEnumValue<global::ApiSdk.Models.Win32LobAppDeliveryOptimizationPriority>("deliveryOptimizationPriority", DeliveryOptimizationPriority);
            writer.WriteObjectValue<global::ApiSdk.Models.MobileAppInstallTimeSettings>("installTimeSettings", InstallTimeSettings);
            writer.WriteEnumValue<global::ApiSdk.Models.Win32LobAppNotification>("notifications", Notifications);
            writer.WriteObjectValue<global::ApiSdk.Models.Win32LobAppRestartSettings>("restartSettings", RestartSettings);
        }
    }
}
#pragma warning restore CS0618
