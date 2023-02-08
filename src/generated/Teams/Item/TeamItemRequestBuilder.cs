using ApiSdk.Models;
using ApiSdk.Models.ODataErrors;
using ApiSdk.Teams.Item.AllChannels;
using ApiSdk.Teams.Item.Channels;
using ApiSdk.Teams.Item.Group;
using ApiSdk.Teams.Item.IncomingChannels;
using ApiSdk.Teams.Item.InstalledApps;
using ApiSdk.Teams.Item.Members;
using ApiSdk.Teams.Item.MicrosoftGraphArchive;
using ApiSdk.Teams.Item.MicrosoftGraphClone;
using ApiSdk.Teams.Item.MicrosoftGraphCompleteMigration;
using ApiSdk.Teams.Item.MicrosoftGraphSendActivityNotification;
using ApiSdk.Teams.Item.MicrosoftGraphUnarchive;
using ApiSdk.Teams.Item.Operations;
using ApiSdk.Teams.Item.Photo;
using ApiSdk.Teams.Item.PrimaryChannel;
using ApiSdk.Teams.Item.Schedule;
using ApiSdk.Teams.Item.Tags;
using ApiSdk.Teams.Item.Template;
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
namespace ApiSdk.Teams.Item {
    /// <summary>
    /// Provides operations to manage the collection of team entities.
    /// </summary>
    public class TeamItemRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Provides operations to manage the allChannels property of the microsoft.graph.team entity.
        /// </summary>
        public Command BuildAllChannelsCommand() {
            var command = new Command("all-channels");
            command.Description = "Provides operations to manage the allChannels property of the microsoft.graph.team entity.";
            var builder = new AllChannelsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the channels property of the microsoft.graph.team entity.
        /// </summary>
        public Command BuildChannelsCommand() {
            var command = new Command("channels");
            command.Description = "Provides operations to manage the channels property of the microsoft.graph.team entity.";
            var builder = new ChannelsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGetAllMessagesCommand());
            return command;
        }
        /// <summary>
        /// Delete entity from teams
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Delete entity from teams";
            // Create options for all the parameters
            var teamIdOption = new Option<string>("--team-id", description: "key: id of team") {
            };
            teamIdOption.IsRequired = true;
            command.AddOption(teamIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var teamId = invocationContext.ParseResult.GetValueForOption(teamIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (teamId is not null) requestInfo.PathParameters.Add("team%2Did", teamId);
                if (ifMatch is not null) requestInfo.Headers.Add("If-Match", ifMatch);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                await reqAdapter.SendNoContentAsync(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            });
            return command;
        }
        /// <summary>
        /// Retrieve the properties and relationships of the specified team.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/team-get?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Retrieve the properties and relationships of the specified team.\n\nFind more info here:\n  https://docs.microsoft.com/graph/api/team-get?view=graph-rest-1.0";
            // Create options for all the parameters
            var teamIdOption = new Option<string>("--team-id", description: "key: id of team") {
            };
            teamIdOption.IsRequired = true;
            command.AddOption(teamIdOption);
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
                var teamId = invocationContext.ParseResult.GetValueForOption(teamIdOption);
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
                if (teamId is not null) requestInfo.PathParameters.Add("team%2Did", teamId);
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
        /// Provides operations to manage the group property of the microsoft.graph.team entity.
        /// </summary>
        public Command BuildGroupCommand() {
            var command = new Command("group");
            command.Description = "Provides operations to manage the group property of the microsoft.graph.team entity.";
            var builder = new GroupRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the incomingChannels property of the microsoft.graph.team entity.
        /// </summary>
        public Command BuildIncomingChannelsCommand() {
            var command = new Command("incoming-channels");
            command.Description = "Provides operations to manage the incomingChannels property of the microsoft.graph.team entity.";
            var builder = new IncomingChannelsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the installedApps property of the microsoft.graph.team entity.
        /// </summary>
        public Command BuildInstalledAppsCommand() {
            var command = new Command("installed-apps");
            command.Description = "Provides operations to manage the installedApps property of the microsoft.graph.team entity.";
            var builder = new InstalledAppsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the members property of the microsoft.graph.team entity.
        /// </summary>
        public Command BuildMembersCommand() {
            var command = new Command("members");
            command.Description = "Provides operations to manage the members property of the microsoft.graph.team entity.";
            var builder = new MembersRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphAddCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the archive method.
        /// </summary>
        public Command BuildMicrosoftGraphArchiveCommand() {
            var command = new Command("microsoft-graph-archive");
            command.Description = "Provides operations to call the archive method.";
            var builder = new MicrosoftGraphArchiveRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the clone method.
        /// </summary>
        public Command BuildMicrosoftGraphCloneCommand() {
            var command = new Command("microsoft-graph-clone");
            command.Description = "Provides operations to call the clone method.";
            var builder = new MicrosoftGraphCloneRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the completeMigration method.
        /// </summary>
        public Command BuildMicrosoftGraphCompleteMigrationCommand() {
            var command = new Command("microsoft-graph-complete-migration");
            command.Description = "Provides operations to call the completeMigration method.";
            var builder = new MicrosoftGraphCompleteMigrationRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the sendActivityNotification method.
        /// </summary>
        public Command BuildMicrosoftGraphSendActivityNotificationCommand() {
            var command = new Command("microsoft-graph-send-activity-notification");
            command.Description = "Provides operations to call the sendActivityNotification method.";
            var builder = new MicrosoftGraphSendActivityNotificationRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the unarchive method.
        /// </summary>
        public Command BuildMicrosoftGraphUnarchiveCommand() {
            var command = new Command("microsoft-graph-unarchive");
            command.Description = "Provides operations to call the unarchive method.";
            var builder = new MicrosoftGraphUnarchiveRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the operations property of the microsoft.graph.team entity.
        /// </summary>
        public Command BuildOperationsCommand() {
            var command = new Command("operations");
            command.Description = "Provides operations to manage the operations property of the microsoft.graph.team entity.";
            var builder = new OperationsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Update the properties of the specified team.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/team-update?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Update the properties of the specified team.\n\nFind more info here:\n  https://docs.microsoft.com/graph/api/team-update?view=graph-rest-1.0";
            // Create options for all the parameters
            var teamIdOption = new Option<string>("--team-id", description: "key: id of team") {
            };
            teamIdOption.IsRequired = true;
            command.AddOption(teamIdOption);
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
                var teamId = invocationContext.ParseResult.GetValueForOption(teamIdOption);
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
                var model = parseNode.GetObjectValue<ApiSdk.Models.Team>(ApiSdk.Models.Team.CreateFromDiscriminatorValue);
                if (model is null) return; // Cannot create a POST request from a null model.
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (teamId is not null) requestInfo.PathParameters.Add("team%2Did", teamId);
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
        /// Provides operations to manage the photo property of the microsoft.graph.team entity.
        /// </summary>
        public Command BuildPhotoCommand() {
            var command = new Command("photo");
            command.Description = "Provides operations to manage the photo property of the microsoft.graph.team entity.";
            var builder = new PhotoRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildContentCommand());
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the primaryChannel property of the microsoft.graph.team entity.
        /// </summary>
        public Command BuildPrimaryChannelCommand() {
            var command = new Command("primary-channel");
            command.Description = "Provides operations to manage the primaryChannel property of the microsoft.graph.team entity.";
            var builder = new PrimaryChannelRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildFilesFolderCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildMembersCommand());
            command.AddCommand(builder.BuildMessagesCommand());
            command.AddCommand(builder.BuildMicrosoftGraphCompleteMigrationCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDoesUserHaveAccessuserIdUserIdTenantIdTenantIdUserPrincipalNameUserPrincipalNameCommand());
            command.AddCommand(builder.BuildMicrosoftGraphProvisionEmailCommand());
            command.AddCommand(builder.BuildMicrosoftGraphRemoveEmailCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildSharedWithTeamsCommand());
            command.AddCommand(builder.BuildTabsCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the schedule property of the microsoft.graph.team entity.
        /// </summary>
        public Command BuildScheduleCommand() {
            var command = new Command("schedule");
            command.Description = "Provides operations to manage the schedule property of the microsoft.graph.team entity.";
            var builder = new ScheduleRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildMicrosoftGraphShareCommand());
            command.AddCommand(builder.BuildOfferShiftRequestsCommand());
            command.AddCommand(builder.BuildOpenShiftChangeRequestsCommand());
            command.AddCommand(builder.BuildOpenShiftsCommand());
            command.AddCommand(builder.BuildPutCommand());
            command.AddCommand(builder.BuildSchedulingGroupsCommand());
            command.AddCommand(builder.BuildShiftsCommand());
            command.AddCommand(builder.BuildSwapShiftsChangeRequestsCommand());
            command.AddCommand(builder.BuildTimeOffReasonsCommand());
            command.AddCommand(builder.BuildTimeOffRequestsCommand());
            command.AddCommand(builder.BuildTimesOffCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the tags property of the microsoft.graph.team entity.
        /// </summary>
        public Command BuildTagsCommand() {
            var command = new Command("tags");
            command.Description = "Provides operations to manage the tags property of the microsoft.graph.team entity.";
            var builder = new TagsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the template property of the microsoft.graph.team entity.
        /// </summary>
        public Command BuildTemplateCommand() {
            var command = new Command("template");
            command.Description = "Provides operations to manage the template property of the microsoft.graph.team entity.";
            var builder = new TemplateRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new TeamItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public TeamItemRequestBuilder(Dictionary<string, object> pathParameters) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            UrlTemplate = "{+baseurl}/teams/{team%2Did}{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
        }
        /// <summary>
        /// Delete entity from teams
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<TeamItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<TeamItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new TeamItemRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Retrieve the properties and relationships of the specified team.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<TeamItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<TeamItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new TeamItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the properties of the specified team.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(ApiSdk.Models.Team body, Action<TeamItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(ApiSdk.Models.Team body, Action<TeamItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new TeamItemRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class TeamItemRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new TeamItemRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public TeamItemRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Retrieve the properties and relationships of the specified team.
        /// </summary>
        public class TeamItemRequestBuilderGetQueryParameters {
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
        public class TeamItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public TeamItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new TeamItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new TeamItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public TeamItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class TeamItemRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new TeamItemRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public TeamItemRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
