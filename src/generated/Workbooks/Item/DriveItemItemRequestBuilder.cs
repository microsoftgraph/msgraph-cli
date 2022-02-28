using ApiSdk.Models.Microsoft.Graph;
using ApiSdk.Workbooks.Item.Analytics;
using ApiSdk.Workbooks.Item.Checkin;
using ApiSdk.Workbooks.Item.Checkout;
using ApiSdk.Workbooks.Item.Children;
using ApiSdk.Workbooks.Item.Content;
using ApiSdk.Workbooks.Item.Copy;
using ApiSdk.Workbooks.Item.CreateLink;
using ApiSdk.Workbooks.Item.CreateUploadSession;
using ApiSdk.Workbooks.Item.Delta;
using ApiSdk.Workbooks.Item.DeltaWithToken;
using ApiSdk.Workbooks.Item.Follow;
using ApiSdk.Workbooks.Item.GetActivitiesByInterval;
using ApiSdk.Workbooks.Item.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval;
using ApiSdk.Workbooks.Item.Invite;
using ApiSdk.Workbooks.Item.ListItem;
using ApiSdk.Workbooks.Item.Permissions;
using ApiSdk.Workbooks.Item.Preview;
using ApiSdk.Workbooks.Item.Restore;
using ApiSdk.Workbooks.Item.SearchWithQ;
using ApiSdk.Workbooks.Item.Subscriptions;
using ApiSdk.Workbooks.Item.Thumbnails;
using ApiSdk.Workbooks.Item.Unfollow;
using ApiSdk.Workbooks.Item.ValidatePermission;
using ApiSdk.Workbooks.Item.Versions;
using ApiSdk.Workbooks.Item.Workbook;
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
namespace ApiSdk.Workbooks.Item {
    /// <summary>Builds and executes requests for operations under \workbooks\{driveItem-id}</summary>
    public class DriveItemItemRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public Command BuildAnalyticsCommand() {
            var command = new Command("analytics");
            var builder = new ApiSdk.Workbooks.Item.Analytics.AnalyticsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        public Command BuildCheckinCommand() {
            var command = new Command("checkin");
            var builder = new ApiSdk.Workbooks.Item.Checkin.CheckinRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildCheckoutCommand() {
            var command = new Command("checkout");
            var builder = new ApiSdk.Workbooks.Item.Checkout.CheckoutRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildChildrenCommand() {
            var command = new Command("children");
            var builder = new ApiSdk.Workbooks.Item.Children.ChildrenRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildContentCommand() {
            var command = new Command("content");
            var builder = new ApiSdk.Workbooks.Item.Content.ContentRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPutCommand());
            return command;
        }
        public Command BuildCopyCommand() {
            var command = new Command("copy");
            var builder = new ApiSdk.Workbooks.Item.Copy.CopyRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildCreateLinkCommand() {
            var command = new Command("create-link");
            var builder = new ApiSdk.Workbooks.Item.CreateLink.CreateLinkRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildCreateUploadSessionCommand() {
            var command = new Command("create-upload-session");
            var builder = new ApiSdk.Workbooks.Item.CreateUploadSession.CreateUploadSessionRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Delete entity from workbooks
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Delete entity from workbooks";
            // Create options for all the parameters
            var driveItemIdOption = new Option<string>("--drive-item-id", description: "key: id of driveItem") {
            };
            driveItemIdOption.IsRequired = true;
            command.AddOption(driveItemIdOption);
            command.SetHandler(async (object[] parameters) => {
                var driveItemId = (string) parameters[0];
                var cancellationToken = (CancellationToken) parameters[1];
                PathParameters.Clear();
                PathParameters.Add("driveItem_id", driveItemId);
                var requestInfo = CreateDeleteRequestInformation(q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(driveItemIdOption, new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        public Command BuildFollowCommand() {
            var command = new Command("follow");
            var builder = new ApiSdk.Workbooks.Item.Follow.FollowRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Get entity from workbooks by key
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Get entity from workbooks by key";
            // Create options for all the parameters
            var driveItemIdOption = new Option<string>("--drive-item-id", description: "key: id of driveItem") {
            };
            driveItemIdOption.IsRequired = true;
            command.AddOption(driveItemIdOption);
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
                var driveItemId = (string) parameters[0];
                var select = (string[]) parameters[1];
                var expand = (string[]) parameters[2];
                var output = (FormatterType) parameters[3];
                var outputFilterOption = (string) parameters[4];
                var outputFormatterFactory = (IOutputFormatterFactory) parameters[5];
                var cancellationToken = (CancellationToken) parameters[6];
                PathParameters.Clear();
                PathParameters.Add("driveItem_id", driveItemId);
                var requestInfo = CreateGetRequestInformation(q => {
                    q.Select = select;
                    q.Expand = expand;
                });
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                var formatter = outputFormatterFactory.GetFormatter(output);
                formatter.WriteOutput(response);
            }, new CollectionBinding(driveItemIdOption, selectOption, expandOption, outputOption, outputFilterOption, new TypeBinding(typeof(IOutputFormatterFactory)), new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        public Command BuildInviteCommand() {
            var command = new Command("invite");
            var builder = new ApiSdk.Workbooks.Item.Invite.InviteRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildListItemCommand() {
            var command = new Command("list-item");
            var builder = new ApiSdk.Workbooks.Item.ListItem.ListItemRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildAnalyticsCommand());
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildDriveItemCommand());
            command.AddCommand(builder.BuildFieldsCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildVersionsCommand());
            return command;
        }
        /// <summary>
        /// Update entity in workbooks
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Update entity in workbooks";
            // Create options for all the parameters
            var driveItemIdOption = new Option<string>("--drive-item-id", description: "key: id of driveItem") {
            };
            driveItemIdOption.IsRequired = true;
            command.AddOption(driveItemIdOption);
            var bodyOption = new Option<string>("--body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (object[] parameters) => {
                var driveItemId = (string) parameters[0];
                var body = (string) parameters[1];
                var cancellationToken = (CancellationToken) parameters[2];
                PathParameters.Clear();
                PathParameters.Add("driveItem_id", driveItemId);
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ApiSdk.Models.Microsoft.Graph.DriveItem>();
                var requestInfo = CreatePatchRequestInformation(model, q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(driveItemIdOption, bodyOption, new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        public Command BuildPermissionsCommand() {
            var command = new Command("permissions");
            var builder = new ApiSdk.Workbooks.Item.Permissions.PermissionsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildPreviewCommand() {
            var command = new Command("preview");
            var builder = new ApiSdk.Workbooks.Item.Preview.PreviewRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildRestoreCommand() {
            var command = new Command("restore");
            var builder = new ApiSdk.Workbooks.Item.Restore.RestoreRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildSubscriptionsCommand() {
            var command = new Command("subscriptions");
            var builder = new ApiSdk.Workbooks.Item.Subscriptions.SubscriptionsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildThumbnailsCommand() {
            var command = new Command("thumbnails");
            var builder = new ApiSdk.Workbooks.Item.Thumbnails.ThumbnailsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildUnfollowCommand() {
            var command = new Command("unfollow");
            var builder = new ApiSdk.Workbooks.Item.Unfollow.UnfollowRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildValidatePermissionCommand() {
            var command = new Command("validate-permission");
            var builder = new ApiSdk.Workbooks.Item.ValidatePermission.ValidatePermissionRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildVersionsCommand() {
            var command = new Command("versions");
            var builder = new ApiSdk.Workbooks.Item.Versions.VersionsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildWorkbookCommand() {
            var command = new Command("workbook");
            var builder = new ApiSdk.Workbooks.Item.Workbook.WorkbookRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildApplicationCommand());
            command.AddCommand(builder.BuildCloseSessionCommand());
            command.AddCommand(builder.BuildCommentsCommand());
            command.AddCommand(builder.BuildCreateSessionCommand());
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildFunctionsCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildNamesCommand());
            command.AddCommand(builder.BuildOperationsCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildRefreshSessionCommand());
            command.AddCommand(builder.BuildTablesCommand());
            command.AddCommand(builder.BuildWorksheetsCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new DriveItemItemRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public DriveItemItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/workbooks/{driveItem_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete entity from workbooks
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
        /// Get entity from workbooks by key
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
        /// Update entity in workbooks
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(ApiSdk.Models.Microsoft.Graph.DriveItem body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// Builds and executes requests for operations under \workbooks\{driveItem-id}\microsoft.graph.delta()
        /// </summary>
        public DeltaRequestBuilder Delta() {
            return new DeltaRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Builds and executes requests for operations under \workbooks\{driveItem-id}\microsoft.graph.delta(token='{token}')
        /// <param name="token">Usage: token={token}</param>
        /// </summary>
        public DeltaWithTokenRequestBuilder DeltaWithToken(string token) {
            if(string.IsNullOrEmpty(token)) throw new ArgumentNullException(nameof(token));
            return new DeltaWithTokenRequestBuilder(PathParameters, RequestAdapter, token);
        }
        /// <summary>
        /// Builds and executes requests for operations under \workbooks\{driveItem-id}\microsoft.graph.getActivitiesByInterval()
        /// </summary>
        public GetActivitiesByIntervalRequestBuilder GetActivitiesByInterval() {
            return new GetActivitiesByIntervalRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Builds and executes requests for operations under \workbooks\{driveItem-id}\microsoft.graph.getActivitiesByInterval(startDateTime='{startDateTime}',endDateTime='{endDateTime}',interval='{interval}')
        /// <param name="endDateTime">Usage: endDateTime={endDateTime}</param>
        /// <param name="interval">Usage: interval={interval}</param>
        /// <param name="startDateTime">Usage: startDateTime={startDateTime}</param>
        /// </summary>
        public GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithIntervalRequestBuilder GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval(string startDateTime, string endDateTime, string interval) {
            if(string.IsNullOrEmpty(endDateTime)) throw new ArgumentNullException(nameof(endDateTime));
            if(string.IsNullOrEmpty(interval)) throw new ArgumentNullException(nameof(interval));
            if(string.IsNullOrEmpty(startDateTime)) throw new ArgumentNullException(nameof(startDateTime));
            return new GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithIntervalRequestBuilder(PathParameters, RequestAdapter, startDateTime, endDateTime, interval);
        }
        /// <summary>
        /// Builds and executes requests for operations under \workbooks\{driveItem-id}\microsoft.graph.search(q='{q}')
        /// <param name="q">Usage: q={q}</param>
        /// </summary>
        public SearchWithQRequestBuilder SearchWithQ(string q) {
            if(string.IsNullOrEmpty(q)) throw new ArgumentNullException(nameof(q));
            return new SearchWithQRequestBuilder(PathParameters, RequestAdapter, q);
        }
        /// <summary>Get entity from workbooks by key</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
