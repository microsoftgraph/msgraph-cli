using ApiSdk.Models.Microsoft.Graph;
using ApiSdk.Workbooks.Item.Workbook.Worksheets.Item.PivotTables.Item.Worksheet.CellWithRowWithColumn;
using ApiSdk.Workbooks.Item.Workbook.Worksheets.Item.PivotTables.Item.Worksheet.Range;
using ApiSdk.Workbooks.Item.Workbook.Worksheets.Item.PivotTables.Item.Worksheet.RangeWithAddress;
using ApiSdk.Workbooks.Item.Workbook.Worksheets.Item.PivotTables.Item.Worksheet.UsedRange;
using ApiSdk.Workbooks.Item.Workbook.Worksheets.Item.PivotTables.Item.Worksheet.UsedRangeWithValuesOnly;
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
namespace ApiSdk.Workbooks.Item.Workbook.Worksheets.Item.PivotTables.Item.Worksheet {
    /// <summary>Builds and executes requests for operations under \workbooks\{driveItem-id}\workbook\worksheets\{workbookWorksheet-id}\pivotTables\{workbookPivotTable-id}\worksheet</summary>
    public class WorksheetRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// The worksheet containing the current PivotTable. Read-only.
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "The worksheet containing the current PivotTable. Read-only.";
            // Create options for all the parameters
            var driveItemIdOption = new Option<string>("--driveitem-id", description: "key: id of driveItem") {
            };
            driveItemIdOption.IsRequired = true;
            command.AddOption(driveItemIdOption);
            var workbookWorksheetIdOption = new Option<string>("--workbookworksheet-id", description: "key: id of workbookWorksheet") {
            };
            workbookWorksheetIdOption.IsRequired = true;
            command.AddOption(workbookWorksheetIdOption);
            var workbookPivotTableIdOption = new Option<string>("--workbookpivottable-id", description: "key: id of workbookPivotTable") {
            };
            workbookPivotTableIdOption.IsRequired = true;
            command.AddOption(workbookPivotTableIdOption);
            command.SetHandler(async (string driveItemId, string workbookWorksheetId, string workbookPivotTableId, IOutputFormatterFactory outputFormatterFactory, IConsole console) => {
                var requestInfo = CreateDeleteRequestInformation(q => {
                });
                await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo);
                console.WriteLine("Success");
            }, driveItemIdOption, workbookWorksheetIdOption, workbookPivotTableIdOption, new OutputFormatterFactoryBinder());
            return command;
        }
        /// <summary>
        /// The worksheet containing the current PivotTable. Read-only.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "The worksheet containing the current PivotTable. Read-only.";
            // Create options for all the parameters
            var driveItemIdOption = new Option<string>("--driveitem-id", description: "key: id of driveItem") {
            };
            driveItemIdOption.IsRequired = true;
            command.AddOption(driveItemIdOption);
            var workbookWorksheetIdOption = new Option<string>("--workbookworksheet-id", description: "key: id of workbookWorksheet") {
            };
            workbookWorksheetIdOption.IsRequired = true;
            command.AddOption(workbookWorksheetIdOption);
            var workbookPivotTableIdOption = new Option<string>("--workbookpivottable-id", description: "key: id of workbookPivotTable") {
            };
            workbookPivotTableIdOption.IsRequired = true;
            command.AddOption(workbookPivotTableIdOption);
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
            command.SetHandler(async (string driveItemId, string workbookWorksheetId, string workbookPivotTableId, string[] select, string[] expand, FormatterType output, IOutputFormatterFactory outputFormatterFactory, IConsole console) => {
                var requestInfo = CreateGetRequestInformation(q => {
                    q.Select = select;
                    q.Expand = expand;
                });
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo);
                var formatter = outputFormatterFactory.GetFormatter(output);
                formatter.WriteOutput(response, console);
            }, driveItemIdOption, workbookWorksheetIdOption, workbookPivotTableIdOption, selectOption, expandOption, outputOption, new OutputFormatterFactoryBinder());
            return command;
        }
        /// <summary>
        /// The worksheet containing the current PivotTable. Read-only.
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "The worksheet containing the current PivotTable. Read-only.";
            // Create options for all the parameters
            var driveItemIdOption = new Option<string>("--driveitem-id", description: "key: id of driveItem") {
            };
            driveItemIdOption.IsRequired = true;
            command.AddOption(driveItemIdOption);
            var workbookWorksheetIdOption = new Option<string>("--workbookworksheet-id", description: "key: id of workbookWorksheet") {
            };
            workbookWorksheetIdOption.IsRequired = true;
            command.AddOption(workbookWorksheetIdOption);
            var workbookPivotTableIdOption = new Option<string>("--workbookpivottable-id", description: "key: id of workbookPivotTable") {
            };
            workbookPivotTableIdOption.IsRequired = true;
            command.AddOption(workbookPivotTableIdOption);
            var bodyOption = new Option<string>("--body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (string driveItemId, string workbookWorksheetId, string workbookPivotTableId, string body, IOutputFormatterFactory outputFormatterFactory, IConsole console) => {
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<WorkbookWorksheet>();
                var requestInfo = CreatePatchRequestInformation(model, q => {
                });
                await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo);
                console.WriteLine("Success");
            }, driveItemIdOption, workbookWorksheetIdOption, workbookPivotTableIdOption, bodyOption, new OutputFormatterFactoryBinder());
            return command;
        }
        /// <summary>
        /// Builds and executes requests for operations under \workbooks\{driveItem-id}\workbook\worksheets\{workbookWorksheet-id}\pivotTables\{workbookPivotTable-id}\worksheet\microsoft.graph.cell(row={row},column={column})
        /// <param name="column">Usage: column={column}</param>
        /// <param name="row">Usage: row={row}</param>
        /// </summary>
        public CellWithRowWithColumnRequestBuilder CellWithRowWithColumn(int? row, int? column) {
            _ = column ?? throw new ArgumentNullException(nameof(column));
            _ = row ?? throw new ArgumentNullException(nameof(row));
            return new CellWithRowWithColumnRequestBuilder(PathParameters, RequestAdapter, row, column);
        }
        /// <summary>
        /// Instantiates a new WorksheetRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public WorksheetRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/workbooks/{driveItem_id}/workbook/worksheets/{workbookWorksheet_id}/pivotTables/{workbookPivotTable_id}/worksheet{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new WorksheetRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public WorksheetRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/workbooks/{driveItem_id}/workbook/worksheets/{workbookWorksheet_id}/pivotTables/{workbookPivotTable_id}/worksheet{?select,expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// The worksheet containing the current PivotTable. Read-only.
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
        /// The worksheet containing the current PivotTable. Read-only.
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
        /// The worksheet containing the current PivotTable. Read-only.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(WorkbookWorksheet body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// <summary>
        /// The worksheet containing the current PivotTable. Read-only.
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
        /// The worksheet containing the current PivotTable. Read-only.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<WorkbookWorksheet> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<WorkbookWorksheet>(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>
        /// The worksheet containing the current PivotTable. Read-only.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="model"></param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(WorkbookWorksheet model, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = model ?? throw new ArgumentNullException(nameof(model));
            var requestInfo = CreatePatchRequestInformation(model, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>
        /// Builds and executes requests for operations under \workbooks\{driveItem-id}\workbook\worksheets\{workbookWorksheet-id}\pivotTables\{workbookPivotTable-id}\worksheet\microsoft.graph.range()
        /// </summary>
        public RangeRequestBuilder Range() {
            return new RangeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Builds and executes requests for operations under \workbooks\{driveItem-id}\workbook\worksheets\{workbookWorksheet-id}\pivotTables\{workbookPivotTable-id}\worksheet\microsoft.graph.range(address='{address}')
        /// <param name="address">Usage: address={address}</param>
        /// </summary>
        public RangeWithAddressRequestBuilder RangeWithAddress(string address) {
            if(string.IsNullOrEmpty(address)) throw new ArgumentNullException(nameof(address));
            return new RangeWithAddressRequestBuilder(PathParameters, RequestAdapter, address);
        }
        /// <summary>
        /// Builds and executes requests for operations under \workbooks\{driveItem-id}\workbook\worksheets\{workbookWorksheet-id}\pivotTables\{workbookPivotTable-id}\worksheet\microsoft.graph.usedRange()
        /// </summary>
        public UsedRangeRequestBuilder UsedRange() {
            return new UsedRangeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Builds and executes requests for operations under \workbooks\{driveItem-id}\workbook\worksheets\{workbookWorksheet-id}\pivotTables\{workbookPivotTable-id}\worksheet\microsoft.graph.usedRange(valuesOnly={valuesOnly})
        /// <param name="valuesOnly">Usage: valuesOnly={valuesOnly}</param>
        /// </summary>
        public UsedRangeWithValuesOnlyRequestBuilder UsedRangeWithValuesOnly(bool? valuesOnly) {
            _ = valuesOnly ?? throw new ArgumentNullException(nameof(valuesOnly));
            return new UsedRangeWithValuesOnlyRequestBuilder(PathParameters, RequestAdapter, valuesOnly);
        }
        /// <summary>The worksheet containing the current PivotTable. Read-only.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
