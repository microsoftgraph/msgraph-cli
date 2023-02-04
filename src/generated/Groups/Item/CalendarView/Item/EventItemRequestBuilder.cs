using ApiSdk.Groups.Item.CalendarView.Item.Attachments;
using ApiSdk.Groups.Item.CalendarView.Item.Calendar;
using ApiSdk.Groups.Item.CalendarView.Item.Extensions;
using ApiSdk.Groups.Item.CalendarView.Item.Instances;
using ApiSdk.Groups.Item.CalendarView.Item.MicrosoftGraphAccept;
using ApiSdk.Groups.Item.CalendarView.Item.MicrosoftGraphCancel;
using ApiSdk.Groups.Item.CalendarView.Item.MicrosoftGraphDecline;
using ApiSdk.Groups.Item.CalendarView.Item.MicrosoftGraphDismissReminder;
using ApiSdk.Groups.Item.CalendarView.Item.MicrosoftGraphForward;
using ApiSdk.Groups.Item.CalendarView.Item.MicrosoftGraphSnoozeReminder;
using ApiSdk.Groups.Item.CalendarView.Item.MicrosoftGraphTentativelyAccept;
using ApiSdk.Groups.Item.CalendarView.Item.MultiValueExtendedProperties;
using ApiSdk.Groups.Item.CalendarView.Item.SingleValueExtendedProperties;
using ApiSdk.Models;
using ApiSdk.Models.ODataErrors;
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
namespace ApiSdk.Groups.Item.CalendarView.Item {
    /// <summary>
    /// Provides operations to manage the calendarView property of the microsoft.graph.group entity.
    /// </summary>
    public class EventItemRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Provides operations to manage the attachments property of the microsoft.graph.event entity.
        /// </summary>
        public Command BuildAttachmentsCommand() {
            var command = new Command("attachments");
            command.Description = "Provides operations to manage the attachments property of the microsoft.graph.event entity.";
            var builder = new AttachmentsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphCreateUploadSessionCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the calendar property of the microsoft.graph.event entity.
        /// </summary>
        public Command BuildCalendarCommand() {
            var command = new Command("calendar");
            command.Description = "Provides operations to manage the calendar property of the microsoft.graph.event entity.";
            var builder = new CalendarRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the extensions property of the microsoft.graph.event entity.
        /// </summary>
        public Command BuildExtensionsCommand() {
            var command = new Command("extensions");
            command.Description = "Provides operations to manage the extensions property of the microsoft.graph.event entity.";
            var builder = new ExtensionsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// The calendar view for the calendar. Read-only.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "The calendar view for the calendar. Read-only.";
            // Create options for all the parameters
            var groupIdOption = new Option<string>("--group-id", description: "key: id of group") {
            };
            groupIdOption.IsRequired = true;
            command.AddOption(groupIdOption);
            var eventIdOption = new Option<string>("--event-id", description: "key: id of event") {
            };
            eventIdOption.IsRequired = true;
            command.AddOption(eventIdOption);
            var startDateTimeOption = new Option<string>("--start-date-time", description: "The start date and time of the time range, represented in ISO 8601 format. For example, 2019-11-08T19:00:00-08:00") {
            };
            startDateTimeOption.IsRequired = true;
            command.AddOption(startDateTimeOption);
            var endDateTimeOption = new Option<string>("--end-date-time", description: "The end date and time of the time range, represented in ISO 8601 format. For example, 2019-11-08T20:00:00-08:00") {
            };
            endDateTimeOption.IsRequired = true;
            command.AddOption(endDateTimeOption);
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
            command.SetHandler(async (invocationContext) => {
                var groupId = invocationContext.ParseResult.GetValueForOption(groupIdOption);
                var eventId = invocationContext.ParseResult.GetValueForOption(eventIdOption);
                var startDateTime = invocationContext.ParseResult.GetValueForOption(startDateTimeOption);
                var endDateTime = invocationContext.ParseResult.GetValueForOption(endDateTimeOption);
                var select = invocationContext.ParseResult.GetValueForOption(selectOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                var jsonNoIndent = invocationContext.ParseResult.GetValueForOption(jsonNoIndentOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetRequiredService<IOutputFilter>();
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetRequiredService<IOutputFormatterFactory>();
                var cancellationToken = invocationContext.GetCancellationToken();
                var requestInfo = ToGetRequestInformation(q => {
                    if (!string.IsNullOrEmpty(startDateTime)) q.QueryParameters.StartDateTime = startDateTime;
                    if (!string.IsNullOrEmpty(endDateTime)) q.QueryParameters.EndDateTime = endDateTime;
                    q.QueryParameters.Select = select;
                });
                if (groupId is not null) requestInfo.PathParameters.Add("group%2Did", groupId);
                if (eventId is not null) requestInfo.PathParameters.Add("event%2Did", eventId);
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
        /// Provides operations to manage the instances property of the microsoft.graph.event entity.
        /// </summary>
        public Command BuildInstancesCommand() {
            var command = new Command("instances");
            command.Description = "Provides operations to manage the instances property of the microsoft.graph.event entity.";
            var builder = new InstancesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDeltaCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the accept method.
        /// </summary>
        public Command BuildMicrosoftGraphAcceptCommand() {
            var command = new Command("microsoft-graph-accept");
            command.Description = "Provides operations to call the accept method.";
            var builder = new AcceptRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the cancel method.
        /// </summary>
        public Command BuildMicrosoftGraphCancelCommand() {
            var command = new Command("microsoft-graph-cancel");
            command.Description = "Provides operations to call the cancel method.";
            var builder = new CancelRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the decline method.
        /// </summary>
        public Command BuildMicrosoftGraphDeclineCommand() {
            var command = new Command("microsoft-graph-decline");
            command.Description = "Provides operations to call the decline method.";
            var builder = new DeclineRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the dismissReminder method.
        /// </summary>
        public Command BuildMicrosoftGraphDismissReminderCommand() {
            var command = new Command("microsoft-graph-dismiss-reminder");
            command.Description = "Provides operations to call the dismissReminder method.";
            var builder = new DismissReminderRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the forward method.
        /// </summary>
        public Command BuildMicrosoftGraphForwardCommand() {
            var command = new Command("microsoft-graph-forward");
            command.Description = "Provides operations to call the forward method.";
            var builder = new ForwardRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the snoozeReminder method.
        /// </summary>
        public Command BuildMicrosoftGraphSnoozeReminderCommand() {
            var command = new Command("microsoft-graph-snooze-reminder");
            command.Description = "Provides operations to call the snoozeReminder method.";
            var builder = new SnoozeReminderRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the tentativelyAccept method.
        /// </summary>
        public Command BuildMicrosoftGraphTentativelyAcceptCommand() {
            var command = new Command("microsoft-graph-tentatively-accept");
            command.Description = "Provides operations to call the tentativelyAccept method.";
            var builder = new TentativelyAcceptRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the multiValueExtendedProperties property of the microsoft.graph.event entity.
        /// </summary>
        public Command BuildMultiValueExtendedPropertiesCommand() {
            var command = new Command("multi-value-extended-properties");
            command.Description = "Provides operations to manage the multiValueExtendedProperties property of the microsoft.graph.event entity.";
            var builder = new MultiValueExtendedPropertiesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the singleValueExtendedProperties property of the microsoft.graph.event entity.
        /// </summary>
        public Command BuildSingleValueExtendedPropertiesCommand() {
            var command = new Command("single-value-extended-properties");
            command.Description = "Provides operations to manage the singleValueExtendedProperties property of the microsoft.graph.event entity.";
            var builder = new SingleValueExtendedPropertiesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new EventItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EventItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/groups/{group%2Did}/calendarView/{event%2Did}{?startDateTime*,endDateTime*,%24select}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// The calendar view for the calendar. Read-only.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<EventItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<EventItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new EventItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// The calendar view for the calendar. Read-only.
        /// </summary>
        public class EventItemRequestBuilderGetQueryParameters {
            /// <summary>The end date and time of the time range, represented in ISO 8601 format. For example, 2019-11-08T20:00:00-08:00</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? EndDateTime { get; set; }
#nullable restore
#else
            public string EndDateTime { get; set; }
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
            /// <summary>The start date and time of the time range, represented in ISO 8601 format. For example, 2019-11-08T19:00:00-08:00</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? StartDateTime { get; set; }
#nullable restore
#else
            public string StartDateTime { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class EventItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public EventItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new EventItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new EventItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public EventItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
