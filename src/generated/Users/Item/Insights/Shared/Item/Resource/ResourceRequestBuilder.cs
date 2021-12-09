using ApiSdk.Models.Microsoft.Graph;
using ApiSdk.Users.Item.Insights.Shared.Item.Resource.CalendarSharingMessage;
using ApiSdk.Users.Item.Insights.Shared.Item.Resource.ManagedAppProtection;
using ApiSdk.Users.Item.Insights.Shared.Item.Resource.MobileAppContentFile;
using ApiSdk.Users.Item.Insights.Shared.Item.Resource.PrintDocument;
using ApiSdk.Users.Item.Insights.Shared.Item.Resource.PrintJob;
using ApiSdk.Users.Item.Insights.Shared.Item.Resource.Ref;
using ApiSdk.Users.Item.Insights.Shared.Item.Resource.ScheduleChangeRequest;
using ApiSdk.Users.Item.Insights.Shared.Item.Resource.TargetedManagedAppProtection;
using ApiSdk.Users.Item.Insights.Shared.Item.Resource.WindowsInformationProtection;
using ApiSdk.Users.Item.Insights.Shared.Item.Resource.WorkbookRange;
using ApiSdk.Users.Item.Insights.Shared.Item.Resource.WorkbookRangeFill;
using ApiSdk.Users.Item.Insights.Shared.Item.Resource.WorkbookRangeFormat;
using ApiSdk.Users.Item.Insights.Shared.Item.Resource.WorkbookRangeSort;
using ApiSdk.Users.Item.Insights.Shared.Item.Resource.WorkbookRangeView;
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
namespace ApiSdk.Users.Item.Insights.Shared.Item.Resource {
    /// <summary>Builds and executes requests for operations under \users\{user-id}\insights\shared\{sharedInsight-id}\resource</summary>
    public class ResourceRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public Command BuildCalendarSharingMessageCommand() {
            var command = new Command("calendar-sharing-message");
            var builder = new ApiSdk.Users.Item.Insights.Shared.Item.Resource.CalendarSharingMessage.CalendarSharingMessageRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildAcceptCommand());
            return command;
        }
        /// <summary>
        /// Used for navigating to the item that was shared. For file attachments, the type is fileAttachment. For linked attachments, the type is driveItem.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Used for navigating to the item that was shared. For file attachments, the type is fileAttachment. For linked attachments, the type is driveItem.";
            // Create options for all the parameters
            var userIdOption = new Option<string>("--user-id", description: "key: id of user");
            userIdOption.IsRequired = true;
            command.AddOption(userIdOption);
            var sharedInsightIdOption = new Option<string>("--sharedinsight-id", description: "key: id of sharedInsight");
            sharedInsightIdOption.IsRequired = true;
            command.AddOption(sharedInsightIdOption);
            var selectOption = new Option<string[]>("--select", description: "Select properties to be returned");
            selectOption.IsRequired = false;
            selectOption.Arity = ArgumentArity.ZeroOrMore;
            command.AddOption(selectOption);
            var expandOption = new Option<string[]>("--expand", description: "Expand related entities");
            expandOption.IsRequired = false;
            expandOption.Arity = ArgumentArity.ZeroOrMore;
            command.AddOption(expandOption);
            command.Handler = CommandHandler.Create<string, string, string[], string[]>(async (userId, sharedInsightId, select, expand) => {
                var requestInfo = CreateGetRequestInformation(q => {
                    q.Select = select;
                    q.Expand = expand;
                });
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
            var builder = new ApiSdk.Users.Item.Insights.Shared.Item.Resource.ManagedAppProtection.ManagedAppProtectionRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildTargetAppsCommand());
            return command;
        }
        public Command BuildMobileAppContentFileCommand() {
            var command = new Command("mobile-app-content-file");
            var builder = new ApiSdk.Users.Item.Insights.Shared.Item.Resource.MobileAppContentFile.MobileAppContentFileRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommitCommand());
            command.AddCommand(builder.BuildRenewUploadCommand());
            return command;
        }
        public Command BuildPrintDocumentCommand() {
            var command = new Command("print-document");
            var builder = new ApiSdk.Users.Item.Insights.Shared.Item.Resource.PrintDocument.PrintDocumentRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateUploadSessionCommand());
            return command;
        }
        public Command BuildPrintJobCommand() {
            var command = new Command("print-job");
            var builder = new ApiSdk.Users.Item.Insights.Shared.Item.Resource.PrintJob.PrintJobRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildAbortCommand());
            command.AddCommand(builder.BuildCancelCommand());
            command.AddCommand(builder.BuildRedirectCommand());
            command.AddCommand(builder.BuildStartCommand());
            return command;
        }
        public Command BuildRefCommand() {
            var command = new Command("ref");
            var builder = new ApiSdk.Users.Item.Insights.Shared.Item.Resource.@Ref.RefRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPutCommand());
            return command;
        }
        public Command BuildScheduleChangeRequestCommand() {
            var command = new Command("schedule-change-request");
            var builder = new ApiSdk.Users.Item.Insights.Shared.Item.Resource.ScheduleChangeRequest.ScheduleChangeRequestRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildApproveCommand());
            command.AddCommand(builder.BuildDeclineCommand());
            return command;
        }
        public Command BuildTargetedManagedAppProtectionCommand() {
            var command = new Command("targeted-managed-app-protection");
            var builder = new ApiSdk.Users.Item.Insights.Shared.Item.Resource.TargetedManagedAppProtection.TargetedManagedAppProtectionRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildAssignCommand());
            command.AddCommand(builder.BuildTargetAppsCommand());
            return command;
        }
        public Command BuildWindowsInformationProtectionCommand() {
            var command = new Command("windows-information-protection");
            var builder = new ApiSdk.Users.Item.Insights.Shared.Item.Resource.WindowsInformationProtection.WindowsInformationProtectionRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildAssignCommand());
            return command;
        }
        public Command BuildWorkbookRangeCommand() {
            var command = new Command("workbook-range");
            var builder = new ApiSdk.Users.Item.Insights.Shared.Item.Resource.WorkbookRange.WorkbookRangeRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildClearCommand());
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildInsertCommand());
            command.AddCommand(builder.BuildMergeCommand());
            command.AddCommand(builder.BuildUnmergeCommand());
            return command;
        }
        public Command BuildWorkbookRangeFillCommand() {
            var command = new Command("workbook-range-fill");
            var builder = new ApiSdk.Users.Item.Insights.Shared.Item.Resource.WorkbookRangeFill.WorkbookRangeFillRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildClearCommand());
            return command;
        }
        public Command BuildWorkbookRangeFormatCommand() {
            var command = new Command("workbook-range-format");
            var builder = new ApiSdk.Users.Item.Insights.Shared.Item.Resource.WorkbookRangeFormat.WorkbookRangeFormatRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildAutofitColumnsCommand());
            command.AddCommand(builder.BuildAutofitRowsCommand());
            return command;
        }
        public Command BuildWorkbookRangeSortCommand() {
            var command = new Command("workbook-range-sort");
            var builder = new ApiSdk.Users.Item.Insights.Shared.Item.Resource.WorkbookRangeSort.WorkbookRangeSortRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildApplyCommand());
            return command;
        }
        public Command BuildWorkbookRangeViewCommand() {
            var command = new Command("workbook-range-view");
            var builder = new ApiSdk.Users.Item.Insights.Shared.Item.Resource.WorkbookRangeView.WorkbookRangeViewRequestBuilder(PathParameters, RequestAdapter);
            return command;
        }
        /// <summary>
        /// Instantiates a new ResourceRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public ResourceRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/users/{user_id}/insights/shared/{sharedInsight_id}/resource{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Used for navigating to the item that was shared. For file attachments, the type is fileAttachment. For linked attachments, the type is driveItem.
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
        /// Used for navigating to the item that was shared. For file attachments, the type is fileAttachment. For linked attachments, the type is driveItem.
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
        /// <summary>Used for navigating to the item that was shared. For file attachments, the type is fileAttachment. For linked attachments, the type is driveItem.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
