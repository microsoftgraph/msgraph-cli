using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class AndroidGeneralDeviceConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Indicates whether or not to block clipboard sharing to copy and paste between applications.</summary>
        public bool? AppsBlockClipboardSharing { get; set; }
        /// <summary>Indicates whether or not to block copy and paste within applications.</summary>
        public bool? AppsBlockCopyPaste { get; set; }
        /// <summary>Indicates whether or not to block the YouTube app.</summary>
        public bool? AppsBlockYouTube { get; set; }
        /// <summary>List of apps to be hidden on the KNOX device. This collection can contain a maximum of 500 elements.</summary>
        public List<AppListItem> AppsHideList { get; set; }
        /// <summary>List of apps which can be installed on the KNOX device. This collection can contain a maximum of 500 elements.</summary>
        public List<AppListItem> AppsInstallAllowList { get; set; }
        /// <summary>List of apps which are blocked from being launched on the KNOX device. This collection can contain a maximum of 500 elements.</summary>
        public List<AppListItem> AppsLaunchBlockList { get; set; }
        /// <summary>Indicates whether or not to block Bluetooth.</summary>
        public bool? BluetoothBlocked { get; set; }
        /// <summary>Indicates whether or not to block the use of the camera.</summary>
        public bool? CameraBlocked { get; set; }
        /// <summary>Indicates whether or not to block data roaming.</summary>
        public bool? CellularBlockDataRoaming { get; set; }
        /// <summary>Indicates whether or not to block SMS/MMS messaging.</summary>
        public bool? CellularBlockMessaging { get; set; }
        /// <summary>Indicates whether or not to block voice roaming.</summary>
        public bool? CellularBlockVoiceRoaming { get; set; }
        /// <summary>Indicates whether or not to block syncing Wi-Fi tethering.</summary>
        public bool? CellularBlockWiFiTethering { get; set; }
        /// <summary>Possible values of the compliance app list.</summary>
        public AppListType? CompliantAppListType { get; set; }
        /// <summary>List of apps in the compliance (either allow list or block list, controlled by CompliantAppListType). This collection can contain a maximum of 10000 elements.</summary>
        public List<AppListItem> CompliantAppsList { get; set; }
        /// <summary>Indicates whether or not to allow device sharing mode.</summary>
        public bool? DeviceSharingAllowed { get; set; }
        /// <summary>Indicates whether or not to block diagnostic data submission.</summary>
        public bool? DiagnosticDataBlockSubmission { get; set; }
        /// <summary>Indicates whether or not to block user performing a factory reset.</summary>
        public bool? FactoryResetBlocked { get; set; }
        /// <summary>Indicates whether or not to block Google account auto sync.</summary>
        public bool? GoogleAccountBlockAutoSync { get; set; }
        /// <summary>Indicates whether or not to block the Google Play store.</summary>
        public bool? GooglePlayStoreBlocked { get; set; }
        /// <summary>A list of apps that will be allowed to run when the device is in Kiosk Mode. This collection can contain a maximum of 500 elements.</summary>
        public List<AppListItem> KioskModeApps { get; set; }
        /// <summary>Indicates whether or not to block the screen sleep button while in Kiosk Mode.</summary>
        public bool? KioskModeBlockSleepButton { get; set; }
        /// <summary>Indicates whether or not to block the volume buttons while in Kiosk Mode.</summary>
        public bool? KioskModeBlockVolumeButtons { get; set; }
        /// <summary>Indicates whether or not to block location services.</summary>
        public bool? LocationServicesBlocked { get; set; }
        /// <summary>Indicates whether or not to block Near-Field Communication.</summary>
        public bool? NfcBlocked { get; set; }
        /// <summary>Indicates whether or not to block fingerprint unlock.</summary>
        public bool? PasswordBlockFingerprintUnlock { get; set; }
        /// <summary>Indicates whether or not to block Smart Lock and other trust agents.</summary>
        public bool? PasswordBlockTrustAgents { get; set; }
        /// <summary>Number of days before the password expires. Valid values 1 to 365</summary>
        public int? PasswordExpirationDays { get; set; }
        /// <summary>Minimum length of passwords. Valid values 4 to 16</summary>
        public int? PasswordMinimumLength { get; set; }
        /// <summary>Minutes of inactivity before the screen times out.</summary>
        public int? PasswordMinutesOfInactivityBeforeScreenTimeout { get; set; }
        /// <summary>Number of previous passwords to block. Valid values 0 to 24</summary>
        public int? PasswordPreviousPasswordBlockCount { get; set; }
        /// <summary>Indicates whether or not to require a password.</summary>
        public bool? PasswordRequired { get; set; }
        /// <summary>Android required password type.</summary>
        public AndroidRequiredPasswordType? PasswordRequiredType { get; set; }
        /// <summary>Number of sign in failures allowed before factory reset. Valid values 1 to 16</summary>
        public int? PasswordSignInFailureCountBeforeFactoryReset { get; set; }
        /// <summary>Indicates whether or not to block powering off the device.</summary>
        public bool? PowerOffBlocked { get; set; }
        /// <summary>Indicates whether or not to block screenshots.</summary>
        public bool? ScreenCaptureBlocked { get; set; }
        /// <summary>Require the Android Verify apps feature is turned on.</summary>
        public bool? SecurityRequireVerifyApps { get; set; }
        /// <summary>Indicates whether or not to block Google Backup.</summary>
        public bool? StorageBlockGoogleBackup { get; set; }
        /// <summary>Indicates whether or not to block removable storage usage.</summary>
        public bool? StorageBlockRemovableStorage { get; set; }
        /// <summary>Indicates whether or not to require device encryption.</summary>
        public bool? StorageRequireDeviceEncryption { get; set; }
        /// <summary>Indicates whether or not to require removable storage encryption.</summary>
        public bool? StorageRequireRemovableStorageEncryption { get; set; }
        /// <summary>Indicates whether or not to block the use of the Voice Assistant.</summary>
        public bool? VoiceAssistantBlocked { get; set; }
        /// <summary>Indicates whether or not to block voice dialing.</summary>
        public bool? VoiceDialingBlocked { get; set; }
        /// <summary>Indicates whether or not to block the web browser&apos;s auto fill feature.</summary>
        public bool? WebBrowserBlockAutofill { get; set; }
        /// <summary>Indicates whether or not to block the web browser.</summary>
        public bool? WebBrowserBlocked { get; set; }
        /// <summary>Indicates whether or not to block JavaScript within the web browser.</summary>
        public bool? WebBrowserBlockJavaScript { get; set; }
        /// <summary>Indicates whether or not to block popups within the web browser.</summary>
        public bool? WebBrowserBlockPopups { get; set; }
        /// <summary>Web Browser Cookie Settings.</summary>
        public ApiSdk.Models.WebBrowserCookieSettings? WebBrowserCookieSettings { get; set; }
        /// <summary>Indicates whether or not to block syncing Wi-Fi.</summary>
        public bool? WiFiBlocked { get; set; }
        /// <summary>
        /// Instantiates a new AndroidGeneralDeviceConfiguration and sets the default values.
        /// </summary>
        public AndroidGeneralDeviceConfiguration() : base() {
            OdataType = "#microsoft.graph.androidGeneralDeviceConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AndroidGeneralDeviceConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidGeneralDeviceConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appsBlockClipboardSharing", n => { AppsBlockClipboardSharing = n.GetBoolValue(); } },
                {"appsBlockCopyPaste", n => { AppsBlockCopyPaste = n.GetBoolValue(); } },
                {"appsBlockYouTube", n => { AppsBlockYouTube = n.GetBoolValue(); } },
                {"appsHideList", n => { AppsHideList = n.GetCollectionOfObjectValues<AppListItem>(AppListItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"appsInstallAllowList", n => { AppsInstallAllowList = n.GetCollectionOfObjectValues<AppListItem>(AppListItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"appsLaunchBlockList", n => { AppsLaunchBlockList = n.GetCollectionOfObjectValues<AppListItem>(AppListItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"bluetoothBlocked", n => { BluetoothBlocked = n.GetBoolValue(); } },
                {"cameraBlocked", n => { CameraBlocked = n.GetBoolValue(); } },
                {"cellularBlockDataRoaming", n => { CellularBlockDataRoaming = n.GetBoolValue(); } },
                {"cellularBlockMessaging", n => { CellularBlockMessaging = n.GetBoolValue(); } },
                {"cellularBlockVoiceRoaming", n => { CellularBlockVoiceRoaming = n.GetBoolValue(); } },
                {"cellularBlockWiFiTethering", n => { CellularBlockWiFiTethering = n.GetBoolValue(); } },
                {"compliantAppListType", n => { CompliantAppListType = n.GetEnumValue<AppListType>(); } },
                {"compliantAppsList", n => { CompliantAppsList = n.GetCollectionOfObjectValues<AppListItem>(AppListItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceSharingAllowed", n => { DeviceSharingAllowed = n.GetBoolValue(); } },
                {"diagnosticDataBlockSubmission", n => { DiagnosticDataBlockSubmission = n.GetBoolValue(); } },
                {"factoryResetBlocked", n => { FactoryResetBlocked = n.GetBoolValue(); } },
                {"googleAccountBlockAutoSync", n => { GoogleAccountBlockAutoSync = n.GetBoolValue(); } },
                {"googlePlayStoreBlocked", n => { GooglePlayStoreBlocked = n.GetBoolValue(); } },
                {"kioskModeApps", n => { KioskModeApps = n.GetCollectionOfObjectValues<AppListItem>(AppListItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"kioskModeBlockSleepButton", n => { KioskModeBlockSleepButton = n.GetBoolValue(); } },
                {"kioskModeBlockVolumeButtons", n => { KioskModeBlockVolumeButtons = n.GetBoolValue(); } },
                {"locationServicesBlocked", n => { LocationServicesBlocked = n.GetBoolValue(); } },
                {"nfcBlocked", n => { NfcBlocked = n.GetBoolValue(); } },
                {"passwordBlockFingerprintUnlock", n => { PasswordBlockFingerprintUnlock = n.GetBoolValue(); } },
                {"passwordBlockTrustAgents", n => { PasswordBlockTrustAgents = n.GetBoolValue(); } },
                {"passwordExpirationDays", n => { PasswordExpirationDays = n.GetIntValue(); } },
                {"passwordMinimumLength", n => { PasswordMinimumLength = n.GetIntValue(); } },
                {"passwordMinutesOfInactivityBeforeScreenTimeout", n => { PasswordMinutesOfInactivityBeforeScreenTimeout = n.GetIntValue(); } },
                {"passwordPreviousPasswordBlockCount", n => { PasswordPreviousPasswordBlockCount = n.GetIntValue(); } },
                {"passwordRequired", n => { PasswordRequired = n.GetBoolValue(); } },
                {"passwordRequiredType", n => { PasswordRequiredType = n.GetEnumValue<AndroidRequiredPasswordType>(); } },
                {"passwordSignInFailureCountBeforeFactoryReset", n => { PasswordSignInFailureCountBeforeFactoryReset = n.GetIntValue(); } },
                {"powerOffBlocked", n => { PowerOffBlocked = n.GetBoolValue(); } },
                {"screenCaptureBlocked", n => { ScreenCaptureBlocked = n.GetBoolValue(); } },
                {"securityRequireVerifyApps", n => { SecurityRequireVerifyApps = n.GetBoolValue(); } },
                {"storageBlockGoogleBackup", n => { StorageBlockGoogleBackup = n.GetBoolValue(); } },
                {"storageBlockRemovableStorage", n => { StorageBlockRemovableStorage = n.GetBoolValue(); } },
                {"storageRequireDeviceEncryption", n => { StorageRequireDeviceEncryption = n.GetBoolValue(); } },
                {"storageRequireRemovableStorageEncryption", n => { StorageRequireRemovableStorageEncryption = n.GetBoolValue(); } },
                {"voiceAssistantBlocked", n => { VoiceAssistantBlocked = n.GetBoolValue(); } },
                {"voiceDialingBlocked", n => { VoiceDialingBlocked = n.GetBoolValue(); } },
                {"webBrowserBlockAutofill", n => { WebBrowserBlockAutofill = n.GetBoolValue(); } },
                {"webBrowserBlocked", n => { WebBrowserBlocked = n.GetBoolValue(); } },
                {"webBrowserBlockJavaScript", n => { WebBrowserBlockJavaScript = n.GetBoolValue(); } },
                {"webBrowserBlockPopups", n => { WebBrowserBlockPopups = n.GetBoolValue(); } },
                {"webBrowserCookieSettings", n => { WebBrowserCookieSettings = n.GetEnumValue<WebBrowserCookieSettings>(); } },
                {"wiFiBlocked", n => { WiFiBlocked = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("appsBlockClipboardSharing", AppsBlockClipboardSharing);
            writer.WriteBoolValue("appsBlockCopyPaste", AppsBlockCopyPaste);
            writer.WriteBoolValue("appsBlockYouTube", AppsBlockYouTube);
            writer.WriteCollectionOfObjectValues<AppListItem>("appsHideList", AppsHideList);
            writer.WriteCollectionOfObjectValues<AppListItem>("appsInstallAllowList", AppsInstallAllowList);
            writer.WriteCollectionOfObjectValues<AppListItem>("appsLaunchBlockList", AppsLaunchBlockList);
            writer.WriteBoolValue("bluetoothBlocked", BluetoothBlocked);
            writer.WriteBoolValue("cameraBlocked", CameraBlocked);
            writer.WriteBoolValue("cellularBlockDataRoaming", CellularBlockDataRoaming);
            writer.WriteBoolValue("cellularBlockMessaging", CellularBlockMessaging);
            writer.WriteBoolValue("cellularBlockVoiceRoaming", CellularBlockVoiceRoaming);
            writer.WriteBoolValue("cellularBlockWiFiTethering", CellularBlockWiFiTethering);
            writer.WriteEnumValue<AppListType>("compliantAppListType", CompliantAppListType);
            writer.WriteCollectionOfObjectValues<AppListItem>("compliantAppsList", CompliantAppsList);
            writer.WriteBoolValue("deviceSharingAllowed", DeviceSharingAllowed);
            writer.WriteBoolValue("diagnosticDataBlockSubmission", DiagnosticDataBlockSubmission);
            writer.WriteBoolValue("factoryResetBlocked", FactoryResetBlocked);
            writer.WriteBoolValue("googleAccountBlockAutoSync", GoogleAccountBlockAutoSync);
            writer.WriteBoolValue("googlePlayStoreBlocked", GooglePlayStoreBlocked);
            writer.WriteCollectionOfObjectValues<AppListItem>("kioskModeApps", KioskModeApps);
            writer.WriteBoolValue("kioskModeBlockSleepButton", KioskModeBlockSleepButton);
            writer.WriteBoolValue("kioskModeBlockVolumeButtons", KioskModeBlockVolumeButtons);
            writer.WriteBoolValue("locationServicesBlocked", LocationServicesBlocked);
            writer.WriteBoolValue("nfcBlocked", NfcBlocked);
            writer.WriteBoolValue("passwordBlockFingerprintUnlock", PasswordBlockFingerprintUnlock);
            writer.WriteBoolValue("passwordBlockTrustAgents", PasswordBlockTrustAgents);
            writer.WriteIntValue("passwordExpirationDays", PasswordExpirationDays);
            writer.WriteIntValue("passwordMinimumLength", PasswordMinimumLength);
            writer.WriteIntValue("passwordMinutesOfInactivityBeforeScreenTimeout", PasswordMinutesOfInactivityBeforeScreenTimeout);
            writer.WriteIntValue("passwordPreviousPasswordBlockCount", PasswordPreviousPasswordBlockCount);
            writer.WriteBoolValue("passwordRequired", PasswordRequired);
            writer.WriteEnumValue<AndroidRequiredPasswordType>("passwordRequiredType", PasswordRequiredType);
            writer.WriteIntValue("passwordSignInFailureCountBeforeFactoryReset", PasswordSignInFailureCountBeforeFactoryReset);
            writer.WriteBoolValue("powerOffBlocked", PowerOffBlocked);
            writer.WriteBoolValue("screenCaptureBlocked", ScreenCaptureBlocked);
            writer.WriteBoolValue("securityRequireVerifyApps", SecurityRequireVerifyApps);
            writer.WriteBoolValue("storageBlockGoogleBackup", StorageBlockGoogleBackup);
            writer.WriteBoolValue("storageBlockRemovableStorage", StorageBlockRemovableStorage);
            writer.WriteBoolValue("storageRequireDeviceEncryption", StorageRequireDeviceEncryption);
            writer.WriteBoolValue("storageRequireRemovableStorageEncryption", StorageRequireRemovableStorageEncryption);
            writer.WriteBoolValue("voiceAssistantBlocked", VoiceAssistantBlocked);
            writer.WriteBoolValue("voiceDialingBlocked", VoiceDialingBlocked);
            writer.WriteBoolValue("webBrowserBlockAutofill", WebBrowserBlockAutofill);
            writer.WriteBoolValue("webBrowserBlocked", WebBrowserBlocked);
            writer.WriteBoolValue("webBrowserBlockJavaScript", WebBrowserBlockJavaScript);
            writer.WriteBoolValue("webBrowserBlockPopups", WebBrowserBlockPopups);
            writer.WriteEnumValue<WebBrowserCookieSettings>("webBrowserCookieSettings", WebBrowserCookieSettings);
            writer.WriteBoolValue("wiFiBlocked", WiFiBlocked);
        }
    }
}
