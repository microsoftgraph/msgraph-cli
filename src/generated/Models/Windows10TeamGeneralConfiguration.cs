using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class Windows10TeamGeneralConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Indicates whether or not to Block Azure Operational Insights.</summary>
        public bool? AzureOperationalInsightsBlockTelemetry { get; set; }
        /// <summary>The Azure Operational Insights workspace id.</summary>
        public string AzureOperationalInsightsWorkspaceId { get; set; }
        /// <summary>The Azure Operational Insights Workspace key.</summary>
        public string AzureOperationalInsightsWorkspaceKey { get; set; }
        /// <summary>Specifies whether to automatically launch the Connect app whenever a projection is initiated.</summary>
        public bool? ConnectAppBlockAutoLaunch { get; set; }
        /// <summary>Indicates whether or not to Block setting a maintenance window for device updates.</summary>
        public bool? MaintenanceWindowBlocked { get; set; }
        /// <summary>Maintenance window duration for device updates. Valid values 0 to 5</summary>
        public int? MaintenanceWindowDurationInHours { get; set; }
        /// <summary>Maintenance window start time for device updates.</summary>
        public Time? MaintenanceWindowStartTime { get; set; }
        /// <summary>Indicates whether or not to Block wireless projection.</summary>
        public bool? MiracastBlocked { get; set; }
        /// <summary>The channel. Possible values are: userDefined, one, two, three, four, five, six, seven, eight, nine, ten, eleven, thirtySix, forty, fortyFour, fortyEight, oneHundredFortyNine, oneHundredFiftyThree, oneHundredFiftySeven, oneHundredSixtyOne, oneHundredSixtyFive.</summary>
        public ApiSdk.Models.MiracastChannel? MiracastChannel { get; set; }
        /// <summary>Indicates whether or not to require a pin for wireless projection.</summary>
        public bool? MiracastRequirePin { get; set; }
        /// <summary>Specifies whether to disable the &apos;My meetings and files&apos; feature in the Start menu, which shows the signed-in user&apos;s meetings and files from Office 365.</summary>
        public bool? SettingsBlockMyMeetingsAndFiles { get; set; }
        /// <summary>Specifies whether to allow the ability to resume a session when the session times out.</summary>
        public bool? SettingsBlockSessionResume { get; set; }
        /// <summary>Specifies whether to disable auto-populating of the sign-in dialog with invitees from scheduled meetings.</summary>
        public bool? SettingsBlockSigninSuggestions { get; set; }
        /// <summary>Specifies the default volume value for a new session. Permitted values are 0-100. The default is 45. Valid values 0 to 100</summary>
        public int? SettingsDefaultVolume { get; set; }
        /// <summary>Specifies the number of minutes until the Hub screen turns off.</summary>
        public int? SettingsScreenTimeoutInMinutes { get; set; }
        /// <summary>Specifies the number of minutes until the session times out.</summary>
        public int? SettingsSessionTimeoutInMinutes { get; set; }
        /// <summary>Specifies the number of minutes until the Hub enters sleep mode.</summary>
        public int? SettingsSleepTimeoutInMinutes { get; set; }
        /// <summary>The welcome screen background image URL. The URL must use the HTTPS protocol and return a PNG image.</summary>
        public string WelcomeScreenBackgroundImageUrl { get; set; }
        /// <summary>Indicates whether or not to Block the welcome screen from waking up automatically when someone enters the room.</summary>
        public bool? WelcomeScreenBlockAutomaticWakeUp { get; set; }
        /// <summary>The welcome screen meeting information shown. Possible values are: userDefined, showOrganizerAndTimeOnly, showOrganizerAndTimeAndSubject.</summary>
        public ApiSdk.Models.WelcomeScreenMeetingInformation? WelcomeScreenMeetingInformation { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Windows10TeamGeneralConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Windows10TeamGeneralConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"azureOperationalInsightsBlockTelemetry", n => { AzureOperationalInsightsBlockTelemetry = n.GetBoolValue(); } },
                {"azureOperationalInsightsWorkspaceId", n => { AzureOperationalInsightsWorkspaceId = n.GetStringValue(); } },
                {"azureOperationalInsightsWorkspaceKey", n => { AzureOperationalInsightsWorkspaceKey = n.GetStringValue(); } },
                {"connectAppBlockAutoLaunch", n => { ConnectAppBlockAutoLaunch = n.GetBoolValue(); } },
                {"maintenanceWindowBlocked", n => { MaintenanceWindowBlocked = n.GetBoolValue(); } },
                {"maintenanceWindowDurationInHours", n => { MaintenanceWindowDurationInHours = n.GetIntValue(); } },
                {"maintenanceWindowStartTime", n => { MaintenanceWindowStartTime = n.GetTimeValue(); } },
                {"miracastBlocked", n => { MiracastBlocked = n.GetBoolValue(); } },
                {"miracastChannel", n => { MiracastChannel = n.GetEnumValue<MiracastChannel>(); } },
                {"miracastRequirePin", n => { MiracastRequirePin = n.GetBoolValue(); } },
                {"settingsBlockMyMeetingsAndFiles", n => { SettingsBlockMyMeetingsAndFiles = n.GetBoolValue(); } },
                {"settingsBlockSessionResume", n => { SettingsBlockSessionResume = n.GetBoolValue(); } },
                {"settingsBlockSigninSuggestions", n => { SettingsBlockSigninSuggestions = n.GetBoolValue(); } },
                {"settingsDefaultVolume", n => { SettingsDefaultVolume = n.GetIntValue(); } },
                {"settingsScreenTimeoutInMinutes", n => { SettingsScreenTimeoutInMinutes = n.GetIntValue(); } },
                {"settingsSessionTimeoutInMinutes", n => { SettingsSessionTimeoutInMinutes = n.GetIntValue(); } },
                {"settingsSleepTimeoutInMinutes", n => { SettingsSleepTimeoutInMinutes = n.GetIntValue(); } },
                {"welcomeScreenBackgroundImageUrl", n => { WelcomeScreenBackgroundImageUrl = n.GetStringValue(); } },
                {"welcomeScreenBlockAutomaticWakeUp", n => { WelcomeScreenBlockAutomaticWakeUp = n.GetBoolValue(); } },
                {"welcomeScreenMeetingInformation", n => { WelcomeScreenMeetingInformation = n.GetEnumValue<WelcomeScreenMeetingInformation>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("azureOperationalInsightsBlockTelemetry", AzureOperationalInsightsBlockTelemetry);
            writer.WriteStringValue("azureOperationalInsightsWorkspaceId", AzureOperationalInsightsWorkspaceId);
            writer.WriteStringValue("azureOperationalInsightsWorkspaceKey", AzureOperationalInsightsWorkspaceKey);
            writer.WriteBoolValue("connectAppBlockAutoLaunch", ConnectAppBlockAutoLaunch);
            writer.WriteBoolValue("maintenanceWindowBlocked", MaintenanceWindowBlocked);
            writer.WriteIntValue("maintenanceWindowDurationInHours", MaintenanceWindowDurationInHours);
            writer.WriteTimeValue("maintenanceWindowStartTime", MaintenanceWindowStartTime);
            writer.WriteBoolValue("miracastBlocked", MiracastBlocked);
            writer.WriteEnumValue<MiracastChannel>("miracastChannel", MiracastChannel);
            writer.WriteBoolValue("miracastRequirePin", MiracastRequirePin);
            writer.WriteBoolValue("settingsBlockMyMeetingsAndFiles", SettingsBlockMyMeetingsAndFiles);
            writer.WriteBoolValue("settingsBlockSessionResume", SettingsBlockSessionResume);
            writer.WriteBoolValue("settingsBlockSigninSuggestions", SettingsBlockSigninSuggestions);
            writer.WriteIntValue("settingsDefaultVolume", SettingsDefaultVolume);
            writer.WriteIntValue("settingsScreenTimeoutInMinutes", SettingsScreenTimeoutInMinutes);
            writer.WriteIntValue("settingsSessionTimeoutInMinutes", SettingsSessionTimeoutInMinutes);
            writer.WriteIntValue("settingsSleepTimeoutInMinutes", SettingsSleepTimeoutInMinutes);
            writer.WriteStringValue("welcomeScreenBackgroundImageUrl", WelcomeScreenBackgroundImageUrl);
            writer.WriteBoolValue("welcomeScreenBlockAutomaticWakeUp", WelcomeScreenBlockAutomaticWakeUp);
            writer.WriteEnumValue<WelcomeScreenMeetingInformation>("welcomeScreenMeetingInformation", WelcomeScreenMeetingInformation);
        }
    }
}
