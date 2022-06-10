using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class ManagedAppProtection : ManagedAppPolicy, IParsable {
        /// <summary>Data storage locations where a user may store managed data.</summary>
        public List<string> AllowedDataStorageLocations { get; set; }
        /// <summary>Sources from which data is allowed to be transferred. Possible values are: allApps, managedApps, none.</summary>
        public ManagedAppDataTransferLevel? AllowedInboundDataTransferSources { get; set; }
        /// <summary>The level to which the clipboard may be shared between apps on the managed device. Possible values are: allApps, managedAppsWithPasteIn, managedApps, blocked.</summary>
        public ManagedAppClipboardSharingLevel? AllowedOutboundClipboardSharingLevel { get; set; }
        /// <summary>Destinations to which data is allowed to be transferred. Possible values are: allApps, managedApps, none.</summary>
        public ManagedAppDataTransferLevel? AllowedOutboundDataTransferDestinations { get; set; }
        /// <summary>Indicates whether contacts can be synced to the user&apos;s device.</summary>
        public bool? ContactSyncBlocked { get; set; }
        /// <summary>Indicates whether the backup of a managed app&apos;s data is blocked.</summary>
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
        public TimeSpan? PeriodBeforePinReset { get; set; }
        /// <summary>The period after which access is checked when the device is not connected to the internet.</summary>
        public TimeSpan? PeriodOfflineBeforeAccessCheck { get; set; }
        /// <summary>The amount of time an app is allowed to remain disconnected from the internet before all managed data it is wiped.</summary>
        public TimeSpan? PeriodOfflineBeforeWipeIsEnforced { get; set; }
        /// <summary>The period after which access is checked when the device is connected to the internet.</summary>
        public TimeSpan? PeriodOnlineBeforeAccessCheck { get; set; }
        /// <summary>Character set which may be used for an app-level pin if PinRequired is set to True. Possible values are: numeric, alphanumericAndSymbol.</summary>
        public ManagedAppPinCharacterSet? PinCharacterSet { get; set; }
        /// <summary>Indicates whether an app-level pin is required.</summary>
        public bool? PinRequired { get; set; }
        /// <summary>Indicates whether printing is allowed from managed apps.</summary>
        public bool? PrintBlocked { get; set; }
        /// <summary>Indicates whether users may use the &apos;Save As&apos; menu item to save a copy of protected files.</summary>
        public bool? SaveAsBlocked { get; set; }
        /// <summary>Indicates whether simplePin is blocked.</summary>
        public bool? SimplePinBlocked { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ManagedAppProtection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagedAppProtection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowedDataStorageLocations", n => { AllowedDataStorageLocations = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"allowedInboundDataTransferSources", n => { AllowedInboundDataTransferSources = n.GetEnumValue<ManagedAppDataTransferLevel>(); } },
                {"allowedOutboundClipboardSharingLevel", n => { AllowedOutboundClipboardSharingLevel = n.GetEnumValue<ManagedAppClipboardSharingLevel>(); } },
                {"allowedOutboundDataTransferDestinations", n => { AllowedOutboundDataTransferDestinations = n.GetEnumValue<ManagedAppDataTransferLevel>(); } },
                {"contactSyncBlocked", n => { ContactSyncBlocked = n.GetBoolValue(); } },
                {"dataBackupBlocked", n => { DataBackupBlocked = n.GetBoolValue(); } },
                {"deviceComplianceRequired", n => { DeviceComplianceRequired = n.GetBoolValue(); } },
                {"disableAppPinIfDevicePinIsSet", n => { DisableAppPinIfDevicePinIsSet = n.GetBoolValue(); } },
                {"fingerprintBlocked", n => { FingerprintBlocked = n.GetBoolValue(); } },
                {"managedBrowser", n => { ManagedBrowser = n.GetEnumValue<ManagedBrowserType>(); } },
                {"managedBrowserToOpenLinksRequired", n => { ManagedBrowserToOpenLinksRequired = n.GetBoolValue(); } },
                {"maximumPinRetries", n => { MaximumPinRetries = n.GetIntValue(); } },
                {"minimumPinLength", n => { MinimumPinLength = n.GetIntValue(); } },
                {"minimumRequiredAppVersion", n => { MinimumRequiredAppVersion = n.GetStringValue(); } },
                {"minimumRequiredOsVersion", n => { MinimumRequiredOsVersion = n.GetStringValue(); } },
                {"minimumWarningAppVersion", n => { MinimumWarningAppVersion = n.GetStringValue(); } },
                {"minimumWarningOsVersion", n => { MinimumWarningOsVersion = n.GetStringValue(); } },
                {"organizationalCredentialsRequired", n => { OrganizationalCredentialsRequired = n.GetBoolValue(); } },
                {"periodBeforePinReset", n => { PeriodBeforePinReset = n.GetTimeSpanValue(); } },
                {"periodOfflineBeforeAccessCheck", n => { PeriodOfflineBeforeAccessCheck = n.GetTimeSpanValue(); } },
                {"periodOfflineBeforeWipeIsEnforced", n => { PeriodOfflineBeforeWipeIsEnforced = n.GetTimeSpanValue(); } },
                {"periodOnlineBeforeAccessCheck", n => { PeriodOnlineBeforeAccessCheck = n.GetTimeSpanValue(); } },
                {"pinCharacterSet", n => { PinCharacterSet = n.GetEnumValue<ManagedAppPinCharacterSet>(); } },
                {"pinRequired", n => { PinRequired = n.GetBoolValue(); } },
                {"printBlocked", n => { PrintBlocked = n.GetBoolValue(); } },
                {"saveAsBlocked", n => { SaveAsBlocked = n.GetBoolValue(); } },
                {"simplePinBlocked", n => { SimplePinBlocked = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("allowedDataStorageLocations", AllowedDataStorageLocations);
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
            writer.WriteTimeSpanValue("periodBeforePinReset", PeriodBeforePinReset);
            writer.WriteTimeSpanValue("periodOfflineBeforeAccessCheck", PeriodOfflineBeforeAccessCheck);
            writer.WriteTimeSpanValue("periodOfflineBeforeWipeIsEnforced", PeriodOfflineBeforeWipeIsEnforced);
            writer.WriteTimeSpanValue("periodOnlineBeforeAccessCheck", PeriodOnlineBeforeAccessCheck);
            writer.WriteEnumValue<ManagedAppPinCharacterSet>("pinCharacterSet", PinCharacterSet);
            writer.WriteBoolValue("pinRequired", PinRequired);
            writer.WriteBoolValue("printBlocked", PrintBlocked);
            writer.WriteBoolValue("saveAsBlocked", SaveAsBlocked);
            writer.WriteBoolValue("simplePinBlocked", SimplePinBlocked);
        }
    }
}
