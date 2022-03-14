using ApiSdk.Me.CalendarGroups.Item.Calendars.Item.Events.Item.Accept;
using ApiSdk.Me.CalendarGroups.Item.Calendars.Item.Events.Item.Attachments;
using ApiSdk.Me.CalendarGroups.Item.Calendars.Item.Events.Item.Calendar;
using ApiSdk.Me.CalendarGroups.Item.Calendars.Item.Events.Item.Cancel;
using ApiSdk.Me.CalendarGroups.Item.Calendars.Item.Events.Item.Decline;
using ApiSdk.Me.CalendarGroups.Item.Calendars.Item.Events.Item.DismissReminder;
using ApiSdk.Me.CalendarGroups.Item.Calendars.Item.Events.Item.Extensions;
using ApiSdk.Me.CalendarGroups.Item.Calendars.Item.Events.Item.Forward;
using ApiSdk.Me.CalendarGroups.Item.Calendars.Item.Events.Item.Instances;
using ApiSdk.Me.CalendarGroups.Item.Calendars.Item.Events.Item.MultiValueExtendedProperties;
using ApiSdk.Me.CalendarGroups.Item.Calendars.Item.Events.Item.SingleValueExtendedProperties;
using ApiSdk.Me.CalendarGroups.Item.Calendars.Item.Events.Item.SnoozeReminder;
using ApiSdk.Me.CalendarGroups.Item.Calendars.Item.Events.Item.TentativelyAccept;
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
namespace ApiSdk.Me.CalendarGroups.Item.Calendars.Item.Events.Item {
    /// <summary>Builds and executes requests for operations under \me\calendarGroups\{calendarGroup-id}\calendars\{calendar-id}\events\{event-id}</summary>
    public class EventItemRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public Command BuildAcceptCommand() {
            var command = new Command("accept");
            var builder = new ApiSdk.Me.CalendarGroups.Item.Calendars.Item.Events.Item.Accept.AcceptRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildAttachmentsCommand() {
            var command = new Command("attachments");
            var builder = new ApiSdk.Me.CalendarGroups.Item.Calendars.Item.Events.Item.Attachments.AttachmentsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildCreateUploadSessionCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildCalendarCommand() {
            var command = new Command("calendar");
            var builder = new ApiSdk.Me.CalendarGroups.Item.Calendars.Item.Events.Item.Calendar.CalendarRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildGetScheduleCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        public Command BuildCancelCommand() {
            var command = new Command("cancel");
            var builder = new ApiSdk.Me.CalendarGroups.Item.Calendars.Item.Events.Item.Cancel.CancelRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildDeclineCommand() {
            var command = new Command("decline");
            var builder = new ApiSdk.Me.CalendarGroups.Item.Calendars.Item.Events.Item.Decline.DeclineRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// The events in the calendar. Navigation property. Read-only.
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "The events in the calendar. Navigation property. Read-only.";
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
            command.SetHandler(async (object[] parameters) => {
                var calendarGroupId = (string) parameters[0];
                var calendarId = (string) parameters[1];
                var eventId = (string) parameters[2];
                var cancellationToken = (CancellationToken) parameters[3];
                PathParameters.Clear();
                PathParameters.Add("calendarGroup_id", calendarGroupId);
                PathParameters.Add("calendar_id", calendarId);
                PathParameters.Add("event_id", eventId);
                var requestInfo = CreateDeleteRequestInformation(q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(calendarGroupIdOption, calendarIdOption, eventIdOption, new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        public Command BuildDismissReminderCommand() {
            var command = new Command("dismiss-reminder");
            var builder = new ApiSdk.Me.CalendarGroups.Item.Calendars.Item.Events.Item.DismissReminder.DismissReminderRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildExtensionsCommand() {
            var command = new Command("extensions");
            var builder = new ApiSdk.Me.CalendarGroups.Item.Calendars.Item.Events.Item.Extensions.ExtensionsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildForwardCommand() {
            var command = new Command("forward");
            var builder = new ApiSdk.Me.CalendarGroups.Item.Calendars.Item.Events.Item.Forward.ForwardRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// The events in the calendar. Navigation property. Read-only.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "The events in the calendar. Navigation property. Read-only.";
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
                var select = (string[]) parameters[3];
                var output = (FormatterType) parameters[4];
                var query = (string) parameters[5];
                var jsonNoIndent = (bool) parameters[6];
                var outputFilter = (IOutputFilter) parameters[7];
                var outputFormatterFactory = (IOutputFormatterFactory) parameters[8];
                var cancellationToken = (CancellationToken) parameters[9];
                PathParameters.Clear();
                PathParameters.Add("calendarGroup_id", calendarGroupId);
                PathParameters.Add("calendar_id", calendarId);
                PathParameters.Add("event_id", eventId);
                var requestInfo = CreateGetRequestInformation(q => {
                    q.Select = select;
                });
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                var formatter = outputFormatterFactory.GetFormatter(output);
                response = await outputFilter?.FilterOutputAsync(response, query, cancellationToken) ?? response;
                var formatterOptions = output.GetOutputFormatterOptions(new FormatterOptionsModel(!jsonNoIndent));
                await formatter.WriteOutputAsync(response, formatterOptions, cancellationToken);
            }, new CollectionBinding(calendarGroupIdOption, calendarIdOption, eventIdOption, selectOption, outputOption, queryOption, jsonNoIndentOption, new TypeBinding(typeof(IOutputFilter)), new TypeBinding(typeof(IOutputFormatterFactory)), new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        public Command BuildInstancesCommand() {
            var command = new Command("instances");
            var builder = new ApiSdk.Me.CalendarGroups.Item.Calendars.Item.Events.Item.Instances.InstancesRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildMultiValueExtendedPropertiesCommand() {
            var command = new Command("multi-value-extended-properties");
            var builder = new ApiSdk.Me.CalendarGroups.Item.Calendars.Item.Events.Item.MultiValueExtendedProperties.MultiValueExtendedPropertiesRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// The events in the calendar. Navigation property. Read-only.
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "The events in the calendar. Navigation property. Read-only.";
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
            var bodyOption = new Option<string>("--body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (object[] parameters) => {
                var calendarGroupId = (string) parameters[0];
                var calendarId = (string) parameters[1];
                var eventId = (string) parameters[2];
                var body = (string) parameters[3];
                var cancellationToken = (CancellationToken) parameters[4];
                PathParameters.Clear();
                PathParameters.Add("calendarGroup_id", calendarGroupId);
                PathParameters.Add("calendar_id", calendarId);
                PathParameters.Add("event_id", eventId);
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<Event>(Event.CreateFromDiscriminatorValue);
                var requestInfo = CreatePatchRequestInformation(model, q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(calendarGroupIdOption, calendarIdOption, eventIdOption, bodyOption, new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        public Command BuildSingleValueExtendedPropertiesCommand() {
            var command = new Command("single-value-extended-properties");
            var builder = new ApiSdk.Me.CalendarGroups.Item.Calendars.Item.Events.Item.SingleValueExtendedProperties.SingleValueExtendedPropertiesRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildSnoozeReminderCommand() {
            var command = new Command("snooze-reminder");
            var builder = new ApiSdk.Me.CalendarGroups.Item.Calendars.Item.Events.Item.SnoozeReminder.SnoozeReminderRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildTentativelyAcceptCommand() {
            var command = new Command("tentatively-accept");
            var builder = new ApiSdk.Me.CalendarGroups.Item.Calendars.Item.Events.Item.TentativelyAccept.TentativelyAcceptRequestBuilder(PathParameters, RequestAdapter);
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
            UrlTemplate = "{+baseurl}/me/calendarGroups/{calendarGroup_id}/calendars/{calendar_id}/events/{event_id}{?select}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// The events in the calendar. Navigation property. Read-only.
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
        /// The events in the calendar. Navigation property. Read-only.
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
        /// The events in the calendar. Navigation property. Read-only.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(Event body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// <summary>The events in the calendar. Navigation property. Read-only.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
