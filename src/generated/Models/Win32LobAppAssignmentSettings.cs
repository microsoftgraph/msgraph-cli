using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class Win32LobAppAssignmentSettings : MobileAppAssignmentSettings, IParsable {
        /// <summary>Contains value for delivery optimization priority.</summary>
        public Win32LobAppDeliveryOptimizationPriority? DeliveryOptimizationPriority { get; set; }
        /// <summary>The install time settings to apply for this app assignment.</summary>
        public MobileAppInstallTimeSettings InstallTimeSettings { get; set; }
        /// <summary>Contains value for notification status.</summary>
        public Win32LobAppNotification? Notifications { get; set; }
        /// <summary>The reboot settings to apply for this app assignment.</summary>
        public Win32LobAppRestartSettings RestartSettings { get; set; }
        /// <summary>
        /// Instantiates a new Win32LobAppAssignmentSettings and sets the default values.
        /// </summary>
        public Win32LobAppAssignmentSettings() : base() {
            OdataType = "#microsoft.graph.win32LobAppAssignmentSettings";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Win32LobAppAssignmentSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Win32LobAppAssignmentSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"deliveryOptimizationPriority", n => { DeliveryOptimizationPriority = n.GetEnumValue<Win32LobAppDeliveryOptimizationPriority>(); } },
                {"installTimeSettings", n => { InstallTimeSettings = n.GetObjectValue<MobileAppInstallTimeSettings>(MobileAppInstallTimeSettings.CreateFromDiscriminatorValue); } },
                {"notifications", n => { Notifications = n.GetEnumValue<Win32LobAppNotification>(); } },
                {"restartSettings", n => { RestartSettings = n.GetObjectValue<Win32LobAppRestartSettings>(Win32LobAppRestartSettings.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<Win32LobAppDeliveryOptimizationPriority>("deliveryOptimizationPriority", DeliveryOptimizationPriority);
            writer.WriteObjectValue<MobileAppInstallTimeSettings>("installTimeSettings", InstallTimeSettings);
            writer.WriteEnumValue<Win32LobAppNotification>("notifications", Notifications);
            writer.WriteObjectValue<Win32LobAppRestartSettings>("restartSettings", RestartSettings);
        }
    }
}
