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
namespace ApiSdk.Sites.Item.Onenote.Notebooks.Item.Sections.Item.CopyToSectionGroup
{
    /// <summary>
    /// Provides operations to call the copyToSectionGroup method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class CopyToSectionGroupRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// For Copy operations, you follow an asynchronous calling pattern:  First call the Copy action, and then poll the operation endpoint for the result.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/section-copytosectiongroup?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "For Copy operations, you follow an asynchronous calling pattern:  First call the Copy action, and then poll the operation endpoint for the result.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/section-copytosectiongroup?view=graph-rest-1.0";
            var siteIdOption = new Option<string>("--site-id", description: "The unique identifier of site") {
            };
            siteIdOption.IsRequired = true;
            command.AddOption(siteIdOption);
            var notebookIdOption = new Option<string>("--notebook-id", description: "The unique identifier of notebook") {
            };
            notebookIdOption.IsRequired = true;
            command.AddOption(notebookIdOption);
            var onenoteSectionIdOption = new Option<string>("--onenote-section-id", description: "The unique identifier of onenoteSection") {
            };
            onenoteSectionIdOption.IsRequired = true;
            command.AddOption(onenoteSectionIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var siteId = invocationContext.ParseResult.GetValueForOption(siteIdOption);
                var notebookId = invocationContext.ParseResult.GetValueForOption(notebookIdOption);
                var onenoteSectionId = invocationContext.ParseResult.GetValueForOption(onenoteSectionIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = await ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNodeAsync("application/json", stream, cancellationToken);
                var model = parseNode.GetObjectValue<global::ApiSdk.Sites.Item.Onenote.Notebooks.Item.Sections.Item.CopyToSectionGroup.CopyToSectionGroupPostRequestBody>(global::ApiSdk.Sites.Item.Onenote.Notebooks.Item.Sections.Item.CopyToSectionGroup.CopyToSectionGroupPostRequestBody.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPostRequestInformation(model, q => {
                });
                if (siteId is not null) requestInfo.PathParameters.Add("site%2Did", siteId);
                if (notebookId is not null) requestInfo.PathParameters.Add("notebook%2Did", notebookId);
                if (onenoteSectionId is not null) requestInfo.PathParameters.Add("onenoteSection%2Did", onenoteSectionId);
                requestInfo.SetContentFromParsable(reqAdapter, "application/json", model);
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
        /// Instantiates a new <see cref="global::ApiSdk.Sites.Item.Onenote.Notebooks.Item.Sections.Item.CopyToSectionGroup.CopyToSectionGroupRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public CopyToSectionGroupRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/sites/{site%2Did}/onenote/notebooks/{notebook%2Did}/sections/{onenoteSection%2Did}/copyToSectionGroup", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Sites.Item.Onenote.Notebooks.Item.Sections.Item.CopyToSectionGroup.CopyToSectionGroupRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public CopyToSectionGroupRequestBuilder(string rawUrl) : base("{+baseurl}/sites/{site%2Did}/onenote/notebooks/{notebook%2Did}/sections/{onenoteSection%2Did}/copyToSectionGroup", rawUrl)
        {
        }
        /// <summary>
        /// For Copy operations, you follow an asynchronous calling pattern:  First call the Copy action, and then poll the operation endpoint for the result.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::ApiSdk.Sites.Item.Onenote.Notebooks.Item.Sections.Item.CopyToSectionGroup.CopyToSectionGroupPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::ApiSdk.Sites.Item.Onenote.Notebooks.Item.Sections.Item.CopyToSectionGroup.CopyToSectionGroupPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
