using ApiSdk.Models.Microsoft.Graph;
using ApiSdk.Users.Item.Insights.Shared.Item.LastSharedMethod.CalendarSharingMessage;
using ApiSdk.Users.Item.Insights.Shared.Item.LastSharedMethod.ManagedAppProtection;
using ApiSdk.Users.Item.Insights.Shared.Item.LastSharedMethod.MobileAppContentFile;
using ApiSdk.Users.Item.Insights.Shared.Item.LastSharedMethod.PrintDocument;
using ApiSdk.Users.Item.Insights.Shared.Item.LastSharedMethod.PrintJob;
using ApiSdk.Users.Item.Insights.Shared.Item.LastSharedMethod.Ref;
using ApiSdk.Users.Item.Insights.Shared.Item.LastSharedMethod.ScheduleChangeRequest;
using ApiSdk.Users.Item.Insights.Shared.Item.LastSharedMethod.TargetedManagedAppProtection;
using ApiSdk.Users.Item.Insights.Shared.Item.LastSharedMethod.WindowsInformationProtection;
using ApiSdk.Users.Item.Insights.Shared.Item.LastSharedMethod.WorkbookRange;
using ApiSdk.Users.Item.Insights.Shared.Item.LastSharedMethod.WorkbookRangeFill;
using ApiSdk.Users.Item.Insights.Shared.Item.LastSharedMethod.WorkbookRangeFormat;
using ApiSdk.Users.Item.Insights.Shared.Item.LastSharedMethod.WorkbookRangeSort;
using ApiSdk.Users.Item.Insights.Shared.Item.LastSharedMethod.WorkbookRangeView;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace ApiSdk.Users.Item.Insights.Shared.Item.LastSharedMethod {
    /// <summary>Builds and executes requests for operations under \users\{user-id}\insights\shared\{sharedInsight-id}\lastSharedMethod</summary>
    public class LastSharedMethodRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public Command BuildCalendarSharingMessageCommand() {
            var command = new Command("calendar-sharing-message");
            var builder = new ApiSdk.Users.Item.Insights.Shared.Item.LastSharedMethod.CalendarSharingMessage.CalendarSharingMessageRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildAcceptCommand());
            return command;
        }
        /// <summary>
        /// Get lastSharedMethod from users
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Get lastSharedMethod from users";
            // Create options for all the parameters
            command.AddOption(new Option<string>("--user-id", description: "key: id of user"));
            command.AddOption(new Option<string>("--sharedinsight-id", description: "key: id of sharedInsight"));
            command.AddOption(new Option<object>("--select", description: "Select properties to be returned"));
            command.AddOption(new Option<object>("--expand", description: "Expand related entities"));
            command.Handler = CommandHandler.Create<string, string, object, object>(async (userId, sharedInsightId, select, expand) => {
                var requestInfo = CreateGetRequestInformation();
                if (!String.IsNullOrEmpty(userId)) requestInfo.PathParameters.Add("user_id", userId);
                if (!String.IsNullOrEmpty(sharedInsightId)) requestInfo.PathParameters.Add("sharedInsight_id", sharedInsightId);
                requestInfo.QueryParameters.Add("select", select);
                requestInfo.QueryParameters.Add("expand", expand);
                var result = await RequestAdapter.SendAsync<Entity>(requestInfo);
                // Print request output. What if the request has no return?
                using var serializer = RequestAdapter.SerializationWriterFactory.GetSerializationWriter("application/json");
                serializer.WriteObjectValue(null, result);
                using var content = serializer.GetSerializedContent();
                using var reader = new StreamReader(content);
                var strContent = await reader.ReadToEndAsync();
                Console.Write(strContent + "\n");
            });
            return command;
        }
        public Command BuildManagedAppProtectionCommand() {
            var command = new Command("managed-app-protection");
            var builder = new ApiSdk.Users.Item.Insights.Shared.Item.LastSharedMethod.ManagedAppProtection.ManagedAppProtectionRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildTargetAppsCommand());
            return command;
        }
        public Command BuildMobileAppContentFileCommand() {
            var command = new Command("mobile-app-content-file");
            var builder = new ApiSdk.Users.Item.Insights.Shared.Item.LastSharedMethod.MobileAppContentFile.MobileAppContentFileRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommitCommand());
            command.AddCommand(builder.BuildRenewUploadCommand());
            return command;
        }
        public Command BuildPrintDocumentCommand() {
            var command = new Command("print-document");
            var builder = new ApiSdk.Users.Item.Insights.Shared.Item.LastSharedMethod.PrintDocument.PrintDocumentRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateUploadSessionCommand());
            return command;
        }
        public Command BuildPrintJobCommand() {
            var command = new Command("print-job");
            var builder = new ApiSdk.Users.Item.Insights.Shared.Item.LastSharedMethod.PrintJob.PrintJobRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildAbortCommand());
            command.AddCommand(builder.BuildCancelCommand());
            command.AddCommand(builder.BuildRedirectCommand());
            command.AddCommand(builder.BuildStartCommand());
            return command;
        }
        public Command BuildRefCommand() {
            var command = new Command("ref");
            var builder = new ApiSdk.Users.Item.Insights.Shared.Item.LastSharedMethod.@Ref.RefRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPutCommand());
            return command;
        }
        public Command BuildScheduleChangeRequestCommand() {
            var command = new Command("schedule-change-request");
            var builder = new ApiSdk.Users.Item.Insights.Shared.Item.LastSharedMethod.ScheduleChangeRequest.ScheduleChangeRequestRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildApproveCommand());
            command.AddCommand(builder.BuildDeclineCommand());
            return command;
        }
        public Command BuildTargetedManagedAppProtectionCommand() {
            var command = new Command("targeted-managed-app-protection");
            var builder = new ApiSdk.Users.Item.Insights.Shared.Item.LastSharedMethod.TargetedManagedAppProtection.TargetedManagedAppProtectionRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildAssignCommand());
            command.AddCommand(builder.BuildTargetAppsCommand());
            return command;
        }
        public Command BuildWindowsInformationProtectionCommand() {
            var command = new Command("windows-information-protection");
            var builder = new ApiSdk.Users.Item.Insights.Shared.Item.LastSharedMethod.WindowsInformationProtection.WindowsInformationProtectionRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildAssignCommand());
            return command;
        }
        public Command BuildWorkbookRangeCommand() {
            var command = new Command("workbook-range");
            var builder = new ApiSdk.Users.Item.Insights.Shared.Item.LastSharedMethod.WorkbookRange.WorkbookRangeRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildClearCommand());
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildInsertCommand());
            command.AddCommand(builder.BuildMergeCommand());
            command.AddCommand(builder.BuildUnmergeCommand());
            return command;
        }
        public Command BuildWorkbookRangeFillCommand() {
            var command = new Command("workbook-range-fill");
            var builder = new ApiSdk.Users.Item.Insights.Shared.Item.LastSharedMethod.WorkbookRangeFill.WorkbookRangeFillRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildClearCommand());
            return command;
        }
        public Command BuildWorkbookRangeFormatCommand() {
            var command = new Command("workbook-range-format");
            var builder = new ApiSdk.Users.Item.Insights.Shared.Item.LastSharedMethod.WorkbookRangeFormat.WorkbookRangeFormatRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildAutofitColumnsCommand());
            command.AddCommand(builder.BuildAutofitRowsCommand());
            return command;
        }
        public Command BuildWorkbookRangeSortCommand() {
            var command = new Command("workbook-range-sort");
            var builder = new ApiSdk.Users.Item.Insights.Shared.Item.LastSharedMethod.WorkbookRangeSort.WorkbookRangeSortRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildApplyCommand());
            return command;
        }
        public Command BuildWorkbookRangeViewCommand() {
            var command = new Command("workbook-range-view");
            var builder = new ApiSdk.Users.Item.Insights.Shared.Item.LastSharedMethod.WorkbookRangeView.WorkbookRangeViewRequestBuilder(PathParameters, RequestAdapter);
            return command;
        }
        /// <summary>
        /// Instantiates a new LastSharedMethodRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public LastSharedMethodRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/users/{user_id}/insights/shared/{sharedInsight_id}/lastSharedMethod{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Get lastSharedMethod from users
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.GET,
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
        /// Get lastSharedMethod from users
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<Entity> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<Entity>(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>Get lastSharedMethod from users</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
