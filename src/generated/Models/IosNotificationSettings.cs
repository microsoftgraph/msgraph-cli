using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    /// <summary>An item describing notification setting.</summary>
    public class IosNotificationSettings : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Notification Settings Alert Type.</summary>
        public IosNotificationAlertType? AlertType { get; set; }
        /// <summary>Application name to be associated with the bundleID.</summary>
        public string AppName { get; set; }
        /// <summary>Indicates whether badges are allowed for this app.</summary>
        public bool? BadgesEnabled { get; set; }
        /// <summary>Bundle id of app to which to apply these notification settings.</summary>
        public string BundleID { get; set; }
        /// <summary>Indicates whether notifications are allowed for this app.</summary>
        public bool? Enabled { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>Publisher to be associated with the bundleID.</summary>
        public string Publisher { get; set; }
        /// <summary>Indicates whether notifications can be shown in notification center.</summary>
        public bool? ShowInNotificationCenter { get; set; }
        /// <summary>Indicates whether notifications can be shown on the lock screen.</summary>
        public bool? ShowOnLockScreen { get; set; }
        /// <summary>Indicates whether sounds are allowed for this app.</summary>
        public bool? SoundsEnabled { get; set; }
        /// <summary>
        /// Instantiates a new iosNotificationSettings and sets the default values.
        /// </summary>
        public IosNotificationSettings() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.iosNotificationSettings";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static IosNotificationSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IosNotificationSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"alertType", n => { AlertType = n.GetEnumValue<IosNotificationAlertType>(); } },
                {"appName", n => { AppName = n.GetStringValue(); } },
                {"badgesEnabled", n => { BadgesEnabled = n.GetBoolValue(); } },
                {"bundleID", n => { BundleID = n.GetStringValue(); } },
                {"enabled", n => { Enabled = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"publisher", n => { Publisher = n.GetStringValue(); } },
                {"showInNotificationCenter", n => { ShowInNotificationCenter = n.GetBoolValue(); } },
                {"showOnLockScreen", n => { ShowOnLockScreen = n.GetBoolValue(); } },
                {"soundsEnabled", n => { SoundsEnabled = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<IosNotificationAlertType>("alertType", AlertType);
            writer.WriteStringValue("appName", AppName);
            writer.WriteBoolValue("badgesEnabled", BadgesEnabled);
            writer.WriteStringValue("bundleID", BundleID);
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("publisher", Publisher);
            writer.WriteBoolValue("showInNotificationCenter", ShowInNotificationCenter);
            writer.WriteBoolValue("showOnLockScreen", ShowOnLockScreen);
            writer.WriteBoolValue("soundsEnabled", SoundsEnabled);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
