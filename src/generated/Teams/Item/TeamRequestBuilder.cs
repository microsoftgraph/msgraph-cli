using ApiSdk.Models.Microsoft.Graph;
using ApiSdk.Teams.Item.Archive;
using ApiSdk.Teams.Item.Channels;
using ApiSdk.Teams.Item.Clone;
using ApiSdk.Teams.Item.CompleteMigration;
using ApiSdk.Teams.Item.Group;
using ApiSdk.Teams.Item.InstalledApps;
using ApiSdk.Teams.Item.Members;
using ApiSdk.Teams.Item.Operations;
using ApiSdk.Teams.Item.PrimaryChannel;
using ApiSdk.Teams.Item.Schedule;
using ApiSdk.Teams.Item.SendActivityNotification;
using ApiSdk.Teams.Item.Template;
using ApiSdk.Teams.Item.Unarchive;
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
namespace ApiSdk.Teams.Item {
    /// <summary>Builds and executes requests for operations under \teams\{team-id}</summary>
    public class TeamRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public Command BuildArchiveCommand() {
            var command = new Command("archive");
            var builder = new ApiSdk.Teams.Item.Archive.ArchiveRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildChannelsCommand() {
            var command = new Command("channels");
            var builder = new ApiSdk.Teams.Item.Channels.ChannelsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildCloneCommand() {
            var command = new Command("clone");
            var builder = new ApiSdk.Teams.Item.Clone.CloneRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildCompleteMigrationCommand() {
            var command = new Command("complete-migration");
            var builder = new ApiSdk.Teams.Item.CompleteMigration.CompleteMigrationRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Delete entity from teams
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Delete entity from teams";
            // Create options for all the parameters
            command.AddOption(new Option<string>("--team-id", description: "key: id of team"));
            command.Handler = CommandHandler.Create<string>(async (teamId) => {
                var requestInfo = CreateDeleteRequestInformation();
                if (!String.IsNullOrEmpty(teamId)) requestInfo.PathParameters.Add("team_id", teamId);
                await RequestAdapter.SendNoContentAsync(requestInfo);
                // Print request output. What if the request has no return?
                Console.WriteLine("Success");
            });
            return command;
        }
        /// <summary>
        /// Get entity from teams by key
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Get entity from teams by key";
            // Create options for all the parameters
            command.AddOption(new Option<string>("--team-id", description: "key: id of team"));
            command.AddOption(new Option<object>("--select", description: "Select properties to be returned"));
            command.AddOption(new Option<object>("--expand", description: "Expand related entities"));
            command.Handler = CommandHandler.Create<string, object, object>(async (teamId, select, expand) => {
                var requestInfo = CreateGetRequestInformation();
                if (!String.IsNullOrEmpty(teamId)) requestInfo.PathParameters.Add("team_id", teamId);
                requestInfo.QueryParameters.Add("select", select);
                requestInfo.QueryParameters.Add("expand", expand);
                var result = await RequestAdapter.SendAsync<ApiSdk.Models.Microsoft.Graph.Team>(requestInfo);
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
        public Command BuildGroupCommand() {
            var command = new Command("group");
            var builder = new ApiSdk.Teams.Item.Group.GroupRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        public Command BuildInstalledAppsCommand() {
            var command = new Command("installed-apps");
            var builder = new ApiSdk.Teams.Item.InstalledApps.InstalledAppsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildMembersCommand() {
            var command = new Command("members");
            var builder = new ApiSdk.Teams.Item.Members.MembersRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildAddCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildOperationsCommand() {
            var command = new Command("operations");
            var builder = new ApiSdk.Teams.Item.Operations.OperationsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Update entity in teams
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Update entity in teams";
            // Create options for all the parameters
            command.AddOption(new Option<string>("--team-id", description: "key: id of team"));
            command.AddOption(new Option<string>("--body"));
            command.Handler = CommandHandler.Create<string, string>(async (teamId, body) => {
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Team>();
                var requestInfo = CreatePatchRequestInformation(model);
                if (!String.IsNullOrEmpty(teamId)) requestInfo.PathParameters.Add("team_id", teamId);
                await RequestAdapter.SendNoContentAsync(requestInfo);
                // Print request output. What if the request has no return?
                Console.WriteLine("Success");
            });
            return command;
        }
        public Command BuildPrimaryChannelCommand() {
            var command = new Command("primary-channel");
            var builder = new ApiSdk.Teams.Item.PrimaryChannel.PrimaryChannelRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCompleteMigrationCommand());
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildFilesFolderCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildMembersCommand());
            command.AddCommand(builder.BuildMessagesCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildProvisionEmailCommand());
            command.AddCommand(builder.BuildRemoveEmailCommand());
            command.AddCommand(builder.BuildTabsCommand());
            return command;
        }
        public Command BuildScheduleCommand() {
            var command = new Command("schedule");
            var builder = new ApiSdk.Teams.Item.Schedule.ScheduleRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildOfferShiftRequestsCommand());
            command.AddCommand(builder.BuildOpenShiftChangeRequestsCommand());
            command.AddCommand(builder.BuildOpenShiftsCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildSchedulingGroupsCommand());
            command.AddCommand(builder.BuildShareCommand());
            command.AddCommand(builder.BuildShiftsCommand());
            command.AddCommand(builder.BuildSwapShiftsChangeRequestsCommand());
            command.AddCommand(builder.BuildTimeOffReasonsCommand());
            command.AddCommand(builder.BuildTimeOffRequestsCommand());
            command.AddCommand(builder.BuildTimesOffCommand());
            return command;
        }
        public Command BuildSendActivityNotificationCommand() {
            var command = new Command("send-activity-notification");
            var builder = new ApiSdk.Teams.Item.SendActivityNotification.SendActivityNotificationRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildTemplateCommand() {
            var command = new Command("template");
            var builder = new ApiSdk.Teams.Item.Template.TemplateRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        public Command BuildUnarchiveCommand() {
            var command = new Command("unarchive");
            var builder = new ApiSdk.Teams.Item.Unarchive.UnarchiveRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new TeamRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public TeamRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/teams/{team_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete entity from teams
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreateDeleteRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Get entity from teams by key
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
        /// Update entity in teams
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(ApiSdk.Models.Microsoft.Graph.Team body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Delete entity from teams
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateDeleteRequestInformation(h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>
        /// Get entity from teams by key
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<ApiSdk.Models.Microsoft.Graph.Team> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<ApiSdk.Models.Microsoft.Graph.Team>(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>
        /// Update entity in teams
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="model"></param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(ApiSdk.Models.Microsoft.Graph.Team model, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = model ?? throw new ArgumentNullException(nameof(model));
            var requestInfo = CreatePatchRequestInformation(model, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>Get entity from teams by key</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
