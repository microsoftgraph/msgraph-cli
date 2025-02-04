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
    /// This topic provides descriptions of the declared methods, properties and relationships exposed by the windows81GeneralConfiguration resource.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Windows81GeneralConfiguration : global::ApiSdk.Models.DeviceConfiguration, IParsable
    {
        /// <summary>Indicates whether or not to Block the user from adding email accounts to the device that are not associated with a Microsoft account.</summary>
        public bool? AccountsBlockAddingNonMicrosoftAccountEmail { get; set; }
        /// <summary>Value indicating whether this policy only applies to Windows 8.1. This property is read-only.</summary>
        public bool? ApplyOnlyToWindows81 { get; private set; }
        /// <summary>Indicates whether or not to block auto fill.</summary>
        public bool? BrowserBlockAutofill { get; set; }
        /// <summary>Indicates whether or not to block automatic detection of Intranet sites.</summary>
        public bool? BrowserBlockAutomaticDetectionOfIntranetSites { get; set; }
        /// <summary>Indicates whether or not to block enterprise mode access.</summary>
        public bool? BrowserBlockEnterpriseModeAccess { get; set; }
        /// <summary>Indicates whether or not to Block the user from using JavaScript.</summary>
        public bool? BrowserBlockJavaScript { get; set; }
        /// <summary>Indicates whether or not to block plug-ins.</summary>
        public bool? BrowserBlockPlugins { get; set; }
        /// <summary>Indicates whether or not to block popups.</summary>
        public bool? BrowserBlockPopups { get; set; }
        /// <summary>Indicates whether or not to Block the user from sending the do not track header.</summary>
        public bool? BrowserBlockSendingDoNotTrackHeader { get; set; }
        /// <summary>Indicates whether or not to block a single word entry on Intranet sites.</summary>
        public bool? BrowserBlockSingleWordEntryOnIntranetSites { get; set; }
        /// <summary>The enterprise mode site list location. Could be a local file, local network or http location.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BrowserEnterpriseModeSiteListLocation { get; set; }
#nullable restore
#else
        public string BrowserEnterpriseModeSiteListLocation { get; set; }
#endif
        /// <summary>Possible values for internet site security level.</summary>
        public global::ApiSdk.Models.InternetSiteSecurityLevel? BrowserInternetSecurityLevel { get; set; }
        /// <summary>Possible values for site security level.</summary>
        public global::ApiSdk.Models.SiteSecurityLevel? BrowserIntranetSecurityLevel { get; set; }
        /// <summary>The logging report location.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BrowserLoggingReportLocation { get; set; }
#nullable restore
#else
        public string BrowserLoggingReportLocation { get; set; }
#endif
        /// <summary>Indicates whether or not to require a firewall.</summary>
        public bool? BrowserRequireFirewall { get; set; }
        /// <summary>Indicates whether or not to require fraud warning.</summary>
        public bool? BrowserRequireFraudWarning { get; set; }
        /// <summary>Indicates whether or not to require high security for restricted sites.</summary>
        public bool? BrowserRequireHighSecurityForRestrictedSites { get; set; }
        /// <summary>Indicates whether or not to require the user to use the smart screen filter.</summary>
        public bool? BrowserRequireSmartScreen { get; set; }
        /// <summary>Possible values for site security level.</summary>
        public global::ApiSdk.Models.SiteSecurityLevel? BrowserTrustedSitesSecurityLevel { get; set; }
        /// <summary>Indicates whether or not to block data roaming.</summary>
        public bool? CellularBlockDataRoaming { get; set; }
        /// <summary>Indicates whether or not to block diagnostic data submission.</summary>
        public bool? DiagnosticsBlockDataSubmission { get; set; }
        /// <summary>Indicates whether or not to Block the user from using a pictures password and pin.</summary>
        public bool? PasswordBlockPicturePasswordAndPin { get; set; }
        /// <summary>Password expiration in days.</summary>
        public int? PasswordExpirationDays { get; set; }
        /// <summary>The number of character sets required in the password.</summary>
        public int? PasswordMinimumCharacterSetCount { get; set; }
        /// <summary>The minimum password length.</summary>
        public int? PasswordMinimumLength { get; set; }
        /// <summary>The minutes of inactivity before the screen times out.</summary>
        public int? PasswordMinutesOfInactivityBeforeScreenTimeout { get; set; }
        /// <summary>The number of previous passwords to prevent re-use of. Valid values 0 to 24</summary>
        public int? PasswordPreviousPasswordBlockCount { get; set; }
        /// <summary>Possible values of required passwords.</summary>
        public global::ApiSdk.Models.RequiredPasswordType? PasswordRequiredType { get; set; }
        /// <summary>The number of sign in failures before factory reset.</summary>
        public int? PasswordSignInFailureCountBeforeFactoryReset { get; set; }
        /// <summary>Indicates whether or not to require encryption on a mobile device.</summary>
        public bool? StorageRequireDeviceEncryption { get; set; }
        /// <summary>Indicates whether or not to require automatic updates.</summary>
        public bool? UpdatesRequireAutomaticUpdates { get; set; }
        /// <summary>Possible values for Windows user account control settings.</summary>
        public global::ApiSdk.Models.WindowsUserAccountControlSettings? UserAccountControlSettings { get; set; }
        /// <summary>The work folders url.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WorkFoldersUrl { get; set; }
#nullable restore
#else
        public string WorkFoldersUrl { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.Windows81GeneralConfiguration"/> and sets the default values.
        /// </summary>
        public Windows81GeneralConfiguration() : base()
        {
            OdataType = "#microsoft.graph.windows81GeneralConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.Windows81GeneralConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.Windows81GeneralConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.Windows81GeneralConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "accountsBlockAddingNonMicrosoftAccountEmail", n => { AccountsBlockAddingNonMicrosoftAccountEmail = n.GetBoolValue(); } },
                { "applyOnlyToWindows81", n => { ApplyOnlyToWindows81 = n.GetBoolValue(); } },
                { "browserBlockAutofill", n => { BrowserBlockAutofill = n.GetBoolValue(); } },
                { "browserBlockAutomaticDetectionOfIntranetSites", n => { BrowserBlockAutomaticDetectionOfIntranetSites = n.GetBoolValue(); } },
                { "browserBlockEnterpriseModeAccess", n => { BrowserBlockEnterpriseModeAccess = n.GetBoolValue(); } },
                { "browserBlockJavaScript", n => { BrowserBlockJavaScript = n.GetBoolValue(); } },
                { "browserBlockPlugins", n => { BrowserBlockPlugins = n.GetBoolValue(); } },
                { "browserBlockPopups", n => { BrowserBlockPopups = n.GetBoolValue(); } },
                { "browserBlockSendingDoNotTrackHeader", n => { BrowserBlockSendingDoNotTrackHeader = n.GetBoolValue(); } },
                { "browserBlockSingleWordEntryOnIntranetSites", n => { BrowserBlockSingleWordEntryOnIntranetSites = n.GetBoolValue(); } },
                { "browserEnterpriseModeSiteListLocation", n => { BrowserEnterpriseModeSiteListLocation = n.GetStringValue(); } },
                { "browserInternetSecurityLevel", n => { BrowserInternetSecurityLevel = n.GetEnumValue<global::ApiSdk.Models.InternetSiteSecurityLevel>(); } },
                { "browserIntranetSecurityLevel", n => { BrowserIntranetSecurityLevel = n.GetEnumValue<global::ApiSdk.Models.SiteSecurityLevel>(); } },
                { "browserLoggingReportLocation", n => { BrowserLoggingReportLocation = n.GetStringValue(); } },
                { "browserRequireFirewall", n => { BrowserRequireFirewall = n.GetBoolValue(); } },
                { "browserRequireFraudWarning", n => { BrowserRequireFraudWarning = n.GetBoolValue(); } },
                { "browserRequireHighSecurityForRestrictedSites", n => { BrowserRequireHighSecurityForRestrictedSites = n.GetBoolValue(); } },
                { "browserRequireSmartScreen", n => { BrowserRequireSmartScreen = n.GetBoolValue(); } },
                { "browserTrustedSitesSecurityLevel", n => { BrowserTrustedSitesSecurityLevel = n.GetEnumValue<global::ApiSdk.Models.SiteSecurityLevel>(); } },
                { "cellularBlockDataRoaming", n => { CellularBlockDataRoaming = n.GetBoolValue(); } },
                { "diagnosticsBlockDataSubmission", n => { DiagnosticsBlockDataSubmission = n.GetBoolValue(); } },
                { "passwordBlockPicturePasswordAndPin", n => { PasswordBlockPicturePasswordAndPin = n.GetBoolValue(); } },
                { "passwordExpirationDays", n => { PasswordExpirationDays = n.GetIntValue(); } },
                { "passwordMinimumCharacterSetCount", n => { PasswordMinimumCharacterSetCount = n.GetIntValue(); } },
                { "passwordMinimumLength", n => { PasswordMinimumLength = n.GetIntValue(); } },
                { "passwordMinutesOfInactivityBeforeScreenTimeout", n => { PasswordMinutesOfInactivityBeforeScreenTimeout = n.GetIntValue(); } },
                { "passwordPreviousPasswordBlockCount", n => { PasswordPreviousPasswordBlockCount = n.GetIntValue(); } },
                { "passwordRequiredType", n => { PasswordRequiredType = n.GetEnumValue<global::ApiSdk.Models.RequiredPasswordType>(); } },
                { "passwordSignInFailureCountBeforeFactoryReset", n => { PasswordSignInFailureCountBeforeFactoryReset = n.GetIntValue(); } },
                { "storageRequireDeviceEncryption", n => { StorageRequireDeviceEncryption = n.GetBoolValue(); } },
                { "updatesRequireAutomaticUpdates", n => { UpdatesRequireAutomaticUpdates = n.GetBoolValue(); } },
                { "userAccountControlSettings", n => { UserAccountControlSettings = n.GetEnumValue<global::ApiSdk.Models.WindowsUserAccountControlSettings>(); } },
                { "workFoldersUrl", n => { WorkFoldersUrl = n.GetStringValue(); } },
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
            writer.WriteBoolValue("accountsBlockAddingNonMicrosoftAccountEmail", AccountsBlockAddingNonMicrosoftAccountEmail);
            writer.WriteBoolValue("browserBlockAutofill", BrowserBlockAutofill);
            writer.WriteBoolValue("browserBlockAutomaticDetectionOfIntranetSites", BrowserBlockAutomaticDetectionOfIntranetSites);
            writer.WriteBoolValue("browserBlockEnterpriseModeAccess", BrowserBlockEnterpriseModeAccess);
            writer.WriteBoolValue("browserBlockJavaScript", BrowserBlockJavaScript);
            writer.WriteBoolValue("browserBlockPlugins", BrowserBlockPlugins);
            writer.WriteBoolValue("browserBlockPopups", BrowserBlockPopups);
            writer.WriteBoolValue("browserBlockSendingDoNotTrackHeader", BrowserBlockSendingDoNotTrackHeader);
            writer.WriteBoolValue("browserBlockSingleWordEntryOnIntranetSites", BrowserBlockSingleWordEntryOnIntranetSites);
            writer.WriteStringValue("browserEnterpriseModeSiteListLocation", BrowserEnterpriseModeSiteListLocation);
            writer.WriteEnumValue<global::ApiSdk.Models.InternetSiteSecurityLevel>("browserInternetSecurityLevel", BrowserInternetSecurityLevel);
            writer.WriteEnumValue<global::ApiSdk.Models.SiteSecurityLevel>("browserIntranetSecurityLevel", BrowserIntranetSecurityLevel);
            writer.WriteStringValue("browserLoggingReportLocation", BrowserLoggingReportLocation);
            writer.WriteBoolValue("browserRequireFirewall", BrowserRequireFirewall);
            writer.WriteBoolValue("browserRequireFraudWarning", BrowserRequireFraudWarning);
            writer.WriteBoolValue("browserRequireHighSecurityForRestrictedSites", BrowserRequireHighSecurityForRestrictedSites);
            writer.WriteBoolValue("browserRequireSmartScreen", BrowserRequireSmartScreen);
            writer.WriteEnumValue<global::ApiSdk.Models.SiteSecurityLevel>("browserTrustedSitesSecurityLevel", BrowserTrustedSitesSecurityLevel);
            writer.WriteBoolValue("cellularBlockDataRoaming", CellularBlockDataRoaming);
            writer.WriteBoolValue("diagnosticsBlockDataSubmission", DiagnosticsBlockDataSubmission);
            writer.WriteBoolValue("passwordBlockPicturePasswordAndPin", PasswordBlockPicturePasswordAndPin);
            writer.WriteIntValue("passwordExpirationDays", PasswordExpirationDays);
            writer.WriteIntValue("passwordMinimumCharacterSetCount", PasswordMinimumCharacterSetCount);
            writer.WriteIntValue("passwordMinimumLength", PasswordMinimumLength);
            writer.WriteIntValue("passwordMinutesOfInactivityBeforeScreenTimeout", PasswordMinutesOfInactivityBeforeScreenTimeout);
            writer.WriteIntValue("passwordPreviousPasswordBlockCount", PasswordPreviousPasswordBlockCount);
            writer.WriteEnumValue<global::ApiSdk.Models.RequiredPasswordType>("passwordRequiredType", PasswordRequiredType);
            writer.WriteIntValue("passwordSignInFailureCountBeforeFactoryReset", PasswordSignInFailureCountBeforeFactoryReset);
            writer.WriteBoolValue("storageRequireDeviceEncryption", StorageRequireDeviceEncryption);
            writer.WriteBoolValue("updatesRequireAutomaticUpdates", UpdatesRequireAutomaticUpdates);
            writer.WriteEnumValue<global::ApiSdk.Models.WindowsUserAccountControlSettings>("userAccountControlSettings", UserAccountControlSettings);
            writer.WriteStringValue("workFoldersUrl", WorkFoldersUrl);
        }
    }
}
#pragma warning restore CS0618
