using ApiSdk.Admin;
using ApiSdk.AgreementAcceptances;
using ApiSdk.Agreements;
using ApiSdk.AppCatalogs;
using ApiSdk.ApplicationTemplates;
using ApiSdk.Applications;
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
using ApiSdk.DirectoryRoleTemplates;
using ApiSdk.DirectoryRoles;
using ApiSdk.DomainDnsRecords;
using ApiSdk.Domains;
using ApiSdk.Drives;
using ApiSdk.Education;
using ApiSdk.EmployeeExperience;
using ApiSdk.External;
using ApiSdk.GroupLifecyclePolicies;
using ApiSdk.GroupSettingTemplates;
using ApiSdk.GroupSettings;
using ApiSdk.Groups;
using ApiSdk.Identity;
using ApiSdk.IdentityGovernance;
using ApiSdk.IdentityProtection;
using ApiSdk.IdentityProviders;
using ApiSdk.InformationProtection;
using ApiSdk.Invitations;
using ApiSdk.Localizations;
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
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Cli.Commons.IO;
using Microsoft.Kiota.Cli.Commons;
using Microsoft.Kiota.Serialization.Form;
using Microsoft.Kiota.Serialization.Json;
using Microsoft.Kiota.Serialization.Text;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
namespace ApiSdk {
    /// <summary>
    /// The main entry point of the SDK, exposes the configuration and the fluent API.
    /// </summary>
    public class GraphClient : BaseCliRequestBuilder {
        /// <summary>
        /// Provides operations to manage the admin singleton.
        /// </summary>
        public Command BuildAdminNavCommand() {
            var command = new Command("admin");
            command.Description = "Provides operations to manage the admin singleton.";
            var builder = new AdminRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildEdgeNavCommand());
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPatchCommand());
            nonExecCommands.Add(builder.BuildServiceAnnouncementNavCommand());
            nonExecCommands.Add(builder.BuildSharepointNavCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of agreementAcceptance entities.
        /// </summary>
        public Command BuildAgreementAcceptancesNavCommand() {
            var command = new Command("agreement-acceptances");
            command.Description = "Provides operations to manage the collection of agreementAcceptance entities.";
            var builder = new AgreementAcceptancesRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            execCommands.Add(builder.BuildCreateCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of agreement entities.
        /// </summary>
        public Command BuildAgreementsNavCommand() {
            var command = new Command("agreements");
            command.Description = "Provides operations to manage the collection of agreement entities.";
            var builder = new AgreementsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            execCommands.Add(builder.BuildCreateCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the appCatalogs singleton.
        /// </summary>
        public Command BuildAppCatalogsNavCommand() {
            var command = new Command("app-catalogs");
            command.Description = "Provides operations to manage the appCatalogs singleton.";
            var builder = new AppCatalogsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPatchCommand());
            nonExecCommands.Add(builder.BuildTeamsAppsNavCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of application entities.
        /// </summary>
        public Command BuildApplicationsNavCommand() {
            var command = new Command("applications");
            command.Description = "Provides operations to manage the collection of application entities.";
            var builder = new ApplicationsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            nonExecCommands.Add(builder.BuildDeltaNavCommand());
            nonExecCommands.Add(builder.BuildGetAvailableExtensionPropertiesNavCommand());
            nonExecCommands.Add(builder.BuildGetByIdsNavCommand());
            execCommands.Add(builder.BuildListCommand());
            nonExecCommands.Add(builder.BuildValidatePropertiesNavCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of applicationTemplate entities.
        /// </summary>
        public Command BuildApplicationTemplatesNavCommand() {
            var command = new Command("application-templates");
            command.Description = "Provides operations to manage the collection of applicationTemplate entities.";
            var builder = new ApplicationTemplatesRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the auditLogRoot singleton.
        /// </summary>
        public Command BuildAuditLogsNavCommand() {
            var command = new Command("audit-logs");
            command.Description = "Provides operations to manage the auditLogRoot singleton.";
            var builder = new AuditLogsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildDirectoryAuditsNavCommand());
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPatchCommand());
            nonExecCommands.Add(builder.BuildProvisioningNavCommand());
            nonExecCommands.Add(builder.BuildSignInsNavCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of authenticationMethodConfiguration entities.
        /// </summary>
        public Command BuildAuthenticationMethodConfigurationsNavCommand() {
            var command = new Command("authentication-method-configurations");
            command.Description = "Provides operations to manage the collection of authenticationMethodConfiguration entities.";
            var builder = new AuthenticationMethodConfigurationsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the authenticationMethodsPolicy singleton.
        /// </summary>
        public Command BuildAuthenticationMethodsPolicyNavCommand() {
            var command = new Command("authentication-methods-policy");
            command.Description = "Provides operations to manage the authenticationMethodsPolicy singleton.";
            var builder = new AuthenticationMethodsPolicyRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildAuthenticationMethodConfigurationsNavCommand());
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPatchCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the organizationalBranding singleton.
        /// </summary>
        public Command BuildBrandingNavCommand() {
            var command = new Command("branding");
            command.Description = "Provides operations to manage the organizationalBranding singleton.";
            var builder = new BrandingRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildBackgroundImageNavCommand());
            nonExecCommands.Add(builder.BuildBannerLogoNavCommand());
            execCommands.Add(builder.BuildGetCommand());
            nonExecCommands.Add(builder.BuildLocalizationsNavCommand());
            execCommands.Add(builder.BuildPatchCommand());
            nonExecCommands.Add(builder.BuildSquareLogoNavCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of certificateBasedAuthConfiguration entities.
        /// </summary>
        public Command BuildCertificateBasedAuthConfigurationNavCommand() {
            var command = new Command("certificate-based-auth-configuration");
            command.Description = "Provides operations to manage the collection of certificateBasedAuthConfiguration entities.";
            var builder = new CertificateBasedAuthConfigurationRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of chat entities.
        /// </summary>
        public Command BuildChatsNavCommand() {
            var command = new Command("chats");
            command.Description = "Provides operations to manage the collection of chat entities.";
            var builder = new ChatsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            nonExecCommands.Add(builder.BuildGetAllMessagesNavCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the cloudCommunications singleton.
        /// </summary>
        public Command BuildCommunicationsNavCommand() {
            var command = new Command("communications");
            command.Description = "Provides operations to manage the cloudCommunications singleton.";
            var builder = new CommunicationsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCallRecordsNavCommand());
            nonExecCommands.Add(builder.BuildCallsNavCommand());
            execCommands.Add(builder.BuildGetCommand());
            nonExecCommands.Add(builder.BuildGetPresencesByUserIdNavCommand());
            nonExecCommands.Add(builder.BuildOnlineMeetingsNavCommand());
            execCommands.Add(builder.BuildPatchCommand());
            nonExecCommands.Add(builder.BuildPresencesNavCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the compliance singleton.
        /// </summary>
        public Command BuildComplianceNavCommand() {
            var command = new Command("compliance");
            command.Description = "Provides operations to manage the compliance singleton.";
            var builder = new ComplianceRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPatchCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of externalConnection entities.
        /// </summary>
        public Command BuildConnectionsNavCommand() {
            var command = new Command("connections");
            command.Description = "Provides operations to manage the collection of externalConnection entities.";
            var builder = new ConnectionsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of orgContact entities.
        /// </summary>
        public Command BuildContactsNavCommand() {
            var command = new Command("contacts");
            command.Description = "Provides operations to manage the collection of orgContact entities.";
            var builder = new ContactsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            nonExecCommands.Add(builder.BuildDeltaNavCommand());
            nonExecCommands.Add(builder.BuildGetAvailableExtensionPropertiesNavCommand());
            nonExecCommands.Add(builder.BuildGetByIdsNavCommand());
            execCommands.Add(builder.BuildListCommand());
            nonExecCommands.Add(builder.BuildValidatePropertiesNavCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of contract entities.
        /// </summary>
        public Command BuildContractsNavCommand() {
            var command = new Command("contracts");
            command.Description = "Provides operations to manage the collection of contract entities.";
            var builder = new ContractsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            nonExecCommands.Add(builder.BuildDeltaNavCommand());
            nonExecCommands.Add(builder.BuildGetAvailableExtensionPropertiesNavCommand());
            nonExecCommands.Add(builder.BuildGetByIdsNavCommand());
            execCommands.Add(builder.BuildListCommand());
            nonExecCommands.Add(builder.BuildValidatePropertiesNavCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of dataPolicyOperation entities.
        /// </summary>
        public Command BuildDataPolicyOperationsNavCommand() {
            var command = new Command("data-policy-operations");
            command.Description = "Provides operations to manage the collection of dataPolicyOperation entities.";
            var builder = new DataPolicyOperationsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the deviceAppManagement singleton.
        /// </summary>
        public Command BuildDeviceAppManagementNavCommand() {
            var command = new Command("device-app-management");
            command.Description = "Provides operations to manage the deviceAppManagement singleton.";
            var builder = new DeviceAppManagementRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildAndroidManagedAppProtectionsNavCommand());
            nonExecCommands.Add(builder.BuildDefaultManagedAppProtectionsNavCommand());
            execCommands.Add(builder.BuildGetCommand());
            nonExecCommands.Add(builder.BuildIosManagedAppProtectionsNavCommand());
            nonExecCommands.Add(builder.BuildManagedAppPoliciesNavCommand());
            nonExecCommands.Add(builder.BuildManagedAppRegistrationsNavCommand());
            nonExecCommands.Add(builder.BuildManagedAppStatusesNavCommand());
            nonExecCommands.Add(builder.BuildManagedEBooksNavCommand());
            nonExecCommands.Add(builder.BuildMdmWindowsInformationProtectionPoliciesNavCommand());
            nonExecCommands.Add(builder.BuildMobileAppCategoriesNavCommand());
            nonExecCommands.Add(builder.BuildMobileAppConfigurationsNavCommand());
            nonExecCommands.Add(builder.BuildMobileAppsNavCommand());
            execCommands.Add(builder.BuildPatchCommand());
            nonExecCommands.Add(builder.BuildSyncMicrosoftStoreForBusinessAppsNavCommand());
            nonExecCommands.Add(builder.BuildTargetedManagedAppConfigurationsNavCommand());
            nonExecCommands.Add(builder.BuildVppTokensNavCommand());
            nonExecCommands.Add(builder.BuildWindowsInformationProtectionPoliciesNavCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the deviceManagement singleton.
        /// </summary>
        public Command BuildDeviceManagementNavCommand() {
            var command = new Command("device-management");
            command.Description = "Provides operations to manage the deviceManagement singleton.";
            var builder = new DeviceManagementRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildApplePushNotificationCertificateNavCommand());
            nonExecCommands.Add(builder.BuildAuditEventsNavCommand());
            nonExecCommands.Add(builder.BuildComplianceManagementPartnersNavCommand());
            nonExecCommands.Add(builder.BuildConditionalAccessSettingsNavCommand());
            nonExecCommands.Add(builder.BuildDetectedAppsNavCommand());
            nonExecCommands.Add(builder.BuildDeviceCategoriesNavCommand());
            nonExecCommands.Add(builder.BuildDeviceCompliancePoliciesNavCommand());
            nonExecCommands.Add(builder.BuildDeviceCompliancePolicyDeviceStateSummaryNavCommand());
            nonExecCommands.Add(builder.BuildDeviceCompliancePolicySettingStateSummariesNavCommand());
            nonExecCommands.Add(builder.BuildDeviceConfigurationDeviceStateSummariesNavCommand());
            nonExecCommands.Add(builder.BuildDeviceConfigurationsNavCommand());
            nonExecCommands.Add(builder.BuildDeviceEnrollmentConfigurationsNavCommand());
            nonExecCommands.Add(builder.BuildDeviceManagementPartnersNavCommand());
            nonExecCommands.Add(builder.BuildExchangeConnectorsNavCommand());
            execCommands.Add(builder.BuildGetCommand());
            nonExecCommands.Add(builder.BuildImportedWindowsAutopilotDeviceIdentitiesNavCommand());
            nonExecCommands.Add(builder.BuildIosUpdateStatusesNavCommand());
            nonExecCommands.Add(builder.BuildManagedDeviceOverviewNavCommand());
            nonExecCommands.Add(builder.BuildManagedDevicesNavCommand());
            nonExecCommands.Add(builder.BuildMobileThreatDefenseConnectorsNavCommand());
            nonExecCommands.Add(builder.BuildNotificationMessageTemplatesNavCommand());
            execCommands.Add(builder.BuildPatchCommand());
            nonExecCommands.Add(builder.BuildRemoteAssistancePartnersNavCommand());
            nonExecCommands.Add(builder.BuildReportsNavCommand());
            nonExecCommands.Add(builder.BuildResourceOperationsNavCommand());
            nonExecCommands.Add(builder.BuildRoleAssignmentsNavCommand());
            nonExecCommands.Add(builder.BuildRoleDefinitionsNavCommand());
            nonExecCommands.Add(builder.BuildSoftwareUpdateStatusSummaryNavCommand());
            nonExecCommands.Add(builder.BuildTelecomExpenseManagementPartnersNavCommand());
            nonExecCommands.Add(builder.BuildTermsAndConditionsNavCommand());
            nonExecCommands.Add(builder.BuildTroubleshootingEventsNavCommand());
            nonExecCommands.Add(builder.BuildWindowsAutopilotDeviceIdentitiesNavCommand());
            nonExecCommands.Add(builder.BuildWindowsInformationProtectionAppLearningSummariesNavCommand());
            nonExecCommands.Add(builder.BuildWindowsInformationProtectionNetworkLearningSummariesNavCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of device entities.
        /// </summary>
        public Command BuildDevicesNavCommand() {
            var command = new Command("devices");
            command.Description = "Provides operations to manage the collection of device entities.";
            var builder = new DevicesRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            nonExecCommands.Add(builder.BuildDeltaNavCommand());
            nonExecCommands.Add(builder.BuildGetAvailableExtensionPropertiesNavCommand());
            nonExecCommands.Add(builder.BuildGetByIdsNavCommand());
            execCommands.Add(builder.BuildListCommand());
            nonExecCommands.Add(builder.BuildValidatePropertiesNavCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the directory singleton.
        /// </summary>
        public Command BuildDirectoryNavCommand() {
            var command = new Command("directory");
            command.Description = "Provides operations to manage the directory singleton.";
            var builder = new DirectoryRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildAdministrativeUnitsNavCommand());
            nonExecCommands.Add(builder.BuildAttributeSetsNavCommand());
            nonExecCommands.Add(builder.BuildCustomSecurityAttributeDefinitionsNavCommand());
            nonExecCommands.Add(builder.BuildDeletedItemsNavCommand());
            nonExecCommands.Add(builder.BuildFederationConfigurationsNavCommand());
            execCommands.Add(builder.BuildGetCommand());
            nonExecCommands.Add(builder.BuildOnPremisesSynchronizationNavCommand());
            execCommands.Add(builder.BuildPatchCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of directoryObject entities.
        /// </summary>
        public Command BuildDirectoryObjectsNavCommand() {
            var command = new Command("directory-objects");
            command.Description = "Provides operations to manage the collection of directoryObject entities.";
            var builder = new DirectoryObjectsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            nonExecCommands.Add(builder.BuildDeltaNavCommand());
            nonExecCommands.Add(builder.BuildGetAvailableExtensionPropertiesNavCommand());
            nonExecCommands.Add(builder.BuildGetByIdsNavCommand());
            execCommands.Add(builder.BuildListCommand());
            nonExecCommands.Add(builder.BuildValidatePropertiesNavCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of directoryRole entities.
        /// </summary>
        public Command BuildDirectoryRolesNavCommand() {
            var command = new Command("directory-roles");
            command.Description = "Provides operations to manage the collection of directoryRole entities.";
            var builder = new DirectoryRolesRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            nonExecCommands.Add(builder.BuildDeltaNavCommand());
            nonExecCommands.Add(builder.BuildGetAvailableExtensionPropertiesNavCommand());
            nonExecCommands.Add(builder.BuildGetByIdsNavCommand());
            execCommands.Add(builder.BuildListCommand());
            nonExecCommands.Add(builder.BuildValidatePropertiesNavCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of directoryRoleTemplate entities.
        /// </summary>
        public Command BuildDirectoryRoleTemplatesNavCommand() {
            var command = new Command("directory-role-templates");
            command.Description = "Provides operations to manage the collection of directoryRoleTemplate entities.";
            var builder = new DirectoryRoleTemplatesRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            nonExecCommands.Add(builder.BuildDeltaNavCommand());
            nonExecCommands.Add(builder.BuildGetAvailableExtensionPropertiesNavCommand());
            nonExecCommands.Add(builder.BuildGetByIdsNavCommand());
            execCommands.Add(builder.BuildListCommand());
            nonExecCommands.Add(builder.BuildValidatePropertiesNavCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of domainDnsRecord entities.
        /// </summary>
        public Command BuildDomainDnsRecordsNavCommand() {
            var command = new Command("domain-dns-records");
            command.Description = "Provides operations to manage the collection of domainDnsRecord entities.";
            var builder = new DomainDnsRecordsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of domain entities.
        /// </summary>
        public Command BuildDomainsNavCommand() {
            var command = new Command("domains");
            command.Description = "Provides operations to manage the collection of domain entities.";
            var builder = new DomainsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of drive entities.
        /// </summary>
        public Command BuildDrivesNavCommand() {
            var command = new Command("drives");
            command.Description = "Provides operations to manage the collection of drive entities.";
            var builder = new DrivesRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the educationRoot singleton.
        /// </summary>
        public Command BuildEducationNavCommand() {
            var command = new Command("education");
            command.Description = "Provides operations to manage the educationRoot singleton.";
            var builder = new EducationRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildClassesNavCommand());
            execCommands.Add(builder.BuildGetCommand());
            nonExecCommands.Add(builder.BuildMeNavCommand());
            execCommands.Add(builder.BuildPatchCommand());
            nonExecCommands.Add(builder.BuildSchoolsNavCommand());
            nonExecCommands.Add(builder.BuildUsersNavCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the employeeExperience singleton.
        /// </summary>
        public Command BuildEmployeeExperienceNavCommand() {
            var command = new Command("employee-experience");
            command.Description = "Provides operations to manage the employeeExperience singleton.";
            var builder = new EmployeeExperienceRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            nonExecCommands.Add(builder.BuildLearningProvidersNavCommand());
            execCommands.Add(builder.BuildPatchCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the external singleton.
        /// </summary>
        public Command BuildExternalNavCommand() {
            var command = new Command("external");
            command.Description = "Provides operations to manage the external singleton.";
            var builder = new ExternalRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildConnectionsNavCommand());
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPatchCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of groupLifecyclePolicy entities.
        /// </summary>
        public Command BuildGroupLifecyclePoliciesNavCommand() {
            var command = new Command("group-lifecycle-policies");
            command.Description = "Provides operations to manage the collection of groupLifecyclePolicy entities.";
            var builder = new GroupLifecyclePoliciesRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of groupSetting entities.
        /// </summary>
        public Command BuildGroupSettingsNavCommand() {
            var command = new Command("group-settings");
            command.Description = "Provides operations to manage the collection of groupSetting entities.";
            var builder = new GroupSettingsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of groupSettingTemplate entities.
        /// </summary>
        public Command BuildGroupSettingTemplatesNavCommand() {
            var command = new Command("group-setting-templates");
            command.Description = "Provides operations to manage the collection of groupSettingTemplate entities.";
            var builder = new GroupSettingTemplatesRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            nonExecCommands.Add(builder.BuildDeltaNavCommand());
            nonExecCommands.Add(builder.BuildGetAvailableExtensionPropertiesNavCommand());
            nonExecCommands.Add(builder.BuildGetByIdsNavCommand());
            execCommands.Add(builder.BuildListCommand());
            nonExecCommands.Add(builder.BuildValidatePropertiesNavCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of group entities.
        /// </summary>
        public Command BuildGroupsNavCommand() {
            var command = new Command("groups");
            command.Description = "Provides operations to manage the collection of group entities.";
            var builder = new GroupsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            nonExecCommands.Add(builder.BuildDeltaNavCommand());
            nonExecCommands.Add(builder.BuildGetAvailableExtensionPropertiesNavCommand());
            nonExecCommands.Add(builder.BuildGetByIdsNavCommand());
            execCommands.Add(builder.BuildListCommand());
            nonExecCommands.Add(builder.BuildValidatePropertiesNavCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the identityGovernance singleton.
        /// </summary>
        public Command BuildIdentityGovernanceNavCommand() {
            var command = new Command("identity-governance");
            command.Description = "Provides operations to manage the identityGovernance singleton.";
            var builder = new IdentityGovernanceRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildAccessReviewsNavCommand());
            nonExecCommands.Add(builder.BuildAppConsentNavCommand());
            nonExecCommands.Add(builder.BuildEntitlementManagementNavCommand());
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPatchCommand());
            nonExecCommands.Add(builder.BuildTermsOfUseNavCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the identityContainer singleton.
        /// </summary>
        public Command BuildIdentityNavCommand() {
            var command = new Command("identity");
            command.Description = "Provides operations to manage the identityContainer singleton.";
            var builder = new IdentityRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildApiConnectorsNavCommand());
            nonExecCommands.Add(builder.BuildB2xUserFlowsNavCommand());
            nonExecCommands.Add(builder.BuildConditionalAccessNavCommand());
            execCommands.Add(builder.BuildGetCommand());
            nonExecCommands.Add(builder.BuildIdentityProvidersNavCommand());
            execCommands.Add(builder.BuildPatchCommand());
            nonExecCommands.Add(builder.BuildUserFlowAttributesNavCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the identityProtectionRoot singleton.
        /// </summary>
        public Command BuildIdentityProtectionNavCommand() {
            var command = new Command("identity-protection");
            command.Description = "Provides operations to manage the identityProtectionRoot singleton.";
            var builder = new IdentityProtectionRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPatchCommand());
            nonExecCommands.Add(builder.BuildRiskDetectionsNavCommand());
            nonExecCommands.Add(builder.BuildRiskyServicePrincipalsNavCommand());
            nonExecCommands.Add(builder.BuildRiskyUsersNavCommand());
            nonExecCommands.Add(builder.BuildServicePrincipalRiskDetectionsNavCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of identityProvider entities.
        /// </summary>
        public Command BuildIdentityProvidersNavCommand() {
            var command = new Command("identity-providers");
            command.Description = "Provides operations to manage the collection of identityProvider entities.";
            var builder = new IdentityProvidersRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildAvailableProviderTypesNavCommand());
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the informationProtection singleton.
        /// </summary>
        public Command BuildInformationProtectionNavCommand() {
            var command = new Command("information-protection");
            command.Description = "Provides operations to manage the informationProtection singleton.";
            var builder = new InformationProtectionRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildBitlockerNavCommand());
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPatchCommand());
            nonExecCommands.Add(builder.BuildThreatAssessmentRequestsNavCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of invitation entities.
        /// </summary>
        public Command BuildInvitationsNavCommand() {
            var command = new Command("invitations");
            command.Description = "Provides operations to manage the collection of invitation entities.";
            var builder = new InvitationsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of organizationalBrandingLocalization entities.
        /// </summary>
        public Command BuildLocalizationsNavCommand() {
            var command = new Command("localizations");
            command.Description = "Provides operations to manage the collection of organizationalBrandingLocalization entities.";
            var builder = new LocalizationsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of oAuth2PermissionGrant entities.
        /// </summary>
        public Command BuildOauth2PermissionGrantsNavCommand() {
            var command = new Command("oauth2-permission-grants");
            command.Description = "Provides operations to manage the collection of oAuth2PermissionGrant entities.";
            var builder = new Oauth2PermissionGrantsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            nonExecCommands.Add(builder.BuildDeltaNavCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of organization entities.
        /// </summary>
        public Command BuildOrganizationNavCommand() {
            var command = new Command("organization");
            command.Description = "Provides operations to manage the collection of organization entities.";
            var builder = new OrganizationRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            nonExecCommands.Add(builder.BuildDeltaNavCommand());
            nonExecCommands.Add(builder.BuildGetAvailableExtensionPropertiesNavCommand());
            nonExecCommands.Add(builder.BuildGetByIdsNavCommand());
            execCommands.Add(builder.BuildListCommand());
            nonExecCommands.Add(builder.BuildValidatePropertiesNavCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of resourceSpecificPermissionGrant entities.
        /// </summary>
        public Command BuildPermissionGrantsNavCommand() {
            var command = new Command("permission-grants");
            command.Description = "Provides operations to manage the collection of resourceSpecificPermissionGrant entities.";
            var builder = new PermissionGrantsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            execCommands.Add(builder.BuildCreateCommand());
            nonExecCommands.Add(builder.BuildDeltaNavCommand());
            nonExecCommands.Add(builder.BuildGetAvailableExtensionPropertiesNavCommand());
            nonExecCommands.Add(builder.BuildGetByIdsNavCommand());
            execCommands.Add(builder.BuildListCommand());
            nonExecCommands.Add(builder.BuildValidatePropertiesNavCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// The places property
        /// </summary>
        public Command BuildPlacesNavCommand() {
            var command = new Command("places");
            command.Description = "The places property";
            var builder = new PlacesRequestBuilder(PathParameters);
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            nonExecCommands.Add(builder.BuildGraphRoomNavCommand());
            var cmds = builder.BuildCommand();
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the planner singleton.
        /// </summary>
        public Command BuildPlannerNavCommand() {
            var command = new Command("planner");
            command.Description = "Provides operations to manage the planner singleton.";
            var builder = new PlannerRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildBucketsNavCommand());
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPatchCommand());
            nonExecCommands.Add(builder.BuildPlansNavCommand());
            nonExecCommands.Add(builder.BuildTasksNavCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the policyRoot singleton.
        /// </summary>
        public Command BuildPoliciesNavCommand() {
            var command = new Command("policies");
            command.Description = "Provides operations to manage the policyRoot singleton.";
            var builder = new PoliciesRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildActivityBasedTimeoutPoliciesNavCommand());
            nonExecCommands.Add(builder.BuildAdminConsentRequestPolicyNavCommand());
            nonExecCommands.Add(builder.BuildAppManagementPoliciesNavCommand());
            nonExecCommands.Add(builder.BuildAuthenticationFlowsPolicyNavCommand());
            nonExecCommands.Add(builder.BuildAuthenticationMethodsPolicyNavCommand());
            nonExecCommands.Add(builder.BuildAuthenticationStrengthPoliciesNavCommand());
            nonExecCommands.Add(builder.BuildAuthorizationPolicyNavCommand());
            nonExecCommands.Add(builder.BuildClaimsMappingPoliciesNavCommand());
            nonExecCommands.Add(builder.BuildConditionalAccessPoliciesNavCommand());
            nonExecCommands.Add(builder.BuildCrossTenantAccessPolicyNavCommand());
            nonExecCommands.Add(builder.BuildDefaultAppManagementPolicyNavCommand());
            nonExecCommands.Add(builder.BuildFeatureRolloutPoliciesNavCommand());
            execCommands.Add(builder.BuildGetCommand());
            nonExecCommands.Add(builder.BuildHomeRealmDiscoveryPoliciesNavCommand());
            nonExecCommands.Add(builder.BuildIdentitySecurityDefaultsEnforcementPolicyNavCommand());
            execCommands.Add(builder.BuildPatchCommand());
            nonExecCommands.Add(builder.BuildPermissionGrantPoliciesNavCommand());
            nonExecCommands.Add(builder.BuildRoleManagementPoliciesNavCommand());
            nonExecCommands.Add(builder.BuildRoleManagementPolicyAssignmentsNavCommand());
            nonExecCommands.Add(builder.BuildTokenIssuancePoliciesNavCommand());
            nonExecCommands.Add(builder.BuildTokenLifetimePoliciesNavCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the print singleton.
        /// </summary>
        public Command BuildPrintNavCommand() {
            var command = new Command("print");
            command.Description = "Provides operations to manage the print singleton.";
            var builder = new PrintRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildConnectorsNavCommand());
            execCommands.Add(builder.BuildGetCommand());
            nonExecCommands.Add(builder.BuildOperationsNavCommand());
            execCommands.Add(builder.BuildPatchCommand());
            nonExecCommands.Add(builder.BuildPrintersNavCommand());
            nonExecCommands.Add(builder.BuildServicesNavCommand());
            nonExecCommands.Add(builder.BuildSharesNavCommand());
            nonExecCommands.Add(builder.BuildTaskDefinitionsNavCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the privacy singleton.
        /// </summary>
        public Command BuildPrivacyNavCommand() {
            var command = new Command("privacy");
            command.Description = "Provides operations to manage the privacy singleton.";
            var builder = new PrivacyRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPatchCommand());
            nonExecCommands.Add(builder.BuildSubjectRightsRequestsNavCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the reportRoot singleton.
        /// </summary>
        public Command BuildReportsNavCommand() {
            var command = new Command("reports");
            command.Description = "Provides operations to manage the reportRoot singleton.";
            var builder = new ReportsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildDailyPrintUsageByPrinterNavCommand());
            nonExecCommands.Add(builder.BuildDailyPrintUsageByUserNavCommand());
            nonExecCommands.Add(builder.BuildDeviceConfigurationDeviceActivityNavCommand());
            nonExecCommands.Add(builder.BuildDeviceConfigurationUserActivityNavCommand());
            execCommands.Add(builder.BuildGetCommand());
            nonExecCommands.Add(builder.BuildGetOffice365ActivationCountsNavCommand());
            nonExecCommands.Add(builder.BuildGetOffice365ActivationsUserCountsNavCommand());
            nonExecCommands.Add(builder.BuildGetOffice365ActivationsUserDetailNavCommand());
            nonExecCommands.Add(builder.BuildManagedDeviceEnrollmentFailureDetailsNavCommand());
            nonExecCommands.Add(builder.BuildManagedDeviceEnrollmentTopFailuresNavCommand());
            nonExecCommands.Add(builder.BuildMonthlyPrintUsageByPrinterNavCommand());
            nonExecCommands.Add(builder.BuildMonthlyPrintUsageByUserNavCommand());
            execCommands.Add(builder.BuildPatchCommand());
            nonExecCommands.Add(builder.BuildSecurityNavCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the roleManagement singleton.
        /// </summary>
        public Command BuildRoleManagementNavCommand() {
            var command = new Command("role-management");
            command.Description = "Provides operations to manage the roleManagement singleton.";
            var builder = new RoleManagementRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildDirectoryNavCommand());
            nonExecCommands.Add(builder.BuildEntitlementManagementNavCommand());
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPatchCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new GraphClient and sets the default values.
        /// </summary>
        public Command BuildRootCommand() {
            var command = new RootCommand();
            command.Description = "Instantiates a new GraphClient and sets the default values.";
            command.AddCommand(BuildAdminNavCommand());
            command.AddCommand(BuildAgreementAcceptancesNavCommand());
            command.AddCommand(BuildAgreementsNavCommand());
            command.AddCommand(BuildAppCatalogsNavCommand());
            command.AddCommand(BuildApplicationsNavCommand());
            command.AddCommand(BuildApplicationTemplatesNavCommand());
            command.AddCommand(BuildAuditLogsNavCommand());
            command.AddCommand(BuildAuthenticationMethodConfigurationsNavCommand());
            command.AddCommand(BuildAuthenticationMethodsPolicyNavCommand());
            command.AddCommand(BuildBrandingNavCommand());
            command.AddCommand(BuildCertificateBasedAuthConfigurationNavCommand());
            command.AddCommand(BuildChatsNavCommand());
            command.AddCommand(BuildCommunicationsNavCommand());
            command.AddCommand(BuildComplianceNavCommand());
            command.AddCommand(BuildConnectionsNavCommand());
            command.AddCommand(BuildContactsNavCommand());
            command.AddCommand(BuildContractsNavCommand());
            command.AddCommand(BuildDataPolicyOperationsNavCommand());
            command.AddCommand(BuildDeviceAppManagementNavCommand());
            command.AddCommand(BuildDeviceManagementNavCommand());
            command.AddCommand(BuildDevicesNavCommand());
            command.AddCommand(BuildDirectoryNavCommand());
            command.AddCommand(BuildDirectoryObjectsNavCommand());
            command.AddCommand(BuildDirectoryRolesNavCommand());
            command.AddCommand(BuildDirectoryRoleTemplatesNavCommand());
            command.AddCommand(BuildDomainDnsRecordsNavCommand());
            command.AddCommand(BuildDomainsNavCommand());
            command.AddCommand(BuildDrivesNavCommand());
            command.AddCommand(BuildEducationNavCommand());
            command.AddCommand(BuildEmployeeExperienceNavCommand());
            command.AddCommand(BuildExternalNavCommand());
            command.AddCommand(BuildGroupLifecyclePoliciesNavCommand());
            command.AddCommand(BuildGroupSettingsNavCommand());
            command.AddCommand(BuildGroupSettingTemplatesNavCommand());
            command.AddCommand(BuildGroupsNavCommand());
            command.AddCommand(BuildIdentityGovernanceNavCommand());
            command.AddCommand(BuildIdentityNavCommand());
            command.AddCommand(BuildIdentityProtectionNavCommand());
            command.AddCommand(BuildIdentityProvidersNavCommand());
            command.AddCommand(BuildInformationProtectionNavCommand());
            command.AddCommand(BuildInvitationsNavCommand());
            command.AddCommand(BuildLocalizationsNavCommand());
            command.AddCommand(BuildOauth2PermissionGrantsNavCommand());
            command.AddCommand(BuildOrganizationNavCommand());
            command.AddCommand(BuildPermissionGrantsNavCommand());
            command.AddCommand(BuildPlacesNavCommand());
            command.AddCommand(BuildPlannerNavCommand());
            command.AddCommand(BuildPoliciesNavCommand());
            command.AddCommand(BuildPrintNavCommand());
            command.AddCommand(BuildPrivacyNavCommand());
            command.AddCommand(BuildReportsNavCommand());
            command.AddCommand(BuildRoleManagementNavCommand());
            command.AddCommand(BuildSchemaExtensionsNavCommand());
            command.AddCommand(BuildScopedRoleMembershipsNavCommand());
            command.AddCommand(BuildSearchNavCommand());
            command.AddCommand(BuildSecurityNavCommand());
            command.AddCommand(BuildServicePrincipalsNavCommand());
            command.AddCommand(BuildSharesNavCommand());
            command.AddCommand(BuildSitesNavCommand());
            command.AddCommand(BuildSolutionsNavCommand());
            command.AddCommand(BuildSubscribedSkusNavCommand());
            command.AddCommand(BuildSubscriptionsNavCommand());
            command.AddCommand(BuildTeamsNavCommand());
            command.AddCommand(BuildTeamsTemplatesNavCommand());
            command.AddCommand(BuildTeamworkNavCommand());
            command.AddCommand(BuildTenantRelationshipsNavCommand());
            command.AddCommand(BuildUsersNavCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of schemaExtension entities.
        /// </summary>
        public Command BuildSchemaExtensionsNavCommand() {
            var command = new Command("schema-extensions");
            command.Description = "Provides operations to manage the collection of schemaExtension entities.";
            var builder = new SchemaExtensionsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of scopedRoleMembership entities.
        /// </summary>
        public Command BuildScopedRoleMembershipsNavCommand() {
            var command = new Command("scoped-role-memberships");
            command.Description = "Provides operations to manage the collection of scopedRoleMembership entities.";
            var builder = new ScopedRoleMembershipsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the searchEntity singleton.
        /// </summary>
        public Command BuildSearchNavCommand() {
            var command = new Command("search");
            command.Description = "Provides operations to manage the searchEntity singleton.";
            var builder = new SearchRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPatchCommand());
            nonExecCommands.Add(builder.BuildQueryNavCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the security singleton.
        /// </summary>
        public Command BuildSecurityNavCommand() {
            var command = new Command("security");
            command.Description = "Provides operations to manage the security singleton.";
            var builder = new SecurityRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildAlerts_v2NavCommand());
            nonExecCommands.Add(builder.BuildAlertsNavCommand());
            nonExecCommands.Add(builder.BuildAttackSimulationNavCommand());
            nonExecCommands.Add(builder.BuildCasesNavCommand());
            execCommands.Add(builder.BuildGetCommand());
            nonExecCommands.Add(builder.BuildIncidentsNavCommand());
            nonExecCommands.Add(builder.BuildMicrosoftGraphSecurityRunHuntingQueryNavCommand());
            execCommands.Add(builder.BuildPatchCommand());
            nonExecCommands.Add(builder.BuildSecureScoreControlProfilesNavCommand());
            nonExecCommands.Add(builder.BuildSecureScoresNavCommand());
            nonExecCommands.Add(builder.BuildTriggersNavCommand());
            nonExecCommands.Add(builder.BuildTriggerTypesNavCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of servicePrincipal entities.
        /// </summary>
        public Command BuildServicePrincipalsNavCommand() {
            var command = new Command("service-principals");
            command.Description = "Provides operations to manage the collection of servicePrincipal entities.";
            var builder = new ServicePrincipalsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            nonExecCommands.Add(builder.BuildDeltaNavCommand());
            nonExecCommands.Add(builder.BuildGetAvailableExtensionPropertiesNavCommand());
            nonExecCommands.Add(builder.BuildGetByIdsNavCommand());
            execCommands.Add(builder.BuildListCommand());
            nonExecCommands.Add(builder.BuildValidatePropertiesNavCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of sharedDriveItem entities.
        /// </summary>
        public Command BuildSharesNavCommand() {
            var command = new Command("shares");
            command.Description = "Provides operations to manage the collection of sharedDriveItem entities.";
            var builder = new SharesRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of site entities.
        /// </summary>
        public Command BuildSitesNavCommand() {
            var command = new Command("sites");
            command.Description = "Provides operations to manage the collection of site entities.";
            var builder = new SitesRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildAddNavCommand());
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildListCommand());
            nonExecCommands.Add(builder.BuildRemoveNavCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the solutionsRoot singleton.
        /// </summary>
        public Command BuildSolutionsNavCommand() {
            var command = new Command("solutions");
            command.Description = "Provides operations to manage the solutionsRoot singleton.";
            var builder = new SolutionsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildBookingBusinessesNavCommand());
            nonExecCommands.Add(builder.BuildBookingCurrenciesNavCommand());
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPatchCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of subscribedSku entities.
        /// </summary>
        public Command BuildSubscribedSkusNavCommand() {
            var command = new Command("subscribed-skus");
            command.Description = "Provides operations to manage the collection of subscribedSku entities.";
            var builder = new SubscribedSkusRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            execCommands.Add(builder.BuildCreateCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of subscription entities.
        /// </summary>
        public Command BuildSubscriptionsNavCommand() {
            var command = new Command("subscriptions");
            command.Description = "Provides operations to manage the collection of subscription entities.";
            var builder = new SubscriptionsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            execCommands.Add(builder.BuildCreateCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of team entities.
        /// </summary>
        public Command BuildTeamsNavCommand() {
            var command = new Command("teams");
            command.Description = "Provides operations to manage the collection of team entities.";
            var builder = new TeamsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            nonExecCommands.Add(builder.BuildGetAllMessagesNavCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of teamsTemplate entities.
        /// </summary>
        public Command BuildTeamsTemplatesNavCommand() {
            var command = new Command("teams-templates");
            command.Description = "Provides operations to manage the collection of teamsTemplate entities.";
            var builder = new TeamsTemplatesRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the teamwork singleton.
        /// </summary>
        public Command BuildTeamworkNavCommand() {
            var command = new Command("teamwork");
            command.Description = "Provides operations to manage the teamwork singleton.";
            var builder = new TeamworkRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildDeletedTeamsNavCommand());
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPatchCommand());
            nonExecCommands.Add(builder.BuildSendActivityNotificationToRecipientsNavCommand());
            nonExecCommands.Add(builder.BuildWorkforceIntegrationsNavCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the tenantRelationship singleton.
        /// </summary>
        public Command BuildTenantRelationshipsNavCommand() {
            var command = new Command("tenant-relationships");
            command.Description = "Provides operations to manage the tenantRelationship singleton.";
            var builder = new TenantRelationshipsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildDelegatedAdminCustomersNavCommand());
            nonExecCommands.Add(builder.BuildDelegatedAdminRelationshipsNavCommand());
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPatchCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of user entities.
        /// </summary>
        public Command BuildUsersNavCommand() {
            var command = new Command("users");
            command.Description = "Provides operations to manage the collection of user entities.";
            var builder = new UsersRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            nonExecCommands.Add(builder.BuildDeltaNavCommand());
            nonExecCommands.Add(builder.BuildGetAvailableExtensionPropertiesNavCommand());
            nonExecCommands.Add(builder.BuildGetByIdsNavCommand());
            execCommands.Add(builder.BuildListCommand());
            nonExecCommands.Add(builder.BuildValidatePropertiesNavCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new GraphClient and sets the default values.
        /// </summary>
        public GraphClient() : base("{+baseurl}", new Dictionary<string, object>()) {
        }
    }
}
