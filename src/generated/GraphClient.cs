using ApiSdk.Admin;
using ApiSdk.AgreementAcceptances;
using ApiSdk.Agreements;
using ApiSdk.AppCatalogs;
using ApiSdk.Applications;
using ApiSdk.ApplicationTemplates;
using ApiSdk.AuditLogs;
using ApiSdk.AuthenticationMethodConfigurations;
using ApiSdk.AuthenticationMethodsPolicy;
using ApiSdk.Branding;
using ApiSdk.CertificateBasedAuthConfiguration;
using ApiSdk.Chats;
using ApiSdk.Communications;
using ApiSdk.Compliance;
using ApiSdk.Connections;
using ApiSdk.Contacts;
using ApiSdk.Contracts;
using ApiSdk.DataPolicyOperations;
using ApiSdk.DeviceAppManagement;
using ApiSdk.DeviceManagement;
using ApiSdk.Devices;
using ApiSdk.DirectoryNamespace;
using ApiSdk.DirectoryObjects;
using ApiSdk.DirectoryRoles;
using ApiSdk.DirectoryRoleTemplates;
using ApiSdk.DomainDnsRecords;
using ApiSdk.Domains;
using ApiSdk.Drives;
using ApiSdk.Education;
using ApiSdk.External;
using ApiSdk.GroupLifecyclePolicies;
using ApiSdk.Groups;
using ApiSdk.GroupSettings;
using ApiSdk.GroupSettingTemplates;
using ApiSdk.Identity;
using ApiSdk.IdentityGovernance;
using ApiSdk.IdentityProtection;
using ApiSdk.IdentityProviders;
using ApiSdk.InformationProtection;
using ApiSdk.Invitations;
using ApiSdk.Localizations;
using ApiSdk.Me;
using ApiSdk.Oauth2PermissionGrants;
using ApiSdk.Organization;
using ApiSdk.PermissionGrants;
using ApiSdk.Places;
using ApiSdk.Planner;
using ApiSdk.Policies;
using ApiSdk.Print;
using ApiSdk.Privacy;
using ApiSdk.Reports;
using ApiSdk.RoleManagement;
using ApiSdk.SchemaExtensions;
using ApiSdk.ScopedRoleMemberships;
using ApiSdk.Search;
using ApiSdk.Security;
using ApiSdk.ServicePrincipals;
using ApiSdk.Shares;
using ApiSdk.Sites;
using ApiSdk.Solutions;
using ApiSdk.SubscribedSkus;
using ApiSdk.Subscriptions;
using ApiSdk.Teams;
using ApiSdk.TeamsTemplates;
using ApiSdk.Teamwork;
using ApiSdk.TenantRelationships;
using ApiSdk.Users;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Cli.Commons.IO;
using Microsoft.Kiota.Serialization.Form;
using Microsoft.Kiota.Serialization.Json;
using Microsoft.Kiota.Serialization.Text;
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ApiSdk {
    /// <summary>
    /// The main entry point of the SDK, exposes the configuration and the fluent API.
    /// </summary>
    public class GraphClient {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Provides operations to manage the admin singleton.
        /// </summary>
        public Command BuildAdminCommand() {
            var command = new Command("admin");
            command.Description = "Provides operations to manage the admin singleton.";
            var builder = new AdminRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildServiceAnnouncementCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of agreementAcceptance entities.
        /// </summary>
        public Command BuildAgreementAcceptancesCommand() {
            var command = new Command("agreement-acceptances");
            command.Description = "Provides operations to manage the collection of agreementAcceptance entities.";
            var builder = new AgreementAcceptancesRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of agreement entities.
        /// </summary>
        public Command BuildAgreementsCommand() {
            var command = new Command("agreements");
            command.Description = "Provides operations to manage the collection of agreement entities.";
            var builder = new AgreementsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the appCatalogs singleton.
        /// </summary>
        public Command BuildAppCatalogsCommand() {
            var command = new Command("app-catalogs");
            command.Description = "Provides operations to manage the appCatalogs singleton.";
            var builder = new AppCatalogsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildTeamsAppsCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of application entities.
        /// </summary>
        public Command BuildApplicationsCommand() {
            var command = new Command("applications");
            command.Description = "Provides operations to manage the collection of application entities.";
            var builder = new ApplicationsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDeltaCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGetAvailableExtensionPropertiesCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGetByIdsCommand());
            command.AddCommand(builder.BuildMicrosoftGraphValidatePropertiesCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of applicationTemplate entities.
        /// </summary>
        public Command BuildApplicationTemplatesCommand() {
            var command = new Command("application-templates");
            command.Description = "Provides operations to manage the collection of applicationTemplate entities.";
            var builder = new ApplicationTemplatesRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the auditLogRoot singleton.
        /// </summary>
        public Command BuildAuditLogsCommand() {
            var command = new Command("audit-logs");
            command.Description = "Provides operations to manage the auditLogRoot singleton.";
            var builder = new AuditLogsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildDirectoryAuditsCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildProvisioningCommand());
            command.AddCommand(builder.BuildSignInsCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of authenticationMethodConfiguration entities.
        /// </summary>
        public Command BuildAuthenticationMethodConfigurationsCommand() {
            var command = new Command("authentication-method-configurations");
            command.Description = "Provides operations to manage the collection of authenticationMethodConfiguration entities.";
            var builder = new AuthenticationMethodConfigurationsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the authenticationMethodsPolicy singleton.
        /// </summary>
        public Command BuildAuthenticationMethodsPolicyCommand() {
            var command = new Command("authentication-methods-policy");
            command.Description = "Provides operations to manage the authenticationMethodsPolicy singleton.";
            var builder = new AuthenticationMethodsPolicyRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildAuthenticationMethodConfigurationsCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the organizationalBranding singleton.
        /// </summary>
        public Command BuildBrandingCommand() {
            var command = new Command("branding");
            command.Description = "Provides operations to manage the organizationalBranding singleton.";
            var builder = new BrandingRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildBackgroundImageCommand());
            command.AddCommand(builder.BuildBannerLogoCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildLocalizationsCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildSquareLogoCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of certificateBasedAuthConfiguration entities.
        /// </summary>
        public Command BuildCertificateBasedAuthConfigurationCommand() {
            var command = new Command("certificate-based-auth-configuration");
            command.Description = "Provides operations to manage the collection of certificateBasedAuthConfiguration entities.";
            var builder = new CertificateBasedAuthConfigurationRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of chat entities.
        /// </summary>
        public Command BuildChatsCommand() {
            var command = new Command("chats");
            command.Description = "Provides operations to manage the collection of chat entities.";
            var builder = new ChatsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGetAllMessagesCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the cloudCommunications singleton.
        /// </summary>
        public Command BuildCommunicationsCommand() {
            var command = new Command("communications");
            command.Description = "Provides operations to manage the cloudCommunications singleton.";
            var builder = new CommunicationsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCallRecordsCommand());
            command.AddCommand(builder.BuildCallsCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGetPresencesByUserIdCommand());
            command.AddCommand(builder.BuildOnlineMeetingsCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildPresencesCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the compliance singleton.
        /// </summary>
        public Command BuildComplianceCommand() {
            var command = new Command("compliance");
            command.Description = "Provides operations to manage the compliance singleton.";
            var builder = new ComplianceRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of externalConnection entities.
        /// </summary>
        public Command BuildConnectionsCommand() {
            var command = new Command("connections");
            command.Description = "Provides operations to manage the collection of externalConnection entities.";
            var builder = new ConnectionsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of orgContact entities.
        /// </summary>
        public Command BuildContactsCommand() {
            var command = new Command("contacts");
            command.Description = "Provides operations to manage the collection of orgContact entities.";
            var builder = new ContactsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDeltaCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGetAvailableExtensionPropertiesCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGetByIdsCommand());
            command.AddCommand(builder.BuildMicrosoftGraphValidatePropertiesCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of contract entities.
        /// </summary>
        public Command BuildContractsCommand() {
            var command = new Command("contracts");
            command.Description = "Provides operations to manage the collection of contract entities.";
            var builder = new ContractsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGetAvailableExtensionPropertiesCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGetByIdsCommand());
            command.AddCommand(builder.BuildMicrosoftGraphValidatePropertiesCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of dataPolicyOperation entities.
        /// </summary>
        public Command BuildDataPolicyOperationsCommand() {
            var command = new Command("data-policy-operations");
            command.Description = "Provides operations to manage the collection of dataPolicyOperation entities.";
            var builder = new DataPolicyOperationsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the deviceAppManagement singleton.
        /// </summary>
        public Command BuildDeviceAppManagementCommand() {
            var command = new Command("device-app-management");
            command.Description = "Provides operations to manage the deviceAppManagement singleton.";
            var builder = new DeviceAppManagementRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildAndroidManagedAppProtectionsCommand());
            command.AddCommand(builder.BuildDefaultManagedAppProtectionsCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildIosManagedAppProtectionsCommand());
            command.AddCommand(builder.BuildManagedAppPoliciesCommand());
            command.AddCommand(builder.BuildManagedAppRegistrationsCommand());
            command.AddCommand(builder.BuildManagedAppStatusesCommand());
            command.AddCommand(builder.BuildManagedEBooksCommand());
            command.AddCommand(builder.BuildMdmWindowsInformationProtectionPoliciesCommand());
            command.AddCommand(builder.BuildMicrosoftGraphSyncMicrosoftStoreForBusinessAppsCommand());
            command.AddCommand(builder.BuildMobileAppCategoriesCommand());
            command.AddCommand(builder.BuildMobileAppConfigurationsCommand());
            command.AddCommand(builder.BuildMobileAppsCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildTargetedManagedAppConfigurationsCommand());
            command.AddCommand(builder.BuildVppTokensCommand());
            command.AddCommand(builder.BuildWindowsInformationProtectionPoliciesCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the deviceManagement singleton.
        /// </summary>
        public Command BuildDeviceManagementCommand() {
            var command = new Command("device-management");
            command.Description = "Provides operations to manage the deviceManagement singleton.";
            var builder = new DeviceManagementRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildApplePushNotificationCertificateCommand());
            command.AddCommand(builder.BuildAuditEventsCommand());
            command.AddCommand(builder.BuildComplianceManagementPartnersCommand());
            command.AddCommand(builder.BuildConditionalAccessSettingsCommand());
            command.AddCommand(builder.BuildDetectedAppsCommand());
            command.AddCommand(builder.BuildDeviceCategoriesCommand());
            command.AddCommand(builder.BuildDeviceCompliancePoliciesCommand());
            command.AddCommand(builder.BuildDeviceCompliancePolicyDeviceStateSummaryCommand());
            command.AddCommand(builder.BuildDeviceCompliancePolicySettingStateSummariesCommand());
            command.AddCommand(builder.BuildDeviceConfigurationDeviceStateSummariesCommand());
            command.AddCommand(builder.BuildDeviceConfigurationsCommand());
            command.AddCommand(builder.BuildDeviceEnrollmentConfigurationsCommand());
            command.AddCommand(builder.BuildDeviceManagementPartnersCommand());
            command.AddCommand(builder.BuildExchangeConnectorsCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildImportedWindowsAutopilotDeviceIdentitiesCommand());
            command.AddCommand(builder.BuildIosUpdateStatusesCommand());
            command.AddCommand(builder.BuildManagedDeviceOverviewCommand());
            command.AddCommand(builder.BuildManagedDevicesCommand());
            command.AddCommand(builder.BuildMobileThreatDefenseConnectorsCommand());
            command.AddCommand(builder.BuildNotificationMessageTemplatesCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildRemoteAssistancePartnersCommand());
            command.AddCommand(builder.BuildReportsCommand());
            command.AddCommand(builder.BuildResourceOperationsCommand());
            command.AddCommand(builder.BuildRoleAssignmentsCommand());
            command.AddCommand(builder.BuildRoleDefinitionsCommand());
            command.AddCommand(builder.BuildSoftwareUpdateStatusSummaryCommand());
            command.AddCommand(builder.BuildTelecomExpenseManagementPartnersCommand());
            command.AddCommand(builder.BuildTermsAndConditionsCommand());
            command.AddCommand(builder.BuildTroubleshootingEventsCommand());
            command.AddCommand(builder.BuildWindowsAutopilotDeviceIdentitiesCommand());
            command.AddCommand(builder.BuildWindowsInformationProtectionAppLearningSummariesCommand());
            command.AddCommand(builder.BuildWindowsInformationProtectionNetworkLearningSummariesCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of device entities.
        /// </summary>
        public Command BuildDevicesCommand() {
            var command = new Command("devices");
            command.Description = "Provides operations to manage the collection of device entities.";
            var builder = new DevicesRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDeltaCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGetAvailableExtensionPropertiesCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGetByIdsCommand());
            command.AddCommand(builder.BuildMicrosoftGraphValidatePropertiesCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the directory singleton.
        /// </summary>
        public Command BuildDirectoryCommand() {
            var command = new Command("directory");
            command.Description = "Provides operations to manage the directory singleton.";
            var builder = new DirectoryRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildAdministrativeUnitsCommand());
            command.AddCommand(builder.BuildDeletedItemsCommand());
            command.AddCommand(builder.BuildFederationConfigurationsCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of directoryObject entities.
        /// </summary>
        public Command BuildDirectoryObjectsCommand() {
            var command = new Command("directory-objects");
            command.Description = "Provides operations to manage the collection of directoryObject entities.";
            var builder = new DirectoryObjectsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGetAvailableExtensionPropertiesCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGetByIdsCommand());
            command.AddCommand(builder.BuildMicrosoftGraphValidatePropertiesCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of directoryRole entities.
        /// </summary>
        public Command BuildDirectoryRolesCommand() {
            var command = new Command("directory-roles");
            command.Description = "Provides operations to manage the collection of directoryRole entities.";
            var builder = new DirectoryRolesRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDeltaCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGetAvailableExtensionPropertiesCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGetByIdsCommand());
            command.AddCommand(builder.BuildMicrosoftGraphValidatePropertiesCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of directoryRoleTemplate entities.
        /// </summary>
        public Command BuildDirectoryRoleTemplatesCommand() {
            var command = new Command("directory-role-templates");
            command.Description = "Provides operations to manage the collection of directoryRoleTemplate entities.";
            var builder = new DirectoryRoleTemplatesRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGetAvailableExtensionPropertiesCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGetByIdsCommand());
            command.AddCommand(builder.BuildMicrosoftGraphValidatePropertiesCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of domainDnsRecord entities.
        /// </summary>
        public Command BuildDomainDnsRecordsCommand() {
            var command = new Command("domain-dns-records");
            command.Description = "Provides operations to manage the collection of domainDnsRecord entities.";
            var builder = new DomainDnsRecordsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of domain entities.
        /// </summary>
        public Command BuildDomainsCommand() {
            var command = new Command("domains");
            command.Description = "Provides operations to manage the collection of domain entities.";
            var builder = new DomainsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of drive entities.
        /// </summary>
        public Command BuildDrivesCommand() {
            var command = new Command("drives");
            command.Description = "Provides operations to manage the collection of drive entities.";
            var builder = new DrivesRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the educationRoot singleton.
        /// </summary>
        public Command BuildEducationCommand() {
            var command = new Command("education");
            command.Description = "Provides operations to manage the educationRoot singleton.";
            var builder = new EducationRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildClassesCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildMeCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildSchoolsCommand());
            command.AddCommand(builder.BuildUsersCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the external singleton.
        /// </summary>
        public Command BuildExternalCommand() {
            var command = new Command("external");
            command.Description = "Provides operations to manage the external singleton.";
            var builder = new ExternalRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildConnectionsCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of groupLifecyclePolicy entities.
        /// </summary>
        public Command BuildGroupLifecyclePoliciesCommand() {
            var command = new Command("group-lifecycle-policies");
            command.Description = "Provides operations to manage the collection of groupLifecyclePolicy entities.";
            var builder = new GroupLifecyclePoliciesRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of group entities.
        /// </summary>
        public Command BuildGroupsCommand() {
            var command = new Command("groups");
            command.Description = "Provides operations to manage the collection of group entities.";
            var builder = new GroupsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDeltaCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGetAvailableExtensionPropertiesCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGetByIdsCommand());
            command.AddCommand(builder.BuildMicrosoftGraphValidatePropertiesCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of groupSetting entities.
        /// </summary>
        public Command BuildGroupSettingsCommand() {
            var command = new Command("group-settings");
            command.Description = "Provides operations to manage the collection of groupSetting entities.";
            var builder = new GroupSettingsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of groupSettingTemplate entities.
        /// </summary>
        public Command BuildGroupSettingTemplatesCommand() {
            var command = new Command("group-setting-templates");
            command.Description = "Provides operations to manage the collection of groupSettingTemplate entities.";
            var builder = new GroupSettingTemplatesRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGetAvailableExtensionPropertiesCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGetByIdsCommand());
            command.AddCommand(builder.BuildMicrosoftGraphValidatePropertiesCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the identityContainer singleton.
        /// </summary>
        public Command BuildIdentityCommand() {
            var command = new Command("identity");
            command.Description = "Provides operations to manage the identityContainer singleton.";
            var builder = new IdentityRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildApiConnectorsCommand());
            command.AddCommand(builder.BuildB2xUserFlowsCommand());
            command.AddCommand(builder.BuildConditionalAccessCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildIdentityProvidersCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildUserFlowAttributesCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the identityGovernance singleton.
        /// </summary>
        public Command BuildIdentityGovernanceCommand() {
            var command = new Command("identity-governance");
            command.Description = "Provides operations to manage the identityGovernance singleton.";
            var builder = new IdentityGovernanceRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildAccessReviewsCommand());
            command.AddCommand(builder.BuildAppConsentCommand());
            command.AddCommand(builder.BuildEntitlementManagementCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildTermsOfUseCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the identityProtectionRoot singleton.
        /// </summary>
        public Command BuildIdentityProtectionCommand() {
            var command = new Command("identity-protection");
            command.Description = "Provides operations to manage the identityProtectionRoot singleton.";
            var builder = new IdentityProtectionRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildRiskDetectionsCommand());
            command.AddCommand(builder.BuildRiskyServicePrincipalsCommand());
            command.AddCommand(builder.BuildRiskyUsersCommand());
            command.AddCommand(builder.BuildServicePrincipalRiskDetectionsCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of identityProvider entities.
        /// </summary>
        public Command BuildIdentityProvidersCommand() {
            var command = new Command("identity-providers");
            command.Description = "Provides operations to manage the collection of identityProvider entities.";
            var builder = new IdentityProvidersRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphAvailableProviderTypesCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the informationProtection singleton.
        /// </summary>
        public Command BuildInformationProtectionCommand() {
            var command = new Command("information-protection");
            command.Description = "Provides operations to manage the informationProtection singleton.";
            var builder = new InformationProtectionRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildBitlockerCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildThreatAssessmentRequestsCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of invitation entities.
        /// </summary>
        public Command BuildInvitationsCommand() {
            var command = new Command("invitations");
            command.Description = "Provides operations to manage the collection of invitation entities.";
            var builder = new InvitationsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of organizationalBrandingLocalization entities.
        /// </summary>
        public Command BuildLocalizationsCommand() {
            var command = new Command("localizations");
            command.Description = "Provides operations to manage the collection of organizationalBrandingLocalization entities.";
            var builder = new LocalizationsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the user singleton.
        /// </summary>
        public Command BuildMeCommand() {
            var command = new Command("me");
            command.Description = "Provides operations to manage the user singleton.";
            var builder = new MeRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildActivitiesCommand());
            command.AddCommand(builder.BuildAgreementAcceptancesCommand());
            command.AddCommand(builder.BuildAppRoleAssignmentsCommand());
            command.AddCommand(builder.BuildAuthenticationCommand());
            command.AddCommand(builder.BuildCalendarCommand());
            command.AddCommand(builder.BuildCalendarGroupsCommand());
            command.AddCommand(builder.BuildCalendarsCommand());
            command.AddCommand(builder.BuildCalendarViewCommand());
            command.AddCommand(builder.BuildChatsCommand());
            command.AddCommand(builder.BuildContactFoldersCommand());
            command.AddCommand(builder.BuildContactsCommand());
            command.AddCommand(builder.BuildCreatedObjectsCommand());
            command.AddCommand(builder.BuildDeviceManagementTroubleshootingEventsCommand());
            command.AddCommand(builder.BuildDirectReportsCommand());
            command.AddCommand(builder.BuildDriveCommand());
            command.AddCommand(builder.BuildDrivesCommand());
            command.AddCommand(builder.BuildEventsCommand());
            command.AddCommand(builder.BuildExtensionsCommand());
            command.AddCommand(builder.BuildFollowedSitesCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildInferenceClassificationCommand());
            command.AddCommand(builder.BuildInsightsCommand());
            command.AddCommand(builder.BuildJoinedTeamsCommand());
            command.AddCommand(builder.BuildLicenseDetailsCommand());
            command.AddCommand(builder.BuildMailFoldersCommand());
            command.AddCommand(builder.BuildManagedAppRegistrationsCommand());
            command.AddCommand(builder.BuildManagedDevicesCommand());
            command.AddCommand(builder.BuildManagerCommand());
            command.AddCommand(builder.BuildMemberOfCommand());
            command.AddCommand(builder.BuildMessagesCommand());
            command.AddCommand(builder.BuildMicrosoftGraphAssignLicenseCommand());
            command.AddCommand(builder.BuildMicrosoftGraphChangePasswordCommand());
            command.AddCommand(builder.BuildMicrosoftGraphCheckMemberGroupsCommand());
            command.AddCommand(builder.BuildMicrosoftGraphCheckMemberObjectsCommand());
            command.AddCommand(builder.BuildMicrosoftGraphExportDeviceAndAppManagementDataCommand());
            command.AddCommand(builder.BuildMicrosoftGraphExportPersonalDataCommand());
            command.AddCommand(builder.BuildMicrosoftGraphFindMeetingTimesCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGetMailTipsCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGetManagedAppDiagnosticStatusesCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGetManagedAppPoliciesCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGetManagedDevicesWithAppFailuresCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGetMemberGroupsCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGetMemberObjectsCommand());
            command.AddCommand(builder.BuildMicrosoftGraphRemoveAllDevicesFromManagementCommand());
            command.AddCommand(builder.BuildMicrosoftGraphReprocessLicenseAssignmentCommand());
            command.AddCommand(builder.BuildMicrosoftGraphRestoreCommand());
            command.AddCommand(builder.BuildMicrosoftGraphRevokeSignInSessionsCommand());
            command.AddCommand(builder.BuildMicrosoftGraphSendMailCommand());
            command.AddCommand(builder.BuildMicrosoftGraphTranslateExchangeIdsCommand());
            command.AddCommand(builder.BuildMicrosoftGraphWipeManagedAppRegistrationsByDeviceTagCommand());
            command.AddCommand(builder.BuildOauth2PermissionGrantsCommand());
            command.AddCommand(builder.BuildOnenoteCommand());
            command.AddCommand(builder.BuildOnlineMeetingsCommand());
            command.AddCommand(builder.BuildOutlookCommand());
            command.AddCommand(builder.BuildOwnedDevicesCommand());
            command.AddCommand(builder.BuildOwnedObjectsCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildPeopleCommand());
            command.AddCommand(builder.BuildPhotoCommand());
            command.AddCommand(builder.BuildPhotosCommand());
            command.AddCommand(builder.BuildPlannerCommand());
            command.AddCommand(builder.BuildPresenceCommand());
            command.AddCommand(builder.BuildRegisteredDevicesCommand());
            command.AddCommand(builder.BuildScopedRoleMemberOfCommand());
            command.AddCommand(builder.BuildSettingsCommand());
            command.AddCommand(builder.BuildTeamworkCommand());
            command.AddCommand(builder.BuildTodoCommand());
            command.AddCommand(builder.BuildTransitiveMemberOfCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of oAuth2PermissionGrant entities.
        /// </summary>
        public Command BuildOauth2PermissionGrantsCommand() {
            var command = new Command("oauth2-permission-grants");
            command.Description = "Provides operations to manage the collection of oAuth2PermissionGrant entities.";
            var builder = new Oauth2PermissionGrantsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDeltaCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of organization entities.
        /// </summary>
        public Command BuildOrganizationCommand() {
            var command = new Command("organization");
            command.Description = "Provides operations to manage the collection of organization entities.";
            var builder = new OrganizationRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGetAvailableExtensionPropertiesCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGetByIdsCommand());
            command.AddCommand(builder.BuildMicrosoftGraphValidatePropertiesCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of resourceSpecificPermissionGrant entities.
        /// </summary>
        public Command BuildPermissionGrantsCommand() {
            var command = new Command("permission-grants");
            command.Description = "Provides operations to manage the collection of resourceSpecificPermissionGrant entities.";
            var builder = new PermissionGrantsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGetAvailableExtensionPropertiesCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGetByIdsCommand());
            command.AddCommand(builder.BuildMicrosoftGraphValidatePropertiesCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of place entities.
        /// </summary>
        public Command BuildPlacesCommand() {
            var command = new Command("places");
            command.Description = "Provides operations to manage the collection of place entities.";
            var builder = new PlacesRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphRoomCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the planner singleton.
        /// </summary>
        public Command BuildPlannerCommand() {
            var command = new Command("planner");
            command.Description = "Provides operations to manage the planner singleton.";
            var builder = new PlannerRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildBucketsCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildPlansCommand());
            command.AddCommand(builder.BuildTasksCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the policyRoot singleton.
        /// </summary>
        public Command BuildPoliciesCommand() {
            var command = new Command("policies");
            command.Description = "Provides operations to manage the policyRoot singleton.";
            var builder = new PoliciesRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildActivityBasedTimeoutPoliciesCommand());
            command.AddCommand(builder.BuildAdminConsentRequestPolicyCommand());
            command.AddCommand(builder.BuildAuthenticationFlowsPolicyCommand());
            command.AddCommand(builder.BuildAuthenticationMethodsPolicyCommand());
            command.AddCommand(builder.BuildAuthorizationPolicyCommand());
            command.AddCommand(builder.BuildClaimsMappingPoliciesCommand());
            command.AddCommand(builder.BuildConditionalAccessPoliciesCommand());
            command.AddCommand(builder.BuildCrossTenantAccessPolicyCommand());
            command.AddCommand(builder.BuildFeatureRolloutPoliciesCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildHomeRealmDiscoveryPoliciesCommand());
            command.AddCommand(builder.BuildIdentitySecurityDefaultsEnforcementPolicyCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildPermissionGrantPoliciesCommand());
            command.AddCommand(builder.BuildRoleManagementPoliciesCommand());
            command.AddCommand(builder.BuildRoleManagementPolicyAssignmentsCommand());
            command.AddCommand(builder.BuildTokenIssuancePoliciesCommand());
            command.AddCommand(builder.BuildTokenLifetimePoliciesCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the print singleton.
        /// </summary>
        public Command BuildPrintCommand() {
            var command = new Command("print");
            command.Description = "Provides operations to manage the print singleton.";
            var builder = new PrintRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildConnectorsCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildOperationsCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildPrintersCommand());
            command.AddCommand(builder.BuildServicesCommand());
            command.AddCommand(builder.BuildSharesCommand());
            command.AddCommand(builder.BuildTaskDefinitionsCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the privacy singleton.
        /// </summary>
        public Command BuildPrivacyCommand() {
            var command = new Command("privacy");
            command.Description = "Provides operations to manage the privacy singleton.";
            var builder = new PrivacyRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildSubjectRightsRequestsCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the reportRoot singleton.
        /// </summary>
        public Command BuildReportsCommand() {
            var command = new Command("reports");
            command.Description = "Provides operations to manage the reportRoot singleton.";
            var builder = new ReportsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildDailyPrintUsageByPrinterCommand());
            command.AddCommand(builder.BuildDailyPrintUsageByUserCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDeviceConfigurationDeviceActivityCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDeviceConfigurationUserActivityCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGetOffice365ActivationCountsCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGetOffice365ActivationsUserCountsCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGetOffice365ActivationsUserDetailCommand());
            command.AddCommand(builder.BuildMicrosoftGraphManagedDeviceEnrollmentFailureDetailsCommand());
            command.AddCommand(builder.BuildMicrosoftGraphManagedDeviceEnrollmentTopFailuresCommand());
            command.AddCommand(builder.BuildMonthlyPrintUsageByPrinterCommand());
            command.AddCommand(builder.BuildMonthlyPrintUsageByUserCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildSecurityCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the roleManagement singleton.
        /// </summary>
        public Command BuildRoleManagementCommand() {
            var command = new Command("role-management");
            command.Description = "Provides operations to manage the roleManagement singleton.";
            var builder = new RoleManagementRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildDirectoryCommand());
            command.AddCommand(builder.BuildEntitlementManagementCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new GraphClient and sets the default values.
        /// </summary>
        public Command BuildRootCommand() {
            var command = new RootCommand();
            command.Description = "Instantiates a new GraphClient and sets the default values.";
            command.AddCommand(BuildAdminCommand());
            command.AddCommand(BuildAgreementAcceptancesCommand());
            command.AddCommand(BuildAgreementsCommand());
            command.AddCommand(BuildAppCatalogsCommand());
            command.AddCommand(BuildApplicationsCommand());
            command.AddCommand(BuildApplicationTemplatesCommand());
            command.AddCommand(BuildAuditLogsCommand());
            command.AddCommand(BuildAuthenticationMethodConfigurationsCommand());
            command.AddCommand(BuildAuthenticationMethodsPolicyCommand());
            command.AddCommand(BuildBrandingCommand());
            command.AddCommand(BuildCertificateBasedAuthConfigurationCommand());
            command.AddCommand(BuildChatsCommand());
            command.AddCommand(BuildCommunicationsCommand());
            command.AddCommand(BuildComplianceCommand());
            command.AddCommand(BuildConnectionsCommand());
            command.AddCommand(BuildContactsCommand());
            command.AddCommand(BuildContractsCommand());
            command.AddCommand(BuildDataPolicyOperationsCommand());
            command.AddCommand(BuildDeviceAppManagementCommand());
            command.AddCommand(BuildDeviceManagementCommand());
            command.AddCommand(BuildDevicesCommand());
            command.AddCommand(BuildDirectoryCommand());
            command.AddCommand(BuildDirectoryObjectsCommand());
            command.AddCommand(BuildDirectoryRolesCommand());
            command.AddCommand(BuildDirectoryRoleTemplatesCommand());
            command.AddCommand(BuildDomainDnsRecordsCommand());
            command.AddCommand(BuildDomainsCommand());
            command.AddCommand(BuildDrivesCommand());
            command.AddCommand(BuildEducationCommand());
            command.AddCommand(BuildExternalCommand());
            command.AddCommand(BuildGroupLifecyclePoliciesCommand());
            command.AddCommand(BuildGroupsCommand());
            command.AddCommand(BuildGroupSettingsCommand());
            command.AddCommand(BuildGroupSettingTemplatesCommand());
            command.AddCommand(BuildIdentityCommand());
            command.AddCommand(BuildIdentityGovernanceCommand());
            command.AddCommand(BuildIdentityProtectionCommand());
            command.AddCommand(BuildIdentityProvidersCommand());
            command.AddCommand(BuildInformationProtectionCommand());
            command.AddCommand(BuildInvitationsCommand());
            command.AddCommand(BuildLocalizationsCommand());
            command.AddCommand(BuildMeCommand());
            command.AddCommand(BuildOauth2PermissionGrantsCommand());
            command.AddCommand(BuildOrganizationCommand());
            command.AddCommand(BuildPermissionGrantsCommand());
            command.AddCommand(BuildPlacesCommand());
            command.AddCommand(BuildPlannerCommand());
            command.AddCommand(BuildPoliciesCommand());
            command.AddCommand(BuildPrintCommand());
            command.AddCommand(BuildPrivacyCommand());
            command.AddCommand(BuildReportsCommand());
            command.AddCommand(BuildRoleManagementCommand());
            command.AddCommand(BuildSchemaExtensionsCommand());
            command.AddCommand(BuildScopedRoleMembershipsCommand());
            command.AddCommand(BuildSearchCommand());
            command.AddCommand(BuildSecurityCommand());
            command.AddCommand(BuildServicePrincipalsCommand());
            command.AddCommand(BuildSharesCommand());
            command.AddCommand(BuildSitesCommand());
            command.AddCommand(BuildSolutionsCommand());
            command.AddCommand(BuildSubscribedSkusCommand());
            command.AddCommand(BuildSubscriptionsCommand());
            command.AddCommand(BuildTeamsCommand());
            command.AddCommand(BuildTeamsTemplatesCommand());
            command.AddCommand(BuildTeamworkCommand());
            command.AddCommand(BuildTenantRelationshipsCommand());
            command.AddCommand(BuildUsersCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of schemaExtension entities.
        /// </summary>
        public Command BuildSchemaExtensionsCommand() {
            var command = new Command("schema-extensions");
            command.Description = "Provides operations to manage the collection of schemaExtension entities.";
            var builder = new SchemaExtensionsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of scopedRoleMembership entities.
        /// </summary>
        public Command BuildScopedRoleMembershipsCommand() {
            var command = new Command("scoped-role-memberships");
            command.Description = "Provides operations to manage the collection of scopedRoleMembership entities.";
            var builder = new ScopedRoleMembershipsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the searchEntity singleton.
        /// </summary>
        public Command BuildSearchCommand() {
            var command = new Command("search");
            command.Description = "Provides operations to manage the searchEntity singleton.";
            var builder = new SearchRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildMicrosoftGraphQueryCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the security singleton.
        /// </summary>
        public Command BuildSecurityCommand() {
            var command = new Command("security");
            command.Description = "Provides operations to manage the security singleton.";
            var builder = new SecurityRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildAlerts_v2Command());
            command.AddCommand(builder.BuildAlertsCommand());
            command.AddCommand(builder.BuildAttackSimulationCommand());
            command.AddCommand(builder.BuildCasesCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildIncidentsCommand());
            command.AddCommand(builder.BuildMicrosoftGraphSecurityRunHuntingQueryCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildSecureScoreControlProfilesCommand());
            command.AddCommand(builder.BuildSecureScoresCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of servicePrincipal entities.
        /// </summary>
        public Command BuildServicePrincipalsCommand() {
            var command = new Command("service-principals");
            command.Description = "Provides operations to manage the collection of servicePrincipal entities.";
            var builder = new ServicePrincipalsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDeltaCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGetAvailableExtensionPropertiesCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGetByIdsCommand());
            command.AddCommand(builder.BuildMicrosoftGraphValidatePropertiesCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of sharedDriveItem entities.
        /// </summary>
        public Command BuildSharesCommand() {
            var command = new Command("shares");
            command.Description = "Provides operations to manage the collection of sharedDriveItem entities.";
            var builder = new SharesRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of site entities.
        /// </summary>
        public Command BuildSitesCommand() {
            var command = new Command("sites");
            command.Description = "Provides operations to manage the collection of site entities.";
            var builder = new SitesRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphAddCommand());
            command.AddCommand(builder.BuildMicrosoftGraphRemoveCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the solutionsRoot singleton.
        /// </summary>
        public Command BuildSolutionsCommand() {
            var command = new Command("solutions");
            command.Description = "Provides operations to manage the solutionsRoot singleton.";
            var builder = new SolutionsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildBookingBusinessesCommand());
            command.AddCommand(builder.BuildBookingCurrenciesCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of subscribedSku entities.
        /// </summary>
        public Command BuildSubscribedSkusCommand() {
            var command = new Command("subscribed-skus");
            command.Description = "Provides operations to manage the collection of subscribedSku entities.";
            var builder = new SubscribedSkusRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of subscription entities.
        /// </summary>
        public Command BuildSubscriptionsCommand() {
            var command = new Command("subscriptions");
            command.Description = "Provides operations to manage the collection of subscription entities.";
            var builder = new SubscriptionsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of team entities.
        /// </summary>
        public Command BuildTeamsCommand() {
            var command = new Command("teams");
            command.Description = "Provides operations to manage the collection of team entities.";
            var builder = new TeamsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGetAllMessagesCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of teamsTemplate entities.
        /// </summary>
        public Command BuildTeamsTemplatesCommand() {
            var command = new Command("teams-templates");
            command.Description = "Provides operations to manage the collection of teamsTemplate entities.";
            var builder = new TeamsTemplatesRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the teamwork singleton.
        /// </summary>
        public Command BuildTeamworkCommand() {
            var command = new Command("teamwork");
            command.Description = "Provides operations to manage the teamwork singleton.";
            var builder = new TeamworkRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildMicrosoftGraphSendActivityNotificationToRecipientsCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildWorkforceIntegrationsCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the tenantRelationship singleton.
        /// </summary>
        public Command BuildTenantRelationshipsCommand() {
            var command = new Command("tenant-relationships");
            command.Description = "Provides operations to manage the tenantRelationship singleton.";
            var builder = new TenantRelationshipsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildDelegatedAdminCustomersCommand());
            command.AddCommand(builder.BuildDelegatedAdminRelationshipsCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of user entities.
        /// </summary>
        public Command BuildUsersCommand() {
            var command = new Command("users");
            command.Description = "Provides operations to manage the collection of user entities.";
            var builder = new UsersRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDeltaCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGetAvailableExtensionPropertiesCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGetByIdsCommand());
            command.AddCommand(builder.BuildMicrosoftGraphValidatePropertiesCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new GraphClient and sets the default values.
        /// </summary>
        public GraphClient() {
            PathParameters = new Dictionary<string, object>();
            UrlTemplate = "{+baseurl}";
        }
    }
}
