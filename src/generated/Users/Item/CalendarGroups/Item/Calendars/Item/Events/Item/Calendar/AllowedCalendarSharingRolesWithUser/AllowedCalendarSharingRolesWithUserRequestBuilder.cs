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
namespace ApiSdk.Users.Item.CalendarGroups.Item.Calendars.Item.Events.Item.Calendar.AllowedCalendarSharingRolesWithUser {
    /// <summary>Builds and executes requests for operations under \users\{user-id}\calendarGroups\{calendarGroup-id}\calendars\{calendar-id}\events\{event-id}\calendar\microsoft.graph.allowedCalendarSharingRoles(User='{User}')</summary>
    public class AllowedCalendarSharingRolesWithUserRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Invoke function allowedCalendarSharingRoles
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Invoke function allowedCalendarSharingRoles";
            // Create options for all the parameters
            command.AddOption(new Option<string>("--user-id", description: "key: id of user"));
            command.AddOption(new Option<string>("--calendargroup-id", description: "key: id of calendarGroup"));
            command.AddOption(new Option<string>("--calendar-id", description: "key: id of calendar"));
            command.AddOption(new Option<string>("--event-id", description: "key: id of event"));
            command.AddOption(new Option<string>("--user", description: "Usage: User={User}"));
            command.Handler = CommandHandler.Create<string, string, string, string, string>(async (userId, calendarGroupId, calendarId, eventId, User) => {
                var requestInfo = CreateGetRequestInformation();
                if (!String.IsNullOrEmpty(userId)) requestInfo.PathParameters.Add("user_id", userId);
                if (!String.IsNullOrEmpty(calendarGroupId)) requestInfo.PathParameters.Add("calendarGroup_id", calendarGroupId);
                if (!String.IsNullOrEmpty(calendarId)) requestInfo.PathParameters.Add("calendar_id", calendarId);
                if (!String.IsNullOrEmpty(eventId)) requestInfo.PathParameters.Add("event_id", eventId);
                if (!String.IsNullOrEmpty(User)) requestInfo.PathParameters.Add("User", User);
                var result = await RequestAdapter.SendPrimitiveCollectionAsync<string>(requestInfo);
                // Print request output. What if the request has no return?
                using var serializer = RequestAdapter.SerializationWriterFactory.GetSerializationWriter("application/json");
                serializer.WriteCollectionOfPrimitiveValues(null, result);
                using var content = serializer.GetSerializedContent();
                using var reader = new StreamReader(content);
                var strContent = await reader.ReadToEndAsync();
                Console.Write(strContent + "\n");
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new AllowedCalendarSharingRolesWithUserRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// <param name="User">Usage: User={User}</param>
        /// </summary>
        public AllowedCalendarSharingRolesWithUserRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, string user = default) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/users/{user_id}/calendarGroups/{calendarGroup_id}/calendars/{calendar_id}/events/{event_id}/calendar/microsoft.graph.allowedCalendarSharingRoles(User='{User}')";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            urlTplParams.Add("User", user);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Invoke function allowedCalendarSharingRoles
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Invoke function allowedCalendarSharingRoles
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<IEnumerable<string>> GetAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(h, o);
            return await RequestAdapter.SendPrimitiveCollectionAsync<string>(requestInfo, responseHandler, cancellationToken);
        }
    }
}
