using ApiSdk.DeviceManagement.ApplePushNotificationCertificate;
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
using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Cli.Commons.Binding;
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
    /// <summary>Builds and executes requests for operations under \deviceManagement</summary>
    public class DeviceManagementRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public Command BuildApplePushNotificationCertificateCommand() {
            var command = new Command("apple-push-notification-certificate");
            var builder = new ApiSdk.DeviceManagement.ApplePushNotificationCertificate.ApplePushNotificationCertificateRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        public Command BuildComplianceManagementPartnersCommand() {
            var command = new Command("compliance-management-partners");
            var builder = new ApiSdk.DeviceManagement.ComplianceManagementPartners.ComplianceManagementPartnersRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildConditionalAccessSettingsCommand() {
            var command = new Command("conditional-access-settings");
            var builder = new ApiSdk.DeviceManagement.ConditionalAccessSettings.ConditionalAccessSettingsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        public Command BuildDetectedAppsCommand() {
            var command = new Command("detected-apps");
            var builder = new ApiSdk.DeviceManagement.DetectedApps.DetectedAppsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildDeviceCategoriesCommand() {
            var command = new Command("device-categories");
            var builder = new ApiSdk.DeviceManagement.DeviceCategories.DeviceCategoriesRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildDeviceCompliancePoliciesCommand() {
            var command = new Command("device-compliance-policies");
            var builder = new ApiSdk.DeviceManagement.DeviceCompliancePolicies.DeviceCompliancePoliciesRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildDeviceCompliancePolicyDeviceStateSummaryCommand() {
            var command = new Command("device-compliance-policy-device-state-summary");
            var builder = new ApiSdk.DeviceManagement.DeviceCompliancePolicyDeviceStateSummary.DeviceCompliancePolicyDeviceStateSummaryRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        public Command BuildDeviceCompliancePolicySettingStateSummariesCommand() {
            var command = new Command("device-compliance-policy-setting-state-summaries");
            var builder = new ApiSdk.DeviceManagement.DeviceCompliancePolicySettingStateSummaries.DeviceCompliancePolicySettingStateSummariesRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildDeviceConfigurationDeviceStateSummariesCommand() {
            var command = new Command("device-configuration-device-state-summaries");
            var builder = new ApiSdk.DeviceManagement.DeviceConfigurationDeviceStateSummaries.DeviceConfigurationDeviceStateSummariesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        public Command BuildDeviceConfigurationsCommand() {
            var command = new Command("device-configurations");
            var builder = new ApiSdk.DeviceManagement.DeviceConfigurations.DeviceConfigurationsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildDeviceEnrollmentConfigurationsCommand() {
            var command = new Command("device-enrollment-configurations");
            var builder = new ApiSdk.DeviceManagement.DeviceEnrollmentConfigurations.DeviceEnrollmentConfigurationsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildDeviceManagementPartnersCommand() {
            var command = new Command("device-management-partners");
            var builder = new ApiSdk.DeviceManagement.DeviceManagementPartners.DeviceManagementPartnersRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildExchangeConnectorsCommand() {
            var command = new Command("exchange-connectors");
            var builder = new ApiSdk.DeviceManagement.ExchangeConnectors.ExchangeConnectorsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
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
            var outputFilterOption = new Option<string>("--query");
            command.AddOption(outputFilterOption);
            command.SetHandler(async (object[] parameters) => {
                var select = (string[]) parameters[0];
                var expand = (string[]) parameters[1];
                var output = (FormatterType) parameters[2];
                var outputFilterOption = (string) parameters[3];
                var outputFormatterFactory = (IOutputFormatterFactory) parameters[4];
                var cancellationToken = (CancellationToken) parameters[5];
                var requestInfo = CreateGetRequestInformation(q => {
                    q.Select = select;
                    q.Expand = expand;
                });
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                var formatter = outputFormatterFactory.GetFormatter(output);
                formatter.WriteOutput(response);
            }, new CollectionBinding(selectOption, expandOption, outputOption, outputFilterOption, new TypeBinding(typeof(IOutputFormatterFactory)), new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        public Command BuildImportedWindowsAutopilotDeviceIdentitiesCommand() {
            var command = new Command("imported-windows-autopilot-device-identities");
            var builder = new ApiSdk.DeviceManagement.ImportedWindowsAutopilotDeviceIdentities.ImportedWindowsAutopilotDeviceIdentitiesRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildImportCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildIosUpdateStatusesCommand() {
            var command = new Command("ios-update-statuses");
            var builder = new ApiSdk.DeviceManagement.IosUpdateStatuses.IosUpdateStatusesRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildManagedDeviceOverviewCommand() {
            var command = new Command("managed-device-overview");
            var builder = new ApiSdk.DeviceManagement.ManagedDeviceOverview.ManagedDeviceOverviewRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        public Command BuildManagedDevicesCommand() {
            var command = new Command("managed-devices");
            var builder = new ApiSdk.DeviceManagement.ManagedDevices.ManagedDevicesRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildMobileThreatDefenseConnectorsCommand() {
            var command = new Command("mobile-threat-defense-connectors");
            var builder = new ApiSdk.DeviceManagement.MobileThreatDefenseConnectors.MobileThreatDefenseConnectorsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildNotificationMessageTemplatesCommand() {
            var command = new Command("notification-message-templates");
            var builder = new ApiSdk.DeviceManagement.NotificationMessageTemplates.NotificationMessageTemplatesRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
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
            var bodyOption = new Option<string>("--body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (object[] parameters) => {
                var body = (string) parameters[0];
                var cancellationToken = (CancellationToken) parameters[1];
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ApiSdk.Models.Microsoft.Graph.DeviceManagement>();
                var requestInfo = CreatePatchRequestInformation(model, q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(bodyOption, new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        public Command BuildRemoteAssistancePartnersCommand() {
            var command = new Command("remote-assistance-partners");
            var builder = new ApiSdk.DeviceManagement.RemoteAssistancePartners.RemoteAssistancePartnersRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildReportsCommand() {
            var command = new Command("reports");
            var builder = new ApiSdk.DeviceManagement.Reports.ReportsRequestBuilder(PathParameters, RequestAdapter);
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
            command.AddCommand(builder.BuildGetHistoricalReportCommand());
            command.AddCommand(builder.BuildGetPolicyNonComplianceMetadataCommand());
            command.AddCommand(builder.BuildGetPolicyNonComplianceReportCommand());
            command.AddCommand(builder.BuildGetPolicyNonComplianceSummaryReportCommand());
            command.AddCommand(builder.BuildGetReportFiltersCommand());
            command.AddCommand(builder.BuildGetSettingNonComplianceReportCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        public Command BuildResourceOperationsCommand() {
            var command = new Command("resource-operations");
            var builder = new ApiSdk.DeviceManagement.ResourceOperations.ResourceOperationsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildRoleAssignmentsCommand() {
            var command = new Command("role-assignments");
            var builder = new ApiSdk.DeviceManagement.RoleAssignments.RoleAssignmentsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildRoleDefinitionsCommand() {
            var command = new Command("role-definitions");
            var builder = new ApiSdk.DeviceManagement.RoleDefinitions.RoleDefinitionsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildSoftwareUpdateStatusSummaryCommand() {
            var command = new Command("software-update-status-summary");
            var builder = new ApiSdk.DeviceManagement.SoftwareUpdateStatusSummary.SoftwareUpdateStatusSummaryRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        public Command BuildTelecomExpenseManagementPartnersCommand() {
            var command = new Command("telecom-expense-management-partners");
            var builder = new ApiSdk.DeviceManagement.TelecomExpenseManagementPartners.TelecomExpenseManagementPartnersRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildTermsAndConditionsCommand() {
            var command = new Command("terms-and-conditions");
            var builder = new ApiSdk.DeviceManagement.TermsAndConditions.TermsAndConditionsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildTroubleshootingEventsCommand() {
            var command = new Command("troubleshooting-events");
            var builder = new ApiSdk.DeviceManagement.TroubleshootingEvents.TroubleshootingEventsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildWindowsAutopilotDeviceIdentitiesCommand() {
            var command = new Command("windows-autopilot-device-identities");
            var builder = new ApiSdk.DeviceManagement.WindowsAutopilotDeviceIdentities.WindowsAutopilotDeviceIdentitiesRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildWindowsInformationProtectionAppLearningSummariesCommand() {
            var command = new Command("windows-information-protection-app-learning-summaries");
            var builder = new ApiSdk.DeviceManagement.WindowsInformationProtectionAppLearningSummaries.WindowsInformationProtectionAppLearningSummariesRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildWindowsInformationProtectionNetworkLearningSummariesCommand() {
            var command = new Command("windows-information-protection-network-learning-summaries");
            var builder = new ApiSdk.DeviceManagement.WindowsInformationProtectionNetworkLearningSummaries.WindowsInformationProtectionNetworkLearningSummariesRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new DeviceManagementRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public DeviceManagementRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Get deviceManagement
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (q != null) {
                var qParams = new GetQueryParameters();
                q.Invoke(qParams);
                qParams.AddQueryParameters(requestInfo.QueryParameters);
            }
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Update deviceManagement
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(ApiSdk.Models.Microsoft.Graph.DeviceManagement body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Builds and executes requests for operations under \deviceManagement\microsoft.graph.getEffectivePermissions(scope='{scope}')
        /// <param name="scope">Usage: scope={scope}</param>
        /// </summary>
        public GetEffectivePermissionsWithScopeRequestBuilder GetEffectivePermissionsWithScope(string scope) {
            if(string.IsNullOrEmpty(scope)) throw new ArgumentNullException(nameof(scope));
            return new GetEffectivePermissionsWithScopeRequestBuilder(PathParameters, RequestAdapter, scope);
        }
        /// <summary>
        /// Builds and executes requests for operations under \deviceManagement\microsoft.graph.verifyWindowsEnrollmentAutoDiscovery(domainName='{domainName}')
        /// <param name="domainName">Usage: domainName={domainName}</param>
        /// </summary>
        public VerifyWindowsEnrollmentAutoDiscoveryWithDomainNameRequestBuilder VerifyWindowsEnrollmentAutoDiscoveryWithDomainName(string domainName) {
            if(string.IsNullOrEmpty(domainName)) throw new ArgumentNullException(nameof(domainName));
            return new VerifyWindowsEnrollmentAutoDiscoveryWithDomainNameRequestBuilder(PathParameters, RequestAdapter, domainName);
        }
        /// <summary>Get deviceManagement</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
