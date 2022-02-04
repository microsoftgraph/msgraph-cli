using Microsoft.Graph.Cli.Core.Binding;
using Microsoft.Graph.Cli.Core.IO;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace ApiSdk.Reports.GetGroupArchivedPrintJobsWithGroupIdWithStartDateTimeWithEndDateTime {
    /// <summary>Builds and executes requests for operations under \reports\microsoft.graph.getGroupArchivedPrintJobs(groupId='{groupId}',startDateTime={startDateTime},endDateTime={endDateTime})</summary>
    public class GetGroupArchivedPrintJobsWithGroupIdWithStartDateTimeWithEndDateTimeRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Invoke function getGroupArchivedPrintJobs
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Invoke function getGroupArchivedPrintJobs";
            // Create options for all the parameters
            var groupIdOption = new Option<string>("--groupid", description: "Usage: groupId={groupId}") {
            };
            groupIdOption.IsRequired = true;
            command.AddOption(groupIdOption);
            var startDateTimeOption = new Option<string>("--startdatetime", description: "Usage: startDateTime={startDateTime}") {
            };
            startDateTimeOption.IsRequired = true;
            command.AddOption(startDateTimeOption);
            var endDateTimeOption = new Option<string>("--enddatetime", description: "Usage: endDateTime={endDateTime}") {
            };
            endDateTimeOption.IsRequired = true;
            command.AddOption(endDateTimeOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON){
                IsRequired = true
            };
            command.AddOption(outputOption);
            command.SetHandler(async (string groupId, string startDateTime, string endDateTime, FormatterType output, IOutputFormatterFactory outputFormatterFactory, IConsole console) => {
                var requestInfo = CreateGetRequestInformation(q => {
                });
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo);
                var formatter = outputFormatterFactory.GetFormatter(output);
                formatter.WriteOutput(response, console);
            }, groupIdOption, startDateTimeOption, endDateTimeOption, outputOption, new OutputFormatterFactoryBinder());
            return command;
        }
        /// <summary>
        /// Instantiates a new GetGroupArchivedPrintJobsWithGroupIdWithStartDateTimeWithEndDateTimeRequestBuilder and sets the default values.
        /// <param name="endDateTime">Usage: endDateTime={endDateTime}</param>
        /// <param name="groupId">Usage: groupId={groupId}</param>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// <param name="startDateTime">Usage: startDateTime={startDateTime}</param>
        /// </summary>
        public GetGroupArchivedPrintJobsWithGroupIdWithStartDateTimeWithEndDateTimeRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, string groupId = default, DateTimeOffset? startDateTime = default, DateTimeOffset? endDateTime = default) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/reports/microsoft.graph.getGroupArchivedPrintJobs(groupId='{groupId}',startDateTime={startDateTime},endDateTime={endDateTime})";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            urlTplParams.Add("groupId", groupId);
            urlTplParams.Add("startDateTime", startDateTime);
            urlTplParams.Add("endDateTime", endDateTime);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new GetGroupArchivedPrintJobsWithGroupIdWithStartDateTimeWithEndDateTimeRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public GetGroupArchivedPrintJobsWithGroupIdWithStartDateTimeWithEndDateTimeRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/reports/microsoft.graph.getGroupArchivedPrintJobs(groupId='{groupId}',startDateTime={startDateTime},endDateTime={endDateTime})";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Invoke function getGroupArchivedPrintJobs
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Invoke function getGroupArchivedPrintJobs
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<IEnumerable<ApiSdk.Reports.GetGroupArchivedPrintJobsWithGroupIdWithStartDateTimeWithEndDateTime.GetGroupArchivedPrintJobsWithGroupIdWithStartDateTimeWithEndDateTime>> GetAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(h, o);
            return await RequestAdapter.SendCollectionAsync<ApiSdk.Reports.GetGroupArchivedPrintJobsWithGroupIdWithStartDateTimeWithEndDateTime.GetGroupArchivedPrintJobsWithGroupIdWithStartDateTimeWithEndDateTime>(requestInfo, responseHandler, cancellationToken);
        }
    }
}
