using ApiSdk.Models.Microsoft.Graph;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Charts.Item.Axes;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Charts.Item.DataLabels;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Charts.Item.Format;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Charts.Item.Image;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Charts.Item.ImageWithWidth;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Charts.Item.ImageWithWidthWithHeight;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Charts.Item.ImageWithWidthWithHeightWithFittingMode;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Charts.Item.Legend;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Charts.Item.Series;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Charts.Item.SetData;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Charts.Item.SetPosition;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Charts.Item.Title;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Charts.Item.Worksheet;
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
namespace ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Charts.Item {
    /// <summary>Builds and executes requests for operations under \workbooks\{driveItem-id}\workbook\names\{workbookNamedItem-id}\worksheet\charts\{workbookChart-id}</summary>
    public class WorkbookChartItemRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public Command BuildAxesCommand() {
            var command = new Command("axes");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Charts.Item.Axes.AxesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCategoryAxisCommand());
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildSeriesAxisCommand());
            command.AddCommand(builder.BuildValueAxisCommand());
            return command;
        }
        public Command BuildDataLabelsCommand() {
            var command = new Command("data-labels");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Charts.Item.DataLabels.DataLabelsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildFormatCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        /// <summary>
        /// Returns collection of charts that are part of the worksheet. Read-only.
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Returns collection of charts that are part of the worksheet. Read-only.";
            // Create options for all the parameters
            var driveItemIdOption = new Option<string>("--drive-item-id", description: "key: id of driveItem") {
            };
            driveItemIdOption.IsRequired = true;
            command.AddOption(driveItemIdOption);
            var workbookNamedItemIdOption = new Option<string>("--workbook-named-item-id", description: "key: id of workbookNamedItem") {
            };
            workbookNamedItemIdOption.IsRequired = true;
            command.AddOption(workbookNamedItemIdOption);
            var workbookChartIdOption = new Option<string>("--workbook-chart-id", description: "key: id of workbookChart") {
            };
            workbookChartIdOption.IsRequired = true;
            command.AddOption(workbookChartIdOption);
            command.SetHandler(async (object[] parameters) => {
                var driveItemId = (string) parameters[0];
                var workbookNamedItemId = (string) parameters[1];
                var workbookChartId = (string) parameters[2];
                var cancellationToken = (CancellationToken) parameters[3];
                PathParameters.Clear();
                PathParameters.Add("driveItem_id", driveItemId);
                PathParameters.Add("workbookNamedItem_id", workbookNamedItemId);
                PathParameters.Add("workbookChart_id", workbookChartId);
                var requestInfo = CreateDeleteRequestInformation(q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(driveItemIdOption, workbookNamedItemIdOption, workbookChartIdOption, new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        public Command BuildFormatCommand() {
            var command = new Command("format");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Charts.Item.Format.FormatRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildFillCommand());
            command.AddCommand(builder.BuildFontCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        /// <summary>
        /// Returns collection of charts that are part of the worksheet. Read-only.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Returns collection of charts that are part of the worksheet. Read-only.";
            // Create options for all the parameters
            var driveItemIdOption = new Option<string>("--drive-item-id", description: "key: id of driveItem") {
            };
            driveItemIdOption.IsRequired = true;
            command.AddOption(driveItemIdOption);
            var workbookNamedItemIdOption = new Option<string>("--workbook-named-item-id", description: "key: id of workbookNamedItem") {
            };
            workbookNamedItemIdOption.IsRequired = true;
            command.AddOption(workbookNamedItemIdOption);
            var workbookChartIdOption = new Option<string>("--workbook-chart-id", description: "key: id of workbookChart") {
            };
            workbookChartIdOption.IsRequired = true;
            command.AddOption(workbookChartIdOption);
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
            var outputFilterOption = new Option<string>("--query");
            command.AddOption(outputFilterOption);
            command.SetHandler(async (object[] parameters) => {
                var driveItemId = (string) parameters[0];
                var workbookNamedItemId = (string) parameters[1];
                var workbookChartId = (string) parameters[2];
                var select = (string[]) parameters[3];
                var expand = (string[]) parameters[4];
                var output = (FormatterType) parameters[5];
                var outputFilterOption = (string) parameters[6];
                var outputFormatterFactory = (IOutputFormatterFactory) parameters[7];
                var cancellationToken = (CancellationToken) parameters[8];
                PathParameters.Clear();
                PathParameters.Add("driveItem_id", driveItemId);
                PathParameters.Add("workbookNamedItem_id", workbookNamedItemId);
                PathParameters.Add("workbookChart_id", workbookChartId);
                var requestInfo = CreateGetRequestInformation(q => {
                    q.Select = select;
                    q.Expand = expand;
                });
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                var formatter = outputFormatterFactory.GetFormatter(output);
                formatter.WriteOutput(response);
            }, new CollectionBinding(driveItemIdOption, workbookNamedItemIdOption, workbookChartIdOption, selectOption, expandOption, outputOption, outputFilterOption, new TypeBinding(typeof(IOutputFormatterFactory)), new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        public Command BuildLegendCommand() {
            var command = new Command("legend");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Charts.Item.Legend.LegendRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildFormatCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        /// <summary>
        /// Returns collection of charts that are part of the worksheet. Read-only.
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Returns collection of charts that are part of the worksheet. Read-only.";
            // Create options for all the parameters
            var driveItemIdOption = new Option<string>("--drive-item-id", description: "key: id of driveItem") {
            };
            driveItemIdOption.IsRequired = true;
            command.AddOption(driveItemIdOption);
            var workbookNamedItemIdOption = new Option<string>("--workbook-named-item-id", description: "key: id of workbookNamedItem") {
            };
            workbookNamedItemIdOption.IsRequired = true;
            command.AddOption(workbookNamedItemIdOption);
            var workbookChartIdOption = new Option<string>("--workbook-chart-id", description: "key: id of workbookChart") {
            };
            workbookChartIdOption.IsRequired = true;
            command.AddOption(workbookChartIdOption);
            var bodyOption = new Option<string>("--body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (object[] parameters) => {
                var driveItemId = (string) parameters[0];
                var workbookNamedItemId = (string) parameters[1];
                var workbookChartId = (string) parameters[2];
                var body = (string) parameters[3];
                var cancellationToken = (CancellationToken) parameters[4];
                PathParameters.Clear();
                PathParameters.Add("driveItem_id", driveItemId);
                PathParameters.Add("workbookNamedItem_id", workbookNamedItemId);
                PathParameters.Add("workbookChart_id", workbookChartId);
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<WorkbookChart>();
                var requestInfo = CreatePatchRequestInformation(model, q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(driveItemIdOption, workbookNamedItemIdOption, workbookChartIdOption, bodyOption, new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        public Command BuildSeriesCommand() {
            var command = new Command("series");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Charts.Item.Series.SeriesRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildSetDataCommand() {
            var command = new Command("set-data");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Charts.Item.SetData.SetDataRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildSetPositionCommand() {
            var command = new Command("set-position");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Charts.Item.SetPosition.SetPositionRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildTitleCommand() {
            var command = new Command("title");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Charts.Item.Title.TitleRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildFormatCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        public Command BuildWorksheetCommand() {
            var command = new Command("worksheet");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Charts.Item.Worksheet.WorksheetRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new WorkbookChartItemRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public WorkbookChartItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/workbooks/{driveItem_id}/workbook/names/{workbookNamedItem_id}/worksheet/charts/{workbookChart_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Returns collection of charts that are part of the worksheet. Read-only.
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
        /// Returns collection of charts that are part of the worksheet. Read-only.
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
        /// Returns collection of charts that are part of the worksheet. Read-only.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(WorkbookChart body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// Builds and executes requests for operations under \workbooks\{driveItem-id}\workbook\names\{workbookNamedItem-id}\worksheet\charts\{workbookChart-id}\microsoft.graph.image()
        /// </summary>
        public ImageRequestBuilder Image() {
            return new ImageRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Builds and executes requests for operations under \workbooks\{driveItem-id}\workbook\names\{workbookNamedItem-id}\worksheet\charts\{workbookChart-id}\microsoft.graph.image(width={width})
        /// <param name="width">Usage: width={width}</param>
        /// </summary>
        public ImageWithWidthRequestBuilder ImageWithWidth(int? width) {
            _ = width ?? throw new ArgumentNullException(nameof(width));
            return new ImageWithWidthRequestBuilder(PathParameters, RequestAdapter, width);
        }
        /// <summary>
        /// Builds and executes requests for operations under \workbooks\{driveItem-id}\workbook\names\{workbookNamedItem-id}\worksheet\charts\{workbookChart-id}\microsoft.graph.image(width={width},height={height})
        /// <param name="height">Usage: height={height}</param>
        /// <param name="width">Usage: width={width}</param>
        /// </summary>
        public ImageWithWidthWithHeightRequestBuilder ImageWithWidthWithHeight(int? width, int? height) {
            _ = height ?? throw new ArgumentNullException(nameof(height));
            _ = width ?? throw new ArgumentNullException(nameof(width));
            return new ImageWithWidthWithHeightRequestBuilder(PathParameters, RequestAdapter, width, height);
        }
        /// <summary>
        /// Builds and executes requests for operations under \workbooks\{driveItem-id}\workbook\names\{workbookNamedItem-id}\worksheet\charts\{workbookChart-id}\microsoft.graph.image(width={width},height={height},fittingMode='{fittingMode}')
        /// <param name="fittingMode">Usage: fittingMode={fittingMode}</param>
        /// <param name="height">Usage: height={height}</param>
        /// <param name="width">Usage: width={width}</param>
        /// </summary>
        public ImageWithWidthWithHeightWithFittingModeRequestBuilder ImageWithWidthWithHeightWithFittingMode(int? width, int? height, string fittingMode) {
            if(string.IsNullOrEmpty(fittingMode)) throw new ArgumentNullException(nameof(fittingMode));
            _ = height ?? throw new ArgumentNullException(nameof(height));
            _ = width ?? throw new ArgumentNullException(nameof(width));
            return new ImageWithWidthWithHeightWithFittingModeRequestBuilder(PathParameters, RequestAdapter, width, height, fittingMode);
        }
        /// <summary>Returns collection of charts that are part of the worksheet. Read-only.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
