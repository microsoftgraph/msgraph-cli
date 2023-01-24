using ApiSdk.DeviceManagement.Reports.ExportJobs;
using ApiSdk.DeviceManagement.Reports.GetCachedReport;
using ApiSdk.DeviceManagement.Reports.GetCompliancePolicyNonComplianceReport;
using ApiSdk.DeviceManagement.Reports.GetCompliancePolicyNonComplianceSummaryReport;
using ApiSdk.DeviceManagement.Reports.GetComplianceSettingNonComplianceReport;
using ApiSdk.DeviceManagement.Reports.GetConfigurationPolicyNonComplianceReport;
using ApiSdk.DeviceManagement.Reports.GetConfigurationPolicyNonComplianceSummaryReport;
using ApiSdk.DeviceManagement.Reports.GetConfigurationSettingNonComplianceReport;
using ApiSdk.DeviceManagement.Reports.GetDeviceManagementIntentPerSettingContributingProfiles;
using ApiSdk.DeviceManagement.Reports.GetDeviceManagementIntentSettingsReport;
using ApiSdk.DeviceManagement.Reports.GetDeviceNonComplianceReport;
using ApiSdk.DeviceManagement.Reports.GetDevicesWithoutCompliancePolicyReport;
using ApiSdk.DeviceManagement.Reports.GetHistoricalReport;
using ApiSdk.DeviceManagement.Reports.GetNoncompliantDevicesAndSettingsReport;
using ApiSdk.DeviceManagement.Reports.GetPolicyNonComplianceMetadata;
using ApiSdk.DeviceManagement.Reports.GetPolicyNonComplianceReport;
using ApiSdk.DeviceManagement.Reports.GetPolicyNonComplianceSummaryReport;
using ApiSdk.DeviceManagement.Reports.GetReportFilters;
using ApiSdk.DeviceManagement.Reports.GetSettingNonComplianceReport;
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
namespace ApiSdk.DeviceManagement.Reports {
    /// <summary>
    /// Provides operations to manage the reports property of the microsoft.graph.deviceManagement entity.
    /// </summary>
    public class ReportsRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Delete navigation property reports for deviceManagement
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Delete navigation property reports for deviceManagement";
            // Create options for all the parameters
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                requestInfo.Headers.Add("If-Match", ifMatch);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            });
            return command;
        }
        /// <summary>
        /// Provides operations to manage the exportJobs property of the microsoft.graph.deviceManagementReports entity.
        /// </summary>
        public Command BuildExportJobsCommand() {
            var command = new Command("export-jobs");
            command.Description = "Provides operations to manage the exportJobs property of the microsoft.graph.deviceManagementReports entity.";
            var builder = new ExportJobsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the getCachedReport method.
        /// </summary>
        public Command BuildGetCachedReportCommand() {
            var command = new Command("get-cached-report");
            command.Description = "Provides operations to call the getCachedReport method.";
            var builder = new GetCachedReportRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Reports singleton
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Reports singleton";
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
        /// Provides operations to call the getCompliancePolicyNonComplianceReport method.
        /// </summary>
        public Command BuildGetCompliancePolicyNonComplianceReportCommand() {
            var command = new Command("get-compliance-policy-non-compliance-report");
            command.Description = "Provides operations to call the getCompliancePolicyNonComplianceReport method.";
            var builder = new GetCompliancePolicyNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the getCompliancePolicyNonComplianceSummaryReport method.
        /// </summary>
        public Command BuildGetCompliancePolicyNonComplianceSummaryReportCommand() {
            var command = new Command("get-compliance-policy-non-compliance-summary-report");
            command.Description = "Provides operations to call the getCompliancePolicyNonComplianceSummaryReport method.";
            var builder = new GetCompliancePolicyNonComplianceSummaryReportRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the getComplianceSettingNonComplianceReport method.
        /// </summary>
        public Command BuildGetComplianceSettingNonComplianceReportCommand() {
            var command = new Command("get-compliance-setting-non-compliance-report");
            command.Description = "Provides operations to call the getComplianceSettingNonComplianceReport method.";
            var builder = new GetComplianceSettingNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the getConfigurationPolicyNonComplianceReport method.
        /// </summary>
        public Command BuildGetConfigurationPolicyNonComplianceReportCommand() {
            var command = new Command("get-configuration-policy-non-compliance-report");
            command.Description = "Provides operations to call the getConfigurationPolicyNonComplianceReport method.";
            var builder = new GetConfigurationPolicyNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the getConfigurationPolicyNonComplianceSummaryReport method.
        /// </summary>
        public Command BuildGetConfigurationPolicyNonComplianceSummaryReportCommand() {
            var command = new Command("get-configuration-policy-non-compliance-summary-report");
            command.Description = "Provides operations to call the getConfigurationPolicyNonComplianceSummaryReport method.";
            var builder = new GetConfigurationPolicyNonComplianceSummaryReportRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the getConfigurationSettingNonComplianceReport method.
        /// </summary>
        public Command BuildGetConfigurationSettingNonComplianceReportCommand() {
            var command = new Command("get-configuration-setting-non-compliance-report");
            command.Description = "Provides operations to call the getConfigurationSettingNonComplianceReport method.";
            var builder = new GetConfigurationSettingNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the getDeviceManagementIntentPerSettingContributingProfiles method.
        /// </summary>
        public Command BuildGetDeviceManagementIntentPerSettingContributingProfilesCommand() {
            var command = new Command("get-device-management-intent-per-setting-contributing-profiles");
            command.Description = "Provides operations to call the getDeviceManagementIntentPerSettingContributingProfiles method.";
            var builder = new GetDeviceManagementIntentPerSettingContributingProfilesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the getDeviceManagementIntentSettingsReport method.
        /// </summary>
        public Command BuildGetDeviceManagementIntentSettingsReportCommand() {
            var command = new Command("get-device-management-intent-settings-report");
            command.Description = "Provides operations to call the getDeviceManagementIntentSettingsReport method.";
            var builder = new GetDeviceManagementIntentSettingsReportRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the getDeviceNonComplianceReport method.
        /// </summary>
        public Command BuildGetDeviceNonComplianceReportCommand() {
            var command = new Command("get-device-non-compliance-report");
            command.Description = "Provides operations to call the getDeviceNonComplianceReport method.";
            var builder = new GetDeviceNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the getDevicesWithoutCompliancePolicyReport method.
        /// </summary>
        public Command BuildGetDevicesWithoutCompliancePolicyReportCommand() {
            var command = new Command("get-devices-without-compliance-policy-report");
            command.Description = "Provides operations to call the getDevicesWithoutCompliancePolicyReport method.";
            var builder = new GetDevicesWithoutCompliancePolicyReportRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the getHistoricalReport method.
        /// </summary>
        public Command BuildGetHistoricalReportCommand() {
            var command = new Command("get-historical-report");
            command.Description = "Provides operations to call the getHistoricalReport method.";
            var builder = new GetHistoricalReportRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the getNoncompliantDevicesAndSettingsReport method.
        /// </summary>
        public Command BuildGetNoncompliantDevicesAndSettingsReportCommand() {
            var command = new Command("get-noncompliant-devices-and-settings-report");
            command.Description = "Provides operations to call the getNoncompliantDevicesAndSettingsReport method.";
            var builder = new GetNoncompliantDevicesAndSettingsReportRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the getPolicyNonComplianceMetadata method.
        /// </summary>
        public Command BuildGetPolicyNonComplianceMetadataCommand() {
            var command = new Command("get-policy-non-compliance-metadata");
            command.Description = "Provides operations to call the getPolicyNonComplianceMetadata method.";
            var builder = new GetPolicyNonComplianceMetadataRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the getPolicyNonComplianceReport method.
        /// </summary>
        public Command BuildGetPolicyNonComplianceReportCommand() {
            var command = new Command("get-policy-non-compliance-report");
            command.Description = "Provides operations to call the getPolicyNonComplianceReport method.";
            var builder = new GetPolicyNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the getPolicyNonComplianceSummaryReport method.
        /// </summary>
        public Command BuildGetPolicyNonComplianceSummaryReportCommand() {
            var command = new Command("get-policy-non-compliance-summary-report");
            command.Description = "Provides operations to call the getPolicyNonComplianceSummaryReport method.";
            var builder = new GetPolicyNonComplianceSummaryReportRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the getReportFilters method.
        /// </summary>
        public Command BuildGetReportFiltersCommand() {
            var command = new Command("get-report-filters");
            command.Description = "Provides operations to call the getReportFilters method.";
            var builder = new GetReportFiltersRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the getSettingNonComplianceReport method.
        /// </summary>
        public Command BuildGetSettingNonComplianceReportCommand() {
            var command = new Command("get-setting-non-compliance-report");
            command.Description = "Provides operations to call the getSettingNonComplianceReport method.";
            var builder = new GetSettingNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Update the navigation property reports in deviceManagement
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Update the navigation property reports in deviceManagement";
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
                var model = parseNode.GetObjectValue<DeviceManagementReports>(DeviceManagementReports.CreateFromDiscriminatorValue);
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
        /// Instantiates a new ReportsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ReportsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/reports{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete navigation property reports for deviceManagement
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<ReportsRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<ReportsRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new ReportsRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Reports singleton
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<ReportsRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<ReportsRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new ReportsRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property reports in deviceManagement
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(DeviceManagementReports body, Action<ReportsRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(DeviceManagementReports body, Action<ReportsRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
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
                var requestConfig = new ReportsRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class ReportsRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new reportsRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public ReportsRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Reports singleton
        /// </summary>
        public class ReportsRequestBuilderGetQueryParameters {
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
        public class ReportsRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public ReportsRequestBuilderGetQueryParameters QueryParameters { get; set; } = new ReportsRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new reportsRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public ReportsRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class ReportsRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new reportsRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public ReportsRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
