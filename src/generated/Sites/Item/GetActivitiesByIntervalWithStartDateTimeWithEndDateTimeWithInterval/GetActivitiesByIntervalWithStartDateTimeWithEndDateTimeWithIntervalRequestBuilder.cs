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
namespace ApiSdk.Sites.Item.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval {
    /// <summary>Builds and executes requests for operations under \sites\{site-id}\microsoft.graph.getActivitiesByInterval(startDateTime='{startDateTime}',endDateTime='{endDateTime}',interval='{interval}')</summary>
    public class GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithIntervalRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Invoke function getActivitiesByInterval
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Invoke function getActivitiesByInterval";
            // Create options for all the parameters
            var siteIdOption = new Option<string>("--site-id", description: "key: id of site") {
            };
            siteIdOption.IsRequired = true;
            command.AddOption(siteIdOption);
            var startDateTimeOption = new Option<string>("--startdatetime", description: "Usage: startDateTime={startDateTime}") {
            };
            startDateTimeOption.IsRequired = true;
            command.AddOption(startDateTimeOption);
            var endDateTimeOption = new Option<string>("--enddatetime", description: "Usage: endDateTime={endDateTime}") {
            };
            endDateTimeOption.IsRequired = true;
            command.AddOption(endDateTimeOption);
            var intervalOption = new Option<string>("--interval", description: "Usage: interval={interval}") {
            };
            intervalOption.IsRequired = true;
            command.AddOption(intervalOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON){
                IsRequired = true
            };
            command.AddOption(outputOption);
            command.SetHandler(async (string siteId, string startDateTime, string endDateTime, string interval, FormatterType output, IServiceProvider serviceProvider, IConsole console) => {
                var responseHandler = serviceProvider.GetService(typeof(IResponseHandler)) as IResponseHandler;
                var requestInfo = CreateGetRequestInformation(q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler);
                // Print request output. What if the request has no return?
                var responseProcessor = serviceProvider.GetService(typeof(IResponseProcessor)) as IResponseProcessor;
                var factory = serviceProvider.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory;
                var formatter = factory.GetFormatter(output);
                if (responseProcessor.IsResponseSuccessful(responseHandler)) {
                    var content = await responseProcessor.ExtractStringResponseAsync(responseHandler);
                    formatter.WriteOutput(content, console);
                }
                else {
                    var content = await responseProcessor.ExtractStringResponseAsync(responseHandler);
                    console.WriteLine(content);
                }
            }, siteIdOption, startDateTimeOption, endDateTimeOption, intervalOption, outputOption, new ServiceProviderBinder());
            return command;
        }
        /// <summary>
        /// Instantiates a new GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithIntervalRequestBuilder and sets the default values.
        /// <param name="endDateTime">Usage: endDateTime={endDateTime}</param>
        /// <param name="interval">Usage: interval={interval}</param>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// <param name="startDateTime">Usage: startDateTime={startDateTime}</param>
        /// </summary>
        public GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithIntervalRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, string startDateTime = default, string endDateTime = default, string interval = default) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/sites/{site_id}/microsoft.graph.getActivitiesByInterval(startDateTime='{startDateTime}',endDateTime='{endDateTime}',interval='{interval}')";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            urlTplParams.Add("startDateTime", startDateTime);
            urlTplParams.Add("endDateTime", endDateTime);
            urlTplParams.Add("interval", interval);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithIntervalRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithIntervalRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/sites/{site_id}/microsoft.graph.getActivitiesByInterval(startDateTime='{startDateTime}',endDateTime='{endDateTime}',interval='{interval}')";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Invoke function getActivitiesByInterval
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
        /// Invoke function getActivitiesByInterval
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<IEnumerable<ApiSdk.Sites.Item.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval>> GetAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(h, o);
            return await RequestAdapter.SendCollectionAsync<ApiSdk.Sites.Item.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval>(requestInfo, responseHandler, cancellationToken);
        }
    }
}
