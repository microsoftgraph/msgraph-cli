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
namespace ApiSdk.Me.CalendarView.Item.Instances.Item.SnoozeReminder {
    /// <summary>Builds and executes requests for operations under \me\calendarView\{event-id}\instances\{event-id1}\microsoft.graph.snoozeReminder</summary>
    public class SnoozeReminderRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Invoke action snoozeReminder
        /// </summary>
        public Command BuildPostCommand() {
            var command = new Command("post");
            command.Description = "Invoke action snoozeReminder";
            // Create options for all the parameters
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
                var eventId = (string) parameters[0];
                var eventId1 = (string) parameters[1];
                var body = (string) parameters[2];
                var cancellationToken = (CancellationToken) parameters[3];
                PathParameters.Clear();
                PathParameters.Add("event_id", eventId);
                PathParameters.Add("event_id1", eventId1);
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<SnoozeReminderRequestBody>();
                var requestInfo = CreatePostRequestInformation(model, q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(eventIdOption, eventId1Option, bodyOption, new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// Instantiates a new SnoozeReminderRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public SnoozeReminderRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/me/calendarView/{event_id}/instances/{event_id1}/microsoft.graph.snoozeReminder";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Invoke action snoozeReminder
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePostRequestInformation(SnoozeReminderRequestBody body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
    }
}
