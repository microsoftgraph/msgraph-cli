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
using ApiSdk.DeviceManagement.Reports.GetHistoricalReport;
using ApiSdk.DeviceManagement.Reports.GetPolicyNonComplianceMetadata;
using ApiSdk.DeviceManagement.Reports.GetPolicyNonComplianceReport;
using ApiSdk.DeviceManagement.Reports.GetPolicyNonComplianceSummaryReport;
using ApiSdk.DeviceManagement.Reports.GetReportFilters;
using ApiSdk.DeviceManagement.Reports.GetSettingNonComplianceReport;
using ApiSdk.Models.Microsoft.Graph;
using ApiSdk.Models.Microsoft.Graph.ODataErrors;
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
namespace ApiSdk.DeviceManagement.Reports {
    /// <summary>Provides operations to manage the reports property of the microsoft.graph.deviceManagement entity.</summary>
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
            command.SetHandler(async (object[] parameters) => {
                var cancellationToken = (CancellationToken) parameters[0];
                var requestInfo = CreateDeleteRequestInformation(q => {
                });
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        public Command BuildExportJobsCommand() {
            var command = new Command("export-jobs");
            var builder = new ExportJobsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildGetCachedReportCommand() {
            var command = new Command("get-cached-report");
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
            command.SetHandler(async (object[] parameters) => {
                var select = (string[]) parameters[0];
                var expand = (string[]) parameters[1];
                var output = (FormatterType) parameters[2];
                var query = (string) parameters[3];
                var jsonNoIndent = (bool) parameters[4];
                var outputFilter = (IOutputFilter) parameters[5];
                var outputFormatterFactory = (IOutputFormatterFactory) parameters[6];
                var cancellationToken = (CancellationToken) parameters[7];
                var requestInfo = CreateGetRequestInformation(q => {
                    q.Select = select;
                    q.Expand = expand;
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
            }, new CollectionBinding(selectOption, expandOption, outputOption, queryOption, jsonNoIndentOption, new TypeBinding(typeof(IOutputFilter)), new TypeBinding(typeof(IOutputFormatterFactory)), new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        public Command BuildGetCompliancePolicyNonComplianceReportCommand() {
            var command = new Command("get-compliance-policy-non-compliance-report");
            var builder = new GetCompliancePolicyNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildGetCompliancePolicyNonComplianceSummaryReportCommand() {
            var command = new Command("get-compliance-policy-non-compliance-summary-report");
            var builder = new GetCompliancePolicyNonComplianceSummaryReportRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildGetComplianceSettingNonComplianceReportCommand() {
            var command = new Command("get-compliance-setting-non-compliance-report");
            var builder = new GetComplianceSettingNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildGetConfigurationPolicyNonComplianceReportCommand() {
            var command = new Command("get-configuration-policy-non-compliance-report");
            var builder = new GetConfigurationPolicyNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildGetConfigurationPolicyNonComplianceSummaryReportCommand() {
            var command = new Command("get-configuration-policy-non-compliance-summary-report");
            var builder = new GetConfigurationPolicyNonComplianceSummaryReportRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildGetConfigurationSettingNonComplianceReportCommand() {
            var command = new Command("get-configuration-setting-non-compliance-report");
            var builder = new GetConfigurationSettingNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildGetDeviceManagementIntentPerSettingContributingProfilesCommand() {
            var command = new Command("get-device-management-intent-per-setting-contributing-profiles");
            var builder = new GetDeviceManagementIntentPerSettingContributingProfilesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildGetDeviceManagementIntentSettingsReportCommand() {
            var command = new Command("get-device-management-intent-settings-report");
            var builder = new GetDeviceManagementIntentSettingsReportRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildGetDeviceNonComplianceReportCommand() {
            var command = new Command("get-device-non-compliance-report");
            var builder = new GetDeviceNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildGetHistoricalReportCommand() {
            var command = new Command("get-historical-report");
            var builder = new GetHistoricalReportRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildGetPolicyNonComplianceMetadataCommand() {
            var command = new Command("get-policy-non-compliance-metadata");
            var builder = new GetPolicyNonComplianceMetadataRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildGetPolicyNonComplianceReportCommand() {
            var command = new Command("get-policy-non-compliance-report");
            var builder = new GetPolicyNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildGetPolicyNonComplianceSummaryReportCommand() {
            var command = new Command("get-policy-non-compliance-summary-report");
            var builder = new GetPolicyNonComplianceSummaryReportRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildGetReportFiltersCommand() {
            var command = new Command("get-report-filters");
            var builder = new GetReportFiltersRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildGetSettingNonComplianceReportCommand() {
            var command = new Command("get-setting-non-compliance-report");
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
            var bodyOption = new Option<string>("--body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (object[] parameters) => {
                var body = (string) parameters[0];
                var cancellationToken = (CancellationToken) parameters[1];
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<DeviceManagementReports>(DeviceManagementReports.CreateFromDiscriminatorValue);
                var requestInfo = CreatePatchRequestInformation(model, q => {
                });
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(bodyOption, new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// Instantiates a new ReportsRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public ReportsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/reports{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete navigation property reports for deviceManagement
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// </summary>
        public RequestInformation CreateDeleteRequestInformation(Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            headers?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(options?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Reports singleton
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// <param name="queryParameters">Request query parameters</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<GetQueryParameters> queryParameters = default, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (queryParameters != null) {
                var qParams = new GetQueryParameters();
                queryParameters.Invoke(qParams);
                qParams.AddQueryParameters(requestInfo.QueryParameters);
            }
            headers?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(options?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property reports in deviceManagement
        /// <param name="body"></param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(DeviceManagementReports body, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            headers?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(options?.ToArray());
            return requestInfo;
        }
        /// <summary>Reports singleton</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
