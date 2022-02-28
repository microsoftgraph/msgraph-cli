using ApiSdk.Me.Insights.Shared.Item.LastSharedMethod.CalendarSharingMessage;
using ApiSdk.Me.Insights.Shared.Item.LastSharedMethod.ManagedAppProtection;
using ApiSdk.Me.Insights.Shared.Item.LastSharedMethod.MobileAppContentFile;
using ApiSdk.Me.Insights.Shared.Item.LastSharedMethod.PrintDocument;
using ApiSdk.Me.Insights.Shared.Item.LastSharedMethod.PrintJob;
using ApiSdk.Me.Insights.Shared.Item.LastSharedMethod.Ref;
using ApiSdk.Me.Insights.Shared.Item.LastSharedMethod.ScheduleChangeRequest;
using ApiSdk.Me.Insights.Shared.Item.LastSharedMethod.TargetedManagedAppProtection;
using ApiSdk.Me.Insights.Shared.Item.LastSharedMethod.WindowsInformationProtection;
using ApiSdk.Me.Insights.Shared.Item.LastSharedMethod.WorkbookRange;
using ApiSdk.Me.Insights.Shared.Item.LastSharedMethod.WorkbookRangeFill;
using ApiSdk.Me.Insights.Shared.Item.LastSharedMethod.WorkbookRangeFormat;
using ApiSdk.Me.Insights.Shared.Item.LastSharedMethod.WorkbookRangeSort;
using ApiSdk.Me.Insights.Shared.Item.LastSharedMethod.WorkbookRangeView;
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
namespace ApiSdk.Me.Insights.Shared.Item.LastSharedMethod {
    /// <summary>Builds and executes requests for operations under \me\insights\shared\{sharedInsight-id}\lastSharedMethod</summary>
    public class LastSharedMethodRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public Command BuildCalendarSharingMessageCommand() {
            var command = new Command("calendar-sharing-message");
            var builder = new ApiSdk.Me.Insights.Shared.Item.LastSharedMethod.CalendarSharingMessage.CalendarSharingMessageRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildAcceptCommand());
            return command;
        }
        /// <summary>
        /// Get lastSharedMethod from me
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Get lastSharedMethod from me";
            // Create options for all the parameters
            var sharedInsightIdOption = new Option<string>("--shared-insight-id", description: "key: id of sharedInsight") {
            };
            sharedInsightIdOption.IsRequired = true;
            command.AddOption(sharedInsightIdOption);
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
            command.SetHandler(async (object[] parameters) => {
                var sharedInsightId = (string) parameters[0];
                var select = (string[]) parameters[1];
                var expand = (string[]) parameters[2];
                var output = (FormatterType) parameters[3];
                var outputFormatterFactory = (IOutputFormatterFactory) parameters[4];
                var cancellationToken = (CancellationToken) parameters[5];
                PathParameters.Clear();
                PathParameters.Add("sharedInsight_id", sharedInsightId);
                var requestInfo = CreateGetRequestInformation(q => {
                    q.Select = select;
                    q.Expand = expand;
                });
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                var formatter = outputFormatterFactory.GetFormatter(output);
                formatter.WriteOutput(response);
            }, new CollectionBinding(sharedInsightIdOption, selectOption, expandOption, outputOption, new TypeBinding(typeof(IOutputFormatterFactory)), new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        public Command BuildManagedAppProtectionCommand() {
            var command = new Command("managed-app-protection");
            var builder = new ApiSdk.Me.Insights.Shared.Item.LastSharedMethod.ManagedAppProtection.ManagedAppProtectionRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildTargetAppsCommand());
            return command;
        }
        public Command BuildMobileAppContentFileCommand() {
            var command = new Command("mobile-app-content-file");
            var builder = new ApiSdk.Me.Insights.Shared.Item.LastSharedMethod.MobileAppContentFile.MobileAppContentFileRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommitCommand());
            command.AddCommand(builder.BuildRenewUploadCommand());
            return command;
        }
        public Command BuildPrintDocumentCommand() {
            var command = new Command("print-document");
            var builder = new ApiSdk.Me.Insights.Shared.Item.LastSharedMethod.PrintDocument.PrintDocumentRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateUploadSessionCommand());
            return command;
        }
        public Command BuildPrintJobCommand() {
            var command = new Command("print-job");
            var builder = new ApiSdk.Me.Insights.Shared.Item.LastSharedMethod.PrintJob.PrintJobRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildAbortCommand());
            command.AddCommand(builder.BuildCancelCommand());
            command.AddCommand(builder.BuildRedirectCommand());
            command.AddCommand(builder.BuildStartCommand());
            return command;
        }
        public Command BuildRefCommand() {
            var command = new Command("ref");
            var builder = new ApiSdk.Me.Insights.Shared.Item.LastSharedMethod.Ref.RefRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPutCommand());
            return command;
        }
        public Command BuildScheduleChangeRequestCommand() {
            var command = new Command("schedule-change-request");
            var builder = new ApiSdk.Me.Insights.Shared.Item.LastSharedMethod.ScheduleChangeRequest.ScheduleChangeRequestRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildApproveCommand());
            command.AddCommand(builder.BuildDeclineCommand());
            return command;
        }
        public Command BuildTargetedManagedAppProtectionCommand() {
            var command = new Command("targeted-managed-app-protection");
            var builder = new ApiSdk.Me.Insights.Shared.Item.LastSharedMethod.TargetedManagedAppProtection.TargetedManagedAppProtectionRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildAssignCommand());
            command.AddCommand(builder.BuildTargetAppsCommand());
            return command;
        }
        public Command BuildWindowsInformationProtectionCommand() {
            var command = new Command("windows-information-protection");
            var builder = new ApiSdk.Me.Insights.Shared.Item.LastSharedMethod.WindowsInformationProtection.WindowsInformationProtectionRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildAssignCommand());
            return command;
        }
        public Command BuildWorkbookRangeCommand() {
            var command = new Command("workbook-range");
            var builder = new ApiSdk.Me.Insights.Shared.Item.LastSharedMethod.WorkbookRange.WorkbookRangeRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildClearCommand());
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildInsertCommand());
            command.AddCommand(builder.BuildMergeCommand());
            command.AddCommand(builder.BuildUnmergeCommand());
            return command;
        }
        public Command BuildWorkbookRangeFillCommand() {
            var command = new Command("workbook-range-fill");
            var builder = new ApiSdk.Me.Insights.Shared.Item.LastSharedMethod.WorkbookRangeFill.WorkbookRangeFillRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildClearCommand());
            return command;
        }
        public Command BuildWorkbookRangeFormatCommand() {
            var command = new Command("workbook-range-format");
            var builder = new ApiSdk.Me.Insights.Shared.Item.LastSharedMethod.WorkbookRangeFormat.WorkbookRangeFormatRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildAutofitColumnsCommand());
            command.AddCommand(builder.BuildAutofitRowsCommand());
            return command;
        }
        public Command BuildWorkbookRangeSortCommand() {
            var command = new Command("workbook-range-sort");
            var builder = new ApiSdk.Me.Insights.Shared.Item.LastSharedMethod.WorkbookRangeSort.WorkbookRangeSortRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildApplyCommand());
            return command;
        }
        public Command BuildWorkbookRangeViewCommand() {
            var command = new Command("workbook-range-view");
            var builder = new ApiSdk.Me.Insights.Shared.Item.LastSharedMethod.WorkbookRangeView.WorkbookRangeViewRequestBuilder(PathParameters, RequestAdapter);
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
            UrlTemplate = "{+baseurl}/me/insights/shared/{sharedInsight_id}/lastSharedMethod{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Get lastSharedMethod from me
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
        /// <summary>Get lastSharedMethod from me</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
