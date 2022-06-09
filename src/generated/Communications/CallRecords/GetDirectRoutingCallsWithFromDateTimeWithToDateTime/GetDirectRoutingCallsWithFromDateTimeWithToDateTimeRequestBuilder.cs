using ApiSdk.Models.ODataErrors;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Cli.Commons.IO;
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace ApiSdk.Communications.CallRecords.GetDirectRoutingCallsWithFromDateTimeWithToDateTime {
    /// <summary>Provides operations to call the getDirectRoutingCalls method.</summary>
    public class GetDirectRoutingCallsWithFromDateTimeWithToDateTimeRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Invoke function getDirectRoutingCalls
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Invoke function getDirectRoutingCalls";
            // Create options for all the parameters
            var fromDateTimeOption = new Option<string>("--from-date-time", description: "Usage: fromDateTime='{fromDateTime}'") {
            };
            fromDateTimeOption.IsRequired = true;
            command.AddOption(fromDateTimeOption);
            var toDateTimeOption = new Option<string>("--to-date-time", description: "Usage: toDateTime='{toDateTime}'") {
            };
            toDateTimeOption.IsRequired = true;
            command.AddOption(toDateTimeOption);
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
                var fromDateTime = invocationContext.ParseResult.GetValueForOption(fromDateTimeOption);
                var toDateTime = invocationContext.ParseResult.GetValueForOption(toDateTimeOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                var jsonNoIndent = invocationContext.ParseResult.GetValueForOption(jsonNoIndentOption);
                var outputFilter = invocationContext.BindingContext.GetRequiredService<IOutputFilter>();
                var outputFormatterFactory = invocationContext.BindingContext.GetRequiredService<IOutputFormatterFactory>();
                var cancellationToken = invocationContext.GetCancellationToken();
                var requestInfo = CreateGetRequestInformation(q => {
                });
                requestInfo.PathParameters.Add("fromDateTime", fromDateTime);
                requestInfo.PathParameters.Add("toDateTime", toDateTime);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                response = await outputFilter?.FilterOutputAsync(response, query, cancellationToken) ?? response;
                var formatterOptions = output.GetOutputFormatterOptions(new FormatterOptionsModel(!jsonNoIndent));
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, formatterOptions, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new GetDirectRoutingCallsWithFromDateTimeWithToDateTimeRequestBuilder and sets the default values.
        /// <param name="fromDateTime">Usage: fromDateTime=&apos;{fromDateTime}&apos;</param>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// <param name="toDateTime">Usage: toDateTime=&apos;{toDateTime}&apos;</param>
        /// </summary>
        public GetDirectRoutingCallsWithFromDateTimeWithToDateTimeRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, DateTimeOffset? fromDateTime = default, DateTimeOffset? toDateTime = default) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/communications/callRecords/microsoft.graph.callRecords.getDirectRoutingCalls(fromDateTime='{fromDateTime}',toDateTime='{toDateTime}')";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            urlTplParams.Add("fromDateTime", fromDateTime);
            urlTplParams.Add("toDateTime", toDateTime);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Invoke function getDirectRoutingCalls
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<GetDirectRoutingCallsWithFromDateTimeWithToDateTimeRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new GetDirectRoutingCallsWithFromDateTimeWithToDateTimeRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class GetDirectRoutingCallsWithFromDateTimeWithToDateTimeRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new getDirectRoutingCallsWithFromDateTimeWithToDateTimeRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public GetDirectRoutingCallsWithFromDateTimeWithToDateTimeRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
    }
}
