using ApiSdk.Models;
using ApiSdk.Models.ODataErrors;
using ApiSdk.Reports.DailyPrintUsageByPrinter;
using ApiSdk.Reports.DailyPrintUsageByUser;
using ApiSdk.Reports.MicrosoftGraphDeviceConfigurationDeviceActivity;
using ApiSdk.Reports.MicrosoftGraphDeviceConfigurationUserActivity;
using ApiSdk.Reports.MicrosoftGraphGetEmailActivityCountsWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetEmailActivityUserCountsWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetEmailActivityUserDetailWithDate;
using ApiSdk.Reports.MicrosoftGraphGetEmailActivityUserDetailWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetEmailAppUsageAppsUserCountsWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetEmailAppUsageUserCountsWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetEmailAppUsageUserDetailWithDate;
using ApiSdk.Reports.MicrosoftGraphGetEmailAppUsageUserDetailWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetEmailAppUsageVersionsUserCountsWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetGroupArchivedPrintJobsWithGroupIdWithStartDateTimeWithEndDateTime;
using ApiSdk.Reports.MicrosoftGraphGetM365AppPlatformUserCountsWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetM365AppUserCountsWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetM365AppUserDetailWithDate;
using ApiSdk.Reports.MicrosoftGraphGetM365AppUserDetailWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetMailboxUsageDetailWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetMailboxUsageMailboxCountsWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetMailboxUsageQuotaStatusMailboxCountsWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetMailboxUsageStorageWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetOffice365ActivationCounts;
using ApiSdk.Reports.MicrosoftGraphGetOffice365ActivationsUserCounts;
using ApiSdk.Reports.MicrosoftGraphGetOffice365ActivationsUserDetail;
using ApiSdk.Reports.MicrosoftGraphGetOffice365ActiveUserCountsWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetOffice365ActiveUserDetailWithDate;
using ApiSdk.Reports.MicrosoftGraphGetOffice365ActiveUserDetailWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetOffice365GroupsActivityCountsWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetOffice365GroupsActivityDetailWithDate;
using ApiSdk.Reports.MicrosoftGraphGetOffice365GroupsActivityDetailWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetOffice365GroupsActivityFileCountsWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetOffice365GroupsActivityGroupCountsWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetOffice365GroupsActivityStorageWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetOffice365ServicesUserCountsWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetOneDriveActivityFileCountsWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetOneDriveActivityUserCountsWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetOneDriveActivityUserDetailWithDate;
using ApiSdk.Reports.MicrosoftGraphGetOneDriveActivityUserDetailWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetOneDriveUsageAccountCountsWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetOneDriveUsageAccountDetailWithDate;
using ApiSdk.Reports.MicrosoftGraphGetOneDriveUsageAccountDetailWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetOneDriveUsageFileCountsWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetOneDriveUsageStorageWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetPrinterArchivedPrintJobsWithPrinterIdWithStartDateTimeWithEndDateTime;
using ApiSdk.Reports.MicrosoftGraphGetSharePointActivityFileCountsWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetSharePointActivityPagesWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetSharePointActivityUserCountsWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetSharePointActivityUserDetailWithDate;
using ApiSdk.Reports.MicrosoftGraphGetSharePointActivityUserDetailWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetSharePointSiteUsageDetailWithDate;
using ApiSdk.Reports.MicrosoftGraphGetSharePointSiteUsageDetailWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetSharePointSiteUsageFileCountsWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetSharePointSiteUsagePagesWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetSharePointSiteUsageSiteCountsWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetSharePointSiteUsageStorageWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetSkypeForBusinessActivityCountsWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetSkypeForBusinessActivityUserCountsWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetSkypeForBusinessActivityUserDetailWithDate;
using ApiSdk.Reports.MicrosoftGraphGetSkypeForBusinessActivityUserDetailWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetSkypeForBusinessDeviceUsageDistributionUserCountsWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetSkypeForBusinessDeviceUsageUserCountsWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetSkypeForBusinessDeviceUsageUserDetailWithDate;
using ApiSdk.Reports.MicrosoftGraphGetSkypeForBusinessDeviceUsageUserDetailWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetSkypeForBusinessOrganizerActivityCountsWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetSkypeForBusinessOrganizerActivityMinuteCountsWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetSkypeForBusinessOrganizerActivityUserCountsWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetSkypeForBusinessParticipantActivityCountsWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetSkypeForBusinessParticipantActivityMinuteCountsWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetSkypeForBusinessParticipantActivityUserCountsWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetSkypeForBusinessPeerToPeerActivityCountsWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetSkypeForBusinessPeerToPeerActivityMinuteCountsWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetSkypeForBusinessPeerToPeerActivityUserCountsWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetTeamsDeviceUsageDistributionUserCountsWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetTeamsDeviceUsageUserCountsWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetTeamsDeviceUsageUserDetailWithDate;
using ApiSdk.Reports.MicrosoftGraphGetTeamsDeviceUsageUserDetailWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetTeamsUserActivityCountsWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetTeamsUserActivityUserCountsWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetTeamsUserActivityUserDetailWithDate;
using ApiSdk.Reports.MicrosoftGraphGetTeamsUserActivityUserDetailWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetUserArchivedPrintJobsWithUserIdWithStartDateTimeWithEndDateTime;
using ApiSdk.Reports.MicrosoftGraphGetYammerActivityCountsWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetYammerActivityUserCountsWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetYammerActivityUserDetailWithDate;
using ApiSdk.Reports.MicrosoftGraphGetYammerActivityUserDetailWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetYammerDeviceUsageDistributionUserCountsWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetYammerDeviceUsageUserCountsWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetYammerDeviceUsageUserDetailWithDate;
using ApiSdk.Reports.MicrosoftGraphGetYammerDeviceUsageUserDetailWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetYammerGroupsActivityCountsWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetYammerGroupsActivityDetailWithDate;
using ApiSdk.Reports.MicrosoftGraphGetYammerGroupsActivityDetailWithPeriod;
using ApiSdk.Reports.MicrosoftGraphGetYammerGroupsActivityGroupCountsWithPeriod;
using ApiSdk.Reports.MicrosoftGraphManagedDeviceEnrollmentFailureDetails;
using ApiSdk.Reports.MicrosoftGraphManagedDeviceEnrollmentFailureDetailsWithSkipWithTopWithFilterWithSkipToken;
using ApiSdk.Reports.MicrosoftGraphManagedDeviceEnrollmentTopFailures;
using ApiSdk.Reports.MicrosoftGraphManagedDeviceEnrollmentTopFailuresWithPeriod;
using ApiSdk.Reports.MonthlyPrintUsageByPrinter;
using ApiSdk.Reports.MonthlyPrintUsageByUser;
using ApiSdk.Reports.Security;
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
namespace ApiSdk.Reports {
    /// <summary>
    /// Provides operations to manage the reportRoot singleton.
    /// </summary>
    public class ReportsRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Provides operations to manage the dailyPrintUsageByPrinter property of the microsoft.graph.reportRoot entity.
        /// </summary>
        public Command BuildDailyPrintUsageByPrinterCommand() {
            var command = new Command("daily-print-usage-by-printer");
            command.Description = "Provides operations to manage the dailyPrintUsageByPrinter property of the microsoft.graph.reportRoot entity.";
            var builder = new DailyPrintUsageByPrinterRequestBuilder(PathParameters, RequestAdapter);
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
            var builder = new DailyPrintUsageByUserRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
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
                var requestInfo = ToGetRequestInformation(q => {
                    q.QueryParameters.Select = select;
                    q.QueryParameters.Expand = expand;
                });
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatterOptions = output.GetOutputFormatterOptions(new FormatterOptionsModel(!jsonNoIndent));
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, formatterOptions, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Provides operations to call the deviceConfigurationDeviceActivity method.
        /// </summary>
        public Command BuildMicrosoftGraphDeviceConfigurationDeviceActivityCommand() {
            var command = new Command("microsoft-graph-device-configuration-device-activity");
            command.Description = "Provides operations to call the deviceConfigurationDeviceActivity method.";
            var builder = new DeviceConfigurationDeviceActivityRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the deviceConfigurationUserActivity method.
        /// </summary>
        public Command BuildMicrosoftGraphDeviceConfigurationUserActivityCommand() {
            var command = new Command("microsoft-graph-device-configuration-user-activity");
            command.Description = "Provides operations to call the deviceConfigurationUserActivity method.";
            var builder = new DeviceConfigurationUserActivityRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the getOffice365ActivationCounts method.
        /// </summary>
        public Command BuildMicrosoftGraphGetOffice365ActivationCountsCommand() {
            var command = new Command("microsoft-graph-get-office365-activation-counts");
            command.Description = "Provides operations to call the getOffice365ActivationCounts method.";
            var builder = new GetOffice365ActivationCountsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the getOffice365ActivationsUserCounts method.
        /// </summary>
        public Command BuildMicrosoftGraphGetOffice365ActivationsUserCountsCommand() {
            var command = new Command("microsoft-graph-get-office365-activations-user-counts");
            command.Description = "Provides operations to call the getOffice365ActivationsUserCounts method.";
            var builder = new GetOffice365ActivationsUserCountsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the getOffice365ActivationsUserDetail method.
        /// </summary>
        public Command BuildMicrosoftGraphGetOffice365ActivationsUserDetailCommand() {
            var command = new Command("microsoft-graph-get-office365-activations-user-detail");
            command.Description = "Provides operations to call the getOffice365ActivationsUserDetail method.";
            var builder = new GetOffice365ActivationsUserDetailRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the managedDeviceEnrollmentFailureDetails method.
        /// </summary>
        public Command BuildMicrosoftGraphManagedDeviceEnrollmentFailureDetailsCommand() {
            var command = new Command("microsoft-graph-managed-device-enrollment-failure-details");
            command.Description = "Provides operations to call the managedDeviceEnrollmentFailureDetails method.";
            var builder = new ManagedDeviceEnrollmentFailureDetailsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the managedDeviceEnrollmentTopFailures method.
        /// </summary>
        public Command BuildMicrosoftGraphManagedDeviceEnrollmentTopFailuresCommand() {
            var command = new Command("microsoft-graph-managed-device-enrollment-top-failures");
            command.Description = "Provides operations to call the managedDeviceEnrollmentTopFailures method.";
            var builder = new ManagedDeviceEnrollmentTopFailuresRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the monthlyPrintUsageByPrinter property of the microsoft.graph.reportRoot entity.
        /// </summary>
        public Command BuildMonthlyPrintUsageByPrinterCommand() {
            var command = new Command("monthly-print-usage-by-printer");
            command.Description = "Provides operations to manage the monthlyPrintUsageByPrinter property of the microsoft.graph.reportRoot entity.";
            var builder = new MonthlyPrintUsageByPrinterRequestBuilder(PathParameters, RequestAdapter);
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
            var builder = new MonthlyPrintUsageByUserRequestBuilder(PathParameters, RequestAdapter);
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
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ReportRoot>(ReportRoot.CreateFromDiscriminatorValue);
                if (model is null) return; // Cannot create a POST request from a null model.
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
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
            var builder = new SecurityRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGetAttackSimulationRepeatOffendersCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGetAttackSimulationSimulationUserCoverageCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGetAttackSimulationTrainingUserCoverageCommand());
            command.AddCommand(builder.BuildPatchCommand());
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
            UrlTemplate = "{+baseurl}/reports{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Provides operations to call the getEmailActivityCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetEmailActivityCountsWithPeriodRequestBuilder MicrosoftGraphGetEmailActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetEmailActivityCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getEmailActivityUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetEmailActivityUserCountsWithPeriodRequestBuilder MicrosoftGraphGetEmailActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetEmailActivityUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getEmailActivityUserDetail method.
        /// </summary>
        /// <param name="date">Usage: date={date}</param>
        public GetEmailActivityUserDetailWithDateRequestBuilder MicrosoftGraphGetEmailActivityUserDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetEmailActivityUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getEmailActivityUserDetail method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetEmailActivityUserDetailWithPeriodRequestBuilder MicrosoftGraphGetEmailActivityUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetEmailActivityUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getEmailAppUsageAppsUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetEmailAppUsageAppsUserCountsWithPeriodRequestBuilder MicrosoftGraphGetEmailAppUsageAppsUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetEmailAppUsageAppsUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getEmailAppUsageUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetEmailAppUsageUserCountsWithPeriodRequestBuilder MicrosoftGraphGetEmailAppUsageUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetEmailAppUsageUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getEmailAppUsageUserDetail method.
        /// </summary>
        /// <param name="date">Usage: date={date}</param>
        public GetEmailAppUsageUserDetailWithDateRequestBuilder MicrosoftGraphGetEmailAppUsageUserDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetEmailAppUsageUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getEmailAppUsageUserDetail method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetEmailAppUsageUserDetailWithPeriodRequestBuilder MicrosoftGraphGetEmailAppUsageUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetEmailAppUsageUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getEmailAppUsageVersionsUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetEmailAppUsageVersionsUserCountsWithPeriodRequestBuilder MicrosoftGraphGetEmailAppUsageVersionsUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetEmailAppUsageVersionsUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getGroupArchivedPrintJobs method.
        /// </summary>
        /// <param name="endDateTime">Usage: endDateTime={endDateTime}</param>
        /// <param name="groupId">Usage: groupId=&apos;{groupId}&apos;</param>
        /// <param name="startDateTime">Usage: startDateTime={startDateTime}</param>
        public GetGroupArchivedPrintJobsWithGroupIdWithStartDateTimeWithEndDateTimeRequestBuilder MicrosoftGraphGetGroupArchivedPrintJobsWithGroupIdWithStartDateTimeWithEndDateTime(DateTimeOffset? endDateTime, string groupId, DateTimeOffset? startDateTime) {
            _ = endDateTime ?? throw new ArgumentNullException(nameof(endDateTime));
            if(string.IsNullOrEmpty(groupId)) throw new ArgumentNullException(nameof(groupId));
            _ = startDateTime ?? throw new ArgumentNullException(nameof(startDateTime));
            return new GetGroupArchivedPrintJobsWithGroupIdWithStartDateTimeWithEndDateTimeRequestBuilder(PathParameters, RequestAdapter, endDateTime, groupId, startDateTime);
        }
        /// <summary>
        /// Provides operations to call the getM365AppPlatformUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetM365AppPlatformUserCountsWithPeriodRequestBuilder MicrosoftGraphGetM365AppPlatformUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetM365AppPlatformUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getM365AppUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetM365AppUserCountsWithPeriodRequestBuilder MicrosoftGraphGetM365AppUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetM365AppUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getM365AppUserDetail method.
        /// </summary>
        /// <param name="date">Usage: date={date}</param>
        public GetM365AppUserDetailWithDateRequestBuilder MicrosoftGraphGetM365AppUserDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetM365AppUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getM365AppUserDetail method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetM365AppUserDetailWithPeriodRequestBuilder MicrosoftGraphGetM365AppUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetM365AppUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getMailboxUsageDetail method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetMailboxUsageDetailWithPeriodRequestBuilder MicrosoftGraphGetMailboxUsageDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetMailboxUsageDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getMailboxUsageMailboxCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetMailboxUsageMailboxCountsWithPeriodRequestBuilder MicrosoftGraphGetMailboxUsageMailboxCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetMailboxUsageMailboxCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getMailboxUsageQuotaStatusMailboxCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetMailboxUsageQuotaStatusMailboxCountsWithPeriodRequestBuilder MicrosoftGraphGetMailboxUsageQuotaStatusMailboxCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetMailboxUsageQuotaStatusMailboxCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getMailboxUsageStorage method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetMailboxUsageStorageWithPeriodRequestBuilder MicrosoftGraphGetMailboxUsageStorageWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetMailboxUsageStorageWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOffice365ActiveUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetOffice365ActiveUserCountsWithPeriodRequestBuilder MicrosoftGraphGetOffice365ActiveUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOffice365ActiveUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOffice365ActiveUserDetail method.
        /// </summary>
        /// <param name="date">Usage: date={date}</param>
        public GetOffice365ActiveUserDetailWithDateRequestBuilder MicrosoftGraphGetOffice365ActiveUserDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetOffice365ActiveUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getOffice365ActiveUserDetail method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetOffice365ActiveUserDetailWithPeriodRequestBuilder MicrosoftGraphGetOffice365ActiveUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOffice365ActiveUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOffice365GroupsActivityCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetOffice365GroupsActivityCountsWithPeriodRequestBuilder MicrosoftGraphGetOffice365GroupsActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOffice365GroupsActivityCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOffice365GroupsActivityDetail method.
        /// </summary>
        /// <param name="date">Usage: date={date}</param>
        public GetOffice365GroupsActivityDetailWithDateRequestBuilder MicrosoftGraphGetOffice365GroupsActivityDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetOffice365GroupsActivityDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getOffice365GroupsActivityDetail method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetOffice365GroupsActivityDetailWithPeriodRequestBuilder MicrosoftGraphGetOffice365GroupsActivityDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOffice365GroupsActivityDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOffice365GroupsActivityFileCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetOffice365GroupsActivityFileCountsWithPeriodRequestBuilder MicrosoftGraphGetOffice365GroupsActivityFileCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOffice365GroupsActivityFileCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOffice365GroupsActivityGroupCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetOffice365GroupsActivityGroupCountsWithPeriodRequestBuilder MicrosoftGraphGetOffice365GroupsActivityGroupCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOffice365GroupsActivityGroupCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOffice365GroupsActivityStorage method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetOffice365GroupsActivityStorageWithPeriodRequestBuilder MicrosoftGraphGetOffice365GroupsActivityStorageWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOffice365GroupsActivityStorageWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOffice365ServicesUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetOffice365ServicesUserCountsWithPeriodRequestBuilder MicrosoftGraphGetOffice365ServicesUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOffice365ServicesUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOneDriveActivityFileCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetOneDriveActivityFileCountsWithPeriodRequestBuilder MicrosoftGraphGetOneDriveActivityFileCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOneDriveActivityFileCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOneDriveActivityUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetOneDriveActivityUserCountsWithPeriodRequestBuilder MicrosoftGraphGetOneDriveActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOneDriveActivityUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOneDriveActivityUserDetail method.
        /// </summary>
        /// <param name="date">Usage: date={date}</param>
        public GetOneDriveActivityUserDetailWithDateRequestBuilder MicrosoftGraphGetOneDriveActivityUserDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetOneDriveActivityUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getOneDriveActivityUserDetail method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetOneDriveActivityUserDetailWithPeriodRequestBuilder MicrosoftGraphGetOneDriveActivityUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOneDriveActivityUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOneDriveUsageAccountCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetOneDriveUsageAccountCountsWithPeriodRequestBuilder MicrosoftGraphGetOneDriveUsageAccountCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOneDriveUsageAccountCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOneDriveUsageAccountDetail method.
        /// </summary>
        /// <param name="date">Usage: date={date}</param>
        public GetOneDriveUsageAccountDetailWithDateRequestBuilder MicrosoftGraphGetOneDriveUsageAccountDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetOneDriveUsageAccountDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getOneDriveUsageAccountDetail method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetOneDriveUsageAccountDetailWithPeriodRequestBuilder MicrosoftGraphGetOneDriveUsageAccountDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOneDriveUsageAccountDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOneDriveUsageFileCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetOneDriveUsageFileCountsWithPeriodRequestBuilder MicrosoftGraphGetOneDriveUsageFileCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOneDriveUsageFileCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOneDriveUsageStorage method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetOneDriveUsageStorageWithPeriodRequestBuilder MicrosoftGraphGetOneDriveUsageStorageWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOneDriveUsageStorageWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getPrinterArchivedPrintJobs method.
        /// </summary>
        /// <param name="endDateTime">Usage: endDateTime={endDateTime}</param>
        /// <param name="printerId">Usage: printerId=&apos;{printerId}&apos;</param>
        /// <param name="startDateTime">Usage: startDateTime={startDateTime}</param>
        public GetPrinterArchivedPrintJobsWithPrinterIdWithStartDateTimeWithEndDateTimeRequestBuilder MicrosoftGraphGetPrinterArchivedPrintJobsWithPrinterIdWithStartDateTimeWithEndDateTime(DateTimeOffset? endDateTime, string printerId, DateTimeOffset? startDateTime) {
            _ = endDateTime ?? throw new ArgumentNullException(nameof(endDateTime));
            if(string.IsNullOrEmpty(printerId)) throw new ArgumentNullException(nameof(printerId));
            _ = startDateTime ?? throw new ArgumentNullException(nameof(startDateTime));
            return new GetPrinterArchivedPrintJobsWithPrinterIdWithStartDateTimeWithEndDateTimeRequestBuilder(PathParameters, RequestAdapter, endDateTime, printerId, startDateTime);
        }
        /// <summary>
        /// Provides operations to call the getSharePointActivityFileCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetSharePointActivityFileCountsWithPeriodRequestBuilder MicrosoftGraphGetSharePointActivityFileCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSharePointActivityFileCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSharePointActivityPages method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetSharePointActivityPagesWithPeriodRequestBuilder MicrosoftGraphGetSharePointActivityPagesWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSharePointActivityPagesWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSharePointActivityUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetSharePointActivityUserCountsWithPeriodRequestBuilder MicrosoftGraphGetSharePointActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSharePointActivityUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSharePointActivityUserDetail method.
        /// </summary>
        /// <param name="date">Usage: date={date}</param>
        public GetSharePointActivityUserDetailWithDateRequestBuilder MicrosoftGraphGetSharePointActivityUserDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetSharePointActivityUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getSharePointActivityUserDetail method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetSharePointActivityUserDetailWithPeriodRequestBuilder MicrosoftGraphGetSharePointActivityUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSharePointActivityUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSharePointSiteUsageDetail method.
        /// </summary>
        /// <param name="date">Usage: date={date}</param>
        public GetSharePointSiteUsageDetailWithDateRequestBuilder MicrosoftGraphGetSharePointSiteUsageDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetSharePointSiteUsageDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getSharePointSiteUsageDetail method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetSharePointSiteUsageDetailWithPeriodRequestBuilder MicrosoftGraphGetSharePointSiteUsageDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSharePointSiteUsageDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSharePointSiteUsageFileCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetSharePointSiteUsageFileCountsWithPeriodRequestBuilder MicrosoftGraphGetSharePointSiteUsageFileCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSharePointSiteUsageFileCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSharePointSiteUsagePages method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetSharePointSiteUsagePagesWithPeriodRequestBuilder MicrosoftGraphGetSharePointSiteUsagePagesWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSharePointSiteUsagePagesWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSharePointSiteUsageSiteCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetSharePointSiteUsageSiteCountsWithPeriodRequestBuilder MicrosoftGraphGetSharePointSiteUsageSiteCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSharePointSiteUsageSiteCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSharePointSiteUsageStorage method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetSharePointSiteUsageStorageWithPeriodRequestBuilder MicrosoftGraphGetSharePointSiteUsageStorageWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSharePointSiteUsageStorageWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessActivityCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetSkypeForBusinessActivityCountsWithPeriodRequestBuilder MicrosoftGraphGetSkypeForBusinessActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessActivityCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessActivityUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetSkypeForBusinessActivityUserCountsWithPeriodRequestBuilder MicrosoftGraphGetSkypeForBusinessActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessActivityUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessActivityUserDetail method.
        /// </summary>
        /// <param name="date">Usage: date={date}</param>
        public GetSkypeForBusinessActivityUserDetailWithDateRequestBuilder MicrosoftGraphGetSkypeForBusinessActivityUserDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetSkypeForBusinessActivityUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessActivityUserDetail method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetSkypeForBusinessActivityUserDetailWithPeriodRequestBuilder MicrosoftGraphGetSkypeForBusinessActivityUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessActivityUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessDeviceUsageDistributionUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetSkypeForBusinessDeviceUsageDistributionUserCountsWithPeriodRequestBuilder MicrosoftGraphGetSkypeForBusinessDeviceUsageDistributionUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessDeviceUsageDistributionUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessDeviceUsageUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetSkypeForBusinessDeviceUsageUserCountsWithPeriodRequestBuilder MicrosoftGraphGetSkypeForBusinessDeviceUsageUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessDeviceUsageUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessDeviceUsageUserDetail method.
        /// </summary>
        /// <param name="date">Usage: date={date}</param>
        public GetSkypeForBusinessDeviceUsageUserDetailWithDateRequestBuilder MicrosoftGraphGetSkypeForBusinessDeviceUsageUserDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetSkypeForBusinessDeviceUsageUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessDeviceUsageUserDetail method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetSkypeForBusinessDeviceUsageUserDetailWithPeriodRequestBuilder MicrosoftGraphGetSkypeForBusinessDeviceUsageUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessDeviceUsageUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessOrganizerActivityCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetSkypeForBusinessOrganizerActivityCountsWithPeriodRequestBuilder MicrosoftGraphGetSkypeForBusinessOrganizerActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessOrganizerActivityCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessOrganizerActivityMinuteCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetSkypeForBusinessOrganizerActivityMinuteCountsWithPeriodRequestBuilder MicrosoftGraphGetSkypeForBusinessOrganizerActivityMinuteCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessOrganizerActivityMinuteCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessOrganizerActivityUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetSkypeForBusinessOrganizerActivityUserCountsWithPeriodRequestBuilder MicrosoftGraphGetSkypeForBusinessOrganizerActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessOrganizerActivityUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessParticipantActivityCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetSkypeForBusinessParticipantActivityCountsWithPeriodRequestBuilder MicrosoftGraphGetSkypeForBusinessParticipantActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessParticipantActivityCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessParticipantActivityMinuteCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetSkypeForBusinessParticipantActivityMinuteCountsWithPeriodRequestBuilder MicrosoftGraphGetSkypeForBusinessParticipantActivityMinuteCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessParticipantActivityMinuteCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessParticipantActivityUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetSkypeForBusinessParticipantActivityUserCountsWithPeriodRequestBuilder MicrosoftGraphGetSkypeForBusinessParticipantActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessParticipantActivityUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessPeerToPeerActivityCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetSkypeForBusinessPeerToPeerActivityCountsWithPeriodRequestBuilder MicrosoftGraphGetSkypeForBusinessPeerToPeerActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessPeerToPeerActivityCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessPeerToPeerActivityMinuteCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetSkypeForBusinessPeerToPeerActivityMinuteCountsWithPeriodRequestBuilder MicrosoftGraphGetSkypeForBusinessPeerToPeerActivityMinuteCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessPeerToPeerActivityMinuteCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessPeerToPeerActivityUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetSkypeForBusinessPeerToPeerActivityUserCountsWithPeriodRequestBuilder MicrosoftGraphGetSkypeForBusinessPeerToPeerActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessPeerToPeerActivityUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getTeamsDeviceUsageDistributionUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetTeamsDeviceUsageDistributionUserCountsWithPeriodRequestBuilder MicrosoftGraphGetTeamsDeviceUsageDistributionUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsDeviceUsageDistributionUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getTeamsDeviceUsageUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetTeamsDeviceUsageUserCountsWithPeriodRequestBuilder MicrosoftGraphGetTeamsDeviceUsageUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsDeviceUsageUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getTeamsDeviceUsageUserDetail method.
        /// </summary>
        /// <param name="date">Usage: date={date}</param>
        public GetTeamsDeviceUsageUserDetailWithDateRequestBuilder MicrosoftGraphGetTeamsDeviceUsageUserDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetTeamsDeviceUsageUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getTeamsDeviceUsageUserDetail method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetTeamsDeviceUsageUserDetailWithPeriodRequestBuilder MicrosoftGraphGetTeamsDeviceUsageUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsDeviceUsageUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getTeamsUserActivityCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetTeamsUserActivityCountsWithPeriodRequestBuilder MicrosoftGraphGetTeamsUserActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsUserActivityCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getTeamsUserActivityUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetTeamsUserActivityUserCountsWithPeriodRequestBuilder MicrosoftGraphGetTeamsUserActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsUserActivityUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getTeamsUserActivityUserDetail method.
        /// </summary>
        /// <param name="date">Usage: date={date}</param>
        public GetTeamsUserActivityUserDetailWithDateRequestBuilder MicrosoftGraphGetTeamsUserActivityUserDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetTeamsUserActivityUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getTeamsUserActivityUserDetail method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetTeamsUserActivityUserDetailWithPeriodRequestBuilder MicrosoftGraphGetTeamsUserActivityUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsUserActivityUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getUserArchivedPrintJobs method.
        /// </summary>
        /// <param name="endDateTime">Usage: endDateTime={endDateTime}</param>
        /// <param name="startDateTime">Usage: startDateTime={startDateTime}</param>
        /// <param name="userId">Usage: userId=&apos;{userId}&apos;</param>
        public GetUserArchivedPrintJobsWithUserIdWithStartDateTimeWithEndDateTimeRequestBuilder MicrosoftGraphGetUserArchivedPrintJobsWithUserIdWithStartDateTimeWithEndDateTime(DateTimeOffset? endDateTime, DateTimeOffset? startDateTime, string userId) {
            _ = endDateTime ?? throw new ArgumentNullException(nameof(endDateTime));
            _ = startDateTime ?? throw new ArgumentNullException(nameof(startDateTime));
            if(string.IsNullOrEmpty(userId)) throw new ArgumentNullException(nameof(userId));
            return new GetUserArchivedPrintJobsWithUserIdWithStartDateTimeWithEndDateTimeRequestBuilder(PathParameters, RequestAdapter, endDateTime, startDateTime, userId);
        }
        /// <summary>
        /// Provides operations to call the getYammerActivityCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetYammerActivityCountsWithPeriodRequestBuilder MicrosoftGraphGetYammerActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetYammerActivityCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getYammerActivityUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetYammerActivityUserCountsWithPeriodRequestBuilder MicrosoftGraphGetYammerActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetYammerActivityUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getYammerActivityUserDetail method.
        /// </summary>
        /// <param name="date">Usage: date={date}</param>
        public GetYammerActivityUserDetailWithDateRequestBuilder MicrosoftGraphGetYammerActivityUserDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetYammerActivityUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getYammerActivityUserDetail method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetYammerActivityUserDetailWithPeriodRequestBuilder MicrosoftGraphGetYammerActivityUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetYammerActivityUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getYammerDeviceUsageDistributionUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetYammerDeviceUsageDistributionUserCountsWithPeriodRequestBuilder MicrosoftGraphGetYammerDeviceUsageDistributionUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetYammerDeviceUsageDistributionUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getYammerDeviceUsageUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetYammerDeviceUsageUserCountsWithPeriodRequestBuilder MicrosoftGraphGetYammerDeviceUsageUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetYammerDeviceUsageUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getYammerDeviceUsageUserDetail method.
        /// </summary>
        /// <param name="date">Usage: date={date}</param>
        public GetYammerDeviceUsageUserDetailWithDateRequestBuilder MicrosoftGraphGetYammerDeviceUsageUserDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetYammerDeviceUsageUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getYammerDeviceUsageUserDetail method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetYammerDeviceUsageUserDetailWithPeriodRequestBuilder MicrosoftGraphGetYammerDeviceUsageUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetYammerDeviceUsageUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getYammerGroupsActivityCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetYammerGroupsActivityCountsWithPeriodRequestBuilder MicrosoftGraphGetYammerGroupsActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetYammerGroupsActivityCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getYammerGroupsActivityDetail method.
        /// </summary>
        /// <param name="date">Usage: date={date}</param>
        public GetYammerGroupsActivityDetailWithDateRequestBuilder MicrosoftGraphGetYammerGroupsActivityDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetYammerGroupsActivityDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getYammerGroupsActivityDetail method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetYammerGroupsActivityDetailWithPeriodRequestBuilder MicrosoftGraphGetYammerGroupsActivityDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetYammerGroupsActivityDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getYammerGroupsActivityGroupCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetYammerGroupsActivityGroupCountsWithPeriodRequestBuilder MicrosoftGraphGetYammerGroupsActivityGroupCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetYammerGroupsActivityGroupCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the managedDeviceEnrollmentFailureDetails method.
        /// </summary>
        /// <param name="filter">Usage: filter=&apos;{filter}&apos;</param>
        /// <param name="skip">Usage: skip={skip}</param>
        /// <param name="skipToken">Usage: skipToken=&apos;{skipToken}&apos;</param>
        /// <param name="top">Usage: top={top}</param>
        public ManagedDeviceEnrollmentFailureDetailsWithSkipWithTopWithFilterWithSkipTokenRequestBuilder MicrosoftGraphManagedDeviceEnrollmentFailureDetailsWithSkipWithTopWithFilterWithSkipToken(string filter, int? skip, string skipToken, int? top) {
            if(string.IsNullOrEmpty(filter)) throw new ArgumentNullException(nameof(filter));
            _ = skip ?? throw new ArgumentNullException(nameof(skip));
            if(string.IsNullOrEmpty(skipToken)) throw new ArgumentNullException(nameof(skipToken));
            _ = top ?? throw new ArgumentNullException(nameof(top));
            return new ManagedDeviceEnrollmentFailureDetailsWithSkipWithTopWithFilterWithSkipTokenRequestBuilder(PathParameters, RequestAdapter, filter, skip, skipToken, top);
        }
        /// <summary>
        /// Provides operations to call the managedDeviceEnrollmentTopFailures method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public ManagedDeviceEnrollmentTopFailuresWithPeriodRequestBuilder MicrosoftGraphManagedDeviceEnrollmentTopFailuresWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new ManagedDeviceEnrollmentTopFailuresWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
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
