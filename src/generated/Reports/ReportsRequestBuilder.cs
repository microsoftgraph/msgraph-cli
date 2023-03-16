using ApiSdk.Models;
using ApiSdk.Models.ODataErrors;
using ApiSdk.Reports.DailyPrintUsageByPrinter;
using ApiSdk.Reports.DailyPrintUsageByUser;
using ApiSdk.Reports.DeviceConfigurationDeviceActivity;
using ApiSdk.Reports.DeviceConfigurationUserActivity;
using ApiSdk.Reports.GetEmailActivityCountsWithPeriod;
using ApiSdk.Reports.GetEmailActivityUserCountsWithPeriod;
using ApiSdk.Reports.GetEmailActivityUserDetailWithDate;
using ApiSdk.Reports.GetEmailActivityUserDetailWithPeriod;
using ApiSdk.Reports.GetEmailAppUsageAppsUserCountsWithPeriod;
using ApiSdk.Reports.GetEmailAppUsageUserCountsWithPeriod;
using ApiSdk.Reports.GetEmailAppUsageUserDetailWithDate;
using ApiSdk.Reports.GetEmailAppUsageUserDetailWithPeriod;
using ApiSdk.Reports.GetEmailAppUsageVersionsUserCountsWithPeriod;
using ApiSdk.Reports.GetGroupArchivedPrintJobsWithGroupIdWithStartDateTimeWithEndDateTime;
using ApiSdk.Reports.GetM365AppPlatformUserCountsWithPeriod;
using ApiSdk.Reports.GetM365AppUserCountsWithPeriod;
using ApiSdk.Reports.GetM365AppUserDetailWithDate;
using ApiSdk.Reports.GetM365AppUserDetailWithPeriod;
using ApiSdk.Reports.GetMailboxUsageDetailWithPeriod;
using ApiSdk.Reports.GetMailboxUsageMailboxCountsWithPeriod;
using ApiSdk.Reports.GetMailboxUsageQuotaStatusMailboxCountsWithPeriod;
using ApiSdk.Reports.GetMailboxUsageStorageWithPeriod;
using ApiSdk.Reports.GetOffice365ActivationCounts;
using ApiSdk.Reports.GetOffice365ActivationsUserCounts;
using ApiSdk.Reports.GetOffice365ActivationsUserDetail;
using ApiSdk.Reports.GetOffice365ActiveUserCountsWithPeriod;
using ApiSdk.Reports.GetOffice365ActiveUserDetailWithDate;
using ApiSdk.Reports.GetOffice365ActiveUserDetailWithPeriod;
using ApiSdk.Reports.GetOffice365GroupsActivityCountsWithPeriod;
using ApiSdk.Reports.GetOffice365GroupsActivityDetailWithDate;
using ApiSdk.Reports.GetOffice365GroupsActivityDetailWithPeriod;
using ApiSdk.Reports.GetOffice365GroupsActivityFileCountsWithPeriod;
using ApiSdk.Reports.GetOffice365GroupsActivityGroupCountsWithPeriod;
using ApiSdk.Reports.GetOffice365GroupsActivityStorageWithPeriod;
using ApiSdk.Reports.GetOffice365ServicesUserCountsWithPeriod;
using ApiSdk.Reports.GetOneDriveActivityFileCountsWithPeriod;
using ApiSdk.Reports.GetOneDriveActivityUserCountsWithPeriod;
using ApiSdk.Reports.GetOneDriveActivityUserDetailWithDate;
using ApiSdk.Reports.GetOneDriveActivityUserDetailWithPeriod;
using ApiSdk.Reports.GetOneDriveUsageAccountCountsWithPeriod;
using ApiSdk.Reports.GetOneDriveUsageAccountDetailWithDate;
using ApiSdk.Reports.GetOneDriveUsageAccountDetailWithPeriod;
using ApiSdk.Reports.GetOneDriveUsageFileCountsWithPeriod;
using ApiSdk.Reports.GetOneDriveUsageStorageWithPeriod;
using ApiSdk.Reports.GetPrinterArchivedPrintJobsWithPrinterIdWithStartDateTimeWithEndDateTime;
using ApiSdk.Reports.GetSharePointActivityFileCountsWithPeriod;
using ApiSdk.Reports.GetSharePointActivityPagesWithPeriod;
using ApiSdk.Reports.GetSharePointActivityUserCountsWithPeriod;
using ApiSdk.Reports.GetSharePointActivityUserDetailWithDate;
using ApiSdk.Reports.GetSharePointActivityUserDetailWithPeriod;
using ApiSdk.Reports.GetSharePointSiteUsageDetailWithDate;
using ApiSdk.Reports.GetSharePointSiteUsageDetailWithPeriod;
using ApiSdk.Reports.GetSharePointSiteUsageFileCountsWithPeriod;
using ApiSdk.Reports.GetSharePointSiteUsagePagesWithPeriod;
using ApiSdk.Reports.GetSharePointSiteUsageSiteCountsWithPeriod;
using ApiSdk.Reports.GetSharePointSiteUsageStorageWithPeriod;
using ApiSdk.Reports.GetSkypeForBusinessActivityCountsWithPeriod;
using ApiSdk.Reports.GetSkypeForBusinessActivityUserCountsWithPeriod;
using ApiSdk.Reports.GetSkypeForBusinessActivityUserDetailWithDate;
using ApiSdk.Reports.GetSkypeForBusinessActivityUserDetailWithPeriod;
using ApiSdk.Reports.GetSkypeForBusinessDeviceUsageDistributionUserCountsWithPeriod;
using ApiSdk.Reports.GetSkypeForBusinessDeviceUsageUserCountsWithPeriod;
using ApiSdk.Reports.GetSkypeForBusinessDeviceUsageUserDetailWithDate;
using ApiSdk.Reports.GetSkypeForBusinessDeviceUsageUserDetailWithPeriod;
using ApiSdk.Reports.GetSkypeForBusinessOrganizerActivityCountsWithPeriod;
using ApiSdk.Reports.GetSkypeForBusinessOrganizerActivityMinuteCountsWithPeriod;
using ApiSdk.Reports.GetSkypeForBusinessOrganizerActivityUserCountsWithPeriod;
using ApiSdk.Reports.GetSkypeForBusinessParticipantActivityCountsWithPeriod;
using ApiSdk.Reports.GetSkypeForBusinessParticipantActivityMinuteCountsWithPeriod;
using ApiSdk.Reports.GetSkypeForBusinessParticipantActivityUserCountsWithPeriod;
using ApiSdk.Reports.GetSkypeForBusinessPeerToPeerActivityCountsWithPeriod;
using ApiSdk.Reports.GetSkypeForBusinessPeerToPeerActivityMinuteCountsWithPeriod;
using ApiSdk.Reports.GetSkypeForBusinessPeerToPeerActivityUserCountsWithPeriod;
using ApiSdk.Reports.GetTeamsDeviceUsageDistributionUserCountsWithPeriod;
using ApiSdk.Reports.GetTeamsDeviceUsageUserCountsWithPeriod;
using ApiSdk.Reports.GetTeamsDeviceUsageUserDetailWithDate;
using ApiSdk.Reports.GetTeamsDeviceUsageUserDetailWithPeriod;
using ApiSdk.Reports.GetTeamsUserActivityCountsWithPeriod;
using ApiSdk.Reports.GetTeamsUserActivityUserCountsWithPeriod;
using ApiSdk.Reports.GetTeamsUserActivityUserDetailWithDate;
using ApiSdk.Reports.GetTeamsUserActivityUserDetailWithPeriod;
using ApiSdk.Reports.GetUserArchivedPrintJobsWithUserIdWithStartDateTimeWithEndDateTime;
using ApiSdk.Reports.GetYammerActivityCountsWithPeriod;
using ApiSdk.Reports.GetYammerActivityUserCountsWithPeriod;
using ApiSdk.Reports.GetYammerActivityUserDetailWithDate;
using ApiSdk.Reports.GetYammerActivityUserDetailWithPeriod;
using ApiSdk.Reports.GetYammerDeviceUsageDistributionUserCountsWithPeriod;
using ApiSdk.Reports.GetYammerDeviceUsageUserCountsWithPeriod;
using ApiSdk.Reports.GetYammerDeviceUsageUserDetailWithDate;
using ApiSdk.Reports.GetYammerDeviceUsageUserDetailWithPeriod;
using ApiSdk.Reports.GetYammerGroupsActivityCountsWithPeriod;
using ApiSdk.Reports.GetYammerGroupsActivityDetailWithDate;
using ApiSdk.Reports.GetYammerGroupsActivityDetailWithPeriod;
using ApiSdk.Reports.GetYammerGroupsActivityGroupCountsWithPeriod;
using ApiSdk.Reports.ManagedDeviceEnrollmentFailureDetails;
using ApiSdk.Reports.ManagedDeviceEnrollmentFailureDetailsWithSkipWithTopWithFilterWithSkipToken;
using ApiSdk.Reports.ManagedDeviceEnrollmentTopFailures;
using ApiSdk.Reports.ManagedDeviceEnrollmentTopFailuresWithPeriod;
using ApiSdk.Reports.MonthlyPrintUsageByPrinter;
using ApiSdk.Reports.MonthlyPrintUsageByUser;
using ApiSdk.Reports.Security;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Cli.Commons.Extensions;
using Microsoft.Kiota.Cli.Commons.IO;
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace ApiSdk.Reports {
    /// <summary>
    /// Provides operations to manage the reportRoot singleton.
    /// </summary>
    public class ReportsRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Provides operations to manage the dailyPrintUsageByPrinter property of the microsoft.graph.reportRoot entity.
        /// </summary>
        public Command BuildDailyPrintUsageByPrinterCommand() {
            var command = new Command("daily-print-usage-by-printer");
            command.Description = "Provides operations to manage the dailyPrintUsageByPrinter property of the microsoft.graph.reportRoot entity.";
            var builder = new DailyPrintUsageByPrinterRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the dailyPrintUsageByUser property of the microsoft.graph.reportRoot entity.
        /// </summary>
        public Command BuildDailyPrintUsageByUserCommand() {
            var command = new Command("daily-print-usage-by-user");
            command.Description = "Provides operations to manage the dailyPrintUsageByUser property of the microsoft.graph.reportRoot entity.";
            var builder = new DailyPrintUsageByUserRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the deviceConfigurationDeviceActivity method.
        /// </summary>
        public Command BuildDeviceConfigurationDeviceActivityCommand() {
            var command = new Command("device-configuration-device-activity");
            command.Description = "Provides operations to call the deviceConfigurationDeviceActivity method.";
            var builder = new DeviceConfigurationDeviceActivityRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the deviceConfigurationUserActivity method.
        /// </summary>
        public Command BuildDeviceConfigurationUserActivityCommand() {
            var command = new Command("device-configuration-user-activity");
            command.Description = "Provides operations to call the deviceConfigurationUserActivity method.";
            var builder = new DeviceConfigurationUserActivityRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Get reports
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Get reports";
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
                IOutputFilter outputFilter = invocationContext.BindingContext.GetRequiredService<IOutputFilter>();
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetRequiredService<IOutputFormatterFactory>();
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                    q.QueryParameters.Select = select;
                    q.QueryParameters.Expand = expand;
                });
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatterOptions = output.GetOutputFormatterOptions(new FormatterOptionsModel(!jsonNoIndent));
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, formatterOptions, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Provides operations to call the getOffice365ActivationCounts method.
        /// </summary>
        public Command BuildGetOffice365ActivationCountsCommand() {
            var command = new Command("get-office365-activation-counts");
            command.Description = "Provides operations to call the getOffice365ActivationCounts method.";
            var builder = new GetOffice365ActivationCountsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the getOffice365ActivationsUserCounts method.
        /// </summary>
        public Command BuildGetOffice365ActivationsUserCountsCommand() {
            var command = new Command("get-office365-activations-user-counts");
            command.Description = "Provides operations to call the getOffice365ActivationsUserCounts method.";
            var builder = new GetOffice365ActivationsUserCountsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the getOffice365ActivationsUserDetail method.
        /// </summary>
        public Command BuildGetOffice365ActivationsUserDetailCommand() {
            var command = new Command("get-office365-activations-user-detail");
            command.Description = "Provides operations to call the getOffice365ActivationsUserDetail method.";
            var builder = new GetOffice365ActivationsUserDetailRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the managedDeviceEnrollmentFailureDetails method.
        /// </summary>
        public Command BuildManagedDeviceEnrollmentFailureDetailsCommand() {
            var command = new Command("managed-device-enrollment-failure-details");
            command.Description = "Provides operations to call the managedDeviceEnrollmentFailureDetails method.";
            var builder = new ManagedDeviceEnrollmentFailureDetailsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the managedDeviceEnrollmentTopFailures method.
        /// </summary>
        public Command BuildManagedDeviceEnrollmentTopFailuresCommand() {
            var command = new Command("managed-device-enrollment-top-failures");
            command.Description = "Provides operations to call the managedDeviceEnrollmentTopFailures method.";
            var builder = new ManagedDeviceEnrollmentTopFailuresRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the monthlyPrintUsageByPrinter property of the microsoft.graph.reportRoot entity.
        /// </summary>
        public Command BuildMonthlyPrintUsageByPrinterCommand() {
            var command = new Command("monthly-print-usage-by-printer");
            command.Description = "Provides operations to manage the monthlyPrintUsageByPrinter property of the microsoft.graph.reportRoot entity.";
            var builder = new MonthlyPrintUsageByPrinterRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the monthlyPrintUsageByUser property of the microsoft.graph.reportRoot entity.
        /// </summary>
        public Command BuildMonthlyPrintUsageByUserCommand() {
            var command = new Command("monthly-print-usage-by-user");
            command.Description = "Provides operations to manage the monthlyPrintUsageByUser property of the microsoft.graph.reportRoot entity.";
            var builder = new MonthlyPrintUsageByUserRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Update reports
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Update reports";
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
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                var jsonNoIndent = invocationContext.ParseResult.GetValueForOption(jsonNoIndentOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetRequiredService<IOutputFilter>();
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetRequiredService<IOutputFormatterFactory>();
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ReportRoot>(ReportRoot.CreateFromDiscriminatorValue);
                if (model is null) return; // Cannot create a POST request from a null model.
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                requestInfo.SetContentFromParsable(reqAdapter, "application/json", model);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatterOptions = output.GetOutputFormatterOptions(new FormatterOptionsModel(!jsonNoIndent));
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, formatterOptions, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Provides operations to manage the security property of the microsoft.graph.reportRoot entity.
        /// </summary>
        public Command BuildSecurityCommand() {
            var command = new Command("security");
            command.Description = "Provides operations to manage the security property of the microsoft.graph.reportRoot entity.";
            var builder = new SecurityRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetAttackSimulationRepeatOffendersCommand());
            command.AddCommand(builder.BuildGetAttackSimulationSimulationUserCoverageCommand());
            command.AddCommand(builder.BuildGetAttackSimulationTrainingUserCoverageCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new ReportsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public ReportsRequestBuilder(Dictionary<string, object> pathParameters) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            UrlTemplate = "{+baseurl}/reports{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
        }
        /// <summary>
        /// Get reports
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
        /// Update reports
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(ReportRoot body, Action<ReportsRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(ReportRoot body, Action<ReportsRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new ReportsRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Get reports
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
