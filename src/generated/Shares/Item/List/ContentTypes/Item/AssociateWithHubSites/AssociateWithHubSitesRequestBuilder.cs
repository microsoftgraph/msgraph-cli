// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.Models.ODataErrors;
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
namespace ApiSdk.Shares.Item.List.ContentTypes.Item.AssociateWithHubSites
{
    /// <summary>
    /// Provides operations to call the associateWithHubSites method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class AssociateWithHubSitesRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Associate a published content type present in a content type hub with a list of hub sites.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/contenttype-associatewithhubsites?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Associate a published content type present in a content type hub with a list of hub sites.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/contenttype-associatewithhubsites?view=graph-rest-1.0";
            var sharedDriveItemIdOption = new Option<string>("--shared-drive-item-id", description: "The unique identifier of sharedDriveItem") {
            };
            sharedDriveItemIdOption.IsRequired = true;
            command.AddOption(sharedDriveItemIdOption);
            var contentTypeIdOption = new Option<string>("--content-type-id", description: "The unique identifier of contentType") {
            };
            contentTypeIdOption.IsRequired = true;
            command.AddOption(contentTypeIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (invocationContext) => {
                var sharedDriveItemId = invocationContext.ParseResult.GetValueForOption(sharedDriveItemIdOption);
                var contentTypeId = invocationContext.ParseResult.GetValueForOption(contentTypeIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = await ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNodeAsync("application/json", stream, cancellationToken);
                var model = parseNode.GetObjectValue<global::ApiSdk.Shares.Item.List.ContentTypes.Item.AssociateWithHubSites.AssociateWithHubSitesPostRequestBody>(global::ApiSdk.Shares.Item.List.ContentTypes.Item.AssociateWithHubSites.AssociateWithHubSitesPostRequestBody.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPostRequestInformation(model, q => {
                });
                if (sharedDriveItemId is not null) requestInfo.PathParameters.Add("sharedDriveItem%2Did", sharedDriveItemId);
                if (contentTypeId is not null) requestInfo.PathParameters.Add("contentType%2Did", contentTypeId);
                requestInfo.SetContentFromParsable(reqAdapter, "application/json", model);
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
        /// Instantiates a new <see cref="global::ApiSdk.Shares.Item.List.ContentTypes.Item.AssociateWithHubSites.AssociateWithHubSitesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public AssociateWithHubSitesRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/shares/{sharedDriveItem%2Did}/list/contentTypes/{contentType%2Did}/associateWithHubSites", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Shares.Item.List.ContentTypes.Item.AssociateWithHubSites.AssociateWithHubSitesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public AssociateWithHubSitesRequestBuilder(string rawUrl) : base("{+baseurl}/shares/{sharedDriveItem%2Did}/list/contentTypes/{contentType%2Did}/associateWithHubSites", rawUrl)
        {
        }
        /// <summary>
        /// Associate a published content type present in a content type hub with a list of hub sites.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::ApiSdk.Shares.Item.List.ContentTypes.Item.AssociateWithHubSites.AssociateWithHubSitesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::ApiSdk.Shares.Item.List.ContentTypes.Item.AssociateWithHubSites.AssociateWithHubSitesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
    }
}
#pragma warning restore CS0618
