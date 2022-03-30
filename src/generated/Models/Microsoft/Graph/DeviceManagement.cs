using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    /// <summary>Singleton entity that acts as a container for all device management functionality.</summary>
    public class DeviceManagement : Entity, IParsable {
        /// <summary>Apple push notification certificate.</summary>
        public ApiSdk.Models.Microsoft.Graph.ApplePushNotificationCertificate ApplePushNotificationCertificate { get; set; }
        /// <summary>The list of Compliance Management Partners configured by the tenant.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.ComplianceManagementPartner> ComplianceManagementPartners { get; set; }
        /// <summary>The Exchange on premises conditional access settings. On premises conditional access will require devices to be both enrolled and compliant for mail access</summary>
        public ApiSdk.Models.Microsoft.Graph.OnPremisesConditionalAccessSettings ConditionalAccessSettings { get; set; }
        /// <summary>The list of detected apps associated with a device.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.DetectedApp> DetectedApps { get; set; }
        /// <summary>The list of device categories with the tenant.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.DeviceCategory> DeviceCategories { get; set; }
        /// <summary>The device compliance policies.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.DeviceCompliancePolicy> DeviceCompliancePolicies { get; set; }
        /// <summary>The device compliance state summary for this account.</summary>
        public ApiSdk.Models.Microsoft.Graph.DeviceCompliancePolicyDeviceStateSummary DeviceCompliancePolicyDeviceStateSummary { get; set; }
        /// <summary>The summary states of compliance policy settings for this account.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.DeviceCompliancePolicySettingStateSummary> DeviceCompliancePolicySettingStateSummaries { get; set; }
        /// <summary>The device configuration device state summary for this account.</summary>
        public ApiSdk.Models.Microsoft.Graph.DeviceConfigurationDeviceStateSummary DeviceConfigurationDeviceStateSummaries { get; set; }
        /// <summary>The device configurations.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.DeviceConfiguration> DeviceConfigurations { get; set; }
        /// <summary>The list of device enrollment configurations</summary>
        public List<ApiSdk.Models.Microsoft.Graph.DeviceEnrollmentConfiguration> DeviceEnrollmentConfigurations { get; set; }
        /// <summary>The list of Device Management Partners configured by the tenant.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.DeviceManagementPartner> DeviceManagementPartners { get; set; }
        /// <summary>The list of Exchange Connectors configured by the tenant.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.DeviceManagementExchangeConnector> ExchangeConnectors { get; set; }
        /// <summary>Collection of imported Windows autopilot devices.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.ImportedWindowsAutopilotDeviceIdentity> ImportedWindowsAutopilotDeviceIdentities { get; set; }
        /// <summary>Intune Account Id for given tenant</summary>
        public string IntuneAccountId { get; set; }
        /// <summary>intuneBrand contains data which is used in customizing the appearance of the Company Portal applications as well as the end user web portal.</summary>
        public ApiSdk.Models.Microsoft.Graph.IntuneBrand IntuneBrand { get; set; }
        /// <summary>The IOS software update installation statuses for this account.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.IosUpdateDeviceStatus> IosUpdateStatuses { get; set; }
        /// <summary>Device overview</summary>
        public ApiSdk.Models.Microsoft.Graph.ManagedDeviceOverview ManagedDeviceOverview { get; set; }
        /// <summary>The list of managed devices.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.ManagedDevice> ManagedDevices { get; set; }
        /// <summary>The list of Mobile threat Defense connectors configured by the tenant.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.MobileThreatDefenseConnector> MobileThreatDefenseConnectors { get; set; }
        /// <summary>The Notification Message Templates.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.NotificationMessageTemplate> NotificationMessageTemplates { get; set; }
        /// <summary>The remote assist partners.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.RemoteAssistancePartner> RemoteAssistancePartners { get; set; }
        /// <summary>Reports singleton</summary>
        public ApiSdk.Models.Microsoft.Graph.DeviceManagementReports Reports { get; set; }
        /// <summary>The Resource Operations.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.ResourceOperation> ResourceOperations { get; set; }
        /// <summary>The Role Assignments.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.DeviceAndAppManagementRoleAssignment> RoleAssignments { get; set; }
        /// <summary>The Role Definitions.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.RoleDefinition> RoleDefinitions { get; set; }
        /// <summary>Account level settings.</summary>
        public ApiSdk.Models.Microsoft.Graph.DeviceManagementSettings Settings { get; set; }
        /// <summary>The software update status summary.</summary>
        public ApiSdk.Models.Microsoft.Graph.SoftwareUpdateStatusSummary SoftwareUpdateStatusSummary { get; set; }
        /// <summary>Tenant mobile device management subscription state. Possible values are: pending, active, warning, disabled, deleted, blocked, lockedOut.</summary>
        public DeviceManagementSubscriptionState? SubscriptionState { get; set; }
        /// <summary>The telecom expense management partners.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.TelecomExpenseManagementPartner> TelecomExpenseManagementPartners { get; set; }
        /// <summary>The terms and conditions associated with device management of the company.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.TermsAndConditions> TermsAndConditions { get; set; }
        /// <summary>The list of troubleshooting events for the tenant.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.DeviceManagementTroubleshootingEvent> TroubleshootingEvents { get; set; }
        /// <summary>The Windows autopilot device identities contained collection.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.WindowsAutopilotDeviceIdentity> WindowsAutopilotDeviceIdentities { get; set; }
        /// <summary>The windows information protection app learning summaries.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.WindowsInformationProtectionAppLearningSummary> WindowsInformationProtectionAppLearningSummaries { get; set; }
        /// <summary>The windows information protection network learning summaries.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.WindowsInformationProtectionNetworkLearningSummary> WindowsInformationProtectionNetworkLearningSummaries { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.DeviceManagement CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagement();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"applePushNotificationCertificate", (o,n) => { (o as DeviceManagement).ApplePushNotificationCertificate = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ApplePushNotificationCertificate>(ApiSdk.Models.Microsoft.Graph.ApplePushNotificationCertificate.CreateFromDiscriminatorValue); } },
                {"complianceManagementPartners", (o,n) => { (o as DeviceManagement).ComplianceManagementPartners = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ComplianceManagementPartner>(ApiSdk.Models.Microsoft.Graph.ComplianceManagementPartner.CreateFromDiscriminatorValue).ToList(); } },
                {"conditionalAccessSettings", (o,n) => { (o as DeviceManagement).ConditionalAccessSettings = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.OnPremisesConditionalAccessSettings>(ApiSdk.Models.Microsoft.Graph.OnPremisesConditionalAccessSettings.CreateFromDiscriminatorValue); } },
                {"detectedApps", (o,n) => { (o as DeviceManagement).DetectedApps = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DetectedApp>(ApiSdk.Models.Microsoft.Graph.DetectedApp.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceCategories", (o,n) => { (o as DeviceManagement).DeviceCategories = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DeviceCategory>(ApiSdk.Models.Microsoft.Graph.DeviceCategory.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceCompliancePolicies", (o,n) => { (o as DeviceManagement).DeviceCompliancePolicies = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DeviceCompliancePolicy>(ApiSdk.Models.Microsoft.Graph.DeviceCompliancePolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceCompliancePolicyDeviceStateSummary", (o,n) => { (o as DeviceManagement).DeviceCompliancePolicyDeviceStateSummary = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.DeviceCompliancePolicyDeviceStateSummary>(ApiSdk.Models.Microsoft.Graph.DeviceCompliancePolicyDeviceStateSummary.CreateFromDiscriminatorValue); } },
                {"deviceCompliancePolicySettingStateSummaries", (o,n) => { (o as DeviceManagement).DeviceCompliancePolicySettingStateSummaries = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DeviceCompliancePolicySettingStateSummary>(ApiSdk.Models.Microsoft.Graph.DeviceCompliancePolicySettingStateSummary.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceConfigurationDeviceStateSummaries", (o,n) => { (o as DeviceManagement).DeviceConfigurationDeviceStateSummaries = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.DeviceConfigurationDeviceStateSummary>(ApiSdk.Models.Microsoft.Graph.DeviceConfigurationDeviceStateSummary.CreateFromDiscriminatorValue); } },
                {"deviceConfigurations", (o,n) => { (o as DeviceManagement).DeviceConfigurations = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DeviceConfiguration>(ApiSdk.Models.Microsoft.Graph.DeviceConfiguration.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceEnrollmentConfigurations", (o,n) => { (o as DeviceManagement).DeviceEnrollmentConfigurations = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DeviceEnrollmentConfiguration>(ApiSdk.Models.Microsoft.Graph.DeviceEnrollmentConfiguration.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceManagementPartners", (o,n) => { (o as DeviceManagement).DeviceManagementPartners = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DeviceManagementPartner>(ApiSdk.Models.Microsoft.Graph.DeviceManagementPartner.CreateFromDiscriminatorValue).ToList(); } },
                {"exchangeConnectors", (o,n) => { (o as DeviceManagement).ExchangeConnectors = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DeviceManagementExchangeConnector>(ApiSdk.Models.Microsoft.Graph.DeviceManagementExchangeConnector.CreateFromDiscriminatorValue).ToList(); } },
                {"importedWindowsAutopilotDeviceIdentities", (o,n) => { (o as DeviceManagement).ImportedWindowsAutopilotDeviceIdentities = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ImportedWindowsAutopilotDeviceIdentity>(ApiSdk.Models.Microsoft.Graph.ImportedWindowsAutopilotDeviceIdentity.CreateFromDiscriminatorValue).ToList(); } },
                {"intuneAccountId", (o,n) => { (o as DeviceManagement).IntuneAccountId = n.GetStringValue(); } },
                {"intuneBrand", (o,n) => { (o as DeviceManagement).IntuneBrand = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.IntuneBrand>(ApiSdk.Models.Microsoft.Graph.IntuneBrand.CreateFromDiscriminatorValue); } },
                {"iosUpdateStatuses", (o,n) => { (o as DeviceManagement).IosUpdateStatuses = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.IosUpdateDeviceStatus>(ApiSdk.Models.Microsoft.Graph.IosUpdateDeviceStatus.CreateFromDiscriminatorValue).ToList(); } },
                {"managedDeviceOverview", (o,n) => { (o as DeviceManagement).ManagedDeviceOverview = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ManagedDeviceOverview>(ApiSdk.Models.Microsoft.Graph.ManagedDeviceOverview.CreateFromDiscriminatorValue); } },
                {"managedDevices", (o,n) => { (o as DeviceManagement).ManagedDevices = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ManagedDevice>(ApiSdk.Models.Microsoft.Graph.ManagedDevice.CreateFromDiscriminatorValue).ToList(); } },
                {"mobileThreatDefenseConnectors", (o,n) => { (o as DeviceManagement).MobileThreatDefenseConnectors = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.MobileThreatDefenseConnector>(ApiSdk.Models.Microsoft.Graph.MobileThreatDefenseConnector.CreateFromDiscriminatorValue).ToList(); } },
                {"notificationMessageTemplates", (o,n) => { (o as DeviceManagement).NotificationMessageTemplates = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.NotificationMessageTemplate>(ApiSdk.Models.Microsoft.Graph.NotificationMessageTemplate.CreateFromDiscriminatorValue).ToList(); } },
                {"remoteAssistancePartners", (o,n) => { (o as DeviceManagement).RemoteAssistancePartners = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.RemoteAssistancePartner>(ApiSdk.Models.Microsoft.Graph.RemoteAssistancePartner.CreateFromDiscriminatorValue).ToList(); } },
                {"reports", (o,n) => { (o as DeviceManagement).Reports = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.DeviceManagementReports>(ApiSdk.Models.Microsoft.Graph.DeviceManagementReports.CreateFromDiscriminatorValue); } },
                {"resourceOperations", (o,n) => { (o as DeviceManagement).ResourceOperations = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ResourceOperation>(ApiSdk.Models.Microsoft.Graph.ResourceOperation.CreateFromDiscriminatorValue).ToList(); } },
                {"roleAssignments", (o,n) => { (o as DeviceManagement).RoleAssignments = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DeviceAndAppManagementRoleAssignment>(ApiSdk.Models.Microsoft.Graph.DeviceAndAppManagementRoleAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"roleDefinitions", (o,n) => { (o as DeviceManagement).RoleDefinitions = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.RoleDefinition>(ApiSdk.Models.Microsoft.Graph.RoleDefinition.CreateFromDiscriminatorValue).ToList(); } },
                {"settings", (o,n) => { (o as DeviceManagement).Settings = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.DeviceManagementSettings>(ApiSdk.Models.Microsoft.Graph.DeviceManagementSettings.CreateFromDiscriminatorValue); } },
                {"softwareUpdateStatusSummary", (o,n) => { (o as DeviceManagement).SoftwareUpdateStatusSummary = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.SoftwareUpdateStatusSummary>(ApiSdk.Models.Microsoft.Graph.SoftwareUpdateStatusSummary.CreateFromDiscriminatorValue); } },
                {"subscriptionState", (o,n) => { (o as DeviceManagement).SubscriptionState = n.GetEnumValue<DeviceManagementSubscriptionState>(); } },
                {"telecomExpenseManagementPartners", (o,n) => { (o as DeviceManagement).TelecomExpenseManagementPartners = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.TelecomExpenseManagementPartner>(ApiSdk.Models.Microsoft.Graph.TelecomExpenseManagementPartner.CreateFromDiscriminatorValue).ToList(); } },
                {"termsAndConditions", (o,n) => { (o as DeviceManagement).TermsAndConditions = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.TermsAndConditions>(ApiSdk.Models.Microsoft.Graph.TermsAndConditions.CreateFromDiscriminatorValue).ToList(); } },
                {"troubleshootingEvents", (o,n) => { (o as DeviceManagement).TroubleshootingEvents = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DeviceManagementTroubleshootingEvent>(ApiSdk.Models.Microsoft.Graph.DeviceManagementTroubleshootingEvent.CreateFromDiscriminatorValue).ToList(); } },
                {"windowsAutopilotDeviceIdentities", (o,n) => { (o as DeviceManagement).WindowsAutopilotDeviceIdentities = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.WindowsAutopilotDeviceIdentity>(ApiSdk.Models.Microsoft.Graph.WindowsAutopilotDeviceIdentity.CreateFromDiscriminatorValue).ToList(); } },
                {"windowsInformationProtectionAppLearningSummaries", (o,n) => { (o as DeviceManagement).WindowsInformationProtectionAppLearningSummaries = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.WindowsInformationProtectionAppLearningSummary>(ApiSdk.Models.Microsoft.Graph.WindowsInformationProtectionAppLearningSummary.CreateFromDiscriminatorValue).ToList(); } },
                {"windowsInformationProtectionNetworkLearningSummaries", (o,n) => { (o as DeviceManagement).WindowsInformationProtectionNetworkLearningSummaries = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.WindowsInformationProtectionNetworkLearningSummary>(ApiSdk.Models.Microsoft.Graph.WindowsInformationProtectionNetworkLearningSummary.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ApplePushNotificationCertificate>("applePushNotificationCertificate", ApplePushNotificationCertificate);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ComplianceManagementPartner>("complianceManagementPartners", ComplianceManagementPartners);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.OnPremisesConditionalAccessSettings>("conditionalAccessSettings", ConditionalAccessSettings);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DetectedApp>("detectedApps", DetectedApps);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DeviceCategory>("deviceCategories", DeviceCategories);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DeviceCompliancePolicy>("deviceCompliancePolicies", DeviceCompliancePolicies);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.DeviceCompliancePolicyDeviceStateSummary>("deviceCompliancePolicyDeviceStateSummary", DeviceCompliancePolicyDeviceStateSummary);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DeviceCompliancePolicySettingStateSummary>("deviceCompliancePolicySettingStateSummaries", DeviceCompliancePolicySettingStateSummaries);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.DeviceConfigurationDeviceStateSummary>("deviceConfigurationDeviceStateSummaries", DeviceConfigurationDeviceStateSummaries);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DeviceConfiguration>("deviceConfigurations", DeviceConfigurations);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DeviceEnrollmentConfiguration>("deviceEnrollmentConfigurations", DeviceEnrollmentConfigurations);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DeviceManagementPartner>("deviceManagementPartners", DeviceManagementPartners);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DeviceManagementExchangeConnector>("exchangeConnectors", ExchangeConnectors);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ImportedWindowsAutopilotDeviceIdentity>("importedWindowsAutopilotDeviceIdentities", ImportedWindowsAutopilotDeviceIdentities);
            writer.WriteStringValue("intuneAccountId", IntuneAccountId);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.IntuneBrand>("intuneBrand", IntuneBrand);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.IosUpdateDeviceStatus>("iosUpdateStatuses", IosUpdateStatuses);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ManagedDeviceOverview>("managedDeviceOverview", ManagedDeviceOverview);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ManagedDevice>("managedDevices", ManagedDevices);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.MobileThreatDefenseConnector>("mobileThreatDefenseConnectors", MobileThreatDefenseConnectors);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.NotificationMessageTemplate>("notificationMessageTemplates", NotificationMessageTemplates);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.RemoteAssistancePartner>("remoteAssistancePartners", RemoteAssistancePartners);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.DeviceManagementReports>("reports", Reports);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ResourceOperation>("resourceOperations", ResourceOperations);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DeviceAndAppManagementRoleAssignment>("roleAssignments", RoleAssignments);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.RoleDefinition>("roleDefinitions", RoleDefinitions);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.DeviceManagementSettings>("settings", Settings);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.SoftwareUpdateStatusSummary>("softwareUpdateStatusSummary", SoftwareUpdateStatusSummary);
            writer.WriteEnumValue<DeviceManagementSubscriptionState>("subscriptionState", SubscriptionState);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.TelecomExpenseManagementPartner>("telecomExpenseManagementPartners", TelecomExpenseManagementPartners);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.TermsAndConditions>("termsAndConditions", TermsAndConditions);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DeviceManagementTroubleshootingEvent>("troubleshootingEvents", TroubleshootingEvents);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.WindowsAutopilotDeviceIdentity>("windowsAutopilotDeviceIdentities", WindowsAutopilotDeviceIdentities);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.WindowsInformationProtectionAppLearningSummary>("windowsInformationProtectionAppLearningSummaries", WindowsInformationProtectionAppLearningSummaries);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.WindowsInformationProtectionNetworkLearningSummary>("windowsInformationProtectionNetworkLearningSummaries", WindowsInformationProtectionNetworkLearningSummaries);
        }
    }
}
