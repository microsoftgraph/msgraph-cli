using ApiSdk.Models.Microsoft.Graph;
using ApiSdk.Workbooks.Item.Workbook.Tables.Item.Worksheet.Tables.Item.ClearFilters;
using ApiSdk.Workbooks.Item.Workbook.Tables.Item.Worksheet.Tables.Item.ConvertToRange;
using ApiSdk.Workbooks.Item.Workbook.Tables.Item.Worksheet.Tables.Item.DataBodyRange;
using ApiSdk.Workbooks.Item.Workbook.Tables.Item.Worksheet.Tables.Item.HeaderRowRange;
using ApiSdk.Workbooks.Item.Workbook.Tables.Item.Worksheet.Tables.Item.Range;
using ApiSdk.Workbooks.Item.Workbook.Tables.Item.Worksheet.Tables.Item.ReapplyFilters;
using ApiSdk.Workbooks.Item.Workbook.Tables.Item.Worksheet.Tables.Item.TotalRowRange;
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
namespace ApiSdk.Workbooks.Item.Workbook.Tables.Item.Worksheet.Tables.Item {
    /// <summary>Builds and executes requests for operations under \workbooks\{driveItem-id}\workbook\tables\{workbookTable-id}\worksheet\tables\{workbookTable-id1}</summary>
    public class WorkbookTableRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public Command BuildClearFiltersCommand() {
            var command = new Command("clear-filters");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Tables.Item.Worksheet.Tables.Item.ClearFilters.ClearFiltersRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildConvertToRangeCommand() {
            var command = new Command("convert-to-range");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Tables.Item.Worksheet.Tables.Item.ConvertToRange.ConvertToRangeRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Collection of tables that are part of the worksheet. Read-only.
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            // Create options for all the parameters
            command.AddOption(new Option<string>("--driveitem-id", description: "key: id of driveItem"));
            command.AddOption(new Option<string>("--workbooktable-id", description: "key: id of workbookTable"));
            command.AddOption(new Option<string>("--workbooktable-id1", description: "key: id of workbookTable"));
            command.Handler = CommandHandler.Create<string, string, string>(async (driveItemId, workbookTableId, workbookTableId1) => {
                var requestInfo = CreateDeleteRequestInformation();
                if (!String.IsNullOrEmpty(driveItemId)) requestInfo.PathParameters.Add("driveItem_id", driveItemId);
                if (!String.IsNullOrEmpty(workbookTableId)) requestInfo.PathParameters.Add("workbookTable_id", workbookTableId);
                if (!String.IsNullOrEmpty(workbookTableId1)) requestInfo.PathParameters.Add("workbookTable_id1", workbookTableId1);
                await RequestAdapter.SendNoContentAsync(requestInfo);
                // Print request output. What if the request has no return?
                Console.WriteLine("Success");
            });
            return command;
        }
        /// <summary>
        /// Collection of tables that are part of the worksheet. Read-only.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            // Create options for all the parameters
            command.AddOption(new Option<string>("--driveitem-id", description: "key: id of driveItem"));
            command.AddOption(new Option<string>("--workbooktable-id", description: "key: id of workbookTable"));
            command.AddOption(new Option<string>("--workbooktable-id1", description: "key: id of workbookTable"));
            command.AddOption(new Option<object>("--select", description: "Select properties to be returned"));
            command.AddOption(new Option<object>("--expand", description: "Expand related entities"));
            command.Handler = CommandHandler.Create<string, string, string, object, object>(async (driveItemId, workbookTableId, workbookTableId1, select, expand) => {
                var requestInfo = CreateGetRequestInformation();
                if (!String.IsNullOrEmpty(driveItemId)) requestInfo.PathParameters.Add("driveItem_id", driveItemId);
                if (!String.IsNullOrEmpty(workbookTableId)) requestInfo.PathParameters.Add("workbookTable_id", workbookTableId);
                if (!String.IsNullOrEmpty(workbookTableId1)) requestInfo.PathParameters.Add("workbookTable_id1", workbookTableId1);
                requestInfo.QueryParameters.Add("select", select);
                requestInfo.QueryParameters.Add("expand", expand);
                var result = await RequestAdapter.SendAsync<WorkbookTable>(requestInfo);
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
        /// Collection of tables that are part of the worksheet. Read-only.
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            // Create options for all the parameters
            command.AddOption(new Option<string>("--driveitem-id", description: "key: id of driveItem"));
            command.AddOption(new Option<string>("--workbooktable-id", description: "key: id of workbookTable"));
            command.AddOption(new Option<string>("--workbooktable-id1", description: "key: id of workbookTable"));
            command.AddOption(new Option<string>("--body"));
            command.Handler = CommandHandler.Create<string, string, string, string>(async (driveItemId, workbookTableId, workbookTableId1, body) => {
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<WorkbookTable>();
                var requestInfo = CreatePatchRequestInformation(model);
                if (!String.IsNullOrEmpty(driveItemId)) requestInfo.PathParameters.Add("driveItem_id", driveItemId);
                if (!String.IsNullOrEmpty(workbookTableId)) requestInfo.PathParameters.Add("workbookTable_id", workbookTableId);
                if (!String.IsNullOrEmpty(workbookTableId1)) requestInfo.PathParameters.Add("workbookTable_id1", workbookTableId1);
                await RequestAdapter.SendNoContentAsync(requestInfo);
                // Print request output. What if the request has no return?
                Console.WriteLine("Success");
            });
            return command;
        }
        public Command BuildReapplyFiltersCommand() {
            var command = new Command("reapply-filters");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Tables.Item.Worksheet.Tables.Item.ReapplyFilters.ReapplyFiltersRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
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
            UrlTemplate = "{+baseurl}/workbooks/{driveItem_id}/workbook/tables/{workbookTable_id}/worksheet/tables/{workbookTable_id1}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
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
                HttpMethod = HttpMethod.DELETE,
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
        /// Collection of tables that are part of the worksheet. Read-only.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(WorkbookTable body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// Builds and executes requests for operations under \workbooks\{driveItem-id}\workbook\tables\{workbookTable-id}\worksheet\tables\{workbookTable-id1}\microsoft.graph.dataBodyRange()
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
        /// Builds and executes requests for operations under \workbooks\{driveItem-id}\workbook\tables\{workbookTable-id}\worksheet\tables\{workbookTable-id1}\microsoft.graph.headerRowRange()
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
        /// Builds and executes requests for operations under \workbooks\{driveItem-id}\workbook\tables\{workbookTable-id}\worksheet\tables\{workbookTable-id1}\microsoft.graph.range()
        /// </summary>
        public RangeRequestBuilder Range() {
            return new RangeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Builds and executes requests for operations under \workbooks\{driveItem-id}\workbook\tables\{workbookTable-id}\worksheet\tables\{workbookTable-id1}\microsoft.graph.totalRowRange()
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
