using ApiSdk.Models.Microsoft.Graph;
using ApiSdk.Workbooks.Item.Workbook.Worksheets.Item.Charts.Item.Series.Item.Format;
using ApiSdk.Workbooks.Item.Workbook.Worksheets.Item.Charts.Item.Series.Item.Points;
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
namespace ApiSdk.Workbooks.Item.Workbook.Worksheets.Item.Charts.Item.Series.Item {
    /// <summary>Builds and executes requests for operations under \workbooks\{driveItem-id}\workbook\worksheets\{workbookWorksheet-id}\charts\{workbookChart-id}\series\{workbookChartSeries-id}</summary>
    public class WorkbookChartSeriesRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Represents either a single series or collection of series in the chart. Read-only.
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            // Create options for all the parameters
            command.AddOption(new Option<string>("--driveitem-id", description: "key: id of driveItem"));
            command.AddOption(new Option<string>("--workbookworksheet-id", description: "key: id of workbookWorksheet"));
            command.AddOption(new Option<string>("--workbookchart-id", description: "key: id of workbookChart"));
            command.AddOption(new Option<string>("--workbookchartseries-id", description: "key: id of workbookChartSeries"));
            command.Handler = CommandHandler.Create<string, string, string, string>(async (driveItemId, workbookWorksheetId, workbookChartId, workbookChartSeriesId) => {
                var requestInfo = CreateDeleteRequestInformation();
                if (!String.IsNullOrEmpty(driveItemId)) requestInfo.PathParameters.Add("driveItem_id", driveItemId);
                if (!String.IsNullOrEmpty(workbookWorksheetId)) requestInfo.PathParameters.Add("workbookWorksheet_id", workbookWorksheetId);
                if (!String.IsNullOrEmpty(workbookChartId)) requestInfo.PathParameters.Add("workbookChart_id", workbookChartId);
                if (!String.IsNullOrEmpty(workbookChartSeriesId)) requestInfo.PathParameters.Add("workbookChartSeries_id", workbookChartSeriesId);
                await RequestAdapter.SendNoContentAsync(requestInfo);
                // Print request output. What if the request has no return?
                Console.WriteLine("Success");
            });
            return command;
        }
        public Command BuildFormatCommand() {
            var command = new Command("format");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Worksheets.Item.Charts.Item.Series.Item.Format.FormatRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildFillCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildLineCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        /// <summary>
        /// Represents either a single series or collection of series in the chart. Read-only.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            // Create options for all the parameters
            command.AddOption(new Option<string>("--driveitem-id", description: "key: id of driveItem"));
            command.AddOption(new Option<string>("--workbookworksheet-id", description: "key: id of workbookWorksheet"));
            command.AddOption(new Option<string>("--workbookchart-id", description: "key: id of workbookChart"));
            command.AddOption(new Option<string>("--workbookchartseries-id", description: "key: id of workbookChartSeries"));
            command.AddOption(new Option<object>("--select", description: "Select properties to be returned"));
            command.AddOption(new Option<object>("--expand", description: "Expand related entities"));
            command.Handler = CommandHandler.Create<string, string, string, string, object, object>(async (driveItemId, workbookWorksheetId, workbookChartId, workbookChartSeriesId, select, expand) => {
                var requestInfo = CreateGetRequestInformation();
                if (!String.IsNullOrEmpty(driveItemId)) requestInfo.PathParameters.Add("driveItem_id", driveItemId);
                if (!String.IsNullOrEmpty(workbookWorksheetId)) requestInfo.PathParameters.Add("workbookWorksheet_id", workbookWorksheetId);
                if (!String.IsNullOrEmpty(workbookChartId)) requestInfo.PathParameters.Add("workbookChart_id", workbookChartId);
                if (!String.IsNullOrEmpty(workbookChartSeriesId)) requestInfo.PathParameters.Add("workbookChartSeries_id", workbookChartSeriesId);
                requestInfo.QueryParameters.Add("select", select);
                requestInfo.QueryParameters.Add("expand", expand);
                var result = await RequestAdapter.SendAsync<WorkbookChartSeries>(requestInfo);
                // Print request output. What if the request has no return?
                using var serializer = RequestAdapter.SerializationWriterFactory.GetSerializationWriter("application/json");
                serializer.WriteObjectValue(null, result);
                using var content = serializer.GetSerializedContent();
                using var reader = new StreamReader(content);
                var strContent = await reader.ReadToEndAsync();
                Console.Write(strContent + "\n");
            });
            return command;
        }
        /// <summary>
        /// Represents either a single series or collection of series in the chart. Read-only.
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            // Create options for all the parameters
            command.AddOption(new Option<string>("--driveitem-id", description: "key: id of driveItem"));
            command.AddOption(new Option<string>("--workbookworksheet-id", description: "key: id of workbookWorksheet"));
            command.AddOption(new Option<string>("--workbookchart-id", description: "key: id of workbookChart"));
            command.AddOption(new Option<string>("--workbookchartseries-id", description: "key: id of workbookChartSeries"));
            command.AddOption(new Option<string>("--body"));
            command.Handler = CommandHandler.Create<string, string, string, string, string>(async (driveItemId, workbookWorksheetId, workbookChartId, workbookChartSeriesId, body) => {
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<WorkbookChartSeries>();
                var requestInfo = CreatePatchRequestInformation(model);
                if (!String.IsNullOrEmpty(driveItemId)) requestInfo.PathParameters.Add("driveItem_id", driveItemId);
                if (!String.IsNullOrEmpty(workbookWorksheetId)) requestInfo.PathParameters.Add("workbookWorksheet_id", workbookWorksheetId);
                if (!String.IsNullOrEmpty(workbookChartId)) requestInfo.PathParameters.Add("workbookChart_id", workbookChartId);
                if (!String.IsNullOrEmpty(workbookChartSeriesId)) requestInfo.PathParameters.Add("workbookChartSeries_id", workbookChartSeriesId);
                await RequestAdapter.SendNoContentAsync(requestInfo);
                // Print request output. What if the request has no return?
                Console.WriteLine("Success");
            });
            return command;
        }
        public Command BuildPointsCommand() {
            var command = new Command("points");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Worksheets.Item.Charts.Item.Series.Item.Points.PointsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new WorkbookChartSeriesRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public WorkbookChartSeriesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/workbooks/{driveItem_id}/workbook/worksheets/{workbookWorksheet_id}/charts/{workbookChart_id}/series/{workbookChartSeries_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Represents either a single series or collection of series in the chart. Read-only.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreateDeleteRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Represents either a single series or collection of series in the chart. Read-only.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.GET,
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
        /// Represents either a single series or collection of series in the chart. Read-only.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(WorkbookChartSeries body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Represents either a single series or collection of series in the chart. Read-only.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateDeleteRequestInformation(h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>
        /// Represents either a single series or collection of series in the chart. Read-only.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<WorkbookChartSeries> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<WorkbookChartSeries>(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>
        /// Represents either a single series or collection of series in the chart. Read-only.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="model"></param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(WorkbookChartSeries model, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = model ?? throw new ArgumentNullException(nameof(model));
            var requestInfo = CreatePatchRequestInformation(model, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>Represents either a single series or collection of series in the chart. Read-only.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
