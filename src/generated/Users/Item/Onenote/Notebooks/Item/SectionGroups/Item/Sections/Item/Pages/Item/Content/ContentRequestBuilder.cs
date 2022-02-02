using Microsoft.Graph.Cli.Core.Binding;
using Microsoft.Graph.Cli.Core.IO;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace ApiSdk.Users.Item.Onenote.Notebooks.Item.SectionGroups.Item.Sections.Item.Pages.Item.Content {
    /// <summary>Builds and executes requests for operations under \users\{user-id}\onenote\notebooks\{notebook-id}\sectionGroups\{sectionGroup-id}\sections\{onenoteSection-id}\pages\{onenotePage-id}\content</summary>
    public class ContentRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Get media content for the navigation property pages from users
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Get media content for the navigation property pages from users";
            // Create options for all the parameters
            var userIdOption = new Option<string>("--user-id", description: "key: id of user") {
            };
            userIdOption.IsRequired = true;
            command.AddOption(userIdOption);
            var notebookIdOption = new Option<string>("--notebook-id", description: "key: id of notebook") {
            };
            notebookIdOption.IsRequired = true;
            command.AddOption(notebookIdOption);
            var sectionGroupIdOption = new Option<string>("--sectiongroup-id", description: "key: id of sectionGroup") {
            };
            sectionGroupIdOption.IsRequired = true;
            command.AddOption(sectionGroupIdOption);
            var onenoteSectionIdOption = new Option<string>("--onenotesection-id", description: "key: id of onenoteSection") {
            };
            onenoteSectionIdOption.IsRequired = true;
            command.AddOption(onenoteSectionIdOption);
            var onenotePageIdOption = new Option<string>("--onenotepage-id", description: "key: id of onenotePage") {
            };
            onenotePageIdOption.IsRequired = true;
            command.AddOption(onenotePageIdOption);
            var fileOption = new Option<FileInfo>("--file");
            command.AddOption(fileOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON){
                IsRequired = true
            };
            command.AddOption(outputOption);
            command.SetHandler(async (string userId, string notebookId, string sectionGroupId, string onenoteSectionId, string onenotePageId, FileInfo file, FormatterType output, IServiceProvider serviceProvider, IConsole console) => {
                var responseHandler = serviceProvider.GetService(typeof(IResponseHandler)) as IResponseHandler;
                var requestInfo = CreateGetRequestInformation(q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler);
                // Print request output. What if the request has no return?
                var responseProcessor = serviceProvider.GetService(typeof(IResponseProcessor)) as IResponseProcessor;
                var factory = serviceProvider.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory;
                var formatter = factory.GetFormatter(output);
                if (responseProcessor.IsResponseSuccessful(responseHandler)) {
                    var content = await responseProcessor.ExtractStreamResponseAsync(responseHandler);
                    if (file == null) {
                        formatter.WriteOutput(content, console);
                    }
                    else {
                        using var writeStream = file.OpenWrite();
                        await content.CopyToAsync(writeStream);
                        console.WriteLine($"Content written to {file.FullName}.");
                    }
                }
                else {
                    var content = await responseProcessor.ExtractStringResponseAsync(responseHandler);
                    console.WriteLine(content);
                }
            }, userIdOption, notebookIdOption, sectionGroupIdOption, onenoteSectionIdOption, onenotePageIdOption, fileOption, outputOption, new ServiceProviderBinder());
            return command;
        }
        /// <summary>
        /// Update media content for the navigation property pages in users
        /// </summary>
        public Command BuildPutCommand() {
            var command = new Command("put");
            command.Description = "Update media content for the navigation property pages in users";
            // Create options for all the parameters
            var userIdOption = new Option<string>("--user-id", description: "key: id of user") {
            };
            userIdOption.IsRequired = true;
            command.AddOption(userIdOption);
            var notebookIdOption = new Option<string>("--notebook-id", description: "key: id of notebook") {
            };
            notebookIdOption.IsRequired = true;
            command.AddOption(notebookIdOption);
            var sectionGroupIdOption = new Option<string>("--sectiongroup-id", description: "key: id of sectionGroup") {
            };
            sectionGroupIdOption.IsRequired = true;
            command.AddOption(sectionGroupIdOption);
            var onenoteSectionIdOption = new Option<string>("--onenotesection-id", description: "key: id of onenoteSection") {
            };
            onenoteSectionIdOption.IsRequired = true;
            command.AddOption(onenoteSectionIdOption);
            var onenotePageIdOption = new Option<string>("--onenotepage-id", description: "key: id of onenotePage") {
            };
            onenotePageIdOption.IsRequired = true;
            command.AddOption(onenotePageIdOption);
            var bodyOption = new Option<Stream>("--file", description: "Binary request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (string userId, string notebookId, string sectionGroupId, string onenoteSectionId, string onenotePageId, FileInfo file, IServiceProvider serviceProvider, IConsole console) => {
                var responseHandler = serviceProvider.GetService(typeof(IResponseHandler)) as IResponseHandler;
                using var stream = file.OpenRead();
                var requestInfo = CreatePutRequestInformation(stream, q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler);
                // Print request output. What if the request has no return?
                console.WriteLine("Success");
            }, userIdOption, notebookIdOption, sectionGroupIdOption, onenoteSectionIdOption, onenotePageIdOption, bodyOption, new ServiceProviderBinder());
            return command;
        }
        /// <summary>
        /// Instantiates a new ContentRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public ContentRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/users/{user_id}/onenote/notebooks/{notebook_id}/sectionGroups/{sectionGroup_id}/sections/{onenoteSection_id}/pages/{onenotePage_id}/content";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new ContentRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public ContentRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/users/{user_id}/onenote/notebooks/{notebook_id}/sectionGroups/{sectionGroup_id}/sections/{onenoteSection_id}/pages/{onenotePage_id}/content";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Get media content for the navigation property pages from users
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Update media content for the navigation property pages in users
        /// <param name="body">Binary request body</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePutRequestInformation(Stream body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PUT,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetStreamContent(body);
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Get media content for the navigation property pages from users
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<Stream> GetAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(h, o);
            return await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>
        /// Update media content for the navigation property pages in users
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// <param name="stream">Binary request body</param>
        /// </summary>
        public async Task PutAsync(Stream stream, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = stream ?? throw new ArgumentNullException(nameof(stream));
            var requestInfo = CreatePutRequestInformation(stream, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, cancellationToken);
        }
    }
}
