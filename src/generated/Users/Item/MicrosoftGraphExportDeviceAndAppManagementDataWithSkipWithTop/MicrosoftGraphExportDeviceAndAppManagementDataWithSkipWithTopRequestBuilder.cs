using ApiSdk.Models;
using ApiSdk.Models.ODataErrors;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Cli.Commons.Extensions;
using Microsoft.Kiota.Cli.Commons.IO;
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace ApiSdk.Users.Item.MicrosoftGraphExportDeviceAndAppManagementDataWithSkipWithTop {
    /// <summary>
    /// Provides operations to call the exportDeviceAndAppManagementData method.
    /// </summary>
    public class MicrosoftGraphExportDeviceAndAppManagementDataWithSkipWithTopRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Invoke function exportDeviceAndAppManagementData
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Invoke function exportDeviceAndAppManagementData";
            // Create options for all the parameters
            var userIdOption = new Option<string>("--user-id", description: "key: id of user") {
            };
            userIdOption.IsRequired = true;
            command.AddOption(userIdOption);
            var skipOption = new Option<int?>("--skip", description: "Usage: skip={skip}") {
            };
            skipOption.IsRequired = true;
            command.AddOption(skipOption);
            var topOption = new Option<int?>("--top", description: "Usage: top={top}") {
            };
            topOption.IsRequired = true;
            command.AddOption(topOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON){
                IsRequired = true
            };
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            var jsonNoIndentOption = new Option<bool>("--json-no-indent", r => {
                if (bool.TryParse(r.Tokens.Select(t => t.Value).LastOrDefault(), out var value)) {
                    return value;
                }
                return true;
            }, description: "Disable indentation for the JSON output formatter.");
            command.AddOption(jsonNoIndentOption);
            command.SetHandler(async (invocationContext) => {
                var userId = invocationContext.ParseResult.GetValueForOption(userIdOption);
                var skip = invocationContext.ParseResult.GetValueForOption(skipOption);
                var top = invocationContext.ParseResult.GetValueForOption(topOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                var jsonNoIndent = invocationContext.ParseResult.GetValueForOption(jsonNoIndentOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetRequiredService<IOutputFilter>();
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetRequiredService<IOutputFormatterFactory>();
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                });
                if (userId is not null) requestInfo.PathParameters.Add("user%2Did", userId);
                if (skip is not null) requestInfo.PathParameters.Add("skip", skip);
                if (top is not null) requestInfo.PathParameters.Add("top", top);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatterOptions = output.GetOutputFormatterOptions(new FormatterOptionsModel(!jsonNoIndent));
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, formatterOptions, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new MicrosoftGraphExportDeviceAndAppManagementDataWithSkipWithTopRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="skip">Usage: skip={skip}</param>
        /// <param name="top">Usage: top={top}</param>
        public MicrosoftGraphExportDeviceAndAppManagementDataWithSkipWithTopRequestBuilder(Dictionary<string, object> pathParameters, int? skip = default, int? top = default) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            UrlTemplate = "{+baseurl}/users/{user%2Did}/microsoft.graph.exportDeviceAndAppManagementData(skip={skip},top={top})";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            if (skip is not null) urlTplParams.Add("skip", skip);
            if (top is not null) urlTplParams.Add("top", top);
            PathParameters = urlTplParams;
        }
        /// <summary>
        /// Invoke function exportDeviceAndAppManagementData
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<MicrosoftGraphExportDeviceAndAppManagementDataWithSkipWithTopRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<MicrosoftGraphExportDeviceAndAppManagementDataWithSkipWithTopRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new MicrosoftGraphExportDeviceAndAppManagementDataWithSkipWithTopRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class MicrosoftGraphExportDeviceAndAppManagementDataWithSkipWithTopRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new microsoftGraphExportDeviceAndAppManagementDataWithSkipWithTopRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public MicrosoftGraphExportDeviceAndAppManagementDataWithSkipWithTopRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
