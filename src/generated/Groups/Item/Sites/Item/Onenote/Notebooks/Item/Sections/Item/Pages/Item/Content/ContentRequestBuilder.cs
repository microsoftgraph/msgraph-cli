using ApiSdk.Models.ODataErrors;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Cli.Commons;
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
namespace ApiSdk.Groups.Item.Sites.Item.Onenote.Notebooks.Item.Sections.Item.Pages.Item.Content {
    /// <summary>
    /// Provides operations to manage the media for the group entity.
    /// </summary>
    public class ContentRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// The page&apos;s HTML content.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "The page's HTML content.";
            var groupIdOption = new Option<string>("--group-id", description: "The unique identifier of group") {
            };
            groupIdOption.IsRequired = true;
            command.AddOption(groupIdOption);
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
            var onenotePageIdOption = new Option<string>("--onenote-page-id", description: "The unique identifier of onenotePage") {
            };
            onenotePageIdOption.IsRequired = true;
            command.AddOption(onenotePageIdOption);
            var fileOption = new Option<FileInfo>("--file");
            command.AddOption(fileOption);
            command.SetHandler(async (invocationContext) => {
                var groupId = invocationContext.ParseResult.GetValueForOption(groupIdOption);
                var siteId = invocationContext.ParseResult.GetValueForOption(siteIdOption);
                var notebookId = invocationContext.ParseResult.GetValueForOption(notebookIdOption);
                var onenoteSectionId = invocationContext.ParseResult.GetValueForOption(onenoteSectionIdOption);
                var onenotePageId = invocationContext.ParseResult.GetValueForOption(onenotePageIdOption);
                var file = invocationContext.ParseResult.GetValueForOption(fileOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                });
                if (groupId is not null) requestInfo.PathParameters.Add("group%2Did", groupId);
                if (siteId is not null) requestInfo.PathParameters.Add("site%2Did", siteId);
                if (notebookId is not null) requestInfo.PathParameters.Add("notebook%2Did", notebookId);
                if (onenoteSectionId is not null) requestInfo.PathParameters.Add("onenoteSection%2Did", onenoteSectionId);
                if (onenotePageId is not null) requestInfo.PathParameters.Add("onenotePage%2Did", onenotePageId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                if (file == null) {
                    using var reader = new StreamReader(response);
                    var strContent = reader.ReadToEnd();
                    Console.Write(strContent);
                }
                else {
                    using var writeStream = file.OpenWrite();
                    await response.CopyToAsync(writeStream);
                    Console.WriteLine($"Content written to {file.FullName}.");
                }
            });
            return command;
        }
        /// <summary>
        /// The page&apos;s HTML content.
        /// </summary>
        public Command BuildPutCommand() {
            var command = new Command("put");
            command.Description = "The page's HTML content.";
            var groupIdOption = new Option<string>("--group-id", description: "The unique identifier of group") {
            };
            groupIdOption.IsRequired = true;
            command.AddOption(groupIdOption);
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
            var onenotePageIdOption = new Option<string>("--onenote-page-id", description: "The unique identifier of onenotePage") {
            };
            onenotePageIdOption.IsRequired = true;
            command.AddOption(onenotePageIdOption);
            var fileOption = new Option<FileInfo>("--file", description: "Binary request body") {
            };
            fileOption.IsRequired = true;
            command.AddOption(fileOption);
            command.SetHandler(async (invocationContext) => {
                var groupId = invocationContext.ParseResult.GetValueForOption(groupIdOption);
                var siteId = invocationContext.ParseResult.GetValueForOption(siteIdOption);
                var notebookId = invocationContext.ParseResult.GetValueForOption(notebookIdOption);
                var onenoteSectionId = invocationContext.ParseResult.GetValueForOption(onenoteSectionIdOption);
                var onenotePageId = invocationContext.ParseResult.GetValueForOption(onenotePageIdOption);
                var file = invocationContext.ParseResult.GetValueForOption(fileOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                if (file is null || !file.Exists) return;
                using var stream = file.OpenRead();
                var requestInfo = ToPutRequestInformation(stream, q => {
                });
                if (groupId is not null) requestInfo.PathParameters.Add("group%2Did", groupId);
                if (siteId is not null) requestInfo.PathParameters.Add("site%2Did", siteId);
                if (notebookId is not null) requestInfo.PathParameters.Add("notebook%2Did", notebookId);
                if (onenoteSectionId is not null) requestInfo.PathParameters.Add("onenoteSection%2Did", onenoteSectionId);
                if (onenotePageId is not null) requestInfo.PathParameters.Add("onenotePage%2Did", onenotePageId);
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
        /// Instantiates a new ContentRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public ContentRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/groups/{group%2Did}/sites/{site%2Did}/onenote/notebooks/{notebook%2Did}/sections/{onenoteSection%2Did}/pages/{onenotePage%2Did}/content", pathParameters) {
        }
        /// <summary>
        /// The page&apos;s HTML content.
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
        /// The page&apos;s HTML content.
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
