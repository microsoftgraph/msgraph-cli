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
using ApiSdk.Directory;
using ApiSdk.DirectoryObjects;
using ApiSdk.DirectoryRoles;
using ApiSdk.DirectoryRoleTemplates;
using ApiSdk.DomainDnsRecords;
using ApiSdk.Domains;
using ApiSdk.Drive;
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
using ApiSdk.Users;
using ApiSdk.Workbooks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Serialization.Json;
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace ApiSdk {
    /// <summary>The main entry point of the SDK, exposes the configuration and the fluent API.</summary>
    public class GraphClient {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public Command BuildAdminCommand() {
            var command = new Command("admin");
            var builder = new ApiSdk.Admin.AdminRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildServiceAnnouncementCommand());
            return command;
        }
        public Command BuildAgreementAcceptancesCommand() {
            var command = new Command("agreement-acceptances");
            var builder = new ApiSdk.AgreementAcceptances.AgreementAcceptancesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildAgreementsCommand() {
            var command = new Command("agreements");
            var builder = new ApiSdk.Agreements.AgreementsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildAppCatalogsCommand() {
            var command = new Command("app-catalogs");
            var builder = new ApiSdk.AppCatalogs.AppCatalogsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildTeamsAppsCommand());
            return command;
        }
        public Command BuildApplicationsCommand() {
            var command = new Command("applications");
            var builder = new ApiSdk.Applications.ApplicationsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildGetAvailableExtensionPropertiesCommand());
            command.AddCommand(builder.BuildGetByIdsCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildValidatePropertiesCommand());
            return command;
        }
        public Command BuildApplicationTemplatesCommand() {
            var command = new Command("application-templates");
            var builder = new ApiSdk.ApplicationTemplates.ApplicationTemplatesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildAuditLogsCommand() {
            var command = new Command("audit-logs");
            var builder = new ApiSdk.AuditLogs.AuditLogsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDirectoryAuditsCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildProvisioningCommand());
            command.AddCommand(builder.BuildRestrictedSignInsCommand());
            command.AddCommand(builder.BuildSignInsCommand());
            return command;
        }
        public Command BuildAuthenticationMethodConfigurationsCommand() {
            var command = new Command("authentication-method-configurations");
            var builder = new ApiSdk.AuthenticationMethodConfigurations.AuthenticationMethodConfigurationsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildAuthenticationMethodsPolicyCommand() {
            var command = new Command("authentication-methods-policy");
            var builder = new ApiSdk.AuthenticationMethodsPolicy.AuthenticationMethodsPolicyRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildAuthenticationMethodConfigurationsCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        public Command BuildBrandingCommand() {
            var command = new Command("branding");
            var builder = new ApiSdk.Branding.BrandingRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildLocalizationsCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        public Command BuildCertificateBasedAuthConfigurationCommand() {
            var command = new Command("certificate-based-auth-configuration");
            var builder = new ApiSdk.CertificateBasedAuthConfiguration.CertificateBasedAuthConfigurationRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildChatsCommand() {
            var command = new Command("chats");
            var builder = new ApiSdk.Chats.ChatsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildCommand() {
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
            command.AddCommand(BuildDriveCommand());
            command.AddCommand(BuildDrivesCommand());
            command.AddCommand(BuildEducationCommand());
            command.AddCommand(BuildExternalCommand());
            command.AddCommand(BuildGetCommand());
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
            command.AddCommand(BuildUsersCommand());
            command.AddCommand(BuildWorkbooksCommand());
            return command;
        }
        public Command BuildCommunicationsCommand() {
            var command = new Command("communications");
            var builder = new ApiSdk.Communications.CommunicationsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCallRecordsCommand());
            command.AddCommand(builder.BuildCallsCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildGetPresencesByUserIdCommand());
            command.AddCommand(builder.BuildOnlineMeetingsCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildPresencesCommand());
            return command;
        }
        public Command BuildComplianceCommand() {
            var command = new Command("compliance");
            var builder = new ApiSdk.Compliance.ComplianceRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        public Command BuildConnectionsCommand() {
            var command = new Command("connections");
            var builder = new ApiSdk.Connections.ConnectionsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildContactsCommand() {
            var command = new Command("contacts");
            var builder = new ApiSdk.Contacts.ContactsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildGetAvailableExtensionPropertiesCommand());
            command.AddCommand(builder.BuildGetByIdsCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildValidatePropertiesCommand());
            return command;
        }
        public Command BuildContractsCommand() {
            var command = new Command("contracts");
            var builder = new ApiSdk.Contracts.ContractsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildGetAvailableExtensionPropertiesCommand());
            command.AddCommand(builder.BuildGetByIdsCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildValidatePropertiesCommand());
            return command;
        }
        public Command BuildDataPolicyOperationsCommand() {
            var command = new Command("data-policy-operations");
            var builder = new ApiSdk.DataPolicyOperations.DataPolicyOperationsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildDeviceAppManagementCommand() {
            var command = new Command("device-app-management");
            var builder = new ApiSdk.DeviceAppManagement.DeviceAppManagementRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildAndroidManagedAppProtectionsCommand());
            command.AddCommand(builder.BuildDefaultManagedAppProtectionsCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildIosManagedAppProtectionsCommand());
            command.AddCommand(builder.BuildManagedAppPoliciesCommand());
            command.AddCommand(builder.BuildManagedAppRegistrationsCommand());
            command.AddCommand(builder.BuildManagedAppStatusesCommand());
            command.AddCommand(builder.BuildManagedEBooksCommand());
            command.AddCommand(builder.BuildMdmWindowsInformationProtectionPoliciesCommand());
            command.AddCommand(builder.BuildMobileAppCategoriesCommand());
            command.AddCommand(builder.BuildMobileAppConfigurationsCommand());
            command.AddCommand(builder.BuildMobileAppsCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildSyncMicrosoftStoreForBusinessAppsCommand());
            command.AddCommand(builder.BuildTargetedManagedAppConfigurationsCommand());
            command.AddCommand(builder.BuildVppTokensCommand());
            command.AddCommand(builder.BuildWindowsInformationProtectionPoliciesCommand());
            return command;
        }
        public Command BuildDeviceManagementCommand() {
            var command = new Command("device-management");
            var builder = new ApiSdk.DeviceManagement.DeviceManagementRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildApplePushNotificationCertificateCommand());
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
        public Command BuildDevicesCommand() {
            var command = new Command("devices");
            var builder = new ApiSdk.Devices.DevicesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildGetAvailableExtensionPropertiesCommand());
            command.AddCommand(builder.BuildGetByIdsCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildValidatePropertiesCommand());
            return command;
        }
        public Command BuildDirectoryCommand() {
            var command = new Command("directory");
            var builder = new ApiSdk.Directory.DirectoryRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildAdministrativeUnitsCommand());
            command.AddCommand(builder.BuildDeletedItemsCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        public Command BuildDirectoryObjectsCommand() {
            var command = new Command("directory-objects");
            var builder = new ApiSdk.DirectoryObjects.DirectoryObjectsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildGetAvailableExtensionPropertiesCommand());
            command.AddCommand(builder.BuildGetByIdsCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildValidatePropertiesCommand());
            return command;
        }
        public Command BuildDirectoryRolesCommand() {
            var command = new Command("directory-roles");
            var builder = new ApiSdk.DirectoryRoles.DirectoryRolesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildGetAvailableExtensionPropertiesCommand());
            command.AddCommand(builder.BuildGetByIdsCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildValidatePropertiesCommand());
            return command;
        }
        public Command BuildDirectoryRoleTemplatesCommand() {
            var command = new Command("directory-role-templates");
            var builder = new ApiSdk.DirectoryRoleTemplates.DirectoryRoleTemplatesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildGetAvailableExtensionPropertiesCommand());
            command.AddCommand(builder.BuildGetByIdsCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildValidatePropertiesCommand());
            return command;
        }
        public Command BuildDomainDnsRecordsCommand() {
            var command = new Command("domain-dns-records");
            var builder = new ApiSdk.DomainDnsRecords.DomainDnsRecordsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildDomainsCommand() {
            var command = new Command("domains");
            var builder = new ApiSdk.Domains.DomainsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildDriveCommand() {
            var command = new Command("drive");
            var builder = new ApiSdk.Drive.DriveRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildBundlesCommand());
            command.AddCommand(builder.BuildFollowingCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildItemsCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildRootCommand());
            command.AddCommand(builder.BuildSpecialCommand());
            return command;
        }
        public Command BuildDrivesCommand() {
            var command = new Command("drives");
            var builder = new ApiSdk.Drives.DrivesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildEducationCommand() {
            var command = new Command("education");
            var builder = new ApiSdk.Education.EducationRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildClassesCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildMeCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildSchoolsCommand());
            command.AddCommand(builder.BuildUsersCommand());
            return command;
        }
        public Command BuildExternalCommand() {
            var command = new Command("external");
            var builder = new ApiSdk.External.ExternalRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildConnectionsCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        public Command BuildGetCommand() {
            var command = new Command("get");
            // Create options for all the parameters
            command.Handler = CommandHandler.Create(async () => {
                var requestInfo = CreateGetRequestInformation(q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo);
                // Print request output. What if the request has no return?
                Console.WriteLine("Success");
            });
            return command;
        }
        public Command BuildGroupLifecyclePoliciesCommand() {
            var command = new Command("group-lifecycle-policies");
            var builder = new ApiSdk.GroupLifecyclePolicies.GroupLifecyclePoliciesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildGroupsCommand() {
            var command = new Command("groups");
            var builder = new ApiSdk.Groups.GroupsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildGetAvailableExtensionPropertiesCommand());
            command.AddCommand(builder.BuildGetByIdsCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildValidatePropertiesCommand());
            return command;
        }
        public Command BuildGroupSettingsCommand() {
            var command = new Command("group-settings");
            var builder = new ApiSdk.GroupSettings.GroupSettingsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildGroupSettingTemplatesCommand() {
            var command = new Command("group-setting-templates");
            var builder = new ApiSdk.GroupSettingTemplates.GroupSettingTemplatesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildGetAvailableExtensionPropertiesCommand());
            command.AddCommand(builder.BuildGetByIdsCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildValidatePropertiesCommand());
            return command;
        }
        public Command BuildIdentityCommand() {
            var command = new Command("identity");
            var builder = new ApiSdk.Identity.IdentityRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildApiConnectorsCommand());
            command.AddCommand(builder.BuildB2xUserFlowsCommand());
            command.AddCommand(builder.BuildConditionalAccessCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildIdentityProvidersCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildUserFlowAttributesCommand());
            return command;
        }
        public Command BuildIdentityGovernanceCommand() {
            var command = new Command("identity-governance");
            var builder = new ApiSdk.IdentityGovernance.IdentityGovernanceRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildAccessReviewsCommand());
            command.AddCommand(builder.BuildAppConsentCommand());
            command.AddCommand(builder.BuildEntitlementManagementCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildTermsOfUseCommand());
            return command;
        }
        public Command BuildIdentityProtectionCommand() {
            var command = new Command("identity-protection");
            var builder = new ApiSdk.IdentityProtection.IdentityProtectionRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildRiskDetectionsCommand());
            command.AddCommand(builder.BuildRiskyUsersCommand());
            return command;
        }
        public Command BuildIdentityProvidersCommand() {
            var command = new Command("identity-providers");
            var builder = new ApiSdk.IdentityProviders.IdentityProvidersRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildInformationProtectionCommand() {
            var command = new Command("information-protection");
            var builder = new ApiSdk.InformationProtection.InformationProtectionRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildBitlockerCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildThreatAssessmentRequestsCommand());
            return command;
        }
        public Command BuildInvitationsCommand() {
            var command = new Command("invitations");
            var builder = new ApiSdk.Invitations.InvitationsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildLocalizationsCommand() {
            var command = new Command("localizations");
            var builder = new ApiSdk.Localizations.LocalizationsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildMeCommand() {
            var command = new Command("me");
            var builder = new ApiSdk.Me.MeRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildActivitiesCommand());
            command.AddCommand(builder.BuildAgreementAcceptancesCommand());
            command.AddCommand(builder.BuildAppRoleAssignmentsCommand());
            command.AddCommand(builder.BuildAssignLicenseCommand());
            command.AddCommand(builder.BuildAuthenticationCommand());
            command.AddCommand(builder.BuildCalendarCommand());
            command.AddCommand(builder.BuildCalendarGroupsCommand());
            command.AddCommand(builder.BuildCalendarsCommand());
            command.AddCommand(builder.BuildCalendarViewCommand());
            command.AddCommand(builder.BuildChangePasswordCommand());
            command.AddCommand(builder.BuildChatsCommand());
            command.AddCommand(builder.BuildCheckMemberGroupsCommand());
            command.AddCommand(builder.BuildCheckMemberObjectsCommand());
            command.AddCommand(builder.BuildContactFoldersCommand());
            command.AddCommand(builder.BuildContactsCommand());
            command.AddCommand(builder.BuildCreatedObjectsCommand());
            command.AddCommand(builder.BuildDeviceManagementTroubleshootingEventsCommand());
            command.AddCommand(builder.BuildDirectReportsCommand());
            command.AddCommand(builder.BuildDriveCommand());
            command.AddCommand(builder.BuildDrivesCommand());
            command.AddCommand(builder.BuildEventsCommand());
            command.AddCommand(builder.BuildExportPersonalDataCommand());
            command.AddCommand(builder.BuildExtensionsCommand());
            command.AddCommand(builder.BuildFindMeetingTimesCommand());
            command.AddCommand(builder.BuildFollowedSitesCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildGetMailTipsCommand());
            command.AddCommand(builder.BuildGetMemberGroupsCommand());
            command.AddCommand(builder.BuildGetMemberObjectsCommand());
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
            command.AddCommand(builder.BuildRemoveAllDevicesFromManagementCommand());
            command.AddCommand(builder.BuildReprocessLicenseAssignmentCommand());
            command.AddCommand(builder.BuildRestoreCommand());
            command.AddCommand(builder.BuildRevokeSignInSessionsCommand());
            command.AddCommand(builder.BuildScopedRoleMemberOfCommand());
            command.AddCommand(builder.BuildSendMailCommand());
            command.AddCommand(builder.BuildSettingsCommand());
            command.AddCommand(builder.BuildTeamworkCommand());
            command.AddCommand(builder.BuildTodoCommand());
            command.AddCommand(builder.BuildTransitiveMemberOfCommand());
            command.AddCommand(builder.BuildTranslateExchangeIdsCommand());
            command.AddCommand(builder.BuildWipeManagedAppRegistrationsByDeviceTagCommand());
            return command;
        }
        public Command BuildOauth2PermissionGrantsCommand() {
            var command = new Command("oauth2-permission-grants");
            var builder = new ApiSdk.Oauth2PermissionGrants.Oauth2PermissionGrantsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildOrganizationCommand() {
            var command = new Command("organization");
            var builder = new ApiSdk.Organization.OrganizationRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildGetAvailableExtensionPropertiesCommand());
            command.AddCommand(builder.BuildGetByIdsCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildValidatePropertiesCommand());
            return command;
        }
        public Command BuildPermissionGrantsCommand() {
            var command = new Command("permission-grants");
            var builder = new ApiSdk.PermissionGrants.PermissionGrantsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildGetAvailableExtensionPropertiesCommand());
            command.AddCommand(builder.BuildGetByIdsCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildValidatePropertiesCommand());
            return command;
        }
        public Command BuildPlacesCommand() {
            var command = new Command("places");
            var builder = new ApiSdk.Places.PlacesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildPlannerCommand() {
            var command = new Command("planner");
            var builder = new ApiSdk.Planner.PlannerRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildBucketsCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildPlansCommand());
            command.AddCommand(builder.BuildTasksCommand());
            return command;
        }
        public Command BuildPoliciesCommand() {
            var command = new Command("policies");
            var builder = new ApiSdk.Policies.PoliciesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildActivityBasedTimeoutPoliciesCommand());
            command.AddCommand(builder.BuildAdminConsentRequestPolicyCommand());
            command.AddCommand(builder.BuildAuthenticationFlowsPolicyCommand());
            command.AddCommand(builder.BuildAuthenticationMethodsPolicyCommand());
            command.AddCommand(builder.BuildAuthorizationPolicyCommand());
            command.AddCommand(builder.BuildClaimsMappingPoliciesCommand());
            command.AddCommand(builder.BuildConditionalAccessPoliciesCommand());
            command.AddCommand(builder.BuildFeatureRolloutPoliciesCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildHomeRealmDiscoveryPoliciesCommand());
            command.AddCommand(builder.BuildIdentitySecurityDefaultsEnforcementPolicyCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildPermissionGrantPoliciesCommand());
            command.AddCommand(builder.BuildTokenIssuancePoliciesCommand());
            command.AddCommand(builder.BuildTokenLifetimePoliciesCommand());
            return command;
        }
        public Command BuildPrintCommand() {
            var command = new Command("print");
            var builder = new ApiSdk.Print.PrintRequestBuilder(PathParameters, RequestAdapter);
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
        public Command BuildPrivacyCommand() {
            var command = new Command("privacy");
            var builder = new ApiSdk.Privacy.PrivacyRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildSubjectRightsRequestsCommand());
            return command;
        }
        public Command BuildReportsCommand() {
            var command = new Command("reports");
            var builder = new ApiSdk.Reports.ReportsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDailyPrintUsageByPrinterCommand());
            command.AddCommand(builder.BuildDailyPrintUsageByUserCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildMonthlyPrintUsageByPrinterCommand());
            command.AddCommand(builder.BuildMonthlyPrintUsageByUserCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        public Command BuildRoleManagementCommand() {
            var command = new Command("role-management");
            var builder = new ApiSdk.RoleManagement.RoleManagementRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDirectoryCommand());
            command.AddCommand(builder.BuildEntitlementManagementCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        public Command BuildSchemaExtensionsCommand() {
            var command = new Command("schema-extensions");
            var builder = new ApiSdk.SchemaExtensions.SchemaExtensionsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildScopedRoleMembershipsCommand() {
            var command = new Command("scoped-role-memberships");
            var builder = new ApiSdk.ScopedRoleMemberships.ScopedRoleMembershipsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildSearchCommand() {
            var command = new Command("search");
            var builder = new ApiSdk.Search.SearchRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildQueryCommand());
            return command;
        }
        public Command BuildSecurityCommand() {
            var command = new Command("security");
            var builder = new ApiSdk.Security.SecurityRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildAlertsCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildSecureScoreControlProfilesCommand());
            command.AddCommand(builder.BuildSecureScoresCommand());
            return command;
        }
        public Command BuildServicePrincipalsCommand() {
            var command = new Command("service-principals");
            var builder = new ApiSdk.ServicePrincipals.ServicePrincipalsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildGetAvailableExtensionPropertiesCommand());
            command.AddCommand(builder.BuildGetByIdsCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildValidatePropertiesCommand());
            return command;
        }
        public Command BuildSharesCommand() {
            var command = new Command("shares");
            var builder = new ApiSdk.Shares.SharesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildSitesCommand() {
            var command = new Command("sites");
            var builder = new ApiSdk.Sites.SitesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildAddCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildRemoveCommand());
            return command;
        }
        public Command BuildSolutionsCommand() {
            var command = new Command("solutions");
            var builder = new ApiSdk.Solutions.SolutionsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildBookingBusinessesCommand());
            command.AddCommand(builder.BuildBookingCurrenciesCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        public Command BuildSubscribedSkusCommand() {
            var command = new Command("subscribed-skus");
            var builder = new ApiSdk.SubscribedSkus.SubscribedSkusRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildSubscriptionsCommand() {
            var command = new Command("subscriptions");
            var builder = new ApiSdk.Subscriptions.SubscriptionsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildTeamsCommand() {
            var command = new Command("teams");
            var builder = new ApiSdk.Teams.TeamsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildTeamsTemplatesCommand() {
            var command = new Command("teams-templates");
            var builder = new ApiSdk.TeamsTemplates.TeamsTemplatesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildTeamworkCommand() {
            var command = new Command("teamwork");
            var builder = new ApiSdk.Teamwork.TeamworkRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildWorkforceIntegrationsCommand());
            return command;
        }
        public Command BuildUsersCommand() {
            var command = new Command("users");
            var builder = new ApiSdk.Users.UsersRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildGetAvailableExtensionPropertiesCommand());
            command.AddCommand(builder.BuildGetByIdsCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildValidatePropertiesCommand());
            return command;
        }
        public Command BuildWorkbooksCommand() {
            var command = new Command("workbooks");
            var builder = new ApiSdk.Workbooks.WorkbooksRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new GraphClient and sets the default values.
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public GraphClient(IRequestAdapter requestAdapter) {
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            PathParameters = new Dictionary<string, object>();
            UrlTemplate = "{+baseurl}";
            RequestAdapter = requestAdapter;
            ApiClientBuilder.RegisterDefaultSerializer<JsonSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<JsonParseNodeFactory>();
            RequestAdapter.BaseUrl = "https://graph.microsoft.com/v1.0";
        }
        public RequestInformation CreateGetRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        public async Task GetAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, cancellationToken);
        }
    }
}
