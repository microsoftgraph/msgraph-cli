using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class DeviceManagement : Entity, IParsable {
        /// <summary>Apple push notification certificate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.ApplePushNotificationCertificate? ApplePushNotificationCertificate { get; set; }
#nullable restore
#else
        public ApiSdk.Models.ApplePushNotificationCertificate ApplePushNotificationCertificate { get; set; }
#endif
        /// <summary>The Audit Events</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AuditEvent>? AuditEvents { get; set; }
#nullable restore
#else
        public List<AuditEvent> AuditEvents { get; set; }
#endif
        /// <summary>The list of Compliance Management Partners configured by the tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ComplianceManagementPartner>? ComplianceManagementPartners { get; set; }
#nullable restore
#else
        public List<ComplianceManagementPartner> ComplianceManagementPartners { get; set; }
#endif
        /// <summary>The Exchange on premises conditional access settings. On premises conditional access will require devices to be both enrolled and compliant for mail access</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public OnPremisesConditionalAccessSettings? ConditionalAccessSettings { get; set; }
#nullable restore
#else
        public OnPremisesConditionalAccessSettings ConditionalAccessSettings { get; set; }
#endif
        /// <summary>The list of detected apps associated with a device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DetectedApp>? DetectedApps { get; set; }
#nullable restore
#else
        public List<DetectedApp> DetectedApps { get; set; }
#endif
        /// <summary>The list of device categories with the tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceCategory>? DeviceCategories { get; set; }
#nullable restore
#else
        public List<DeviceCategory> DeviceCategories { get; set; }
#endif
        /// <summary>The device compliance policies.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceCompliancePolicy>? DeviceCompliancePolicies { get; set; }
#nullable restore
#else
        public List<DeviceCompliancePolicy> DeviceCompliancePolicies { get; set; }
#endif
        /// <summary>The device compliance state summary for this account.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.DeviceCompliancePolicyDeviceStateSummary? DeviceCompliancePolicyDeviceStateSummary { get; set; }
#nullable restore
#else
        public ApiSdk.Models.DeviceCompliancePolicyDeviceStateSummary DeviceCompliancePolicyDeviceStateSummary { get; set; }
#endif
        /// <summary>The summary states of compliance policy settings for this account.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceCompliancePolicySettingStateSummary>? DeviceCompliancePolicySettingStateSummaries { get; set; }
#nullable restore
#else
        public List<DeviceCompliancePolicySettingStateSummary> DeviceCompliancePolicySettingStateSummaries { get; set; }
#endif
        /// <summary>The device configuration device state summary for this account.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceConfigurationDeviceStateSummary? DeviceConfigurationDeviceStateSummaries { get; set; }
#nullable restore
#else
        public DeviceConfigurationDeviceStateSummary DeviceConfigurationDeviceStateSummaries { get; set; }
#endif
        /// <summary>The device configurations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceConfiguration>? DeviceConfigurations { get; set; }
#nullable restore
#else
        public List<DeviceConfiguration> DeviceConfigurations { get; set; }
#endif
        /// <summary>The list of device enrollment configurations</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceEnrollmentConfiguration>? DeviceEnrollmentConfigurations { get; set; }
#nullable restore
#else
        public List<DeviceEnrollmentConfiguration> DeviceEnrollmentConfigurations { get; set; }
#endif
        /// <summary>The list of Device Management Partners configured by the tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceManagementPartner>? DeviceManagementPartners { get; set; }
#nullable restore
#else
        public List<DeviceManagementPartner> DeviceManagementPartners { get; set; }
#endif
        /// <summary>The list of Exchange Connectors configured by the tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceManagementExchangeConnector>? ExchangeConnectors { get; set; }
#nullable restore
#else
        public List<DeviceManagementExchangeConnector> ExchangeConnectors { get; set; }
#endif
        /// <summary>Collection of imported Windows autopilot devices.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ImportedWindowsAutopilotDeviceIdentity>? ImportedWindowsAutopilotDeviceIdentities { get; set; }
#nullable restore
#else
        public List<ImportedWindowsAutopilotDeviceIdentity> ImportedWindowsAutopilotDeviceIdentities { get; set; }
#endif
        /// <summary>Intune Account Id for given tenant</summary>
        public Guid? IntuneAccountId { get; set; }
        /// <summary>intuneBrand contains data which is used in customizing the appearance of the Company Portal applications as well as the end user web portal.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.IntuneBrand? IntuneBrand { get; set; }
#nullable restore
#else
        public ApiSdk.Models.IntuneBrand IntuneBrand { get; set; }
#endif
        /// <summary>The IOS software update installation statuses for this account.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IosUpdateDeviceStatus>? IosUpdateStatuses { get; set; }
#nullable restore
#else
        public List<IosUpdateDeviceStatus> IosUpdateStatuses { get; set; }
#endif
        /// <summary>Device overview</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.ManagedDeviceOverview? ManagedDeviceOverview { get; set; }
#nullable restore
#else
        public ApiSdk.Models.ManagedDeviceOverview ManagedDeviceOverview { get; set; }
#endif
        /// <summary>The list of managed devices.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagedDevice>? ManagedDevices { get; set; }
#nullable restore
#else
        public List<ManagedDevice> ManagedDevices { get; set; }
#endif
        /// <summary>The list of Mobile threat Defense connectors configured by the tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MobileThreatDefenseConnector>? MobileThreatDefenseConnectors { get; set; }
#nullable restore
#else
        public List<MobileThreatDefenseConnector> MobileThreatDefenseConnectors { get; set; }
#endif
        /// <summary>The Notification Message Templates.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<NotificationMessageTemplate>? NotificationMessageTemplates { get; set; }
#nullable restore
#else
        public List<NotificationMessageTemplate> NotificationMessageTemplates { get; set; }
#endif
        /// <summary>The remote assist partners.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RemoteAssistancePartner>? RemoteAssistancePartners { get; set; }
#nullable restore
#else
        public List<RemoteAssistancePartner> RemoteAssistancePartners { get; set; }
#endif
        /// <summary>Reports singleton</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementReports? Reports { get; set; }
#nullable restore
#else
        public DeviceManagementReports Reports { get; set; }
#endif
        /// <summary>The Resource Operations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ResourceOperation>? ResourceOperations { get; set; }
#nullable restore
#else
        public List<ResourceOperation> ResourceOperations { get; set; }
#endif
        /// <summary>The Role Assignments.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceAndAppManagementRoleAssignment>? RoleAssignments { get; set; }
#nullable restore
#else
        public List<DeviceAndAppManagementRoleAssignment> RoleAssignments { get; set; }
#endif
        /// <summary>The Role Definitions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RoleDefinition>? RoleDefinitions { get; set; }
#nullable restore
#else
        public List<RoleDefinition> RoleDefinitions { get; set; }
#endif
        /// <summary>Account level settings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementSettings? Settings { get; set; }
#nullable restore
#else
        public DeviceManagementSettings Settings { get; set; }
#endif
        /// <summary>The software update status summary.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.SoftwareUpdateStatusSummary? SoftwareUpdateStatusSummary { get; set; }
#nullable restore
#else
        public ApiSdk.Models.SoftwareUpdateStatusSummary SoftwareUpdateStatusSummary { get; set; }
#endif
        /// <summary>Tenant mobile device management subscription state.</summary>
        public DeviceManagementSubscriptionState? SubscriptionState { get; set; }
        /// <summary>The telecom expense management partners.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TelecomExpenseManagementPartner>? TelecomExpenseManagementPartners { get; set; }
#nullable restore
#else
        public List<TelecomExpenseManagementPartner> TelecomExpenseManagementPartners { get; set; }
#endif
        /// <summary>The terms and conditions associated with device management of the company.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ApiSdk.Models.TermsAndConditions>? TermsAndConditions { get; set; }
#nullable restore
#else
        public List<ApiSdk.Models.TermsAndConditions> TermsAndConditions { get; set; }
#endif
        /// <summary>The list of troubleshooting events for the tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceManagementTroubleshootingEvent>? TroubleshootingEvents { get; set; }
#nullable restore
#else
        public List<DeviceManagementTroubleshootingEvent> TroubleshootingEvents { get; set; }
#endif
        /// <summary>The Windows autopilot device identities contained collection.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WindowsAutopilotDeviceIdentity>? WindowsAutopilotDeviceIdentities { get; set; }
#nullable restore
#else
        public List<WindowsAutopilotDeviceIdentity> WindowsAutopilotDeviceIdentities { get; set; }
#endif
        /// <summary>The windows information protection app learning summaries.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WindowsInformationProtectionAppLearningSummary>? WindowsInformationProtectionAppLearningSummaries { get; set; }
#nullable restore
#else
        public List<WindowsInformationProtectionAppLearningSummary> WindowsInformationProtectionAppLearningSummaries { get; set; }
#endif
        /// <summary>The windows information protection network learning summaries.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WindowsInformationProtectionNetworkLearningSummary>? WindowsInformationProtectionNetworkLearningSummaries { get; set; }
#nullable restore
#else
        public List<WindowsInformationProtectionNetworkLearningSummary> WindowsInformationProtectionNetworkLearningSummaries { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceManagement CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagement();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"applePushNotificationCertificate", n => { ApplePushNotificationCertificate = n.GetObjectValue<ApiSdk.Models.ApplePushNotificationCertificate>(ApiSdk.Models.ApplePushNotificationCertificate.CreateFromDiscriminatorValue); } },
                {"auditEvents", n => { AuditEvents = n.GetCollectionOfObjectValues<AuditEvent>(AuditEvent.CreateFromDiscriminatorValue)?.ToList(); } },
                {"complianceManagementPartners", n => { ComplianceManagementPartners = n.GetCollectionOfObjectValues<ComplianceManagementPartner>(ComplianceManagementPartner.CreateFromDiscriminatorValue)?.ToList(); } },
                {"conditionalAccessSettings", n => { ConditionalAccessSettings = n.GetObjectValue<OnPremisesConditionalAccessSettings>(OnPremisesConditionalAccessSettings.CreateFromDiscriminatorValue); } },
                {"detectedApps", n => { DetectedApps = n.GetCollectionOfObjectValues<DetectedApp>(DetectedApp.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceCategories", n => { DeviceCategories = n.GetCollectionOfObjectValues<DeviceCategory>(DeviceCategory.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceCompliancePolicies", n => { DeviceCompliancePolicies = n.GetCollectionOfObjectValues<DeviceCompliancePolicy>(DeviceCompliancePolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceCompliancePolicyDeviceStateSummary", n => { DeviceCompliancePolicyDeviceStateSummary = n.GetObjectValue<ApiSdk.Models.DeviceCompliancePolicyDeviceStateSummary>(ApiSdk.Models.DeviceCompliancePolicyDeviceStateSummary.CreateFromDiscriminatorValue); } },
                {"deviceCompliancePolicySettingStateSummaries", n => { DeviceCompliancePolicySettingStateSummaries = n.GetCollectionOfObjectValues<DeviceCompliancePolicySettingStateSummary>(DeviceCompliancePolicySettingStateSummary.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceConfigurationDeviceStateSummaries", n => { DeviceConfigurationDeviceStateSummaries = n.GetObjectValue<DeviceConfigurationDeviceStateSummary>(DeviceConfigurationDeviceStateSummary.CreateFromDiscriminatorValue); } },
                {"deviceConfigurations", n => { DeviceConfigurations = n.GetCollectionOfObjectValues<DeviceConfiguration>(DeviceConfiguration.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceEnrollmentConfigurations", n => { DeviceEnrollmentConfigurations = n.GetCollectionOfObjectValues<DeviceEnrollmentConfiguration>(DeviceEnrollmentConfiguration.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceManagementPartners", n => { DeviceManagementPartners = n.GetCollectionOfObjectValues<DeviceManagementPartner>(DeviceManagementPartner.CreateFromDiscriminatorValue)?.ToList(); } },
                {"exchangeConnectors", n => { ExchangeConnectors = n.GetCollectionOfObjectValues<DeviceManagementExchangeConnector>(DeviceManagementExchangeConnector.CreateFromDiscriminatorValue)?.ToList(); } },
                {"importedWindowsAutopilotDeviceIdentities", n => { ImportedWindowsAutopilotDeviceIdentities = n.GetCollectionOfObjectValues<ImportedWindowsAutopilotDeviceIdentity>(ImportedWindowsAutopilotDeviceIdentity.CreateFromDiscriminatorValue)?.ToList(); } },
                {"intuneAccountId", n => { IntuneAccountId = n.GetGuidValue(); } },
                {"intuneBrand", n => { IntuneBrand = n.GetObjectValue<ApiSdk.Models.IntuneBrand>(ApiSdk.Models.IntuneBrand.CreateFromDiscriminatorValue); } },
                {"iosUpdateStatuses", n => { IosUpdateStatuses = n.GetCollectionOfObjectValues<IosUpdateDeviceStatus>(IosUpdateDeviceStatus.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managedDeviceOverview", n => { ManagedDeviceOverview = n.GetObjectValue<ApiSdk.Models.ManagedDeviceOverview>(ApiSdk.Models.ManagedDeviceOverview.CreateFromDiscriminatorValue); } },
                {"managedDevices", n => { ManagedDevices = n.GetCollectionOfObjectValues<ManagedDevice>(ManagedDevice.CreateFromDiscriminatorValue)?.ToList(); } },
                {"mobileThreatDefenseConnectors", n => { MobileThreatDefenseConnectors = n.GetCollectionOfObjectValues<MobileThreatDefenseConnector>(MobileThreatDefenseConnector.CreateFromDiscriminatorValue)?.ToList(); } },
                {"notificationMessageTemplates", n => { NotificationMessageTemplates = n.GetCollectionOfObjectValues<NotificationMessageTemplate>(NotificationMessageTemplate.CreateFromDiscriminatorValue)?.ToList(); } },
                {"remoteAssistancePartners", n => { RemoteAssistancePartners = n.GetCollectionOfObjectValues<RemoteAssistancePartner>(RemoteAssistancePartner.CreateFromDiscriminatorValue)?.ToList(); } },
                {"reports", n => { Reports = n.GetObjectValue<DeviceManagementReports>(DeviceManagementReports.CreateFromDiscriminatorValue); } },
                {"resourceOperations", n => { ResourceOperations = n.GetCollectionOfObjectValues<ResourceOperation>(ResourceOperation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"roleAssignments", n => { RoleAssignments = n.GetCollectionOfObjectValues<DeviceAndAppManagementRoleAssignment>(DeviceAndAppManagementRoleAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"roleDefinitions", n => { RoleDefinitions = n.GetCollectionOfObjectValues<RoleDefinition>(RoleDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"settings", n => { Settings = n.GetObjectValue<DeviceManagementSettings>(DeviceManagementSettings.CreateFromDiscriminatorValue); } },
                {"softwareUpdateStatusSummary", n => { SoftwareUpdateStatusSummary = n.GetObjectValue<ApiSdk.Models.SoftwareUpdateStatusSummary>(ApiSdk.Models.SoftwareUpdateStatusSummary.CreateFromDiscriminatorValue); } },
                {"subscriptionState", n => { SubscriptionState = n.GetEnumValue<DeviceManagementSubscriptionState>(); } },
                {"telecomExpenseManagementPartners", n => { TelecomExpenseManagementPartners = n.GetCollectionOfObjectValues<TelecomExpenseManagementPartner>(TelecomExpenseManagementPartner.CreateFromDiscriminatorValue)?.ToList(); } },
                {"termsAndConditions", n => { TermsAndConditions = n.GetCollectionOfObjectValues<ApiSdk.Models.TermsAndConditions>(ApiSdk.Models.TermsAndConditions.CreateFromDiscriminatorValue)?.ToList(); } },
                {"troubleshootingEvents", n => { TroubleshootingEvents = n.GetCollectionOfObjectValues<DeviceManagementTroubleshootingEvent>(DeviceManagementTroubleshootingEvent.CreateFromDiscriminatorValue)?.ToList(); } },
                {"windowsAutopilotDeviceIdentities", n => { WindowsAutopilotDeviceIdentities = n.GetCollectionOfObjectValues<WindowsAutopilotDeviceIdentity>(WindowsAutopilotDeviceIdentity.CreateFromDiscriminatorValue)?.ToList(); } },
                {"windowsInformationProtectionAppLearningSummaries", n => { WindowsInformationProtectionAppLearningSummaries = n.GetCollectionOfObjectValues<WindowsInformationProtectionAppLearningSummary>(WindowsInformationProtectionAppLearningSummary.CreateFromDiscriminatorValue)?.ToList(); } },
                {"windowsInformationProtectionNetworkLearningSummaries", n => { WindowsInformationProtectionNetworkLearningSummaries = n.GetCollectionOfObjectValues<WindowsInformationProtectionNetworkLearningSummary>(WindowsInformationProtectionNetworkLearningSummary.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ApiSdk.Models.ApplePushNotificationCertificate>("applePushNotificationCertificate", ApplePushNotificationCertificate);
            writer.WriteCollectionOfObjectValues<AuditEvent>("auditEvents", AuditEvents);
            writer.WriteCollectionOfObjectValues<ComplianceManagementPartner>("complianceManagementPartners", ComplianceManagementPartners);
            writer.WriteObjectValue<OnPremisesConditionalAccessSettings>("conditionalAccessSettings", ConditionalAccessSettings);
            writer.WriteCollectionOfObjectValues<DetectedApp>("detectedApps", DetectedApps);
            writer.WriteCollectionOfObjectValues<DeviceCategory>("deviceCategories", DeviceCategories);
            writer.WriteCollectionOfObjectValues<DeviceCompliancePolicy>("deviceCompliancePolicies", DeviceCompliancePolicies);
            writer.WriteObjectValue<ApiSdk.Models.DeviceCompliancePolicyDeviceStateSummary>("deviceCompliancePolicyDeviceStateSummary", DeviceCompliancePolicyDeviceStateSummary);
            writer.WriteCollectionOfObjectValues<DeviceCompliancePolicySettingStateSummary>("deviceCompliancePolicySettingStateSummaries", DeviceCompliancePolicySettingStateSummaries);
            writer.WriteObjectValue<DeviceConfigurationDeviceStateSummary>("deviceConfigurationDeviceStateSummaries", DeviceConfigurationDeviceStateSummaries);
            writer.WriteCollectionOfObjectValues<DeviceConfiguration>("deviceConfigurations", DeviceConfigurations);
            writer.WriteCollectionOfObjectValues<DeviceEnrollmentConfiguration>("deviceEnrollmentConfigurations", DeviceEnrollmentConfigurations);
            writer.WriteCollectionOfObjectValues<DeviceManagementPartner>("deviceManagementPartners", DeviceManagementPartners);
            writer.WriteCollectionOfObjectValues<DeviceManagementExchangeConnector>("exchangeConnectors", ExchangeConnectors);
            writer.WriteCollectionOfObjectValues<ImportedWindowsAutopilotDeviceIdentity>("importedWindowsAutopilotDeviceIdentities", ImportedWindowsAutopilotDeviceIdentities);
            writer.WriteGuidValue("intuneAccountId", IntuneAccountId);
            writer.WriteObjectValue<ApiSdk.Models.IntuneBrand>("intuneBrand", IntuneBrand);
            writer.WriteCollectionOfObjectValues<IosUpdateDeviceStatus>("iosUpdateStatuses", IosUpdateStatuses);
            writer.WriteObjectValue<ApiSdk.Models.ManagedDeviceOverview>("managedDeviceOverview", ManagedDeviceOverview);
            writer.WriteCollectionOfObjectValues<ManagedDevice>("managedDevices", ManagedDevices);
            writer.WriteCollectionOfObjectValues<MobileThreatDefenseConnector>("mobileThreatDefenseConnectors", MobileThreatDefenseConnectors);
            writer.WriteCollectionOfObjectValues<NotificationMessageTemplate>("notificationMessageTemplates", NotificationMessageTemplates);
            writer.WriteCollectionOfObjectValues<RemoteAssistancePartner>("remoteAssistancePartners", RemoteAssistancePartners);
            writer.WriteObjectValue<DeviceManagementReports>("reports", Reports);
            writer.WriteCollectionOfObjectValues<ResourceOperation>("resourceOperations", ResourceOperations);
            writer.WriteCollectionOfObjectValues<DeviceAndAppManagementRoleAssignment>("roleAssignments", RoleAssignments);
            writer.WriteCollectionOfObjectValues<RoleDefinition>("roleDefinitions", RoleDefinitions);
            writer.WriteObjectValue<DeviceManagementSettings>("settings", Settings);
            writer.WriteObjectValue<ApiSdk.Models.SoftwareUpdateStatusSummary>("softwareUpdateStatusSummary", SoftwareUpdateStatusSummary);
            writer.WriteEnumValue<DeviceManagementSubscriptionState>("subscriptionState", SubscriptionState);
            writer.WriteCollectionOfObjectValues<TelecomExpenseManagementPartner>("telecomExpenseManagementPartners", TelecomExpenseManagementPartners);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.TermsAndConditions>("termsAndConditions", TermsAndConditions);
            writer.WriteCollectionOfObjectValues<DeviceManagementTroubleshootingEvent>("troubleshootingEvents", TroubleshootingEvents);
            writer.WriteCollectionOfObjectValues<WindowsAutopilotDeviceIdentity>("windowsAutopilotDeviceIdentities", WindowsAutopilotDeviceIdentities);
            writer.WriteCollectionOfObjectValues<WindowsInformationProtectionAppLearningSummary>("windowsInformationProtectionAppLearningSummaries", WindowsInformationProtectionAppLearningSummaries);
            writer.WriteCollectionOfObjectValues<WindowsInformationProtectionNetworkLearningSummary>("windowsInformationProtectionNetworkLearningSummaries", WindowsInformationProtectionNetworkLearningSummaries);
        }
    }
}
