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
namespace ApiSdk.Workbooks.Item.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval {
    /// <summary>Builds and executes requests for operations under \workbooks\{driveItem-id}\microsoft.graph.getActivitiesByInterval(startDateTime='{startDateTime}',endDateTime='{endDateTime}',interval='{interval}')</summary>
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
            var driveItemIdOption = new Option<string>("--drive-item-id", description: "key: id of driveItem") {
            };
            driveItemIdOption.IsRequired = true;
            command.AddOption(driveItemIdOption);
            var startDateTimeOption = new Option<string>("--start-date-time", description: "Usage: startDateTime={startDateTime}") {
            };
            startDateTimeOption.IsRequired = true;
            command.AddOption(startDateTimeOption);
            var endDateTimeOption = new Option<string>("--end-date-time", description: "Usage: endDateTime={endDateTime}") {
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
            command.SetHandler(async (object[] parameters) => {
                var driveItemId = (string) parameters[0];
                var startDateTime = (string) parameters[1];
                var endDateTime = (string) parameters[2];
                var interval = (string) parameters[3];
                var output = (FormatterType) parameters[4];
                var outputFormatterFactory = (IOutputFormatterFactory) parameters[5];
                var cancellationToken = (CancellationToken) parameters[6];
                PathParameters.Clear();
                PathParameters.Add("driveItem_id", driveItemId);
                PathParameters.Add("startDateTime", startDateTime);
                PathParameters.Add("endDateTime", endDateTime);
                PathParameters.Add("interval", interval);
                var requestInfo = CreateGetRequestInformation(q => {
                });
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                var formatter = outputFormatterFactory.GetFormatter(output);
                formatter.WriteOutput(response);
            }, new CollectionBinding(driveItemIdOption, startDateTimeOption, endDateTimeOption, intervalOption, outputOption, new TypeBinding(typeof(IOutputFormatterFactory)), new TypeBinding(typeof(CancellationToken))));
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
            UrlTemplate = "{+baseurl}/workbooks/{driveItem_id}/microsoft.graph.getActivitiesByInterval(startDateTime='{startDateTime}',endDateTime='{endDateTime}',interval='{interval}')";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            urlTplParams.Add("startDateTime", startDateTime);
            urlTplParams.Add("endDateTime", endDateTime);
            urlTplParams.Add("interval", interval);
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
    }
}
