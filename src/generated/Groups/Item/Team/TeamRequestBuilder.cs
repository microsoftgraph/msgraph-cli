using ApiSdk.Groups.Item.Team.Channels;
using ApiSdk.Groups.Item.Team.Group;
using ApiSdk.Groups.Item.Team.InstalledApps;
using ApiSdk.Groups.Item.Team.Members;
using ApiSdk.Groups.Item.Team.Operations;
using ApiSdk.Groups.Item.Team.PrimaryChannel;
using ApiSdk.Groups.Item.Team.Schedule;
using ApiSdk.Groups.Item.Team.Template;
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
namespace ApiSdk.Groups.Item.Team {
    /// <summary>Provides operations to manage the team property of the microsoft.graph.group entity.</summary>
    public class TeamRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public Command BuildChannelsCommand() {
            var command = new Command("channels");
            var builder = new ChannelsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Delete navigation property team for groups
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Delete navigation property team for groups";
            // Create options for all the parameters
            var groupIdOption = new Option<string>("--group-id", description: "key: id of group") {
            };
            groupIdOption.IsRequired = true;
            command.AddOption(groupIdOption);
            command.SetHandler(async (object[] parameters) => {
                var groupId = (string) parameters[0];
                var cancellationToken = (CancellationToken) parameters[1];
                PathParameters.Clear();
                PathParameters.Add("group_id", groupId);
                var requestInfo = CreateDeleteRequestInformation(q => {
                });
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(groupIdOption, new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// Get team from groups
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Get team from groups";
            // Create options for all the parameters
            var groupIdOption = new Option<string>("--group-id", description: "key: id of group") {
            };
            groupIdOption.IsRequired = true;
            command.AddOption(groupIdOption);
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
                var groupId = (string) parameters[0];
                var select = (string[]) parameters[1];
                var expand = (string[]) parameters[2];
                var output = (FormatterType) parameters[3];
                var query = (string) parameters[4];
                var jsonNoIndent = (bool) parameters[5];
                var outputFilter = (IOutputFilter) parameters[6];
                var outputFormatterFactory = (IOutputFormatterFactory) parameters[7];
                var cancellationToken = (CancellationToken) parameters[8];
                PathParameters.Clear();
                PathParameters.Add("group_id", groupId);
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
            }, new CollectionBinding(groupIdOption, selectOption, expandOption, outputOption, queryOption, jsonNoIndentOption, new TypeBinding(typeof(IOutputFilter)), new TypeBinding(typeof(IOutputFormatterFactory)), new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        public Command BuildGroupCommand() {
            var command = new Command("group");
            var builder = new GroupRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        public Command BuildInstalledAppsCommand() {
            var command = new Command("installed-apps");
            var builder = new InstalledAppsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildMembersCommand() {
            var command = new Command("members");
            var builder = new MembersRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildAddCommand());
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildOperationsCommand() {
            var command = new Command("operations");
            var builder = new OperationsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Update the navigation property team in groups
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Update the navigation property team in groups";
            // Create options for all the parameters
            var groupIdOption = new Option<string>("--group-id", description: "key: id of group") {
            };
            groupIdOption.IsRequired = true;
            command.AddOption(groupIdOption);
            var bodyOption = new Option<string>("--body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (object[] parameters) => {
                var groupId = (string) parameters[0];
                var body = (string) parameters[1];
                var cancellationToken = (CancellationToken) parameters[2];
                PathParameters.Clear();
                PathParameters.Add("group_id", groupId);
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Team>(ApiSdk.Models.Microsoft.Graph.Team.CreateFromDiscriminatorValue);
                var requestInfo = CreatePatchRequestInformation(model, q => {
                });
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(groupIdOption, bodyOption, new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        public Command BuildPrimaryChannelCommand() {
            var command = new Command("primary-channel");
            var builder = new PrimaryChannelRequestBuilder(PathParameters, RequestAdapter);
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
            var builder = new ScheduleRequestBuilder(PathParameters, RequestAdapter);
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
        public Command BuildTemplateCommand() {
            var command = new Command("template");
            var builder = new TemplateRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
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
            UrlTemplate = "{+baseurl}/groups/{group_id}/team{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete navigation property team for groups
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
        /// Get team from groups
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
        /// Update the navigation property team in groups
        /// <param name="body"></param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(ApiSdk.Models.Microsoft.Graph.Team body, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default) {
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
        /// <summary>Get team from groups</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
