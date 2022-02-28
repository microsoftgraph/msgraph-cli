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
    /// <summary>Builds and executes requests for operations under \deviceManagement\reports</summary>
    public class ReportsRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Reports singleton
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Reports singleton";
            // Create options for all the parameters
            command.SetHandler(async (object[] parameters) => {
                var cancellationToken = (CancellationToken) parameters[0];
                var requestInfo = CreateDeleteRequestInformation(q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        public Command BuildExportJobsCommand() {
            var command = new Command("export-jobs");
            var builder = new ApiSdk.DeviceManagement.Reports.ExportJobs.ExportJobsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildGetCachedReportCommand() {
            var command = new Command("get-cached-report");
            var builder = new ApiSdk.DeviceManagement.Reports.GetCachedReport.GetCachedReportRequestBuilder(PathParameters, RequestAdapter);
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
        public Command BuildGetCompliancePolicyNonComplianceReportCommand() {
            var command = new Command("get-compliance-policy-non-compliance-report");
            var builder = new ApiSdk.DeviceManagement.Reports.GetCompliancePolicyNonComplianceReport.GetCompliancePolicyNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildGetCompliancePolicyNonComplianceSummaryReportCommand() {
            var command = new Command("get-compliance-policy-non-compliance-summary-report");
            var builder = new ApiSdk.DeviceManagement.Reports.GetCompliancePolicyNonComplianceSummaryReport.GetCompliancePolicyNonComplianceSummaryReportRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildGetComplianceSettingNonComplianceReportCommand() {
            var command = new Command("get-compliance-setting-non-compliance-report");
            var builder = new ApiSdk.DeviceManagement.Reports.GetComplianceSettingNonComplianceReport.GetComplianceSettingNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildGetConfigurationPolicyNonComplianceReportCommand() {
            var command = new Command("get-configuration-policy-non-compliance-report");
            var builder = new ApiSdk.DeviceManagement.Reports.GetConfigurationPolicyNonComplianceReport.GetConfigurationPolicyNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildGetConfigurationPolicyNonComplianceSummaryReportCommand() {
            var command = new Command("get-configuration-policy-non-compliance-summary-report");
            var builder = new ApiSdk.DeviceManagement.Reports.GetConfigurationPolicyNonComplianceSummaryReport.GetConfigurationPolicyNonComplianceSummaryReportRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildGetConfigurationSettingNonComplianceReportCommand() {
            var command = new Command("get-configuration-setting-non-compliance-report");
            var builder = new ApiSdk.DeviceManagement.Reports.GetConfigurationSettingNonComplianceReport.GetConfigurationSettingNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildGetDeviceManagementIntentPerSettingContributingProfilesCommand() {
            var command = new Command("get-device-management-intent-per-setting-contributing-profiles");
            var builder = new ApiSdk.DeviceManagement.Reports.GetDeviceManagementIntentPerSettingContributingProfiles.GetDeviceManagementIntentPerSettingContributingProfilesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildGetDeviceManagementIntentSettingsReportCommand() {
            var command = new Command("get-device-management-intent-settings-report");
            var builder = new ApiSdk.DeviceManagement.Reports.GetDeviceManagementIntentSettingsReport.GetDeviceManagementIntentSettingsReportRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildGetDeviceNonComplianceReportCommand() {
            var command = new Command("get-device-non-compliance-report");
            var builder = new ApiSdk.DeviceManagement.Reports.GetDeviceNonComplianceReport.GetDeviceNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildGetHistoricalReportCommand() {
            var command = new Command("get-historical-report");
            var builder = new ApiSdk.DeviceManagement.Reports.GetHistoricalReport.GetHistoricalReportRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildGetPolicyNonComplianceMetadataCommand() {
            var command = new Command("get-policy-non-compliance-metadata");
            var builder = new ApiSdk.DeviceManagement.Reports.GetPolicyNonComplianceMetadata.GetPolicyNonComplianceMetadataRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildGetPolicyNonComplianceReportCommand() {
            var command = new Command("get-policy-non-compliance-report");
            var builder = new ApiSdk.DeviceManagement.Reports.GetPolicyNonComplianceReport.GetPolicyNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildGetPolicyNonComplianceSummaryReportCommand() {
            var command = new Command("get-policy-non-compliance-summary-report");
            var builder = new ApiSdk.DeviceManagement.Reports.GetPolicyNonComplianceSummaryReport.GetPolicyNonComplianceSummaryReportRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildGetReportFiltersCommand() {
            var command = new Command("get-report-filters");
            var builder = new ApiSdk.DeviceManagement.Reports.GetReportFilters.GetReportFiltersRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildGetSettingNonComplianceReportCommand() {
            var command = new Command("get-setting-non-compliance-report");
            var builder = new ApiSdk.DeviceManagement.Reports.GetSettingNonComplianceReport.GetSettingNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Reports singleton
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Reports singleton";
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
                var model = parseNode.GetObjectValue<DeviceManagementReports>();
                var requestInfo = CreatePatchRequestInformation(model, q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
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
        /// Reports singleton
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreateDeleteRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Reports singleton
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
        /// Reports singleton
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(DeviceManagementReports body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// <summary>Reports singleton</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
