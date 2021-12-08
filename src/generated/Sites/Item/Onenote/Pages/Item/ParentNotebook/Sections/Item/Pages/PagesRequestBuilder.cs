using ApiSdk.Models.Microsoft.Graph;
using ApiSdk.Sites.Item.Onenote.Pages.Item.ParentNotebook.Sections.Item.Pages.Item;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace ApiSdk.Sites.Item.Onenote.Pages.Item.ParentNotebook.Sections.Item.Pages {
    /// <summary>Builds and executes requests for operations under \sites\{site-id}\onenote\pages\{onenotePage-id}\parentNotebook\sections\{onenoteSection-id}\pages</summary>
    public class PagesRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public List<Command> BuildCommand() {
            var builder = new OnenotePageRequestBuilder(PathParameters, RequestAdapter);
            var commands = new List<Command> { 
                builder.BuildContentCommand(),
                builder.BuildCopyToSectionCommand(),
                builder.BuildDeleteCommand(),
                builder.BuildGetCommand(),
                builder.BuildOnenotePatchContentCommand(),
                builder.BuildPatchCommand(),
            };
            return commands;
        }
        /// <summary>
        /// The collection of pages in the section.  Read-only. Nullable.
        /// </summary>
        public Command BuildCreateCommand() {
            var command = new Command("create");
            command.Description = "The collection of pages in the section.  Read-only. Nullable.";
            // Create options for all the parameters
            command.AddOption(new Option<string>("--site-id", description: "key: id of site"));
            command.AddOption(new Option<string>("--onenotepage-id", description: "key: id of onenotePage"));
            command.AddOption(new Option<string>("--onenotesection-id", description: "key: id of onenoteSection"));
            command.AddOption(new Option<string>("--body"));
            command.Handler = CommandHandler.Create<string, string, string, string>(async (siteId, onenotePageId, onenoteSectionId, body) => {
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<OnenotePage>();
                var requestInfo = CreatePostRequestInformation(model);
                if (!String.IsNullOrEmpty(siteId)) requestInfo.PathParameters.Add("site_id", siteId);
                if (!String.IsNullOrEmpty(onenotePageId)) requestInfo.PathParameters.Add("onenotePage_id", onenotePageId);
                if (!String.IsNullOrEmpty(onenoteSectionId)) requestInfo.PathParameters.Add("onenoteSection_id", onenoteSectionId);
                var result = await RequestAdapter.SendAsync<OnenotePage>(requestInfo);
                // Print request output. What if the request has no return?
                using var serializer = RequestAdapter.SerializationWriterFactory.GetSerializationWriter("application/json");
                serializer.WriteObjectValue(null, result);
                using var content = serializer.GetSerializedContent();
                using var reader = new StreamReader(content);
                var strContent = await reader.ReadToEndAsync();
                Console.Write(strContent + "\n");
            });
            return command;
        }
        /// <summary>
        /// The collection of pages in the section.  Read-only. Nullable.
        /// </summary>
        public Command BuildListCommand() {
            var command = new Command("list");
            command.Description = "The collection of pages in the section.  Read-only. Nullable.";
            // Create options for all the parameters
            command.AddOption(new Option<string>("--site-id", description: "key: id of site"));
            command.AddOption(new Option<string>("--onenotepage-id", description: "key: id of onenotePage"));
            command.AddOption(new Option<string>("--onenotesection-id", description: "key: id of onenoteSection"));
            command.AddOption(new Option<int?>("--top", description: "Show only the first n items"));
            command.AddOption(new Option<int?>("--skip", description: "Skip the first n items"));
            command.AddOption(new Option<string>("--search", description: "Search items by search phrases"));
            command.AddOption(new Option<string>("--filter", description: "Filter items by property values"));
            command.AddOption(new Option<bool?>("--count", description: "Include count of items"));
            command.AddOption(new Option<object>("--orderby", description: "Order items by property values"));
            command.AddOption(new Option<object>("--select", description: "Select properties to be returned"));
            command.AddOption(new Option<object>("--expand", description: "Expand related entities"));
            command.Handler = CommandHandler.Create<string, string, string, int?, int?, string, string, bool?, object, object, object>(async (siteId, onenotePageId, onenoteSectionId, top, skip, search, filter, count, orderby, select, expand) => {
                var requestInfo = CreateGetRequestInformation();
                if (!String.IsNullOrEmpty(siteId)) requestInfo.PathParameters.Add("site_id", siteId);
                if (!String.IsNullOrEmpty(onenotePageId)) requestInfo.PathParameters.Add("onenotePage_id", onenotePageId);
                if (!String.IsNullOrEmpty(onenoteSectionId)) requestInfo.PathParameters.Add("onenoteSection_id", onenoteSectionId);
                requestInfo.QueryParameters.Add("top", top);
                requestInfo.QueryParameters.Add("skip", skip);
                if (!String.IsNullOrEmpty(search)) requestInfo.QueryParameters.Add("search", search);
                if (!String.IsNullOrEmpty(filter)) requestInfo.QueryParameters.Add("filter", filter);
                requestInfo.QueryParameters.Add("count", count);
                requestInfo.QueryParameters.Add("orderby", orderby);
                requestInfo.QueryParameters.Add("select", select);
                requestInfo.QueryParameters.Add("expand", expand);
                var result = await RequestAdapter.SendAsync<PagesResponse>(requestInfo);
                // Print request output. What if the request has no return?
                using var serializer = RequestAdapter.SerializationWriterFactory.GetSerializationWriter("application/json");
                serializer.WriteObjectValue(null, result);
                using var content = serializer.GetSerializedContent();
                using var reader = new StreamReader(content);
                var strContent = await reader.ReadToEndAsync();
                Console.Write(strContent + "\n");
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new PagesRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public PagesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/sites/{site_id}/onenote/pages/{onenotePage_id}/parentNotebook/sections/{onenoteSection_id}/pages{?top,skip,search,filter,count,orderby,select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// The collection of pages in the section.  Read-only. Nullable.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (q != null) {
                var qParams = new GetQueryParameters();
                q.Invoke(qParams);
                qParams.AddQueryParameters(requestInfo.QueryParameters);
            }
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// The collection of pages in the section.  Read-only. Nullable.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePostRequestInformation(OnenotePage body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// The collection of pages in the section.  Read-only. Nullable.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<PagesResponse> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<PagesResponse>(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>
        /// The collection of pages in the section.  Read-only. Nullable.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="model"></param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<OnenotePage> PostAsync(OnenotePage model, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = model ?? throw new ArgumentNullException(nameof(model));
            var requestInfo = CreatePostRequestInformation(model, h, o);
            return await RequestAdapter.SendAsync<OnenotePage>(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>The collection of pages in the section.  Read-only. Nullable.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Include count of items</summary>
            public bool? Count { get; set; }
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Filter items by property values</summary>
            public string Filter { get; set; }
            /// <summary>Order items by property values</summary>
            public string[] Orderby { get; set; }
            /// <summary>Search items by search phrases</summary>
            public string Search { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
            /// <summary>Skip the first n items</summary>
            public int? Skip { get; set; }
            /// <summary>Show only the first n items</summary>
            public int? Top { get; set; }
        }
    }
}
