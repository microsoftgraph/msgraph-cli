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
namespace ApiSdk.Shares.Item.List.Items.Item.DocumentSetVersions.Item.Restore {
    /// <summary>
    /// Provides operations to call the restore method.
    /// </summary>
    public class RestoreRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Restore a document set version.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/documentsetversion-restore?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildPostCommand() {
            var command = new Command("post");
            command.Description = "Restore a document set version.";
            // Create options for all the parameters
            var sharedDriveItemIdOption = new Option<string>("--shared-drive-item-id", description: "key: id of sharedDriveItem") {
            };
            sharedDriveItemIdOption.IsRequired = true;
            command.AddOption(sharedDriveItemIdOption);
            var listItemIdOption = new Option<string>("--list-item-id", description: "key: id of listItem") {
            };
            listItemIdOption.IsRequired = true;
            command.AddOption(listItemIdOption);
            var documentSetVersionIdOption = new Option<string>("--document-set-version-id", description: "key: id of documentSetVersion") {
            };
            documentSetVersionIdOption.IsRequired = true;
            command.AddOption(documentSetVersionIdOption);
            command.SetHandler(async (invocationContext) => {
                var sharedDriveItemId = invocationContext.ParseResult.GetValueForOption(sharedDriveItemIdOption);
                var listItemId = invocationContext.ParseResult.GetValueForOption(listItemIdOption);
                var documentSetVersionId = invocationContext.ParseResult.GetValueForOption(documentSetVersionIdOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var requestInfo = ToPostRequestInformation(q => {
                });
                requestInfo.PathParameters.Add("sharedDriveItem%2Did", sharedDriveItemId);
                requestInfo.PathParameters.Add("listItem%2Did", listItemId);
                requestInfo.PathParameters.Add("documentSetVersion%2Did", documentSetVersionId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new RestoreRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RestoreRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/shares/{sharedDriveItem%2Did}/list/items/{listItem%2Did}/documentSetVersions/{documentSetVersion%2Did}/microsoft.graph.restore";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Restore a document set version.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Action<RestoreRequestBuilderPostRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Action<RestoreRequestBuilderPostRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new RestoreRequestBuilderPostRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class RestoreRequestBuilderPostRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new restoreRequestBuilderPostRequestConfiguration and sets the default values.
            /// </summary>
            public RestoreRequestBuilderPostRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
