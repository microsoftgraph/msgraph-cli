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
namespace ApiSdk.Print.Printers.Item.Jobs.Item.Documents.Item.Value {
    /// <summary>
    /// Provides operations to manage the media for the print entity.
    /// </summary>
    public class ContentRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Get media content for the navigation property documents from print
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Get media content for the navigation property documents from print";
            var printerIdOption = new Option<string>("--printer-id", description: "The unique identifier of printer") {
            };
            printerIdOption.IsRequired = true;
            command.AddOption(printerIdOption);
            var printJobIdOption = new Option<string>("--print-job-id", description: "The unique identifier of printJob") {
            };
            printJobIdOption.IsRequired = true;
            command.AddOption(printJobIdOption);
            var printDocumentIdOption = new Option<string>("--print-document-id", description: "The unique identifier of printDocument") {
            };
            printDocumentIdOption.IsRequired = true;
            command.AddOption(printDocumentIdOption);
            var outputFileOption = new Option<FileInfo>("--output-file");
            command.AddOption(outputFileOption);
            command.SetHandler(async (invocationContext) => {
                var printerId = invocationContext.ParseResult.GetValueForOption(printerIdOption);
                var printJobId = invocationContext.ParseResult.GetValueForOption(printJobIdOption);
                var printDocumentId = invocationContext.ParseResult.GetValueForOption(printDocumentIdOption);
                var outputFile = invocationContext.ParseResult.GetValueForOption(outputFileOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                });
                if (printerId is not null) requestInfo.PathParameters.Add("printer%2Did", printerId);
                if (printJobId is not null) requestInfo.PathParameters.Add("printJob%2Did", printJobId);
                if (printDocumentId is not null) requestInfo.PathParameters.Add("printDocument%2Did", printDocumentId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                if (outputFile == null) {
                    using var reader = new StreamReader(response);
                    var strContent = reader.ReadToEnd();
                    Console.Write(strContent);
                }
                else {
                    using var writeStream = outputFile.OpenWrite();
                    await response.CopyToAsync(writeStream);
                    Console.WriteLine($"Content written to {outputFile.FullName}.");
                }
            });
            return command;
        }
        /// <summary>
        /// Update media content for the navigation property documents in print
        /// </summary>
        public Command BuildPutCommand() {
            var command = new Command("put");
            command.Description = "Update media content for the navigation property documents in print";
            var printerIdOption = new Option<string>("--printer-id", description: "The unique identifier of printer") {
            };
            printerIdOption.IsRequired = true;
            command.AddOption(printerIdOption);
            var printJobIdOption = new Option<string>("--print-job-id", description: "The unique identifier of printJob") {
            };
            printJobIdOption.IsRequired = true;
            command.AddOption(printJobIdOption);
            var printDocumentIdOption = new Option<string>("--print-document-id", description: "The unique identifier of printDocument") {
            };
            printDocumentIdOption.IsRequired = true;
            command.AddOption(printDocumentIdOption);
            var inputFileOption = new Option<FileInfo>("--input-file", description: "Binary request body") {
            };
            inputFileOption.IsRequired = true;
            command.AddOption(inputFileOption);
            var outputFileOption = new Option<FileInfo>("--output-file");
            command.AddOption(outputFileOption);
            command.SetHandler(async (invocationContext) => {
                var printerId = invocationContext.ParseResult.GetValueForOption(printerIdOption);
                var printJobId = invocationContext.ParseResult.GetValueForOption(printJobIdOption);
                var printDocumentId = invocationContext.ParseResult.GetValueForOption(printDocumentIdOption);
                var inputFile = invocationContext.ParseResult.GetValueForOption(inputFileOption);
                var outputFile = invocationContext.ParseResult.GetValueForOption(outputFileOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                if (inputFile is null || !inputFile.Exists) return;
                using var stream = inputFile.OpenRead();
                var requestInfo = ToPutRequestInformation(stream, q => {
                });
                if (printerId is not null) requestInfo.PathParameters.Add("printer%2Did", printerId);
                if (printJobId is not null) requestInfo.PathParameters.Add("printJob%2Did", printJobId);
                if (printDocumentId is not null) requestInfo.PathParameters.Add("printDocument%2Did", printDocumentId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                if (outputFile == null) {
                    using var reader = new StreamReader(response);
                    var strContent = reader.ReadToEnd();
                    Console.Write(strContent);
                }
                else {
                    using var writeStream = outputFile.OpenWrite();
                    await response.CopyToAsync(writeStream);
                    Console.WriteLine($"Content written to {outputFile.FullName}.");
                }
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new ContentRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public ContentRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/print/printers/{printer%2Did}/jobs/{printJob%2Did}/documents/{printDocument%2Did}/$value", pathParameters) {
        }
        /// <summary>
        /// Get media content for the navigation property documents from print
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
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
        /// <summary>
        /// Update media content for the navigation property documents in print
        /// </summary>
        /// <param name="body">Binary request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(Stream body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(Stream body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PUT,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetStreamContent(body);
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
