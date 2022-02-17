using ApiSdk.Models.Microsoft.Graph;
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
namespace ApiSdk.Me.OnlineMeetings.Item.AttendanceReports.Item.AttendanceRecords.Item {
    /// <summary>Builds and executes requests for operations under \me\onlineMeetings\{onlineMeeting-id}\attendanceReports\{meetingAttendanceReport-id}\attendanceRecords\{attendanceRecord-id}</summary>
    public class AttendanceRecordRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// List of attendance records of an attendance report. Read-only.
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "List of attendance records of an attendance report. Read-only.";
            // Create options for all the parameters
            var onlineMeetingIdOption = new Option<string>("--online-meeting-id", description: "key: id of onlineMeeting") {
            };
            onlineMeetingIdOption.IsRequired = true;
            command.AddOption(onlineMeetingIdOption);
            var meetingAttendanceReportIdOption = new Option<string>("--meeting-attendance-report-id", description: "key: id of meetingAttendanceReport") {
            };
            meetingAttendanceReportIdOption.IsRequired = true;
            command.AddOption(meetingAttendanceReportIdOption);
            var attendanceRecordIdOption = new Option<string>("--attendance-record-id", description: "key: id of attendanceRecord") {
            };
            attendanceRecordIdOption.IsRequired = true;
            command.AddOption(attendanceRecordIdOption);
            command.SetHandler(async (string onlineMeetingId, string meetingAttendanceReportId, string attendanceRecordId, IOutputFormatterFactory outputFormatterFactory, CancellationToken cancellationToken) => {
                var requestInfo = CreateDeleteRequestInformation(q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, onlineMeetingIdOption, meetingAttendanceReportIdOption, attendanceRecordIdOption);
            return command;
        }
        /// <summary>
        /// List of attendance records of an attendance report. Read-only.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "List of attendance records of an attendance report. Read-only.";
            // Create options for all the parameters
            var onlineMeetingIdOption = new Option<string>("--online-meeting-id", description: "key: id of onlineMeeting") {
            };
            onlineMeetingIdOption.IsRequired = true;
            command.AddOption(onlineMeetingIdOption);
            var meetingAttendanceReportIdOption = new Option<string>("--meeting-attendance-report-id", description: "key: id of meetingAttendanceReport") {
            };
            meetingAttendanceReportIdOption.IsRequired = true;
            command.AddOption(meetingAttendanceReportIdOption);
            var attendanceRecordIdOption = new Option<string>("--attendance-record-id", description: "key: id of attendanceRecord") {
            };
            attendanceRecordIdOption.IsRequired = true;
            command.AddOption(attendanceRecordIdOption);
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
            command.SetHandler(async (string onlineMeetingId, string meetingAttendanceReportId, string attendanceRecordId, string[] select, string[] expand, FormatterType output, IOutputFormatterFactory outputFormatterFactory, CancellationToken cancellationToken) => {
                var requestInfo = CreateGetRequestInformation(q => {
                    q.Select = select;
                    q.Expand = expand;
                });
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                var formatter = outputFormatterFactory.GetFormatter(output);
                formatter.WriteOutput(response);
            }, onlineMeetingIdOption, meetingAttendanceReportIdOption, attendanceRecordIdOption, selectOption, expandOption, outputOption);
            return command;
        }
        /// <summary>
        /// List of attendance records of an attendance report. Read-only.
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "List of attendance records of an attendance report. Read-only.";
            // Create options for all the parameters
            var onlineMeetingIdOption = new Option<string>("--online-meeting-id", description: "key: id of onlineMeeting") {
            };
            onlineMeetingIdOption.IsRequired = true;
            command.AddOption(onlineMeetingIdOption);
            var meetingAttendanceReportIdOption = new Option<string>("--meeting-attendance-report-id", description: "key: id of meetingAttendanceReport") {
            };
            meetingAttendanceReportIdOption.IsRequired = true;
            command.AddOption(meetingAttendanceReportIdOption);
            var attendanceRecordIdOption = new Option<string>("--attendance-record-id", description: "key: id of attendanceRecord") {
            };
            attendanceRecordIdOption.IsRequired = true;
            command.AddOption(attendanceRecordIdOption);
            var bodyOption = new Option<string>("--body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (string onlineMeetingId, string meetingAttendanceReportId, string attendanceRecordId, string body, IOutputFormatterFactory outputFormatterFactory, CancellationToken cancellationToken) => {
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<AttendanceRecord>();
                var requestInfo = CreatePatchRequestInformation(model, q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, onlineMeetingIdOption, meetingAttendanceReportIdOption, attendanceRecordIdOption, bodyOption);
            return command;
        }
        /// <summary>
        /// Instantiates a new AttendanceRecordRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public AttendanceRecordRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/me/onlineMeetings/{onlineMeeting_id}/attendanceReports/{meetingAttendanceReport_id}/attendanceRecords/{attendanceRecord_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// List of attendance records of an attendance report. Read-only.
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
        /// List of attendance records of an attendance report. Read-only.
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
        /// List of attendance records of an attendance report. Read-only.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(AttendanceRecord body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// <summary>List of attendance records of an attendance report. Read-only.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
