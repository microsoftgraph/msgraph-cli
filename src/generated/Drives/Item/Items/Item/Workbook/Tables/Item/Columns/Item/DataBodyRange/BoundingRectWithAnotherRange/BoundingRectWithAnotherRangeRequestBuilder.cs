// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.Models.ODataErrors;
using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Extensions;
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
namespace ApiSdk.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.DataBodyRange.BoundingRectWithAnotherRange
{
    /// <summary>
    /// Provides operations to call the boundingRect method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class BoundingRectWithAnotherRangeRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Invoke function boundingRect
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Invoke function boundingRect";
            var driveIdOption = new Option<string>("--drive-id", description: "The unique identifier of drive") {
            };
            driveIdOption.IsRequired = true;
            command.AddOption(driveIdOption);
            var driveItemIdOption = new Option<string>("--drive-item-id", description: "The unique identifier of driveItem") {
            };
            driveItemIdOption.IsRequired = true;
            command.AddOption(driveItemIdOption);
            var workbookTableIdOption = new Option<string>("--workbook-table-id", description: "The unique identifier of workbookTable") {
            };
            workbookTableIdOption.IsRequired = true;
            command.AddOption(workbookTableIdOption);
            var workbookTableColumnIdOption = new Option<string>("--workbook-table-column-id", description: "The unique identifier of workbookTableColumn") {
            };
            workbookTableColumnIdOption.IsRequired = true;
            command.AddOption(workbookTableColumnIdOption);
            var anotherRangeOption = new Option<string>("--another-range", description: "Usage: anotherRange='{anotherRange}'") {
            };
            anotherRangeOption.IsRequired = true;
            command.AddOption(anotherRangeOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var driveId = invocationContext.ParseResult.GetValueForOption(driveIdOption);
                var driveItemId = invocationContext.ParseResult.GetValueForOption(driveItemIdOption);
                var workbookTableId = invocationContext.ParseResult.GetValueForOption(workbookTableIdOption);
                var workbookTableColumnId = invocationContext.ParseResult.GetValueForOption(workbookTableColumnIdOption);
                var anotherRange = invocationContext.ParseResult.GetValueForOption(anotherRangeOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                });
                if (driveId is not null) requestInfo.PathParameters.Add("drive%2Did", driveId);
                if (driveItemId is not null) requestInfo.PathParameters.Add("driveItem%2Did", driveItemId);
                if (workbookTableId is not null) requestInfo.PathParameters.Add("workbookTable%2Did", workbookTableId);
                if (workbookTableColumnId is not null) requestInfo.PathParameters.Add("workbookTableColumn%2Did", workbookTableColumnId);
                if (anotherRange is not null) requestInfo.PathParameters.Add("anotherRange", anotherRange);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.DataBodyRange.BoundingRectWithAnotherRange.BoundingRectWithAnotherRangeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public BoundingRectWithAnotherRangeRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/drives/{drive%2Did}/items/{driveItem%2Did}/workbook/tables/{workbookTable%2Did}/columns/{workbookTableColumn%2Did}/dataBodyRange()/boundingRect(anotherRange='{anotherRange}')", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.DataBodyRange.BoundingRectWithAnotherRange.BoundingRectWithAnotherRangeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public BoundingRectWithAnotherRangeRequestBuilder(string rawUrl) : base("{+baseurl}/drives/{drive%2Did}/items/{driveItem%2Did}/workbook/tables/{workbookTable%2Did}/columns/{workbookTableColumn%2Did}/dataBodyRange()/boundingRect(anotherRange='{anotherRange}')", rawUrl)
        {
        }
        /// <summary>
        /// Invoke function boundingRect
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
    }
}
#pragma warning restore CS0618
