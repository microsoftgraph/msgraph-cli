using ApiSdk.DeviceManagement.ApplePushNotificationCertificate;
using ApiSdk.DeviceManagement.AuditEvents;
using ApiSdk.DeviceManagement.ComplianceManagementPartners;
using ApiSdk.DeviceManagement.ConditionalAccessSettings;
using ApiSdk.DeviceManagement.DetectedApps;
using ApiSdk.DeviceManagement.DeviceCategories;
using ApiSdk.DeviceManagement.DeviceCompliancePolicies;
using ApiSdk.DeviceManagement.DeviceCompliancePolicyDeviceStateSummary;
using ApiSdk.DeviceManagement.DeviceCompliancePolicySettingStateSummaries;
using ApiSdk.DeviceManagement.DeviceConfigurationDeviceStateSummaries;
using ApiSdk.DeviceManagement.DeviceConfigurations;
using ApiSdk.DeviceManagement.DeviceEnrollmentConfigurations;
using ApiSdk.DeviceManagement.DeviceManagementPartners;
using ApiSdk.DeviceManagement.ExchangeConnectors;
using ApiSdk.DeviceManagement.GetEffectivePermissionsWithScope;
using ApiSdk.DeviceManagement.ImportedWindowsAutopilotDeviceIdentities;
using ApiSdk.DeviceManagement.IosUpdateStatuses;
using ApiSdk.DeviceManagement.ManagedDeviceOverview;
using ApiSdk.DeviceManagement.ManagedDevices;
using ApiSdk.DeviceManagement.MobileThreatDefenseConnectors;
using ApiSdk.DeviceManagement.NotificationMessageTemplates;
using ApiSdk.DeviceManagement.RemoteAssistancePartners;
using ApiSdk.DeviceManagement.Reports;
using ApiSdk.DeviceManagement.ResourceOperations;
using ApiSdk.DeviceManagement.RoleAssignments;
using ApiSdk.DeviceManagement.RoleDefinitions;
using ApiSdk.DeviceManagement.SoftwareUpdateStatusSummary;
using ApiSdk.DeviceManagement.TelecomExpenseManagementPartners;
using ApiSdk.DeviceManagement.TermsAndConditions;
using ApiSdk.DeviceManagement.TroubleshootingEvents;
using ApiSdk.DeviceManagement.VerifyWindowsEnrollmentAutoDiscoveryWithDomainName;
using ApiSdk.DeviceManagement.WindowsAutopilotDeviceIdentities;
using ApiSdk.DeviceManagement.WindowsInformationProtectionAppLearningSummaries;
using ApiSdk.DeviceManagement.WindowsInformationProtectionNetworkLearningSummaries;
using ApiSdk.Models;
using ApiSdk.Models.ODataErrors;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Cli.Commons.IO;
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace ApiSdk.DeviceManagement {
    /// <summary>
    /// Provides operations to manage the deviceManagement singleton.
    /// </summary>
    public class DeviceManagementRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Provides operations to manage the applePushNotificationCertificate property of the microsoft.graph.deviceManagement entity.
        /// </summary>
        public Command BuildApplePushNotificationCertificateCommand() {
            var command = new Command("apple-push-notification-certificate");
            command.Description = "Provides operations to manage the applePushNotificationCertificate property of the microsoft.graph.deviceManagement entity.";
            var builder = new ApplePushNotificationCertificateRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the auditEvents property of the microsoft.graph.deviceManagement entity.
        /// </summary>
        public Command BuildAuditEventsCommand() {
            var command = new Command("audit-events");
            command.Description = "Provides operations to manage the auditEvents property of the microsoft.graph.deviceManagement entity.";
            var builder = new AuditEventsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the complianceManagementPartners property of the microsoft.graph.deviceManagement entity.
        /// </summary>
        public Command BuildComplianceManagementPartnersCommand() {
            var command = new Command("compliance-management-partners");
            command.Description = "Provides operations to manage the complianceManagementPartners property of the microsoft.graph.deviceManagement entity.";
            var builder = new ComplianceManagementPartnersRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the conditionalAccessSettings property of the microsoft.graph.deviceManagement entity.
        /// </summary>
        public Command BuildConditionalAccessSettingsCommand() {
            var command = new Command("conditional-access-settings");
            command.Description = "Provides operations to manage the conditionalAccessSettings property of the microsoft.graph.deviceManagement entity.";
            var builder = new ConditionalAccessSettingsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the detectedApps property of the microsoft.graph.deviceManagement entity.
        /// </summary>
        public Command BuildDetectedAppsCommand() {
            var command = new Command("detected-apps");
            command.Description = "Provides operations to manage the detectedApps property of the microsoft.graph.deviceManagement entity.";
            var builder = new DetectedAppsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the deviceCategories property of the microsoft.graph.deviceManagement entity.
        /// </summary>
        public Command BuildDeviceCategoriesCommand() {
            var command = new Command("device-categories");
            command.Description = "Provides operations to manage the deviceCategories property of the microsoft.graph.deviceManagement entity.";
            var builder = new DeviceCategoriesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the deviceCompliancePolicies property of the microsoft.graph.deviceManagement entity.
        /// </summary>
        public Command BuildDeviceCompliancePoliciesCommand() {
            var command = new Command("device-compliance-policies");
            command.Description = "Provides operations to manage the deviceCompliancePolicies property of the microsoft.graph.deviceManagement entity.";
            var builder = new DeviceCompliancePoliciesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the deviceCompliancePolicyDeviceStateSummary property of the microsoft.graph.deviceManagement entity.
        /// </summary>
        public Command BuildDeviceCompliancePolicyDeviceStateSummaryCommand() {
            var command = new Command("device-compliance-policy-device-state-summary");
            command.Description = "Provides operations to manage the deviceCompliancePolicyDeviceStateSummary property of the microsoft.graph.deviceManagement entity.";
            var builder = new DeviceCompliancePolicyDeviceStateSummaryRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the deviceCompliancePolicySettingStateSummaries property of the microsoft.graph.deviceManagement entity.
        /// </summary>
        public Command BuildDeviceCompliancePolicySettingStateSummariesCommand() {
            var command = new Command("device-compliance-policy-setting-state-summaries");
            command.Description = "Provides operations to manage the deviceCompliancePolicySettingStateSummaries property of the microsoft.graph.deviceManagement entity.";
            var builder = new DeviceCompliancePolicySettingStateSummariesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the deviceConfigurationDeviceStateSummaries property of the microsoft.graph.deviceManagement entity.
        /// </summary>
        public Command BuildDeviceConfigurationDeviceStateSummariesCommand() {
            var command = new Command("device-configuration-device-state-summaries");
            command.Description = "Provides operations to manage the deviceConfigurationDeviceStateSummaries property of the microsoft.graph.deviceManagement entity.";
            var builder = new DeviceConfigurationDeviceStateSummariesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the deviceConfigurations property of the microsoft.graph.deviceManagement entity.
        /// </summary>
        public Command BuildDeviceConfigurationsCommand() {
            var command = new Command("device-configurations");
            command.Description = "Provides operations to manage the deviceConfigurations property of the microsoft.graph.deviceManagement entity.";
            var builder = new DeviceConfigurationsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the deviceEnrollmentConfigurations property of the microsoft.graph.deviceManagement entity.
        /// </summary>
        public Command BuildDeviceEnrollmentConfigurationsCommand() {
            var command = new Command("device-enrollment-configurations");
            command.Description = "Provides operations to manage the deviceEnrollmentConfigurations property of the microsoft.graph.deviceManagement entity.";
            var builder = new DeviceEnrollmentConfigurationsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the deviceManagementPartners property of the microsoft.graph.deviceManagement entity.
        /// </summary>
        public Command BuildDeviceManagementPartnersCommand() {
            var command = new Command("device-management-partners");
            command.Description = "Provides operations to manage the deviceManagementPartners property of the microsoft.graph.deviceManagement entity.";
            var builder = new DeviceManagementPartnersRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the exchangeConnectors property of the microsoft.graph.deviceManagement entity.
        /// </summary>
        public Command BuildExchangeConnectorsCommand() {
            var command = new Command("exchange-connectors");
            command.Description = "Provides operations to manage the exchangeConnectors property of the microsoft.graph.deviceManagement entity.";
            var builder = new ExchangeConnectorsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Get deviceManagement
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Get deviceManagement";
            // Create options for all the parameters
            var selectOption = new Option<string[]>("--select", description: "Select properties to be returned") {
                Arity = ArgumentArity.ZeroOrMore
            };
            selectOption.IsRequired = false;
            command.AddOption(selectOption);
            var expandOption = new Option<string[]>("--expand", description: "Expand related entities") {
                Arity = ArgumentArity.ZeroOrMore
            };
            expandOption.IsRequired = false;
            command.AddOption(expandOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON){
                IsRequired = true
            };
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            var jsonNoIndentOption = new Option<bool>("--json-no-indent", r => {
                if (bool.TryParse(r.Tokens.Select(t => t.Value).LastOrDefault(), out var value)) {
                    return value;
                }
                return true;
            }, description: "Disable indentation for the JSON output formatter.");
            command.AddOption(jsonNoIndentOption);
            command.SetHandler(async (invocationContext) => {
                var select = invocationContext.ParseResult.GetValueForOption(selectOption);
                var expand = invocationContext.ParseResult.GetValueForOption(expandOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                var jsonNoIndent = invocationContext.ParseResult.GetValueForOption(jsonNoIndentOption);
                var outputFilter = invocationContext.BindingContext.GetRequiredService<IOutputFilter>();
                var outputFormatterFactory = invocationContext.BindingContext.GetRequiredService<IOutputFormatterFactory>();
                var cancellationToken = invocationContext.GetCancellationToken();
                var requestInfo = ToGetRequestInformation(q => {
                    q.QueryParameters.Select = select;
                    q.QueryParameters.Expand = expand;
                });
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                response = await outputFilter?.FilterOutputAsync(response, query, cancellationToken) ?? response;
                var formatterOptions = output.GetOutputFormatterOptions(new FormatterOptionsModel(!jsonNoIndent));
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, formatterOptions, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Provides operations to manage the importedWindowsAutopilotDeviceIdentities property of the microsoft.graph.deviceManagement entity.
        /// </summary>
        public Command BuildImportedWindowsAutopilotDeviceIdentitiesCommand() {
            var command = new Command("imported-windows-autopilot-device-identities");
            command.Description = "Provides operations to manage the importedWindowsAutopilotDeviceIdentities property of the microsoft.graph.deviceManagement entity.";
            var builder = new ImportedWindowsAutopilotDeviceIdentitiesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildImportCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the iosUpdateStatuses property of the microsoft.graph.deviceManagement entity.
        /// </summary>
        public Command BuildIosUpdateStatusesCommand() {
            var command = new Command("ios-update-statuses");
            command.Description = "Provides operations to manage the iosUpdateStatuses property of the microsoft.graph.deviceManagement entity.";
            var builder = new IosUpdateStatusesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the managedDeviceOverview property of the microsoft.graph.deviceManagement entity.
        /// </summary>
        public Command BuildManagedDeviceOverviewCommand() {
            var command = new Command("managed-device-overview");
            command.Description = "Provides operations to manage the managedDeviceOverview property of the microsoft.graph.deviceManagement entity.";
            var builder = new ManagedDeviceOverviewRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the managedDevices property of the microsoft.graph.deviceManagement entity.
        /// </summary>
        public Command BuildManagedDevicesCommand() {
            var command = new Command("managed-devices");
            command.Description = "Provides operations to manage the managedDevices property of the microsoft.graph.deviceManagement entity.";
            var builder = new ManagedDevicesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the mobileThreatDefenseConnectors property of the microsoft.graph.deviceManagement entity.
        /// </summary>
        public Command BuildMobileThreatDefenseConnectorsCommand() {
            var command = new Command("mobile-threat-defense-connectors");
            command.Description = "Provides operations to manage the mobileThreatDefenseConnectors property of the microsoft.graph.deviceManagement entity.";
            var builder = new MobileThreatDefenseConnectorsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the notificationMessageTemplates property of the microsoft.graph.deviceManagement entity.
        /// </summary>
        public Command BuildNotificationMessageTemplatesCommand() {
            var command = new Command("notification-message-templates");
            command.Description = "Provides operations to manage the notificationMessageTemplates property of the microsoft.graph.deviceManagement entity.";
            var builder = new NotificationMessageTemplatesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Update deviceManagement
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Update deviceManagement";
            // Create options for all the parameters
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON){
                IsRequired = true
            };
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            var jsonNoIndentOption = new Option<bool>("--json-no-indent", r => {
                if (bool.TryParse(r.Tokens.Select(t => t.Value).LastOrDefault(), out var value)) {
                    return value;
                }
                return true;
            }, description: "Disable indentation for the JSON output formatter.");
            command.AddOption(jsonNoIndentOption);
            command.SetHandler(async (invocationContext) => {
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                var jsonNoIndent = invocationContext.ParseResult.GetValueForOption(jsonNoIndentOption);
                var outputFilter = invocationContext.BindingContext.GetRequiredService<IOutputFilter>();
                var outputFormatterFactory = invocationContext.BindingContext.GetRequiredService<IOutputFormatterFactory>();
                var cancellationToken = invocationContext.GetCancellationToken();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ApiSdk.Models.DeviceManagement>(ApiSdk.Models.DeviceManagement.CreateFromDiscriminatorValue);
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                response = await outputFilter?.FilterOutputAsync(response, query, cancellationToken) ?? response;
                var formatterOptions = output.GetOutputFormatterOptions(new FormatterOptionsModel(!jsonNoIndent));
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, formatterOptions, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Provides operations to manage the remoteAssistancePartners property of the microsoft.graph.deviceManagement entity.
        /// </summary>
        public Command BuildRemoteAssistancePartnersCommand() {
            var command = new Command("remote-assistance-partners");
            command.Description = "Provides operations to manage the remoteAssistancePartners property of the microsoft.graph.deviceManagement entity.";
            var builder = new RemoteAssistancePartnersRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the reports property of the microsoft.graph.deviceManagement entity.
        /// </summary>
        public Command BuildReportsCommand() {
            var command = new Command("reports");
            command.Description = "Provides operations to manage the reports property of the microsoft.graph.deviceManagement entity.";
            var builder = new ReportsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildExportJobsCommand());
            command.AddCommand(builder.BuildGetCachedReportCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildGetCompliancePolicyNonComplianceReportCommand());
            command.AddCommand(builder.BuildGetCompliancePolicyNonComplianceSummaryReportCommand());
            command.AddCommand(builder.BuildGetComplianceSettingNonComplianceReportCommand());
            command.AddCommand(builder.BuildGetConfigurationPolicyNonComplianceReportCommand());
            command.AddCommand(builder.BuildGetConfigurationPolicyNonComplianceSummaryReportCommand());
            command.AddCommand(builder.BuildGetConfigurationSettingNonComplianceReportCommand());
            command.AddCommand(builder.BuildGetDeviceManagementIntentPerSettingContributingProfilesCommand());
            command.AddCommand(builder.BuildGetDeviceManagementIntentSettingsReportCommand());
            command.AddCommand(builder.BuildGetDeviceNonComplianceReportCommand());
            command.AddCommand(builder.BuildGetDevicesWithoutCompliancePolicyReportCommand());
            command.AddCommand(builder.BuildGetHistoricalReportCommand());
            command.AddCommand(builder.BuildGetNoncompliantDevicesAndSettingsReportCommand());
            command.AddCommand(builder.BuildGetPolicyNonComplianceMetadataCommand());
            command.AddCommand(builder.BuildGetPolicyNonComplianceReportCommand());
            command.AddCommand(builder.BuildGetPolicyNonComplianceSummaryReportCommand());
            command.AddCommand(builder.BuildGetReportFiltersCommand());
            command.AddCommand(builder.BuildGetSettingNonComplianceReportCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the resourceOperations property of the microsoft.graph.deviceManagement entity.
        /// </summary>
        public Command BuildResourceOperationsCommand() {
            var command = new Command("resource-operations");
            command.Description = "Provides operations to manage the resourceOperations property of the microsoft.graph.deviceManagement entity.";
            var builder = new ResourceOperationsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the roleAssignments property of the microsoft.graph.deviceManagement entity.
        /// </summary>
        public Command BuildRoleAssignmentsCommand() {
            var command = new Command("role-assignments");
            command.Description = "Provides operations to manage the roleAssignments property of the microsoft.graph.deviceManagement entity.";
            var builder = new RoleAssignmentsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the roleDefinitions property of the microsoft.graph.deviceManagement entity.
        /// </summary>
        public Command BuildRoleDefinitionsCommand() {
            var command = new Command("role-definitions");
            command.Description = "Provides operations to manage the roleDefinitions property of the microsoft.graph.deviceManagement entity.";
            var builder = new RoleDefinitionsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the softwareUpdateStatusSummary property of the microsoft.graph.deviceManagement entity.
        /// </summary>
        public Command BuildSoftwareUpdateStatusSummaryCommand() {
            var command = new Command("software-update-status-summary");
            command.Description = "Provides operations to manage the softwareUpdateStatusSummary property of the microsoft.graph.deviceManagement entity.";
            var builder = new SoftwareUpdateStatusSummaryRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the telecomExpenseManagementPartners property of the microsoft.graph.deviceManagement entity.
        /// </summary>
        public Command BuildTelecomExpenseManagementPartnersCommand() {
            var command = new Command("telecom-expense-management-partners");
            command.Description = "Provides operations to manage the telecomExpenseManagementPartners property of the microsoft.graph.deviceManagement entity.";
            var builder = new TelecomExpenseManagementPartnersRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the termsAndConditions property of the microsoft.graph.deviceManagement entity.
        /// </summary>
        public Command BuildTermsAndConditionsCommand() {
            var command = new Command("terms-and-conditions");
            command.Description = "Provides operations to manage the termsAndConditions property of the microsoft.graph.deviceManagement entity.";
            var builder = new TermsAndConditionsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the troubleshootingEvents property of the microsoft.graph.deviceManagement entity.
        /// </summary>
        public Command BuildTroubleshootingEventsCommand() {
            var command = new Command("troubleshooting-events");
            command.Description = "Provides operations to manage the troubleshootingEvents property of the microsoft.graph.deviceManagement entity.";
            var builder = new TroubleshootingEventsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the windowsAutopilotDeviceIdentities property of the microsoft.graph.deviceManagement entity.
        /// </summary>
        public Command BuildWindowsAutopilotDeviceIdentitiesCommand() {
            var command = new Command("windows-autopilot-device-identities");
            command.Description = "Provides operations to manage the windowsAutopilotDeviceIdentities property of the microsoft.graph.deviceManagement entity.";
            var builder = new WindowsAutopilotDeviceIdentitiesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the windowsInformationProtectionAppLearningSummaries property of the microsoft.graph.deviceManagement entity.
        /// </summary>
        public Command BuildWindowsInformationProtectionAppLearningSummariesCommand() {
            var command = new Command("windows-information-protection-app-learning-summaries");
            command.Description = "Provides operations to manage the windowsInformationProtectionAppLearningSummaries property of the microsoft.graph.deviceManagement entity.";
            var builder = new WindowsInformationProtectionAppLearningSummariesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the windowsInformationProtectionNetworkLearningSummaries property of the microsoft.graph.deviceManagement entity.
        /// </summary>
        public Command BuildWindowsInformationProtectionNetworkLearningSummariesCommand() {
            var command = new Command("windows-information-protection-network-learning-summaries");
            command.Description = "Provides operations to manage the windowsInformationProtectionNetworkLearningSummaries property of the microsoft.graph.deviceManagement entity.";
            var builder = new WindowsInformationProtectionNetworkLearningSummariesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new DeviceManagementRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DeviceManagementRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Provides operations to call the getEffectivePermissions method.
        /// </summary>
        /// <param name="scope">Usage: scope=&apos;{scope}&apos;</param>
        public GetEffectivePermissionsWithScopeRequestBuilder GetEffectivePermissionsWithScope(string scope) {
            if(string.IsNullOrEmpty(scope)) throw new ArgumentNullException(nameof(scope));
            return new GetEffectivePermissionsWithScopeRequestBuilder(PathParameters, RequestAdapter, scope);
        }
        /// <summary>
        /// Get deviceManagement
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<DeviceManagementRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<DeviceManagementRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new DeviceManagementRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update deviceManagement
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(ApiSdk.Models.DeviceManagement body, Action<DeviceManagementRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(ApiSdk.Models.DeviceManagement body, Action<DeviceManagementRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new DeviceManagementRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Provides operations to call the verifyWindowsEnrollmentAutoDiscovery method.
        /// </summary>
        /// <param name="domainName">Usage: domainName=&apos;{domainName}&apos;</param>
        public VerifyWindowsEnrollmentAutoDiscoveryWithDomainNameRequestBuilder VerifyWindowsEnrollmentAutoDiscoveryWithDomainName(string domainName) {
            if(string.IsNullOrEmpty(domainName)) throw new ArgumentNullException(nameof(domainName));
            return new VerifyWindowsEnrollmentAutoDiscoveryWithDomainNameRequestBuilder(PathParameters, RequestAdapter, domainName);
        }
        /// <summary>
        /// Get deviceManagement
        /// </summary>
        public class DeviceManagementRequestBuilderGetQueryParameters {
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class DeviceManagementRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public DeviceManagementRequestBuilderGetQueryParameters QueryParameters { get; set; } = new DeviceManagementRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new deviceManagementRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public DeviceManagementRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class DeviceManagementRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new deviceManagementRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public DeviceManagementRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
