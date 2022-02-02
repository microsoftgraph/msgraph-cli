using ApiSdk.Models.Microsoft.Graph;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.ClearFilters;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.Columns;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.ConvertToRange;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.DataBodyRange;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.HeaderRowRange;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.Range;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.ReapplyFilters;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.Rows;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.Sort;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.TotalRowRange;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.Worksheet;
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
namespace ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item {
    /// <summary>Builds and executes requests for operations under \workbooks\{driveItem-id}\workbook\names\{workbookNamedItem-id}\worksheet\tables\{workbookTable-id}</summary>
    public class WorkbookTableRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public Command BuildClearFiltersCommand() {
            var command = new Command("clear-filters");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.ClearFilters.ClearFiltersRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildColumnsCommand() {
            var command = new Command("columns");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.Columns.ColumnsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildAddCommand());
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildConvertToRangeCommand() {
            var command = new Command("convert-to-range");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.ConvertToRange.ConvertToRangeRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Collection of tables that are part of the worksheet. Read-only.
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Collection of tables that are part of the worksheet. Read-only.";
            // Create options for all the parameters
            var driveItemIdOption = new Option<string>("--driveitem-id", description: "key: id of driveItem") {
            };
            driveItemIdOption.IsRequired = true;
            command.AddOption(driveItemIdOption);
            var workbookNamedItemIdOption = new Option<string>("--workbooknameditem-id", description: "key: id of workbookNamedItem") {
            };
            workbookNamedItemIdOption.IsRequired = true;
            command.AddOption(workbookNamedItemIdOption);
            var workbookTableIdOption = new Option<string>("--workbooktable-id", description: "key: id of workbookTable") {
            };
            workbookTableIdOption.IsRequired = true;
            command.AddOption(workbookTableIdOption);
            command.SetHandler(async (string driveItemId, string workbookNamedItemId, string workbookTableId, IServiceProvider serviceProvider, IConsole console) => {
                var responseHandler = serviceProvider.GetService(typeof(IResponseHandler)) as IResponseHandler;
                var requestInfo = CreateDeleteRequestInformation(q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler);
                // Print request output. What if the request has no return?
                console.WriteLine("Success");
            }, driveItemIdOption, workbookNamedItemIdOption, workbookTableIdOption, new ServiceProviderBinder());
            return command;
        }
        /// <summary>
        /// Collection of tables that are part of the worksheet. Read-only.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Collection of tables that are part of the worksheet. Read-only.";
            // Create options for all the parameters
            var driveItemIdOption = new Option<string>("--driveitem-id", description: "key: id of driveItem") {
            };
            driveItemIdOption.IsRequired = true;
            command.AddOption(driveItemIdOption);
            var workbookNamedItemIdOption = new Option<string>("--workbooknameditem-id", description: "key: id of workbookNamedItem") {
            };
            workbookNamedItemIdOption.IsRequired = true;
            command.AddOption(workbookNamedItemIdOption);
            var workbookTableIdOption = new Option<string>("--workbooktable-id", description: "key: id of workbookTable") {
            };
            workbookTableIdOption.IsRequired = true;
            command.AddOption(workbookTableIdOption);
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
            command.SetHandler(async (string driveItemId, string workbookNamedItemId, string workbookTableId, string[] select, string[] expand, FormatterType output, IServiceProvider serviceProvider, IConsole console) => {
                var responseHandler = serviceProvider.GetService(typeof(IResponseHandler)) as IResponseHandler;
                var requestInfo = CreateGetRequestInformation(q => {
                    q.Select = select;
                    q.Expand = expand;
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
            }, driveItemIdOption, workbookNamedItemIdOption, workbookTableIdOption, selectOption, expandOption, outputOption, new ServiceProviderBinder());
            return command;
        }
        /// <summary>
        /// Collection of tables that are part of the worksheet. Read-only.
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Collection of tables that are part of the worksheet. Read-only.";
            // Create options for all the parameters
            var driveItemIdOption = new Option<string>("--driveitem-id", description: "key: id of driveItem") {
            };
            driveItemIdOption.IsRequired = true;
            command.AddOption(driveItemIdOption);
            var workbookNamedItemIdOption = new Option<string>("--workbooknameditem-id", description: "key: id of workbookNamedItem") {
            };
            workbookNamedItemIdOption.IsRequired = true;
            command.AddOption(workbookNamedItemIdOption);
            var workbookTableIdOption = new Option<string>("--workbooktable-id", description: "key: id of workbookTable") {
            };
            workbookTableIdOption.IsRequired = true;
            command.AddOption(workbookTableIdOption);
            var bodyOption = new Option<string>("--body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (string driveItemId, string workbookNamedItemId, string workbookTableId, string body, IServiceProvider serviceProvider, IConsole console) => {
                var responseHandler = serviceProvider.GetService(typeof(IResponseHandler)) as IResponseHandler;
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<WorkbookTable>();
                var requestInfo = CreatePatchRequestInformation(model, q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler);
                // Print request output. What if the request has no return?
                console.WriteLine("Success");
            }, driveItemIdOption, workbookNamedItemIdOption, workbookTableIdOption, bodyOption, new ServiceProviderBinder());
            return command;
        }
        public Command BuildReapplyFiltersCommand() {
            var command = new Command("reapply-filters");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.ReapplyFilters.ReapplyFiltersRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildRowsCommand() {
            var command = new Command("rows");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.Rows.RowsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildAddCommand());
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildSortCommand() {
            var command = new Command("sort");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.Sort.SortRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildApplyCommand());
            command.AddCommand(builder.BuildClearCommand());
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildReapplyCommand());
            return command;
        }
        public Command BuildWorksheetCommand() {
            var command = new Command("worksheet");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.Worksheet.WorksheetRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new WorkbookTableRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public WorkbookTableRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/workbooks/{driveItem_id}/workbook/names/{workbookNamedItem_id}/worksheet/tables/{workbookTable_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new WorkbookTableRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public WorkbookTableRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/workbooks/{driveItem_id}/workbook/names/{workbookNamedItem_id}/worksheet/tables/{workbookTable_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Collection of tables that are part of the worksheet. Read-only.
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
        /// Collection of tables that are part of the worksheet. Read-only.
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
        /// Collection of tables that are part of the worksheet. Read-only.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(WorkbookTable body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// Builds and executes requests for operations under \workbooks\{driveItem-id}\workbook\names\{workbookNamedItem-id}\worksheet\tables\{workbookTable-id}\microsoft.graph.dataBodyRange()
        /// </summary>
        public DataBodyRangeRequestBuilder DataBodyRange() {
            return new DataBodyRangeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Collection of tables that are part of the worksheet. Read-only.
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
        /// Collection of tables that are part of the worksheet. Read-only.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<WorkbookTable> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<WorkbookTable>(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>
        /// Builds and executes requests for operations under \workbooks\{driveItem-id}\workbook\names\{workbookNamedItem-id}\worksheet\tables\{workbookTable-id}\microsoft.graph.headerRowRange()
        /// </summary>
        public HeaderRowRangeRequestBuilder HeaderRowRange() {
            return new HeaderRowRangeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Collection of tables that are part of the worksheet. Read-only.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="model"></param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(WorkbookTable model, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = model ?? throw new ArgumentNullException(nameof(model));
            var requestInfo = CreatePatchRequestInformation(model, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>
        /// Builds and executes requests for operations under \workbooks\{driveItem-id}\workbook\names\{workbookNamedItem-id}\worksheet\tables\{workbookTable-id}\microsoft.graph.range()
        /// </summary>
        public RangeRequestBuilder Range() {
            return new RangeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Builds and executes requests for operations under \workbooks\{driveItem-id}\workbook\names\{workbookNamedItem-id}\worksheet\tables\{workbookTable-id}\microsoft.graph.totalRowRange()
        /// </summary>
        public TotalRowRangeRequestBuilder TotalRowRange() {
            return new TotalRowRangeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Collection of tables that are part of the worksheet. Read-only.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
