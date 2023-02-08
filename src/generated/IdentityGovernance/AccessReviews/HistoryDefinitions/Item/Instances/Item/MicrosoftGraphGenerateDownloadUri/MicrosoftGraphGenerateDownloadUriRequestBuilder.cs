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
namespace ApiSdk.IdentityGovernance.AccessReviews.HistoryDefinitions.Item.Instances.Item.MicrosoftGraphGenerateDownloadUri {
    /// <summary>
    /// Provides operations to call the generateDownloadUri method.
    /// </summary>
    public class MicrosoftGraphGenerateDownloadUriRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Generates a URI for an accessReviewHistoryInstance object the **status** for which is `done`. Each URI can be used to retrieve the instance&apos;s review history data. Each URI is valid for 24 hours and can be retrieved by fetching the **downloadUri** property from the accessReviewHistoryInstance object.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/accessreviewhistoryinstance-generatedownloaduri?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildPostCommand() {
            var command = new Command("post");
            command.Description = "Generates a URI for an accessReviewHistoryInstance object the **status** for which is `done`. Each URI can be used to retrieve the instance's review history data. Each URI is valid for 24 hours and can be retrieved by fetching the **downloadUri** property from the accessReviewHistoryInstance object.\n\nFind more info here:\n  https://docs.microsoft.com/graph/api/accessreviewhistoryinstance-generatedownloaduri?view=graph-rest-1.0";
            // Create options for all the parameters
            var accessReviewHistoryDefinitionIdOption = new Option<string>("--access-review-history-definition-id", description: "key: id of accessReviewHistoryDefinition") {
            };
            accessReviewHistoryDefinitionIdOption.IsRequired = true;
            command.AddOption(accessReviewHistoryDefinitionIdOption);
            var accessReviewHistoryInstanceIdOption = new Option<string>("--access-review-history-instance-id", description: "key: id of accessReviewHistoryInstance") {
            };
            accessReviewHistoryInstanceIdOption.IsRequired = true;
            command.AddOption(accessReviewHistoryInstanceIdOption);
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
                var accessReviewHistoryDefinitionId = invocationContext.ParseResult.GetValueForOption(accessReviewHistoryDefinitionIdOption);
                var accessReviewHistoryInstanceId = invocationContext.ParseResult.GetValueForOption(accessReviewHistoryInstanceIdOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                var jsonNoIndent = invocationContext.ParseResult.GetValueForOption(jsonNoIndentOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetRequiredService<IOutputFilter>();
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetRequiredService<IOutputFormatterFactory>();
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                });
                if (accessReviewHistoryDefinitionId is not null) requestInfo.PathParameters.Add("accessReviewHistoryDefinition%2Did", accessReviewHistoryDefinitionId);
                if (accessReviewHistoryInstanceId is not null) requestInfo.PathParameters.Add("accessReviewHistoryInstance%2Did", accessReviewHistoryInstanceId);
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
        /// Instantiates a new MicrosoftGraphGenerateDownloadUriRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public MicrosoftGraphGenerateDownloadUriRequestBuilder(Dictionary<string, object> pathParameters) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            UrlTemplate = "{+baseurl}/identityGovernance/accessReviews/historyDefinitions/{accessReviewHistoryDefinition%2Did}/instances/{accessReviewHistoryInstance%2Did}/microsoft.graph.generateDownloadUri";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
        }
        /// <summary>
        /// Generates a URI for an accessReviewHistoryInstance object the **status** for which is `done`. Each URI can be used to retrieve the instance&apos;s review history data. Each URI is valid for 24 hours and can be retrieved by fetching the **downloadUri** property from the accessReviewHistoryInstance object.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Action<MicrosoftGraphGenerateDownloadUriRequestBuilderPostRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Action<MicrosoftGraphGenerateDownloadUriRequestBuilderPostRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new MicrosoftGraphGenerateDownloadUriRequestBuilderPostRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class MicrosoftGraphGenerateDownloadUriRequestBuilderPostRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new microsoftGraphGenerateDownloadUriRequestBuilderPostRequestConfiguration and sets the default values.
            /// </summary>
            public MicrosoftGraphGenerateDownloadUriRequestBuilderPostRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
