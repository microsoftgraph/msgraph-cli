using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ManagedAppProtection : ManagedAppPolicy, IParsable {
        /// <summary>Data storage locations where a user may store managed data.</summary>
        public List<ManagedAppDataStorageLocation?> AllowedDataStorageLocations { get; set; }
        /// <summary>Sources from which data is allowed to be transferred. Possible values are: allApps, managedApps, none.</summary>
        public ManagedAppDataTransferLevel? AllowedInboundDataTransferSources { get; set; }
        /// <summary>The level to which the clipboard may be shared between apps on the managed device. Possible values are: allApps, managedAppsWithPasteIn, managedApps, blocked.</summary>
        public ManagedAppClipboardSharingLevel? AllowedOutboundClipboardSharingLevel { get; set; }
        /// <summary>Destinations to which data is allowed to be transferred. Possible values are: allApps, managedApps, none.</summary>
        public ManagedAppDataTransferLevel? AllowedOutboundDataTransferDestinations { get; set; }
        /// <summary>Indicates whether contacts can be synced to the user's device.</summary>
        public bool? ContactSyncBlocked { get; set; }
        /// <summary>Indicates whether the backup of a managed app's data is blocked.</summary>
        public bool? DataBackupBlocked { get; set; }
        /// <summary>Indicates whether device compliance is required.</summary>
        public bool? DeviceComplianceRequired { get; set; }
        /// <summary>Indicates whether use of the app pin is required if the device pin is set.</summary>
        public bool? DisableAppPinIfDevicePinIsSet { get; set; }
        /// <summary>Indicates whether use of the fingerprint reader is allowed in place of a pin if PinRequired is set to True.</summary>
        public bool? FingerprintBlocked { get; set; }
        /// <summary>Indicates in which managed browser(s) that internet links should be opened. When this property is configured, ManagedBrowserToOpenLinksRequired should be true. Possible values are: notConfigured, microsoftEdge.</summary>
        public ManagedBrowserType? ManagedBrowser { get; set; }
        /// <summary>Indicates whether internet links should be opened in the managed browser app, or any custom browser specified by CustomBrowserProtocol (for iOS) or CustomBrowserPackageId/CustomBrowserDisplayName (for Android)</summary>
        public bool? ManagedBrowserToOpenLinksRequired { get; set; }
        /// <summary>Maximum number of incorrect pin retry attempts before the managed app is either blocked or wiped.</summary>
        public int? MaximumPinRetries { get; set; }
        /// <summary>Minimum pin length required for an app-level pin if PinRequired is set to True</summary>
        public int? MinimumPinLength { get; set; }
        /// <summary>Versions less than the specified version will block the managed app from accessing company data.</summary>
        public string MinimumRequiredAppVersion { get; set; }
        /// <summary>Versions less than the specified version will block the managed app from accessing company data.</summary>
        public string MinimumRequiredOsVersion { get; set; }
        /// <summary>Versions less than the specified version will result in warning message on the managed app.</summary>
        public string MinimumWarningAppVersion { get; set; }
        /// <summary>Versions less than the specified version will result in warning message on the managed app from accessing company data.</summary>
        public string MinimumWarningOsVersion { get; set; }
        /// <summary>Indicates whether organizational credentials are required for app use.</summary>
        public bool? OrganizationalCredentialsRequired { get; set; }
        /// <summary>TimePeriod before the all-level pin must be reset if PinRequired is set to True.</summary>
        public string PeriodBeforePinReset { get; set; }
        /// <summary>The period after which access is checked when the device is not connected to the internet.</summary>
        public string PeriodOfflineBeforeAccessCheck { get; set; }
        /// <summary>The amount of time an app is allowed to remain disconnected from the internet before all managed data it is wiped.</summary>
        public string PeriodOfflineBeforeWipeIsEnforced { get; set; }
        /// <summary>The period after which access is checked when the device is connected to the internet.</summary>
        public string PeriodOnlineBeforeAccessCheck { get; set; }
        /// <summary>Character set which may be used for an app-level pin if PinRequired is set to True. Possible values are: numeric, alphanumericAndSymbol.</summary>
        public ManagedAppPinCharacterSet? PinCharacterSet { get; set; }
        /// <summary>Indicates whether an app-level pin is required.</summary>
        public bool? PinRequired { get; set; }
        /// <summary>Indicates whether printing is allowed from managed apps.</summary>
        public bool? PrintBlocked { get; set; }
        /// <summary>Indicates whether users may use the 'Save As' menu item to save a copy of protected files.</summary>
        public bool? SaveAsBlocked { get; set; }
        /// <summary>Indicates whether simplePin is blocked.</summary>
        public bool? SimplePinBlocked { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"allowedDataStorageLocations", (o,n) => { (o as ManagedAppProtection).AllowedDataStorageLocations = n.GetCollectionOfEnumValues<ManagedAppDataStorageLocation>().ToList(); } },
                {"allowedInboundDataTransferSources", (o,n) => { (o as ManagedAppProtection).AllowedInboundDataTransferSources = n.GetEnumValue<ManagedAppDataTransferLevel>(); } },
                {"allowedOutboundClipboardSharingLevel", (o,n) => { (o as ManagedAppProtection).AllowedOutboundClipboardSharingLevel = n.GetEnumValue<ManagedAppClipboardSharingLevel>(); } },
                {"allowedOutboundDataTransferDestinations", (o,n) => { (o as ManagedAppProtection).AllowedOutboundDataTransferDestinations = n.GetEnumValue<ManagedAppDataTransferLevel>(); } },
                {"contactSyncBlocked", (o,n) => { (o as ManagedAppProtection).ContactSyncBlocked = n.GetBoolValue(); } },
                {"dataBackupBlocked", (o,n) => { (o as ManagedAppProtection).DataBackupBlocked = n.GetBoolValue(); } },
                {"deviceComplianceRequired", (o,n) => { (o as ManagedAppProtection).DeviceComplianceRequired = n.GetBoolValue(); } },
                {"disableAppPinIfDevicePinIsSet", (o,n) => { (o as ManagedAppProtection).DisableAppPinIfDevicePinIsSet = n.GetBoolValue(); } },
                {"fingerprintBlocked", (o,n) => { (o as ManagedAppProtection).FingerprintBlocked = n.GetBoolValue(); } },
                {"managedBrowser", (o,n) => { (o as ManagedAppProtection).ManagedBrowser = n.GetEnumValue<ManagedBrowserType>(); } },
                {"managedBrowserToOpenLinksRequired", (o,n) => { (o as ManagedAppProtection).ManagedBrowserToOpenLinksRequired = n.GetBoolValue(); } },
                {"maximumPinRetries", (o,n) => { (o as ManagedAppProtection).MaximumPinRetries = n.GetIntValue(); } },
                {"minimumPinLength", (o,n) => { (o as ManagedAppProtection).MinimumPinLength = n.GetIntValue(); } },
                {"minimumRequiredAppVersion", (o,n) => { (o as ManagedAppProtection).MinimumRequiredAppVersion = n.GetStringValue(); } },
                {"minimumRequiredOsVersion", (o,n) => { (o as ManagedAppProtection).MinimumRequiredOsVersion = n.GetStringValue(); } },
                {"minimumWarningAppVersion", (o,n) => { (o as ManagedAppProtection).MinimumWarningAppVersion = n.GetStringValue(); } },
                {"minimumWarningOsVersion", (o,n) => { (o as ManagedAppProtection).MinimumWarningOsVersion = n.GetStringValue(); } },
                {"organizationalCredentialsRequired", (o,n) => { (o as ManagedAppProtection).OrganizationalCredentialsRequired = n.GetBoolValue(); } },
                {"periodBeforePinReset", (o,n) => { (o as ManagedAppProtection).PeriodBeforePinReset = n.GetStringValue(); } },
                {"periodOfflineBeforeAccessCheck", (o,n) => { (o as ManagedAppProtection).PeriodOfflineBeforeAccessCheck = n.GetStringValue(); } },
                {"periodOfflineBeforeWipeIsEnforced", (o,n) => { (o as ManagedAppProtection).PeriodOfflineBeforeWipeIsEnforced = n.GetStringValue(); } },
                {"periodOnlineBeforeAccessCheck", (o,n) => { (o as ManagedAppProtection).PeriodOnlineBeforeAccessCheck = n.GetStringValue(); } },
                {"pinCharacterSet", (o,n) => { (o as ManagedAppProtection).PinCharacterSet = n.GetEnumValue<ManagedAppPinCharacterSet>(); } },
                {"pinRequired", (o,n) => { (o as ManagedAppProtection).PinRequired = n.GetBoolValue(); } },
                {"printBlocked", (o,n) => { (o as ManagedAppProtection).PrintBlocked = n.GetBoolValue(); } },
                {"saveAsBlocked", (o,n) => { (o as ManagedAppProtection).SaveAsBlocked = n.GetBoolValue(); } },
                {"simplePinBlocked", (o,n) => { (o as ManagedAppProtection).SimplePinBlocked = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfEnumValues<ManagedAppDataStorageLocation>("allowedDataStorageLocations", AllowedDataStorageLocations);
            writer.WriteEnumValue<ManagedAppDataTransferLevel>("allowedInboundDataTransferSources", AllowedInboundDataTransferSources);
            writer.WriteEnumValue<ManagedAppClipboardSharingLevel>("allowedOutboundClipboardSharingLevel", AllowedOutboundClipboardSharingLevel);
            writer.WriteEnumValue<ManagedAppDataTransferLevel>("allowedOutboundDataTransferDestinations", AllowedOutboundDataTransferDestinations);
            writer.WriteBoolValue("contactSyncBlocked", ContactSyncBlocked);
            writer.WriteBoolValue("dataBackupBlocked", DataBackupBlocked);
            writer.WriteBoolValue("deviceComplianceRequired", DeviceComplianceRequired);
            writer.WriteBoolValue("disableAppPinIfDevicePinIsSet", DisableAppPinIfDevicePinIsSet);
            writer.WriteBoolValue("fingerprintBlocked", FingerprintBlocked);
            writer.WriteEnumValue<ManagedBrowserType>("managedBrowser", ManagedBrowser);
            writer.WriteBoolValue("managedBrowserToOpenLinksRequired", ManagedBrowserToOpenLinksRequired);
            writer.WriteIntValue("maximumPinRetries", MaximumPinRetries);
            writer.WriteIntValue("minimumPinLength", MinimumPinLength);
            writer.WriteStringValue("minimumRequiredAppVersion", MinimumRequiredAppVersion);
            writer.WriteStringValue("minimumRequiredOsVersion", MinimumRequiredOsVersion);
            writer.WriteStringValue("minimumWarningAppVersion", MinimumWarningAppVersion);
            writer.WriteStringValue("minimumWarningOsVersion", MinimumWarningOsVersion);
            writer.WriteBoolValue("organizationalCredentialsRequired", OrganizationalCredentialsRequired);
            writer.WriteStringValue("periodBeforePinReset", PeriodBeforePinReset);
            writer.WriteStringValue("periodOfflineBeforeAccessCheck", PeriodOfflineBeforeAccessCheck);
            writer.WriteStringValue("periodOfflineBeforeWipeIsEnforced", PeriodOfflineBeforeWipeIsEnforced);
            writer.WriteStringValue("periodOnlineBeforeAccessCheck", PeriodOnlineBeforeAccessCheck);
            writer.WriteEnumValue<ManagedAppPinCharacterSet>("pinCharacterSet", PinCharacterSet);
            writer.WriteBoolValue("pinRequired", PinRequired);
            writer.WriteBoolValue("printBlocked", PrintBlocked);
            writer.WriteBoolValue("saveAsBlocked", SaveAsBlocked);
            writer.WriteBoolValue("simplePinBlocked", SimplePinBlocked);
        }
    }
}
