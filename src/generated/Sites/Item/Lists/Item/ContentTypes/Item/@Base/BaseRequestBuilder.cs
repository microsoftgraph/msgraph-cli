using ApiSdk.Models.Microsoft.Graph;
using ApiSdk.Sites.Item.Lists.Item.ContentTypes.Item.Base.AssociateWithHubSites;
using ApiSdk.Sites.Item.Lists.Item.ContentTypes.Item.Base.CopyToDefaultContentLocation;
using ApiSdk.Sites.Item.Lists.Item.ContentTypes.Item.Base.IsPublished;
using ApiSdk.Sites.Item.Lists.Item.ContentTypes.Item.Base.Publish;
using ApiSdk.Sites.Item.Lists.Item.ContentTypes.Item.Base.Ref;
using ApiSdk.Sites.Item.Lists.Item.ContentTypes.Item.Base.Unpublish;
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
namespace ApiSdk.Sites.Item.Lists.Item.ContentTypes.Item.@Base {
    /// <summary>Builds and executes requests for operations under \sites\{site-id}\lists\{list-id}\contentTypes\{contentType-id}\base</summary>
    public class BaseRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public Command BuildAssociateWithHubSitesCommand() {
            var command = new Command("associate-with-hub-sites");
            var builder = new ApiSdk.Sites.Item.Lists.Item.ContentTypes.Item.@Base.AssociateWithHubSites.AssociateWithHubSitesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildCopyToDefaultContentLocationCommand() {
            var command = new Command("copy-to-default-content-location");
            var builder = new ApiSdk.Sites.Item.Lists.Item.ContentTypes.Item.@Base.CopyToDefaultContentLocation.CopyToDefaultContentLocationRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Parent contentType from which this content type is derived.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            // Create options for all the parameters
            command.AddOption(new Option<string>("--site-id", description: "key: id of site"));
            command.AddOption(new Option<string>("--list-id", description: "key: id of list"));
            command.AddOption(new Option<string>("--contenttype-id", description: "key: id of contentType"));
            command.AddOption(new Option<object>("--select", description: "Select properties to be returned"));
            command.AddOption(new Option<object>("--expand", description: "Expand related entities"));
            command.Handler = CommandHandler.Create<string, string, string, object, object>(async (siteId, listId, contentTypeId, select, expand) => {
                var requestInfo = CreateGetRequestInformation();
                if (!String.IsNullOrEmpty(siteId)) requestInfo.PathParameters.Add("site_id", siteId);
                if (!String.IsNullOrEmpty(listId)) requestInfo.PathParameters.Add("list_id", listId);
                if (!String.IsNullOrEmpty(contentTypeId)) requestInfo.PathParameters.Add("contentType_id", contentTypeId);
                requestInfo.QueryParameters.Add("select", select);
                requestInfo.QueryParameters.Add("expand", expand);
                var result = await RequestAdapter.SendAsync<ContentType>(requestInfo);
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
        public Command BuildPublishCommand() {
            var command = new Command("publish");
            var builder = new ApiSdk.Sites.Item.Lists.Item.ContentTypes.Item.@Base.Publish.PublishRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildRefCommand() {
            var command = new Command("ref");
            var builder = new ApiSdk.Sites.Item.Lists.Item.ContentTypes.Item.@Base.@Ref.RefRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPutCommand());
            return command;
        }
        public Command BuildUnpublishCommand() {
            var command = new Command("unpublish");
            var builder = new ApiSdk.Sites.Item.Lists.Item.ContentTypes.Item.@Base.Unpublish.UnpublishRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new BaseRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public BaseRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/sites/{site_id}/lists/{list_id}/contentTypes/{contentType_id}/base{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Parent contentType from which this content type is derived.
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
        /// Parent contentType from which this content type is derived.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<ContentType> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<ContentType>(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>
        /// Builds and executes requests for operations under \sites\{site-id}\lists\{list-id}\contentTypes\{contentType-id}\base\microsoft.graph.isPublished()
        /// </summary>
        public IsPublishedRequestBuilder IsPublished() {
            return new IsPublishedRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Parent contentType from which this content type is derived.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
