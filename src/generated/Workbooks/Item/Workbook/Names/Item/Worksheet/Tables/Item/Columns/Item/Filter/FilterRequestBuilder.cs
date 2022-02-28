using ApiSdk.Models.Microsoft.Graph;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.Columns.Item.Filter.Apply;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.Columns.Item.Filter.ApplyBottomItemsFilter;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.Columns.Item.Filter.ApplyBottomPercentFilter;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.Columns.Item.Filter.ApplyCellColorFilter;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.Columns.Item.Filter.ApplyCustomFilter;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.Columns.Item.Filter.ApplyDynamicFilter;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.Columns.Item.Filter.ApplyFontColorFilter;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.Columns.Item.Filter.ApplyIconFilter;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.Columns.Item.Filter.ApplyTopItemsFilter;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.Columns.Item.Filter.ApplyTopPercentFilter;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.Columns.Item.Filter.ApplyValuesFilter;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.Columns.Item.Filter.Clear;
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
namespace ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.Columns.Item.Filter {
    /// <summary>Builds and executes requests for operations under \workbooks\{driveItem-id}\workbook\names\{workbookNamedItem-id}\worksheet\tables\{workbookTable-id}\columns\{workbookTableColumn-id}\filter</summary>
    public class FilterRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public Command BuildApplyBottomItemsFilterCommand() {
            var command = new Command("apply-bottom-items-filter");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.Columns.Item.Filter.ApplyBottomItemsFilter.ApplyBottomItemsFilterRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildApplyBottomPercentFilterCommand() {
            var command = new Command("apply-bottom-percent-filter");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.Columns.Item.Filter.ApplyBottomPercentFilter.ApplyBottomPercentFilterRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildApplyCellColorFilterCommand() {
            var command = new Command("apply-cell-color-filter");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.Columns.Item.Filter.ApplyCellColorFilter.ApplyCellColorFilterRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildApplyCommand() {
            var command = new Command("apply");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.Columns.Item.Filter.Apply.ApplyRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildApplyCustomFilterCommand() {
            var command = new Command("apply-custom-filter");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.Columns.Item.Filter.ApplyCustomFilter.ApplyCustomFilterRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildApplyDynamicFilterCommand() {
            var command = new Command("apply-dynamic-filter");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.Columns.Item.Filter.ApplyDynamicFilter.ApplyDynamicFilterRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildApplyFontColorFilterCommand() {
            var command = new Command("apply-font-color-filter");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.Columns.Item.Filter.ApplyFontColorFilter.ApplyFontColorFilterRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildApplyIconFilterCommand() {
            var command = new Command("apply-icon-filter");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.Columns.Item.Filter.ApplyIconFilter.ApplyIconFilterRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildApplyTopItemsFilterCommand() {
            var command = new Command("apply-top-items-filter");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.Columns.Item.Filter.ApplyTopItemsFilter.ApplyTopItemsFilterRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildApplyTopPercentFilterCommand() {
            var command = new Command("apply-top-percent-filter");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.Columns.Item.Filter.ApplyTopPercentFilter.ApplyTopPercentFilterRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildApplyValuesFilterCommand() {
            var command = new Command("apply-values-filter");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.Columns.Item.Filter.ApplyValuesFilter.ApplyValuesFilterRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildClearCommand() {
            var command = new Command("clear");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.Columns.Item.Filter.Clear.ClearRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Retrieve the filter applied to the column. Read-only.
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Retrieve the filter applied to the column. Read-only.";
            // Create options for all the parameters
            var driveItemIdOption = new Option<string>("--drive-item-id", description: "key: id of driveItem") {
            };
            driveItemIdOption.IsRequired = true;
            command.AddOption(driveItemIdOption);
            var workbookNamedItemIdOption = new Option<string>("--workbook-named-item-id", description: "key: id of workbookNamedItem") {
            };
            workbookNamedItemIdOption.IsRequired = true;
            command.AddOption(workbookNamedItemIdOption);
            var workbookTableIdOption = new Option<string>("--workbook-table-id", description: "key: id of workbookTable") {
            };
            workbookTableIdOption.IsRequired = true;
            command.AddOption(workbookTableIdOption);
            var workbookTableColumnIdOption = new Option<string>("--workbook-table-column-id", description: "key: id of workbookTableColumn") {
            };
            workbookTableColumnIdOption.IsRequired = true;
            command.AddOption(workbookTableColumnIdOption);
            command.SetHandler(async (object[] parameters) => {
                var driveItemId = (string) parameters[0];
                var workbookNamedItemId = (string) parameters[1];
                var workbookTableId = (string) parameters[2];
                var workbookTableColumnId = (string) parameters[3];
                var outputFormatterFactory = (IOutputFormatterFactory) parameters[4];
                var cancellationToken = (CancellationToken) parameters[5];
                PathParameters.Clear();
                PathParameters.Add("driveItem_id", driveItemId);
                PathParameters.Add("workbookNamedItem_id", workbookNamedItemId);
                PathParameters.Add("workbookTable_id", workbookTableId);
                PathParameters.Add("workbookTableColumn_id", workbookTableColumnId);
                var requestInfo = CreateDeleteRequestInformation(q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(driveItemIdOption, workbookNamedItemIdOption, workbookTableIdOption, workbookTableColumnIdOption, new TypeBinding(typeof(IOutputFormatterFactory)), new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// Retrieve the filter applied to the column. Read-only.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Retrieve the filter applied to the column. Read-only.";
            // Create options for all the parameters
            var driveItemIdOption = new Option<string>("--drive-item-id", description: "key: id of driveItem") {
            };
            driveItemIdOption.IsRequired = true;
            command.AddOption(driveItemIdOption);
            var workbookNamedItemIdOption = new Option<string>("--workbook-named-item-id", description: "key: id of workbookNamedItem") {
            };
            workbookNamedItemIdOption.IsRequired = true;
            command.AddOption(workbookNamedItemIdOption);
            var workbookTableIdOption = new Option<string>("--workbook-table-id", description: "key: id of workbookTable") {
            };
            workbookTableIdOption.IsRequired = true;
            command.AddOption(workbookTableIdOption);
            var workbookTableColumnIdOption = new Option<string>("--workbook-table-column-id", description: "key: id of workbookTableColumn") {
            };
            workbookTableColumnIdOption.IsRequired = true;
            command.AddOption(workbookTableColumnIdOption);
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
            command.SetHandler(async (object[] parameters) => {
                var driveItemId = (string) parameters[0];
                var workbookNamedItemId = (string) parameters[1];
                var workbookTableId = (string) parameters[2];
                var workbookTableColumnId = (string) parameters[3];
                var select = (string[]) parameters[4];
                var expand = (string[]) parameters[5];
                var output = (FormatterType) parameters[6];
                var outputFormatterFactory = (IOutputFormatterFactory) parameters[7];
                var cancellationToken = (CancellationToken) parameters[8];
                PathParameters.Clear();
                PathParameters.Add("driveItem_id", driveItemId);
                PathParameters.Add("workbookNamedItem_id", workbookNamedItemId);
                PathParameters.Add("workbookTable_id", workbookTableId);
                PathParameters.Add("workbookTableColumn_id", workbookTableColumnId);
                var requestInfo = CreateGetRequestInformation(q => {
                    q.Select = select;
                    q.Expand = expand;
                });
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                var formatter = outputFormatterFactory.GetFormatter(output);
                formatter.WriteOutput(response);
            }, new CollectionBinding(driveItemIdOption, workbookNamedItemIdOption, workbookTableIdOption, workbookTableColumnIdOption, selectOption, expandOption, outputOption, new TypeBinding(typeof(IOutputFormatterFactory)), new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// Retrieve the filter applied to the column. Read-only.
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Retrieve the filter applied to the column. Read-only.";
            // Create options for all the parameters
            var driveItemIdOption = new Option<string>("--drive-item-id", description: "key: id of driveItem") {
            };
            driveItemIdOption.IsRequired = true;
            command.AddOption(driveItemIdOption);
            var workbookNamedItemIdOption = new Option<string>("--workbook-named-item-id", description: "key: id of workbookNamedItem") {
            };
            workbookNamedItemIdOption.IsRequired = true;
            command.AddOption(workbookNamedItemIdOption);
            var workbookTableIdOption = new Option<string>("--workbook-table-id", description: "key: id of workbookTable") {
            };
            workbookTableIdOption.IsRequired = true;
            command.AddOption(workbookTableIdOption);
            var workbookTableColumnIdOption = new Option<string>("--workbook-table-column-id", description: "key: id of workbookTableColumn") {
            };
            workbookTableColumnIdOption.IsRequired = true;
            command.AddOption(workbookTableColumnIdOption);
            var bodyOption = new Option<string>("--body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (object[] parameters) => {
                var driveItemId = (string) parameters[0];
                var workbookNamedItemId = (string) parameters[1];
                var workbookTableId = (string) parameters[2];
                var workbookTableColumnId = (string) parameters[3];
                var body = (string) parameters[4];
                var outputFormatterFactory = (IOutputFormatterFactory) parameters[5];
                var cancellationToken = (CancellationToken) parameters[6];
                PathParameters.Clear();
                PathParameters.Add("driveItem_id", driveItemId);
                PathParameters.Add("workbookNamedItem_id", workbookNamedItemId);
                PathParameters.Add("workbookTable_id", workbookTableId);
                PathParameters.Add("workbookTableColumn_id", workbookTableColumnId);
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<WorkbookFilter>();
                var requestInfo = CreatePatchRequestInformation(model, q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(driveItemIdOption, workbookNamedItemIdOption, workbookTableIdOption, workbookTableColumnIdOption, bodyOption, new TypeBinding(typeof(IOutputFormatterFactory)), new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// Instantiates a new FilterRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public FilterRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/workbooks/{driveItem_id}/workbook/names/{workbookNamedItem_id}/worksheet/tables/{workbookTable_id}/columns/{workbookTableColumn_id}/filter{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Retrieve the filter applied to the column. Read-only.
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
        /// Retrieve the filter applied to the column. Read-only.
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
        /// Retrieve the filter applied to the column. Read-only.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(WorkbookFilter body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// <summary>Retrieve the filter applied to the column. Read-only.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
