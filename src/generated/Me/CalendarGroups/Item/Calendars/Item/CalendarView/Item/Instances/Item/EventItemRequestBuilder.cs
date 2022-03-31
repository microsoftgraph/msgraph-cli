using ApiSdk.Me.CalendarGroups.Item.Calendars.Item.CalendarView.Item.Instances.Item.Accept;
using ApiSdk.Me.CalendarGroups.Item.Calendars.Item.CalendarView.Item.Instances.Item.Attachments;
using ApiSdk.Me.CalendarGroups.Item.Calendars.Item.CalendarView.Item.Instances.Item.Calendar;
using ApiSdk.Me.CalendarGroups.Item.Calendars.Item.CalendarView.Item.Instances.Item.Cancel;
using ApiSdk.Me.CalendarGroups.Item.Calendars.Item.CalendarView.Item.Instances.Item.Decline;
using ApiSdk.Me.CalendarGroups.Item.Calendars.Item.CalendarView.Item.Instances.Item.DismissReminder;
using ApiSdk.Me.CalendarGroups.Item.Calendars.Item.CalendarView.Item.Instances.Item.Extensions;
using ApiSdk.Me.CalendarGroups.Item.Calendars.Item.CalendarView.Item.Instances.Item.Forward;
using ApiSdk.Me.CalendarGroups.Item.Calendars.Item.CalendarView.Item.Instances.Item.MultiValueExtendedProperties;
using ApiSdk.Me.CalendarGroups.Item.Calendars.Item.CalendarView.Item.Instances.Item.SingleValueExtendedProperties;
using ApiSdk.Me.CalendarGroups.Item.Calendars.Item.CalendarView.Item.Instances.Item.SnoozeReminder;
using ApiSdk.Me.CalendarGroups.Item.Calendars.Item.CalendarView.Item.Instances.Item.TentativelyAccept;
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
namespace ApiSdk.Me.CalendarGroups.Item.Calendars.Item.CalendarView.Item.Instances.Item {
    /// <summary>Provides operations to manage the instances property of the microsoft.graph.event entity.</summary>
    public class EventItemRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public Command BuildAcceptCommand() {
            var command = new Command("accept");
            var builder = new AcceptRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildAttachmentsCommand() {
            var command = new Command("attachments");
            var builder = new AttachmentsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildCreateUploadSessionCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildCalendarCommand() {
            var command = new Command("calendar");
            var builder = new CalendarRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        public Command BuildCancelCommand() {
            var command = new Command("cancel");
            var builder = new CancelRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildDeclineCommand() {
            var command = new Command("decline");
            var builder = new DeclineRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Delete navigation property instances for me
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Delete navigation property instances for me";
            // Create options for all the parameters
            var calendarGroupIdOption = new Option<string>("--calendar-group-id", description: "key: id of calendarGroup") {
            };
            calendarGroupIdOption.IsRequired = true;
            command.AddOption(calendarGroupIdOption);
            var calendarIdOption = new Option<string>("--calendar-id", description: "key: id of calendar") {
            };
            calendarIdOption.IsRequired = true;
            command.AddOption(calendarIdOption);
            var eventIdOption = new Option<string>("--event-id", description: "key: id of event") {
            };
            eventIdOption.IsRequired = true;
            command.AddOption(eventIdOption);
            var eventId1Option = new Option<string>("--event-id1", description: "key: id of event") {
            };
            eventId1Option.IsRequired = true;
            command.AddOption(eventId1Option);
            command.SetHandler(async (object[] parameters) => {
                var calendarGroupId = (string) parameters[0];
                var calendarId = (string) parameters[1];
                var eventId = (string) parameters[2];
                var eventId1 = (string) parameters[3];
                var cancellationToken = (CancellationToken) parameters[4];
                PathParameters.Clear();
                PathParameters.Add("calendarGroup_id", calendarGroupId);
                PathParameters.Add("calendar_id", calendarId);
                PathParameters.Add("event_id", eventId);
                PathParameters.Add("event_id1", eventId1);
                var requestInfo = CreateDeleteRequestInformation(q => {
                });
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(calendarGroupIdOption, calendarIdOption, eventIdOption, eventId1Option, new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        public Command BuildDismissReminderCommand() {
            var command = new Command("dismiss-reminder");
            var builder = new DismissReminderRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildExtensionsCommand() {
            var command = new Command("extensions");
            var builder = new ExtensionsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildForwardCommand() {
            var command = new Command("forward");
            var builder = new ForwardRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// The occurrences of a recurring series, if the event is a series master. This property includes occurrences that are part of the recurrence pattern, and exceptions that have been modified, but does not include occurrences that have been cancelled from the series. Navigation property. Read-only. Nullable.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "The occurrences of a recurring series, if the event is a series master. This property includes occurrences that are part of the recurrence pattern, and exceptions that have been modified, but does not include occurrences that have been cancelled from the series. Navigation property. Read-only. Nullable.";
            // Create options for all the parameters
            var calendarGroupIdOption = new Option<string>("--calendar-group-id", description: "key: id of calendarGroup") {
            };
            calendarGroupIdOption.IsRequired = true;
            command.AddOption(calendarGroupIdOption);
            var calendarIdOption = new Option<string>("--calendar-id", description: "key: id of calendar") {
            };
            calendarIdOption.IsRequired = true;
            command.AddOption(calendarIdOption);
            var eventIdOption = new Option<string>("--event-id", description: "key: id of event") {
            };
            eventIdOption.IsRequired = true;
            command.AddOption(eventIdOption);
            var eventId1Option = new Option<string>("--event-id1", description: "key: id of event") {
            };
            eventId1Option.IsRequired = true;
            command.AddOption(eventId1Option);
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
            command.SetHandler(async (object[] parameters) => {
                var calendarGroupId = (string) parameters[0];
                var calendarId = (string) parameters[1];
                var eventId = (string) parameters[2];
                var eventId1 = (string) parameters[3];
                var select = (string[]) parameters[4];
                var output = (FormatterType) parameters[5];
                var query = (string) parameters[6];
                var jsonNoIndent = (bool) parameters[7];
                var outputFilter = (IOutputFilter) parameters[8];
                var outputFormatterFactory = (IOutputFormatterFactory) parameters[9];
                var cancellationToken = (CancellationToken) parameters[10];
                PathParameters.Clear();
                PathParameters.Add("calendarGroup_id", calendarGroupId);
                PathParameters.Add("calendar_id", calendarId);
                PathParameters.Add("event_id", eventId);
                PathParameters.Add("event_id1", eventId1);
                var requestInfo = CreateGetRequestInformation(q => {
                    q.Select = select;
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
            }, new CollectionBinding(calendarGroupIdOption, calendarIdOption, eventIdOption, eventId1Option, selectOption, outputOption, queryOption, jsonNoIndentOption, new TypeBinding(typeof(IOutputFilter)), new TypeBinding(typeof(IOutputFormatterFactory)), new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        public Command BuildMultiValueExtendedPropertiesCommand() {
            var command = new Command("multi-value-extended-properties");
            var builder = new MultiValueExtendedPropertiesRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Update the navigation property instances in me
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Update the navigation property instances in me";
            // Create options for all the parameters
            var calendarGroupIdOption = new Option<string>("--calendar-group-id", description: "key: id of calendarGroup") {
            };
            calendarGroupIdOption.IsRequired = true;
            command.AddOption(calendarGroupIdOption);
            var calendarIdOption = new Option<string>("--calendar-id", description: "key: id of calendar") {
            };
            calendarIdOption.IsRequired = true;
            command.AddOption(calendarIdOption);
            var eventIdOption = new Option<string>("--event-id", description: "key: id of event") {
            };
            eventIdOption.IsRequired = true;
            command.AddOption(eventIdOption);
            var eventId1Option = new Option<string>("--event-id1", description: "key: id of event") {
            };
            eventId1Option.IsRequired = true;
            command.AddOption(eventId1Option);
            var bodyOption = new Option<string>("--body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (object[] parameters) => {
                var calendarGroupId = (string) parameters[0];
                var calendarId = (string) parameters[1];
                var eventId = (string) parameters[2];
                var eventId1 = (string) parameters[3];
                var body = (string) parameters[4];
                var cancellationToken = (CancellationToken) parameters[5];
                PathParameters.Clear();
                PathParameters.Add("calendarGroup_id", calendarGroupId);
                PathParameters.Add("calendar_id", calendarId);
                PathParameters.Add("event_id", eventId);
                PathParameters.Add("event_id1", eventId1);
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<Event>(Event.CreateFromDiscriminatorValue);
                var requestInfo = CreatePatchRequestInformation(model, q => {
                });
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(calendarGroupIdOption, calendarIdOption, eventIdOption, eventId1Option, bodyOption, new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        public Command BuildSingleValueExtendedPropertiesCommand() {
            var command = new Command("single-value-extended-properties");
            var builder = new SingleValueExtendedPropertiesRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildSnoozeReminderCommand() {
            var command = new Command("snooze-reminder");
            var builder = new SnoozeReminderRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildTentativelyAcceptCommand() {
            var command = new Command("tentatively-accept");
            var builder = new TentativelyAcceptRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new EventItemRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public EventItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/me/calendarGroups/{calendarGroup_id}/calendars/{calendar_id}/calendarView/{event_id}/instances/{event_id1}{?select}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete navigation property instances for me
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
        /// The occurrences of a recurring series, if the event is a series master. This property includes occurrences that are part of the recurrence pattern, and exceptions that have been modified, but does not include occurrences that have been cancelled from the series. Navigation property. Read-only. Nullable.
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
        /// Update the navigation property instances in me
        /// <param name="body"></param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(Event body, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default) {
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
        /// <summary>The occurrences of a recurring series, if the event is a series master. This property includes occurrences that are part of the recurrence pattern, and exceptions that have been modified, but does not include occurrences that have been cancelled from the series. Navigation property. Read-only. Nullable.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
