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
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class DeviceManagementRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public Command BuildApplePushNotificationCertificateCommand() {
            var command = new Command("apple-push-notification-certificate");
            var builder = new ApplePushNotificationCertificateRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        public Command BuildComplianceManagementPartnersCommand() {
            var command = new Command("compliance-management-partners");
            var builder = new ComplianceManagementPartnersRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildConditionalAccessSettingsCommand() {
            var command = new Command("conditional-access-settings");
            var builder = new ConditionalAccessSettingsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        public Command BuildDetectedAppsCommand() {
            var command = new Command("detected-apps");
            var builder = new DetectedAppsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildDeviceCategoriesCommand() {
            var command = new Command("device-categories");
            var builder = new DeviceCategoriesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildDeviceCompliancePoliciesCommand() {
            var command = new Command("device-compliance-policies");
            var builder = new DeviceCompliancePoliciesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildDeviceCompliancePolicyDeviceStateSummaryCommand() {
            var command = new Command("device-compliance-policy-device-state-summary");
            var builder = new DeviceCompliancePolicyDeviceStateSummaryRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        public Command BuildDeviceCompliancePolicySettingStateSummariesCommand() {
            var command = new Command("device-compliance-policy-setting-state-summaries");
            var builder = new DeviceCompliancePolicySettingStateSummariesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildDeviceConfigurationDeviceStateSummariesCommand() {
            var command = new Command("device-configuration-device-state-summaries");
            var builder = new DeviceConfigurationDeviceStateSummariesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        public Command BuildDeviceConfigurationsCommand() {
            var command = new Command("device-configurations");
            var builder = new DeviceConfigurationsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildDeviceEnrollmentConfigurationsCommand() {
            var command = new Command("device-enrollment-configurations");
            var builder = new DeviceEnrollmentConfigurationsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildDeviceManagementPartnersCommand() {
            var command = new Command("device-management-partners");
            var builder = new DeviceManagementPartnersRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildExchangeConnectorsCommand() {
            var command = new Command("exchange-connectors");
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
                var requestInfo = CreateGetRequestInformation(q => {
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
        public Command BuildImportedWindowsAutopilotDeviceIdentitiesCommand() {
            var command = new Command("imported-windows-autopilot-device-identities");
            var builder = new ImportedWindowsAutopilotDeviceIdentitiesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildImportCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildIosUpdateStatusesCommand() {
            var command = new Command("ios-update-statuses");
            var builder = new IosUpdateStatusesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildManagedDeviceOverviewCommand() {
            var command = new Command("managed-device-overview");
            var builder = new ManagedDeviceOverviewRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        public Command BuildManagedDevicesCommand() {
            var command = new Command("managed-devices");
            var builder = new ManagedDevicesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildMobileThreatDefenseConnectorsCommand() {
            var command = new Command("mobile-threat-defense-connectors");
            var builder = new MobileThreatDefenseConnectorsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildNotificationMessageTemplatesCommand() {
            var command = new Command("notification-message-templates");
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
            var bodyOption = new Option<string>("--body") {
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
                var requestInfo = CreatePatchRequestInformation(model, q => {
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
        public Command BuildRemoteAssistancePartnersCommand() {
            var command = new Command("remote-assistance-partners");
            var builder = new RemoteAssistancePartnersRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildReportsCommand() {
            var command = new Command("reports");
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
        public Command BuildResourceOperationsCommand() {
            var command = new Command("resource-operations");
            var builder = new ResourceOperationsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildRoleAssignmentsCommand() {
            var command = new Command("role-assignments");
            var builder = new RoleAssignmentsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildRoleDefinitionsCommand() {
            var command = new Command("role-definitions");
            var builder = new RoleDefinitionsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildSoftwareUpdateStatusSummaryCommand() {
            var command = new Command("software-update-status-summary");
            var builder = new SoftwareUpdateStatusSummaryRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        public Command BuildTelecomExpenseManagementPartnersCommand() {
            var command = new Command("telecom-expense-management-partners");
            var builder = new TelecomExpenseManagementPartnersRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildTermsAndConditionsCommand() {
            var command = new Command("terms-and-conditions");
            var builder = new TermsAndConditionsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildTroubleshootingEventsCommand() {
            var command = new Command("troubleshooting-events");
            var builder = new TroubleshootingEventsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildWindowsAutopilotDeviceIdentitiesCommand() {
            var command = new Command("windows-autopilot-device-identities");
            var builder = new WindowsAutopilotDeviceIdentitiesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildWindowsInformationProtectionAppLearningSummariesCommand() {
            var command = new Command("windows-information-protection-app-learning-summaries");
            var builder = new WindowsInformationProtectionAppLearningSummariesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildWindowsInformationProtectionNetworkLearningSummariesCommand() {
            var command = new Command("windows-information-protection-network-learning-summaries");
            var builder = new WindowsInformationProtectionNetworkLearningSummariesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
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
            UrlTemplate = "{+baseurl}/deviceManagement{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Get deviceManagement
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<DeviceManagementRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
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
        /// <param name="body"></param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(ApiSdk.Models.DeviceManagement body, Action<DeviceManagementRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
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
        /// Provides operations to call the getEffectivePermissions method.
        /// <param name="scope">Usage: scope=&apos;{scope}&apos;</param>
        /// </summary>
        public GetEffectivePermissionsWithScopeRequestBuilder GetEffectivePermissionsWithScope(string scope) {
            if(string.IsNullOrEmpty(scope)) throw new ArgumentNullException(nameof(scope));
            return new GetEffectivePermissionsWithScopeRequestBuilder(PathParameters, RequestAdapter, scope);
        }
        /// <summary>
        /// Provides operations to call the verifyWindowsEnrollmentAutoDiscovery method.
        /// <param name="domainName">Usage: domainName=&apos;{domainName}&apos;</param>
        /// </summary>
        public VerifyWindowsEnrollmentAutoDiscoveryWithDomainNameRequestBuilder VerifyWindowsEnrollmentAutoDiscoveryWithDomainName(string domainName) {
            if(string.IsNullOrEmpty(domainName)) throw new ArgumentNullException(nameof(domainName));
            return new VerifyWindowsEnrollmentAutoDiscoveryWithDomainNameRequestBuilder(PathParameters, RequestAdapter, domainName);
        }
        /// <summary>Get deviceManagement</summary>
        public class DeviceManagementRequestBuilderGetQueryParameters {
            /// <summary>Expand related entities</summary>
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class DeviceManagementRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public DeviceManagementRequestBuilderGetQueryParameters QueryParameters { get; set; } = new DeviceManagementRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new deviceManagementRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public DeviceManagementRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class DeviceManagementRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new deviceManagementRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public DeviceManagementRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
    }
}
