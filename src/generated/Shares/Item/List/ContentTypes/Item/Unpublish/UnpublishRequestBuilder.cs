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
namespace ApiSdk.Shares.Item.List.ContentTypes.Item.Unpublish {
    /// <summary>
    /// Provides operations to call the unpublish method.
    /// </summary>
    public class UnpublishRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Unpublish a [contentType][] from a content type hub site.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/contenttype-unpublish?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildPostCommand() {
            var command = new Command("post");
            command.Description = "Unpublish a [contentType][] from a content type hub site.\n\nFind more info here:\n  https://docs.microsoft.com/graph/api/contenttype-unpublish?view=graph-rest-1.0";
            // Create options for all the parameters
            var sharedDriveItemIdOption = new Option<string>("--shared-drive-item-id", description: "The unique identifier of sharedDriveItem") {
            };
            sharedDriveItemIdOption.IsRequired = true;
            command.AddOption(sharedDriveItemIdOption);
            var contentTypeIdOption = new Option<string>("--content-type-id", description: "The unique identifier of contentType") {
            };
            contentTypeIdOption.IsRequired = true;
            command.AddOption(contentTypeIdOption);
            command.SetHandler(async (invocationContext) => {
                var sharedDriveItemId = invocationContext.ParseResult.GetValueForOption(sharedDriveItemIdOption);
                var contentTypeId = invocationContext.ParseResult.GetValueForOption(contentTypeIdOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                });
                if (sharedDriveItemId is not null) requestInfo.PathParameters.Add("sharedDriveItem%2Did", sharedDriveItemId);
                if (contentTypeId is not null) requestInfo.PathParameters.Add("contentType%2Did", contentTypeId);
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
        /// Instantiates a new UnpublishRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public UnpublishRequestBuilder(Dictionary<string, object> pathParameters) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            UrlTemplate = "{+baseurl}/shares/{sharedDriveItem%2Did}/list/contentTypes/{contentType%2Did}/unpublish";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
        }
        /// <summary>
        /// Unpublish a [contentType][] from a content type hub site.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Action<UnpublishRequestBuilderPostRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Action<UnpublishRequestBuilderPostRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new UnpublishRequestBuilderPostRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class UnpublishRequestBuilderPostRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new unpublishRequestBuilderPostRequestConfiguration and sets the default values.
            /// </summary>
            public UnpublishRequestBuilderPostRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
