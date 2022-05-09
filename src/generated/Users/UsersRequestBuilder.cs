using ApiSdk.Models;
using ApiSdk.Models.ODataErrors;
using ApiSdk.Users.Count;
using ApiSdk.Users.Delta;
using ApiSdk.Users.GetAvailableExtensionProperties;
using ApiSdk.Users.GetByIds;
using ApiSdk.Users.Item;
using ApiSdk.Users.ValidateProperties;
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
namespace ApiSdk.Users {
    /// <summary>Provides operations to manage the collection of user entities.</summary>
    public class UsersRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public Command BuildCommand() {
            var command = new Command("item");
            var builder = new UserItemRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildActivitiesCommand());
            command.AddCommand(builder.BuildAgreementAcceptancesCommand());
            command.AddCommand(builder.BuildAppRoleAssignmentsCommand());
            command.AddCommand(builder.BuildAssignLicenseCommand());
            command.AddCommand(builder.BuildAuthenticationCommand());
            command.AddCommand(builder.BuildCalendarCommand());
            command.AddCommand(builder.BuildCalendarGroupsCommand());
            command.AddCommand(builder.BuildCalendarsCommand());
            command.AddCommand(builder.BuildCalendarViewCommand());
            command.AddCommand(builder.BuildChangePasswordCommand());
            command.AddCommand(builder.BuildChatsCommand());
            command.AddCommand(builder.BuildCheckMemberGroupsCommand());
            command.AddCommand(builder.BuildCheckMemberObjectsCommand());
            command.AddCommand(builder.BuildContactFoldersCommand());
            command.AddCommand(builder.BuildContactsCommand());
            command.AddCommand(builder.BuildCreatedObjectsCommand());
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildDeviceManagementTroubleshootingEventsCommand());
            command.AddCommand(builder.BuildDirectReportsCommand());
            command.AddCommand(builder.BuildDriveCommand());
            command.AddCommand(builder.BuildDrivesCommand());
            command.AddCommand(builder.BuildEventsCommand());
            command.AddCommand(builder.BuildExportPersonalDataCommand());
            command.AddCommand(builder.BuildExtensionsCommand());
            command.AddCommand(builder.BuildFindMeetingTimesCommand());
            command.AddCommand(builder.BuildFollowedSitesCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildGetMailTipsCommand());
            command.AddCommand(builder.BuildGetMemberGroupsCommand());
            command.AddCommand(builder.BuildGetMemberObjectsCommand());
            command.AddCommand(builder.BuildInferenceClassificationCommand());
            command.AddCommand(builder.BuildInsightsCommand());
            command.AddCommand(builder.BuildJoinedTeamsCommand());
            command.AddCommand(builder.BuildLicenseDetailsCommand());
            command.AddCommand(builder.BuildMailFoldersCommand());
            command.AddCommand(builder.BuildManagedAppRegistrationsCommand());
            command.AddCommand(builder.BuildManagedDevicesCommand());
            command.AddCommand(builder.BuildManagerCommand());
            command.AddCommand(builder.BuildMemberOfCommand());
            command.AddCommand(builder.BuildMessagesCommand());
            command.AddCommand(builder.BuildOauth2PermissionGrantsCommand());
            command.AddCommand(builder.BuildOnenoteCommand());
            command.AddCommand(builder.BuildOnlineMeetingsCommand());
            command.AddCommand(builder.BuildOutlookCommand());
            command.AddCommand(builder.BuildOwnedDevicesCommand());
            command.AddCommand(builder.BuildOwnedObjectsCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildPeopleCommand());
            command.AddCommand(builder.BuildPhotoCommand());
            command.AddCommand(builder.BuildPhotosCommand());
            command.AddCommand(builder.BuildPlannerCommand());
            command.AddCommand(builder.BuildPresenceCommand());
            command.AddCommand(builder.BuildRegisteredDevicesCommand());
            command.AddCommand(builder.BuildRemoveAllDevicesFromManagementCommand());
            command.AddCommand(builder.BuildReprocessLicenseAssignmentCommand());
            command.AddCommand(builder.BuildRestoreCommand());
            command.AddCommand(builder.BuildRevokeSignInSessionsCommand());
            command.AddCommand(builder.BuildScopedRoleMemberOfCommand());
            command.AddCommand(builder.BuildSendMailCommand());
            command.AddCommand(builder.BuildSettingsCommand());
            command.AddCommand(builder.BuildTeamworkCommand());
            command.AddCommand(builder.BuildTodoCommand());
            command.AddCommand(builder.BuildTransitiveMemberOfCommand());
            command.AddCommand(builder.BuildTranslateExchangeIdsCommand());
            command.AddCommand(builder.BuildWipeManagedAppRegistrationsByDeviceTagCommand());
            return command;
        }
        public Command BuildCountCommand() {
            var command = new Command("count");
            var builder = new CountRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Add new entity to users
        /// </summary>
        public Command BuildCreateCommand() {
            var command = new Command("create");
            command.Description = "Add new entity to users";
            // Create options for all the parameters
            var bodyOption = new Option<string>("--body") {
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
            command.SetHandler(async (object[] parameters) => {
                var body = (string) parameters[0];
                var output = (FormatterType) parameters[1];
                var query = (string) parameters[2];
                var jsonNoIndent = (bool) parameters[3];
                var outputFilter = (IOutputFilter) parameters[4];
                var outputFormatterFactory = (IOutputFormatterFactory) parameters[5];
                var cancellationToken = (CancellationToken) parameters[6];
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ApiSdk.Models.User>(ApiSdk.Models.User.CreateFromDiscriminatorValue);
                var requestInfo = CreatePostRequestInformation(model, q => {
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
            }, new CollectionBinding(bodyOption, outputOption, queryOption, jsonNoIndentOption, new TypeBinding(typeof(IOutputFilter)), new TypeBinding(typeof(IOutputFormatterFactory)), new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        public Command BuildGetAvailableExtensionPropertiesCommand() {
            var command = new Command("get-available-extension-properties");
            var builder = new GetAvailableExtensionPropertiesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildGetByIdsCommand() {
            var command = new Command("get-by-ids");
            var builder = new GetByIdsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Get entities from users
        /// </summary>
        public Command BuildListCommand() {
            var command = new Command("list");
            command.Description = "Get entities from users";
            // Create options for all the parameters
            var consistencyLevelOption = new Option<string>("--consistency-level", description: "Indicates the requested consistency level. Documentation URL: https://developer.microsoft.com/en-us/office/blogs/microsoft-graph-advanced-queries-for-directory-objects-are-now-generally-available/") {
            };
            consistencyLevelOption.IsRequired = false;
            command.AddOption(consistencyLevelOption);
            var topOption = new Option<int?>("--top", description: "Show only the first n items") {
            };
            topOption.IsRequired = false;
            command.AddOption(topOption);
            var skipOption = new Option<int?>("--skip", description: "Skip the first n items") {
            };
            skipOption.IsRequired = false;
            command.AddOption(skipOption);
            var searchOption = new Option<string>("--search", description: "Search items by search phrases") {
            };
            searchOption.IsRequired = false;
            command.AddOption(searchOption);
            var filterOption = new Option<string>("--filter", description: "Filter items by property values") {
            };
            filterOption.IsRequired = false;
            command.AddOption(filterOption);
            var countOption = new Option<bool?>("--count", description: "Include count of items") {
            };
            countOption.IsRequired = false;
            command.AddOption(countOption);
            var orderbyOption = new Option<string[]>("--orderby", description: "Order items by property values") {
                Arity = ArgumentArity.ZeroOrMore
            };
            orderbyOption.IsRequired = false;
            command.AddOption(orderbyOption);
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
                var consistencyLevel = (string) parameters[0];
                var top = (int?) parameters[1];
                var skip = (int?) parameters[2];
                var search = (string) parameters[3];
                var filter = (string) parameters[4];
                var count = (bool?) parameters[5];
                var orderby = (string[]) parameters[6];
                var select = (string[]) parameters[7];
                var expand = (string[]) parameters[8];
                var output = (FormatterType) parameters[9];
                var query = (string) parameters[10];
                var jsonNoIndent = (bool) parameters[11];
                var outputFilter = (IOutputFilter) parameters[12];
                var outputFormatterFactory = (IOutputFormatterFactory) parameters[13];
                var cancellationToken = (CancellationToken) parameters[14];
                var requestInfo = CreateGetRequestInformation(q => {
                    q.QueryParameters.Top = top;
                    q.QueryParameters.Skip = skip;
                    if (!String.IsNullOrEmpty(search)) q.QueryParameters.Search = search;
                    if (!String.IsNullOrEmpty(filter)) q.QueryParameters.Filter = filter;
                    q.QueryParameters.Count = count;
                    q.QueryParameters.Orderby = orderby;
                    q.QueryParameters.Select = select;
                    q.QueryParameters.Expand = expand;
                });
                requestInfo.Headers["ConsistencyLevel"] = consistencyLevel;
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                response = await outputFilter?.FilterOutputAsync(response, query, cancellationToken) ?? response;
                var formatterOptions = output.GetOutputFormatterOptions(new FormatterOptionsModel(!jsonNoIndent));
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, formatterOptions, cancellationToken);
            }, new CollectionBinding(consistencyLevelOption, topOption, skipOption, searchOption, filterOption, new NullableBooleanBinding(countOption), orderbyOption, selectOption, expandOption, outputOption, queryOption, jsonNoIndentOption, new TypeBinding(typeof(IOutputFilter)), new TypeBinding(typeof(IOutputFormatterFactory)), new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        public Command BuildValidatePropertiesCommand() {
            var command = new Command("validate-properties");
            var builder = new ValidatePropertiesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new UsersRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public UsersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/users{?%24top,%24skip,%24search,%24filter,%24count,%24orderby,%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Get entities from users
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<UsersRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new UsersRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Add new entity to users
        /// <param name="body"></param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreatePostRequestInformation(ApiSdk.Models.User body, Action<UsersRequestBuilderPostRequestConfiguration> requestConfiguration = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new UsersRequestBuilderPostRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Provides operations to call the delta method.
        /// </summary>
        public DeltaRequestBuilder Delta() {
            return new DeltaRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Get entities from users</summary>
        public class UsersRequestBuilderGetQueryParameters {
            /// <summary>Include count of items</summary>
            [QueryParameter("%24count")]
            public bool? Count { get; set; }
            /// <summary>Expand related entities</summary>
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
            /// <summary>Filter items by property values</summary>
            [QueryParameter("%24filter")]
            public string Filter { get; set; }
            /// <summary>Order items by property values</summary>
            [QueryParameter("%24orderby")]
            public string[] Orderby { get; set; }
            /// <summary>Search items by search phrases</summary>
            [QueryParameter("%24search")]
            public string Search { get; set; }
            /// <summary>Select properties to be returned</summary>
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
            /// <summary>Skip the first n items</summary>
            [QueryParameter("%24skip")]
            public int? Skip { get; set; }
            /// <summary>Show only the first n items</summary>
            [QueryParameter("%24top")]
            public int? Top { get; set; }
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class UsersRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public UsersRequestBuilderGetQueryParameters QueryParameters { get; set; } = new UsersRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new usersRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public UsersRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class UsersRequestBuilderPostRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new usersRequestBuilderPostRequestConfiguration and sets the default values.
            /// </summary>
            public UsersRequestBuilderPostRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
    }
}
