using ApiSdk.Models;
using ApiSdk.Models.ODataErrors;
using ApiSdk.Users.Item.Events.Count;
using ApiSdk.Users.Item.Events.Item;
using ApiSdk.Users.Item.Events.MicrosoftGraphDelta;
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
namespace ApiSdk.Users.Item.Events {
    /// <summary>
    /// Provides operations to manage the events property of the microsoft.graph.user entity.
    /// </summary>
    public class EventsRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Provides operations to manage the events property of the microsoft.graph.user entity.
        /// </summary>
        public Command BuildCommand() {
            var command = new Command("item");
            var builder = new EventItemRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildAttachmentsCommand());
            command.AddCommand(builder.BuildCalendarCommand());
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildExtensionsCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildInstancesCommand());
            command.AddCommand(builder.BuildMicrosoftGraphAcceptCommand());
            command.AddCommand(builder.BuildMicrosoftGraphCancelCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDeclineCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDismissReminderCommand());
            command.AddCommand(builder.BuildMicrosoftGraphForwardCommand());
            command.AddCommand(builder.BuildMicrosoftGraphSnoozeReminderCommand());
            command.AddCommand(builder.BuildMicrosoftGraphTentativelyAcceptCommand());
            command.AddCommand(builder.BuildMultiValueExtendedPropertiesCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildSingleValueExtendedPropertiesCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to count the resources in the collection.
        /// </summary>
        public Command BuildCountCommand() {
            var command = new Command("count");
            command.Description = "Provides operations to count the resources in the collection.";
            var builder = new CountRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Create an event in the user&apos;s default calendar or specified calendar. By default, the **allowNewTimeProposals** property is set to true when an event is created, which means invitees can propose a different date/time for the event. See Propose new meeting times for more information on how to propose a time, and how to receive and accept a new time proposal. You can specify the time zone for each of the start and end times of the event as part of their values, because the **start** and **end** properties are of dateTimeTimeZone type. First find the supported time zones to make sure you set only time zones that have been configured for the user&apos;s mailbox server.  When an event is sent, the server sends invitations to all the attendees. **Setting the location in an event** An Exchange administrator can set up a mailbox and an email address for a resource such as a meeting room, or equipment like a projector. Users can then invite the resource as an attendee to a meeting. On behalf of the resource, the server accepts or rejects the meeting request based on the free/busy schedule of the resource. If the server accepts a meeting for the resource, it creates an event for the meeting in the resource&apos;s calendar. If the meeting is rescheduled, the server automatically updates the event in the resource&apos;s calendar. Another advantage of setting up a mailbox for a resource is to control scheduling of the resource, for example, only executivesor their delegates can book a private meeting room. If you&apos;re organizing an event that involves a meeting location: Additionally, if the meeting location has been set up as a resource, or if the event involves some equipment that has been set up as a resource:
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/user-post-events?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildCreateCommand() {
            var command = new Command("create");
            command.Description = "Create an event in the user's default calendar or specified calendar. By default, the **allowNewTimeProposals** property is set to true when an event is created, which means invitees can propose a different date/time for the event. See Propose new meeting times for more information on how to propose a time, and how to receive and accept a new time proposal. You can specify the time zone for each of the start and end times of the event as part of their values, because the **start** and **end** properties are of dateTimeTimeZone type. First find the supported time zones to make sure you set only time zones that have been configured for the user's mailbox server.  When an event is sent, the server sends invitations to all the attendees. **Setting the location in an event** An Exchange administrator can set up a mailbox and an email address for a resource such as a meeting room, or equipment like a projector. Users can then invite the resource as an attendee to a meeting. On behalf of the resource, the server accepts or rejects the meeting request based on the free/busy schedule of the resource. If the server accepts a meeting for the resource, it creates an event for the meeting in the resource's calendar. If the meeting is rescheduled, the server automatically updates the event in the resource's calendar. Another advantage of setting up a mailbox for a resource is to control scheduling of the resource, for example, only executivesor their delegates can book a private meeting room. If you're organizing an event that involves a meeting location: Additionally, if the meeting location has been set up as a resource, or if the event involves some equipment that has been set up as a resource:\n\nFind more info here:\n  https://docs.microsoft.com/graph/api/user-post-events?view=graph-rest-1.0";
            // Create options for all the parameters
            var userIdOption = new Option<string>("--user-id", description: "key: id of user") {
            };
            userIdOption.IsRequired = true;
            command.AddOption(userIdOption);
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
                var userId = invocationContext.ParseResult.GetValueForOption(userIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                var jsonNoIndent = invocationContext.ParseResult.GetValueForOption(jsonNoIndentOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetRequiredService<IOutputFilter>();
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetRequiredService<IOutputFormatterFactory>();
                var cancellationToken = invocationContext.GetCancellationToken();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<Event>(Event.CreateFromDiscriminatorValue);
                if (model is null) return; // Cannot create a POST request from a null model.
                var requestInfo = ToPostRequestInformation(model, q => {
                });
                if (userId is not null) requestInfo.PathParameters.Add("user%2Did", userId);
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
        /// Get a list of event objects in the user&apos;s mailbox. The list contains single instance meetings and series masters. To get expanded event instances, you can get the calendar view, or get the instances of an event. Currently, this operation returns event bodies in only HTML format. There are two scenarios where an app can get events in another user&apos;s calendar:
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/user-list-events?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildListCommand() {
            var command = new Command("list");
            command.Description = "Get a list of event objects in the user's mailbox. The list contains single instance meetings and series masters. To get expanded event instances, you can get the calendar view, or get the instances of an event. Currently, this operation returns event bodies in only HTML format. There are two scenarios where an app can get events in another user's calendar:\n\nFind more info here:\n  https://docs.microsoft.com/graph/api/user-list-events?view=graph-rest-1.0";
            // Create options for all the parameters
            var userIdOption = new Option<string>("--user-id", description: "key: id of user") {
            };
            userIdOption.IsRequired = true;
            command.AddOption(userIdOption);
            var topOption = new Option<int?>("--top", description: "Show only the first n items") {
            };
            topOption.IsRequired = false;
            command.AddOption(topOption);
            var skipOption = new Option<int?>("--skip", description: "Skip the first n items") {
            };
            skipOption.IsRequired = false;
            command.AddOption(skipOption);
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
            var allOption = new Option<bool>("--all");
            command.AddOption(allOption);
            command.SetHandler(async (invocationContext) => {
                var userId = invocationContext.ParseResult.GetValueForOption(userIdOption);
                var top = invocationContext.ParseResult.GetValueForOption(topOption);
                var skip = invocationContext.ParseResult.GetValueForOption(skipOption);
                var filter = invocationContext.ParseResult.GetValueForOption(filterOption);
                var count = invocationContext.ParseResult.GetValueForOption(countOption);
                var orderby = invocationContext.ParseResult.GetValueForOption(orderbyOption);
                var select = invocationContext.ParseResult.GetValueForOption(selectOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                var jsonNoIndent = invocationContext.ParseResult.GetValueForOption(jsonNoIndentOption);
                var all = invocationContext.ParseResult.GetValueForOption(allOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetRequiredService<IOutputFilter>();
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetRequiredService<IOutputFormatterFactory>();
                IPagingService pagingService = invocationContext.BindingContext.GetRequiredService<IPagingService>();
                var cancellationToken = invocationContext.GetCancellationToken();
                var requestInfo = ToGetRequestInformation(q => {
                    q.QueryParameters.Top = top;
                    q.QueryParameters.Skip = skip;
                    if (!string.IsNullOrEmpty(filter)) q.QueryParameters.Filter = filter;
                    q.QueryParameters.Count = count;
                    q.QueryParameters.Orderby = orderby;
                    q.QueryParameters.Select = select;
                });
                if (userId is not null) requestInfo.PathParameters.Add("user%2Did", userId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var pagingData = new PageLinkData(requestInfo, null, itemName: "value", nextLinkName: "@odata.nextLink");
                var pageResponse = await pagingService.GetPagedDataAsync((info, token) => RequestAdapter.SendNoContentAsync(info, cancellationToken: token), pagingData, all, cancellationToken);
                var response = pageResponse?.Response;
                IOutputFormatterOptions? formatterOptions = null;
                IOutputFormatter? formatter = null;
                if (pageResponse?.StatusCode >= 200 && pageResponse?.StatusCode < 300) {
                    formatter = outputFormatterFactory.GetFormatter(output);
                    response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                    formatterOptions = output.GetOutputFormatterOptions(new FormatterOptionsModel(!jsonNoIndent));
                } else {
                    formatter = outputFormatterFactory.GetFormatter(FormatterType.TEXT);
                }
                await formatter.WriteOutputAsync(response, formatterOptions, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Provides operations to call the delta method.
        /// </summary>
        public Command BuildMicrosoftGraphDeltaCommand() {
            var command = new Command("microsoft-graph-delta");
            command.Description = "Provides operations to call the delta method.";
            var builder = new DeltaRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new EventsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EventsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/users/{user%2Did}/events{?%24top,%24skip,%24filter,%24count,%24orderby,%24select}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Get a list of event objects in the user&apos;s mailbox. The list contains single instance meetings and series masters. To get expanded event instances, you can get the calendar view, or get the instances of an event. Currently, this operation returns event bodies in only HTML format. There are two scenarios where an app can get events in another user&apos;s calendar:
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<EventsRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<EventsRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new EventsRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Create an event in the user&apos;s default calendar or specified calendar. By default, the **allowNewTimeProposals** property is set to true when an event is created, which means invitees can propose a different date/time for the event. See Propose new meeting times for more information on how to propose a time, and how to receive and accept a new time proposal. You can specify the time zone for each of the start and end times of the event as part of their values, because the **start** and **end** properties are of dateTimeTimeZone type. First find the supported time zones to make sure you set only time zones that have been configured for the user&apos;s mailbox server.  When an event is sent, the server sends invitations to all the attendees. **Setting the location in an event** An Exchange administrator can set up a mailbox and an email address for a resource such as a meeting room, or equipment like a projector. Users can then invite the resource as an attendee to a meeting. On behalf of the resource, the server accepts or rejects the meeting request based on the free/busy schedule of the resource. If the server accepts a meeting for the resource, it creates an event for the meeting in the resource&apos;s calendar. If the meeting is rescheduled, the server automatically updates the event in the resource&apos;s calendar. Another advantage of setting up a mailbox for a resource is to control scheduling of the resource, for example, only executivesor their delegates can book a private meeting room. If you&apos;re organizing an event that involves a meeting location: Additionally, if the meeting location has been set up as a resource, or if the event involves some equipment that has been set up as a resource:
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Event body, Action<EventsRequestBuilderPostRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Event body, Action<EventsRequestBuilderPostRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new EventsRequestBuilderPostRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Get a list of event objects in the user&apos;s mailbox. The list contains single instance meetings and series masters. To get expanded event instances, you can get the calendar view, or get the instances of an event. Currently, this operation returns event bodies in only HTML format. There are two scenarios where an app can get events in another user&apos;s calendar:
        /// </summary>
        public class EventsRequestBuilderGetQueryParameters {
            /// <summary>Include count of items</summary>
            [QueryParameter("%24count")]
            public bool? Count { get; set; }
            /// <summary>Filter items by property values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24filter")]
            public string? Filter { get; set; }
#nullable restore
#else
            [QueryParameter("%24filter")]
            public string Filter { get; set; }
#endif
            /// <summary>Order items by property values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24orderby")]
            public string[]? Orderby { get; set; }
#nullable restore
#else
            [QueryParameter("%24orderby")]
            public string[] Orderby { get; set; }
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
            /// <summary>Skip the first n items</summary>
            [QueryParameter("%24skip")]
            public int? Skip { get; set; }
            /// <summary>Show only the first n items</summary>
            [QueryParameter("%24top")]
            public int? Top { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class EventsRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public EventsRequestBuilderGetQueryParameters QueryParameters { get; set; } = new EventsRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new eventsRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public EventsRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class EventsRequestBuilderPostRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new eventsRequestBuilderPostRequestConfiguration and sets the default values.
            /// </summary>
            public EventsRequestBuilderPostRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
