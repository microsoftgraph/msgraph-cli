using ApiSdk.Models.ODataErrors;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Cli.Commons.Extensions;
using Microsoft.Kiota.Cli.Commons.IO;
using Microsoft.Kiota.Cli.Commons;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.Item.Series.Item.Points.Item.Format.Fill.Clear {
    /// <summary>
    /// Provides operations to call the clear method.
    /// </summary>
    public class ClearRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Clear the fill color of a chart element.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/chartfill-clear?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildPostCommand() {
            var command = new Command("post");
            command.Description = "Clear the fill color of a chart element.\n\nFind more info here:\n  https://docs.microsoft.com/graph/api/chartfill-clear?view=graph-rest-1.0";
            var driveIdOption = new Option<string>("--drive-id", description: "The unique identifier of drive") {
            };
            driveIdOption.IsRequired = true;
            command.AddOption(driveIdOption);
            var driveItemIdOption = new Option<string>("--drive-item-id", description: "The unique identifier of driveItem") {
            };
            driveItemIdOption.IsRequired = true;
            command.AddOption(driveItemIdOption);
            var workbookWorksheetIdOption = new Option<string>("--workbook-worksheet-id", description: "The unique identifier of workbookWorksheet") {
            };
            workbookWorksheetIdOption.IsRequired = true;
            command.AddOption(workbookWorksheetIdOption);
            var workbookChartIdOption = new Option<string>("--workbook-chart-id", description: "The unique identifier of workbookChart") {
            };
            workbookChartIdOption.IsRequired = true;
            command.AddOption(workbookChartIdOption);
            var workbookChartSeriesIdOption = new Option<string>("--workbook-chart-series-id", description: "The unique identifier of workbookChartSeries") {
            };
            workbookChartSeriesIdOption.IsRequired = true;
            command.AddOption(workbookChartSeriesIdOption);
            var workbookChartPointIdOption = new Option<string>("--workbook-chart-point-id", description: "The unique identifier of workbookChartPoint") {
            };
            workbookChartPointIdOption.IsRequired = true;
            command.AddOption(workbookChartPointIdOption);
            command.SetHandler(async (invocationContext) => {
                var driveId = invocationContext.ParseResult.GetValueForOption(driveIdOption);
                var driveItemId = invocationContext.ParseResult.GetValueForOption(driveItemIdOption);
                var workbookWorksheetId = invocationContext.ParseResult.GetValueForOption(workbookWorksheetIdOption);
                var workbookChartId = invocationContext.ParseResult.GetValueForOption(workbookChartIdOption);
                var workbookChartSeriesId = invocationContext.ParseResult.GetValueForOption(workbookChartSeriesIdOption);
                var workbookChartPointId = invocationContext.ParseResult.GetValueForOption(workbookChartPointIdOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                });
                if (driveId is not null) requestInfo.PathParameters.Add("drive%2Did", driveId);
                if (driveItemId is not null) requestInfo.PathParameters.Add("driveItem%2Did", driveItemId);
                if (workbookWorksheetId is not null) requestInfo.PathParameters.Add("workbookWorksheet%2Did", workbookWorksheetId);
                if (workbookChartId is not null) requestInfo.PathParameters.Add("workbookChart%2Did", workbookChartId);
                if (workbookChartSeriesId is not null) requestInfo.PathParameters.Add("workbookChartSeries%2Did", workbookChartSeriesId);
                if (workbookChartPointId is not null) requestInfo.PathParameters.Add("workbookChartPoint%2Did", workbookChartPointId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                await reqAdapter.SendNoContentAsync(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new ClearRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public ClearRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/drives/{drive%2Did}/items/{driveItem%2Did}/workbook/worksheets/{workbookWorksheet%2Did}/charts/{workbookChart%2Did}/series/{workbookChartSeries%2Did}/points/{workbookChartPoint%2Did}/format/fill/clear", pathParameters) {
        }
        /// <summary>
        /// Clear the fill color of a chart element.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new RequestConfiguration<DefaultQueryParameters>();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
    }
}
