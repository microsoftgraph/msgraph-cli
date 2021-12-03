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
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildCreateCommand());
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            return command;
        }
        public Command BuildAgreementsCommand() {
            var command = new Command("agreements");
            var builder = new ApiSdk.Agreements.AgreementsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildCreateCommand());
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
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
            command.AddCommand(builder.BuildGetByIdsCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildGetAvailableExtensionPropertiesCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildValidatePropertiesCommand());
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            return command;
        }
        public Command BuildApplicationTemplatesCommand() {
            var command = new Command("application-templates");
            var builder = new ApiSdk.ApplicationTemplates.ApplicationTemplatesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildCreateCommand());
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            return command;
        }
        public Command BuildAuditLogsCommand() {
            var command = new Command("audit-logs");
            var builder = new ApiSdk.AuditLogs.AuditLogsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildProvisioningCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildSignInsCommand());
            command.AddCommand(builder.BuildDirectoryAuditsCommand());
            command.AddCommand(builder.BuildRestrictedSignInsCommand());
            return command;
        }
        public Command BuildAuthenticationMethodConfigurationsCommand() {
            var command = new Command("authentication-method-configurations");
            var builder = new ApiSdk.AuthenticationMethodConfigurations.AuthenticationMethodConfigurationsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildCreateCommand());
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            return command;
        }
        public Command BuildAuthenticationMethodsPolicyCommand() {
            var command = new Command("authentication-methods-policy");
            var builder = new ApiSdk.AuthenticationMethodsPolicy.AuthenticationMethodsPolicyRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildAuthenticationMethodConfigurationsCommand());
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
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildCreateCommand());
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            return command;
        }
        public Command BuildChatsCommand() {
            var command = new Command("chats");
            var builder = new ApiSdk.Chats.ChatsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildCreateCommand());
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            return command;
        }
        public Command BuildCommand() {
            var command = new RootCommand();
            command.AddCommand(BuildScopedRoleMembershipsCommand());
            command.AddCommand(BuildPrintCommand());
            command.AddCommand(BuildGetCommand());
            command.AddCommand(BuildOrganizationCommand());
            command.AddCommand(BuildOauth2PermissionGrantsCommand());
            command.AddCommand(BuildDomainDnsRecordsCommand());
            command.AddCommand(BuildSitesCommand());
            command.AddCommand(BuildRoleManagementCommand());
            command.AddCommand(BuildAuditLogsCommand());
            command.AddCommand(BuildSearchCommand());
            command.AddCommand(BuildDirectoryObjectsCommand());
            command.AddCommand(BuildExternalCommand());
            command.AddCommand(BuildApplicationTemplatesCommand());
            command.AddCommand(BuildSubscribedSkusCommand());
            command.AddCommand(BuildPrivacyCommand());
            command.AddCommand(BuildGroupSettingsCommand());
            command.AddCommand(BuildInvitationsCommand());
            command.AddCommand(BuildChatsCommand());
            command.AddCommand(BuildTeamsTemplatesCommand());
            command.AddCommand(BuildContractsCommand());
            command.AddCommand(BuildIdentityProvidersCommand());
            command.AddCommand(BuildSchemaExtensionsCommand());
            command.AddCommand(BuildDomainsCommand());
            command.AddCommand(BuildDataPolicyOperationsCommand());
            command.AddCommand(BuildAuthenticationMethodsPolicyCommand());
            command.AddCommand(BuildLocalizationsCommand());
            command.AddCommand(BuildDirectoryRolesCommand());
            command.AddCommand(BuildApplicationsCommand());
            command.AddCommand(BuildAgreementsCommand());
            command.AddCommand(BuildDirectoryRoleTemplatesCommand());
            command.AddCommand(BuildServicePrincipalsCommand());
            command.AddCommand(BuildMeCommand());
            command.AddCommand(BuildDeviceManagementCommand());
            command.AddCommand(BuildReportsCommand());
            command.AddCommand(BuildDeviceAppManagementCommand());
            command.AddCommand(BuildWorkbooksCommand());
            command.AddCommand(BuildAuthenticationMethodConfigurationsCommand());
            command.AddCommand(BuildCommunicationsCommand());
            command.AddCommand(BuildAgreementAcceptancesCommand());
            command.AddCommand(BuildPoliciesCommand());
            command.AddCommand(BuildAppCatalogsCommand());
            command.AddCommand(BuildBrandingCommand());
            command.AddCommand(BuildInformationProtectionCommand());
            command.AddCommand(BuildPermissionGrantsCommand());
            command.AddCommand(BuildDirectoryCommand());
            command.AddCommand(BuildEducationCommand());
            command.AddCommand(BuildDrivesCommand());
            command.AddCommand(BuildUsersCommand());
            command.AddCommand(BuildSharesCommand());
            command.AddCommand(BuildGroupsCommand());
            command.AddCommand(BuildGroupSettingTemplatesCommand());
            command.AddCommand(BuildTeamworkCommand());
            command.AddCommand(BuildPlacesCommand());
            command.AddCommand(BuildContactsCommand());
            command.AddCommand(BuildDriveCommand());
            command.AddCommand(BuildAdminCommand());
            command.AddCommand(BuildIdentityGovernanceCommand());
            command.AddCommand(BuildCertificateBasedAuthConfigurationCommand());
            command.AddCommand(BuildGroupLifecyclePoliciesCommand());
            command.AddCommand(BuildSubscriptionsCommand());
            command.AddCommand(BuildTeamsCommand());
            command.AddCommand(BuildComplianceCommand());
            command.AddCommand(BuildSecurityCommand());
            command.AddCommand(BuildIdentityCommand());
            command.AddCommand(BuildPlannerCommand());
            command.AddCommand(BuildDevicesCommand());
            command.AddCommand(BuildConnectionsCommand());
            return command;
        }
        public Command BuildCommunicationsCommand() {
            var command = new Command("communications");
            var builder = new ApiSdk.Communications.CommunicationsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetPresencesByUserIdCommand());
            command.AddCommand(builder.BuildOnlineMeetingsCommand());
            command.AddCommand(builder.BuildCallsCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildPresencesCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildCallRecordsCommand());
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
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildCreateCommand());
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            return command;
        }
        public Command BuildContactsCommand() {
            var command = new Command("contacts");
            var builder = new ApiSdk.Contacts.ContactsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildGetAvailableExtensionPropertiesCommand());
            command.AddCommand(builder.BuildValidatePropertiesCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildGetByIdsCommand());
            return command;
        }
        public Command BuildContractsCommand() {
            var command = new Command("contracts");
            var builder = new ApiSdk.Contracts.ContractsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetByIdsCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildGetAvailableExtensionPropertiesCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildValidatePropertiesCommand());
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            return command;
        }
        public Command BuildDataPolicyOperationsCommand() {
            var command = new Command("data-policy-operations");
            var builder = new ApiSdk.DataPolicyOperations.DataPolicyOperationsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildCreateCommand());
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            return command;
        }
        public Command BuildDeviceAppManagementCommand() {
            var command = new Command("device-app-management");
            var builder = new ApiSdk.DeviceAppManagement.DeviceAppManagementRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDefaultManagedAppProtectionsCommand());
            command.AddCommand(builder.BuildMobileAppsCommand());
            command.AddCommand(builder.BuildVppTokensCommand());
            command.AddCommand(builder.BuildMobileAppCategoriesCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildMdmWindowsInformationProtectionPoliciesCommand());
            command.AddCommand(builder.BuildIosManagedAppProtectionsCommand());
            command.AddCommand(builder.BuildManagedEBooksCommand());
            command.AddCommand(builder.BuildSyncMicrosoftStoreForBusinessAppsCommand());
            command.AddCommand(builder.BuildWindowsInformationProtectionPoliciesCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildTargetedManagedAppConfigurationsCommand());
            command.AddCommand(builder.BuildManagedAppRegistrationsCommand());
            command.AddCommand(builder.BuildMobileAppConfigurationsCommand());
            command.AddCommand(builder.BuildAndroidManagedAppProtectionsCommand());
            command.AddCommand(builder.BuildManagedAppPoliciesCommand());
            command.AddCommand(builder.BuildManagedAppStatusesCommand());
            return command;
        }
        public Command BuildDeviceManagementCommand() {
            var command = new Command("device-management");
            var builder = new ApiSdk.DeviceManagement.DeviceManagementRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildWindowsInformationProtectionAppLearningSummariesCommand());
            command.AddCommand(builder.BuildRemoteAssistancePartnersCommand());
            command.AddCommand(builder.BuildApplePushNotificationCertificateCommand());
            command.AddCommand(builder.BuildWindowsInformationProtectionNetworkLearningSummariesCommand());
            command.AddCommand(builder.BuildDeviceCompliancePolicyDeviceStateSummaryCommand());
            command.AddCommand(builder.BuildIosUpdateStatusesCommand());
            command.AddCommand(builder.BuildManagedDevicesCommand());
            command.AddCommand(builder.BuildDeviceEnrollmentConfigurationsCommand());
            command.AddCommand(builder.BuildWindowsAutopilotDeviceIdentitiesCommand());
            command.AddCommand(builder.BuildDeviceCompliancePolicySettingStateSummariesCommand());
            command.AddCommand(builder.BuildTelecomExpenseManagementPartnersCommand());
            command.AddCommand(builder.BuildDeviceCategoriesCommand());
            command.AddCommand(builder.BuildNotificationMessageTemplatesCommand());
            command.AddCommand(builder.BuildTermsAndConditionsCommand());
            command.AddCommand(builder.BuildManagedDeviceOverviewCommand());
            command.AddCommand(builder.BuildDeviceManagementPartnersCommand());
            command.AddCommand(builder.BuildMobileThreatDefenseConnectorsCommand());
            command.AddCommand(builder.BuildDeviceConfigurationDeviceStateSummariesCommand());
            command.AddCommand(builder.BuildExchangeConnectorsCommand());
            command.AddCommand(builder.BuildRoleAssignmentsCommand());
            command.AddCommand(builder.BuildRoleDefinitionsCommand());
            command.AddCommand(builder.BuildSoftwareUpdateStatusSummaryCommand());
            command.AddCommand(builder.BuildComplianceManagementPartnersCommand());
            command.AddCommand(builder.BuildDeviceConfigurationsCommand());
            command.AddCommand(builder.BuildConditionalAccessSettingsCommand());
            command.AddCommand(builder.BuildTroubleshootingEventsCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildDetectedAppsCommand());
            command.AddCommand(builder.BuildReportsCommand());
            command.AddCommand(builder.BuildDeviceCompliancePoliciesCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildImportedWindowsAutopilotDeviceIdentitiesCommand());
            command.AddCommand(builder.BuildResourceOperationsCommand());
            return command;
        }
        public Command BuildDevicesCommand() {
            var command = new Command("devices");
            var builder = new ApiSdk.Devices.DevicesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetByIdsCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildGetAvailableExtensionPropertiesCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildValidatePropertiesCommand());
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            return command;
        }
        public Command BuildDirectoryCommand() {
            var command = new Command("directory");
            var builder = new ApiSdk.Directory.DirectoryRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildAdministrativeUnitsCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildDeletedItemsCommand());
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        public Command BuildDirectoryObjectsCommand() {
            var command = new Command("directory-objects");
            var builder = new ApiSdk.DirectoryObjects.DirectoryObjectsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetByIdsCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildGetAvailableExtensionPropertiesCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildValidatePropertiesCommand());
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            return command;
        }
        public Command BuildDirectoryRolesCommand() {
            var command = new Command("directory-roles");
            var builder = new ApiSdk.DirectoryRoles.DirectoryRolesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetByIdsCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildGetAvailableExtensionPropertiesCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildValidatePropertiesCommand());
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            return command;
        }
        public Command BuildDirectoryRoleTemplatesCommand() {
            var command = new Command("directory-role-templates");
            var builder = new ApiSdk.DirectoryRoleTemplates.DirectoryRoleTemplatesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetByIdsCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildGetAvailableExtensionPropertiesCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildValidatePropertiesCommand());
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            return command;
        }
        public Command BuildDomainDnsRecordsCommand() {
            var command = new Command("domain-dns-records");
            var builder = new ApiSdk.DomainDnsRecords.DomainDnsRecordsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildCreateCommand());
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            return command;
        }
        public Command BuildDomainsCommand() {
            var command = new Command("domains");
            var builder = new ApiSdk.Domains.DomainsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildCreateCommand());
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            return command;
        }
        public Command BuildDriveCommand() {
            var command = new Command("drive");
            var builder = new ApiSdk.Drive.DriveRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildSpecialCommand());
            command.AddCommand(builder.BuildBundlesCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildFollowingCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRootCommand());
            command.AddCommand(builder.BuildItemsCommand());
            return command;
        }
        public Command BuildDrivesCommand() {
            var command = new Command("drives");
            var builder = new ApiSdk.Drives.DrivesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildCreateCommand());
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            return command;
        }
        public Command BuildEducationCommand() {
            var command = new Command("education");
            var builder = new ApiSdk.Education.EducationRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildClassesCommand());
            command.AddCommand(builder.BuildMeCommand());
            command.AddCommand(builder.BuildUsersCommand());
            command.AddCommand(builder.BuildSchoolsCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        public Command BuildExternalCommand() {
            var command = new Command("external");
            var builder = new ApiSdk.External.ExternalRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildConnectionsCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        public Command BuildGetCommand() {
            var command = new Command("get");
            // Create options for all the parameters
            command.Handler = CommandHandler.Create(async () => {
                var requestInfo = CreateGetRequestInformation();
                await RequestAdapter.SendNoContentAsync(requestInfo);
                // Print request output. What if the request has no return?
                Console.WriteLine("Success");
            });
            return command;
        }
        public Command BuildGroupLifecyclePoliciesCommand() {
            var command = new Command("group-lifecycle-policies");
            var builder = new ApiSdk.GroupLifecyclePolicies.GroupLifecyclePoliciesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildCreateCommand());
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            return command;
        }
        public Command BuildGroupsCommand() {
            var command = new Command("groups");
            var builder = new ApiSdk.Groups.GroupsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetByIdsCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildGetAvailableExtensionPropertiesCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildValidatePropertiesCommand());
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            return command;
        }
        public Command BuildGroupSettingsCommand() {
            var command = new Command("group-settings");
            var builder = new ApiSdk.GroupSettings.GroupSettingsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildCreateCommand());
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            return command;
        }
        public Command BuildGroupSettingTemplatesCommand() {
            var command = new Command("group-setting-templates");
            var builder = new ApiSdk.GroupSettingTemplates.GroupSettingTemplatesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetByIdsCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildGetAvailableExtensionPropertiesCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildValidatePropertiesCommand());
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            return command;
        }
        public Command BuildIdentityCommand() {
            var command = new Command("identity");
            var builder = new ApiSdk.Identity.IdentityRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildConditionalAccessCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildApiConnectorsCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildIdentityProvidersCommand());
            command.AddCommand(builder.BuildB2xUserFlowsCommand());
            command.AddCommand(builder.BuildUserFlowAttributesCommand());
            return command;
        }
        public Command BuildIdentityGovernanceCommand() {
            var command = new Command("identity-governance");
            var builder = new ApiSdk.IdentityGovernance.IdentityGovernanceRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildAppConsentCommand());
            command.AddCommand(builder.BuildAccessReviewsCommand());
            command.AddCommand(builder.BuildEntitlementManagementCommand());
            command.AddCommand(builder.BuildTermsOfUseCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        public Command BuildIdentityProvidersCommand() {
            var command = new Command("identity-providers");
            var builder = new ApiSdk.IdentityProviders.IdentityProvidersRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildCreateCommand());
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            return command;
        }
        public Command BuildInformationProtectionCommand() {
            var command = new Command("information-protection");
            var builder = new ApiSdk.InformationProtection.InformationProtectionRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildBitlockerCommand());
            command.AddCommand(builder.BuildThreatAssessmentRequestsCommand());
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        public Command BuildInvitationsCommand() {
            var command = new Command("invitations");
            var builder = new ApiSdk.Invitations.InvitationsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildCreateCommand());
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            return command;
        }
        public Command BuildLocalizationsCommand() {
            var command = new Command("localizations");
            var builder = new ApiSdk.Localizations.LocalizationsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildCreateCommand());
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            return command;
        }
        public Command BuildMeCommand() {
            var command = new Command("me");
            var builder = new ApiSdk.Me.MeRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPresenceCommand());
            command.AddCommand(builder.BuildDeviceManagementTroubleshootingEventsCommand());
            command.AddCommand(builder.BuildExportPersonalDataCommand());
            command.AddCommand(builder.BuildCheckMemberGroupsCommand());
            command.AddCommand(builder.BuildLicenseDetailsCommand());
            command.AddCommand(builder.BuildDrivesCommand());
            command.AddCommand(builder.BuildTransitiveMemberOfCommand());
            command.AddCommand(builder.BuildGetMemberGroupsCommand());
            command.AddCommand(builder.BuildEventsCommand());
            command.AddCommand(builder.BuildRemoveAllDevicesFromManagementCommand());
            command.AddCommand(builder.BuildTranslateExchangeIdsCommand());
            command.AddCommand(builder.BuildScopedRoleMemberOfCommand());
            command.AddCommand(builder.BuildFindMeetingTimesCommand());
            command.AddCommand(builder.BuildTeamworkCommand());
            command.AddCommand(builder.BuildPhotosCommand());
            command.AddCommand(builder.BuildOnenoteCommand());
            command.AddCommand(builder.BuildGetMemberObjectsCommand());
            command.AddCommand(builder.BuildOutlookCommand());
            command.AddCommand(builder.BuildAssignLicenseCommand());
            command.AddCommand(builder.BuildJoinedTeamsCommand());
            command.AddCommand(builder.BuildActivitiesCommand());
            command.AddCommand(builder.BuildManagedDevicesCommand());
            command.AddCommand(builder.BuildDriveCommand());
            command.AddCommand(builder.BuildRestoreCommand());
            command.AddCommand(builder.BuildInferenceClassificationCommand());
            command.AddCommand(builder.BuildFollowedSitesCommand());
            command.AddCommand(builder.BuildInsightsCommand());
            command.AddCommand(builder.BuildCalendarGroupsCommand());
            command.AddCommand(builder.BuildPhotoCommand());
            command.AddCommand(builder.BuildRegisteredDevicesCommand());
            command.AddCommand(builder.BuildSendMailCommand());
            command.AddCommand(builder.BuildCalendarViewCommand());
            command.AddCommand(builder.BuildCalendarCommand());
            command.AddCommand(builder.BuildWipeManagedAppRegistrationsByDeviceTagCommand());
            command.AddCommand(builder.BuildPlannerCommand());
            command.AddCommand(builder.BuildOwnedObjectsCommand());
            command.AddCommand(builder.BuildCheckMemberObjectsCommand());
            command.AddCommand(builder.BuildContactFoldersCommand());
            command.AddCommand(builder.BuildDirectReportsCommand());
            command.AddCommand(builder.BuildOnlineMeetingsCommand());
            command.AddCommand(builder.BuildContactsCommand());
            command.AddCommand(builder.BuildRevokeSignInSessionsCommand());
            command.AddCommand(builder.BuildMessagesCommand());
            command.AddCommand(builder.BuildAgreementAcceptancesCommand());
            command.AddCommand(builder.BuildPeopleCommand());
            command.AddCommand(builder.BuildMemberOfCommand());
            command.AddCommand(builder.BuildSettingsCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildCreatedObjectsCommand());
            command.AddCommand(builder.BuildAuthenticationCommand());
            command.AddCommand(builder.BuildGetMailTipsCommand());
            command.AddCommand(builder.BuildCalendarsCommand());
            command.AddCommand(builder.BuildChatsCommand());
            command.AddCommand(builder.BuildMailFoldersCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildAppRoleAssignmentsCommand());
            command.AddCommand(builder.BuildReprocessLicenseAssignmentCommand());
            command.AddCommand(builder.BuildManagerCommand());
            command.AddCommand(builder.BuildExtensionsCommand());
            command.AddCommand(builder.BuildOauth2PermissionGrantsCommand());
            command.AddCommand(builder.BuildTodoCommand());
            command.AddCommand(builder.BuildOwnedDevicesCommand());
            command.AddCommand(builder.BuildManagedAppRegistrationsCommand());
            command.AddCommand(builder.BuildChangePasswordCommand());
            return command;
        }
        public Command BuildOauth2PermissionGrantsCommand() {
            var command = new Command("oauth2-permission-grants");
            var builder = new ApiSdk.Oauth2PermissionGrants.Oauth2PermissionGrantsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildCreateCommand());
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            return command;
        }
        public Command BuildOrganizationCommand() {
            var command = new Command("organization");
            var builder = new ApiSdk.Organization.OrganizationRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetByIdsCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildGetAvailableExtensionPropertiesCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildValidatePropertiesCommand());
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            return command;
        }
        public Command BuildPermissionGrantsCommand() {
            var command = new Command("permission-grants");
            var builder = new ApiSdk.PermissionGrants.PermissionGrantsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetByIdsCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildGetAvailableExtensionPropertiesCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildValidatePropertiesCommand());
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            return command;
        }
        public Command BuildPlacesCommand() {
            var command = new Command("places");
            var builder = new ApiSdk.Places.PlacesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildCreateCommand());
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            return command;
        }
        public Command BuildPlannerCommand() {
            var command = new Command("planner");
            var builder = new ApiSdk.Planner.PlannerRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildBucketsCommand());
            command.AddCommand(builder.BuildTasksCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildPlansCommand());
            return command;
        }
        public Command BuildPoliciesCommand() {
            var command = new Command("policies");
            var builder = new ApiSdk.Policies.PoliciesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildFeatureRolloutPoliciesCommand());
            command.AddCommand(builder.BuildConditionalAccessPoliciesCommand());
            command.AddCommand(builder.BuildAdminConsentRequestPolicyCommand());
            command.AddCommand(builder.BuildAuthorizationPolicyCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildAuthenticationMethodsPolicyCommand());
            command.AddCommand(builder.BuildIdentitySecurityDefaultsEnforcementPolicyCommand());
            command.AddCommand(builder.BuildAuthenticationFlowsPolicyCommand());
            command.AddCommand(builder.BuildActivityBasedTimeoutPoliciesCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildTokenLifetimePoliciesCommand());
            command.AddCommand(builder.BuildPermissionGrantPoliciesCommand());
            command.AddCommand(builder.BuildHomeRealmDiscoveryPoliciesCommand());
            command.AddCommand(builder.BuildTokenIssuancePoliciesCommand());
            command.AddCommand(builder.BuildClaimsMappingPoliciesCommand());
            return command;
        }
        public Command BuildPrintCommand() {
            var command = new Command("print");
            var builder = new ApiSdk.Print.PrintRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildServicesCommand());
            command.AddCommand(builder.BuildTaskDefinitionsCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildOperationsCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildSharesCommand());
            command.AddCommand(builder.BuildConnectorsCommand());
            command.AddCommand(builder.BuildPrintersCommand());
            return command;
        }
        public Command BuildPrivacyCommand() {
            var command = new Command("privacy");
            var builder = new ApiSdk.Privacy.PrivacyRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildSubjectRightsRequestsCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        public Command BuildReportsCommand() {
            var command = new Command("reports");
            var builder = new ApiSdk.Reports.ReportsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDailyPrintUsageByUserCommand());
            command.AddCommand(builder.BuildDailyPrintUsageByPrinterCommand());
            command.AddCommand(builder.BuildMonthlyPrintUsageByUserCommand());
            command.AddCommand(builder.BuildMonthlyPrintUsageByPrinterCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        public Command BuildRoleManagementCommand() {
            var command = new Command("role-management");
            var builder = new ApiSdk.RoleManagement.RoleManagementRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildEntitlementManagementCommand());
            command.AddCommand(builder.BuildDirectoryCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        public Command BuildSchemaExtensionsCommand() {
            var command = new Command("schema-extensions");
            var builder = new ApiSdk.SchemaExtensions.SchemaExtensionsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildCreateCommand());
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            return command;
        }
        public Command BuildScopedRoleMembershipsCommand() {
            var command = new Command("scoped-role-memberships");
            var builder = new ApiSdk.ScopedRoleMemberships.ScopedRoleMembershipsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildCreateCommand());
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            return command;
        }
        public Command BuildSearchCommand() {
            var command = new Command("search");
            var builder = new ApiSdk.Search.SearchRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildQueryCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        public Command BuildSecurityCommand() {
            var command = new Command("security");
            var builder = new ApiSdk.Security.SecurityRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildSecureScoresCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildAlertsCommand());
            command.AddCommand(builder.BuildSecureScoreControlProfilesCommand());
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        public Command BuildServicePrincipalsCommand() {
            var command = new Command("service-principals");
            var builder = new ApiSdk.ServicePrincipals.ServicePrincipalsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildGetAvailableExtensionPropertiesCommand());
            command.AddCommand(builder.BuildValidatePropertiesCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildGetByIdsCommand());
            return command;
        }
        public Command BuildSharesCommand() {
            var command = new Command("shares");
            var builder = new ApiSdk.Shares.SharesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildCreateCommand());
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            return command;
        }
        public Command BuildSitesCommand() {
            var command = new Command("sites");
            var builder = new ApiSdk.Sites.SitesRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildRemoveCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildAddCommand());
            return command;
        }
        public Command BuildSubscribedSkusCommand() {
            var command = new Command("subscribed-skus");
            var builder = new ApiSdk.SubscribedSkus.SubscribedSkusRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildCreateCommand());
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            return command;
        }
        public Command BuildSubscriptionsCommand() {
            var command = new Command("subscriptions");
            var builder = new ApiSdk.Subscriptions.SubscriptionsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildCreateCommand());
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            return command;
        }
        public Command BuildTeamsCommand() {
            var command = new Command("teams");
            var builder = new ApiSdk.Teams.TeamsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildCreateCommand());
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            return command;
        }
        public Command BuildTeamsTemplatesCommand() {
            var command = new Command("teams-templates");
            var builder = new ApiSdk.TeamsTemplates.TeamsTemplatesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildCreateCommand());
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            return command;
        }
        public Command BuildTeamworkCommand() {
            var command = new Command("teamwork");
            var builder = new ApiSdk.Teamwork.TeamworkRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildWorkforceIntegrationsCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        public Command BuildUsersCommand() {
            var command = new Command("users");
            var builder = new ApiSdk.Users.UsersRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildGetAvailableExtensionPropertiesCommand());
            command.AddCommand(builder.BuildValidatePropertiesCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildGetByIdsCommand());
            return command;
        }
        public Command BuildWorkbooksCommand() {
            var command = new Command("workbooks");
            var builder = new ApiSdk.Workbooks.WorkbooksRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildCreateCommand());
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
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
        public async Task GetAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateGetRequestInformation(h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler);
        }
    }
}
