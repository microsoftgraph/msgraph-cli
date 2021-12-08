using ApiSdk.Models.Microsoft.Graph.TermStore;
using ApiSdk.Sites.Item.TermStores.Item.Groups.Item.Sets.Item.Terms.Item.Relations.Item.FromTerm;
using ApiSdk.Sites.Item.TermStores.Item.Groups.Item.Sets.Item.Terms.Item.Relations.Item.Set;
using ApiSdk.Sites.Item.TermStores.Item.Groups.Item.Sets.Item.Terms.Item.Relations.Item.ToTerm;
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
namespace ApiSdk.Sites.Item.TermStores.Item.Groups.Item.Sets.Item.Terms.Item.Relations.Item {
    /// <summary>Builds and executes requests for operations under \sites\{site-id}\termStores\{store-id}\groups\{group-id}\sets\{set-id}\terms\{term-id}\relations\{relation-id}</summary>
    public class RelationRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// To indicate which terms are related to the current term as either pinned or reused.
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "To indicate which terms are related to the current term as either pinned or reused.";
            // Create options for all the parameters
            command.AddOption(new Option<string>("--site-id", description: "key: id of site"));
            command.AddOption(new Option<string>("--store-id", description: "key: id of store"));
            command.AddOption(new Option<string>("--group-id", description: "key: id of group"));
            command.AddOption(new Option<string>("--set-id", description: "key: id of set"));
            command.AddOption(new Option<string>("--term-id", description: "key: id of term"));
            command.AddOption(new Option<string>("--relation-id", description: "key: id of relation"));
            command.Handler = CommandHandler.Create<string, string, string, string, string, string>(async (siteId, storeId, groupId, setId, termId, relationId) => {
                var requestInfo = CreateDeleteRequestInformation();
                if (!String.IsNullOrEmpty(siteId)) requestInfo.PathParameters.Add("site_id", siteId);
                if (!String.IsNullOrEmpty(storeId)) requestInfo.PathParameters.Add("store_id", storeId);
                if (!String.IsNullOrEmpty(groupId)) requestInfo.PathParameters.Add("group_id", groupId);
                if (!String.IsNullOrEmpty(setId)) requestInfo.PathParameters.Add("set_id", setId);
                if (!String.IsNullOrEmpty(termId)) requestInfo.PathParameters.Add("term_id", termId);
                if (!String.IsNullOrEmpty(relationId)) requestInfo.PathParameters.Add("relation_id", relationId);
                await RequestAdapter.SendNoContentAsync(requestInfo);
                // Print request output. What if the request has no return?
                Console.WriteLine("Success");
            });
            return command;
        }
        public Command BuildFromTermCommand() {
            var command = new Command("from-term");
            var builder = new ApiSdk.Sites.Item.TermStores.Item.Groups.Item.Sets.Item.Terms.Item.Relations.Item.FromTerm.FromTermRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        /// <summary>
        /// To indicate which terms are related to the current term as either pinned or reused.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "To indicate which terms are related to the current term as either pinned or reused.";
            // Create options for all the parameters
            command.AddOption(new Option<string>("--site-id", description: "key: id of site"));
            command.AddOption(new Option<string>("--store-id", description: "key: id of store"));
            command.AddOption(new Option<string>("--group-id", description: "key: id of group"));
            command.AddOption(new Option<string>("--set-id", description: "key: id of set"));
            command.AddOption(new Option<string>("--term-id", description: "key: id of term"));
            command.AddOption(new Option<string>("--relation-id", description: "key: id of relation"));
            command.AddOption(new Option<object>("--select", description: "Select properties to be returned"));
            command.AddOption(new Option<object>("--expand", description: "Expand related entities"));
            command.Handler = CommandHandler.Create<string, string, string, string, string, string, object, object>(async (siteId, storeId, groupId, setId, termId, relationId, select, expand) => {
                var requestInfo = CreateGetRequestInformation();
                if (!String.IsNullOrEmpty(siteId)) requestInfo.PathParameters.Add("site_id", siteId);
                if (!String.IsNullOrEmpty(storeId)) requestInfo.PathParameters.Add("store_id", storeId);
                if (!String.IsNullOrEmpty(groupId)) requestInfo.PathParameters.Add("group_id", groupId);
                if (!String.IsNullOrEmpty(setId)) requestInfo.PathParameters.Add("set_id", setId);
                if (!String.IsNullOrEmpty(termId)) requestInfo.PathParameters.Add("term_id", termId);
                if (!String.IsNullOrEmpty(relationId)) requestInfo.PathParameters.Add("relation_id", relationId);
                requestInfo.QueryParameters.Add("select", select);
                requestInfo.QueryParameters.Add("expand", expand);
                var result = await RequestAdapter.SendAsync<Relation>(requestInfo);
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
        /// To indicate which terms are related to the current term as either pinned or reused.
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "To indicate which terms are related to the current term as either pinned or reused.";
            // Create options for all the parameters
            command.AddOption(new Option<string>("--site-id", description: "key: id of site"));
            command.AddOption(new Option<string>("--store-id", description: "key: id of store"));
            command.AddOption(new Option<string>("--group-id", description: "key: id of group"));
            command.AddOption(new Option<string>("--set-id", description: "key: id of set"));
            command.AddOption(new Option<string>("--term-id", description: "key: id of term"));
            command.AddOption(new Option<string>("--relation-id", description: "key: id of relation"));
            command.AddOption(new Option<string>("--body"));
            command.Handler = CommandHandler.Create<string, string, string, string, string, string, string>(async (siteId, storeId, groupId, setId, termId, relationId, body) => {
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<Relation>();
                var requestInfo = CreatePatchRequestInformation(model);
                if (!String.IsNullOrEmpty(siteId)) requestInfo.PathParameters.Add("site_id", siteId);
                if (!String.IsNullOrEmpty(storeId)) requestInfo.PathParameters.Add("store_id", storeId);
                if (!String.IsNullOrEmpty(groupId)) requestInfo.PathParameters.Add("group_id", groupId);
                if (!String.IsNullOrEmpty(setId)) requestInfo.PathParameters.Add("set_id", setId);
                if (!String.IsNullOrEmpty(termId)) requestInfo.PathParameters.Add("term_id", termId);
                if (!String.IsNullOrEmpty(relationId)) requestInfo.PathParameters.Add("relation_id", relationId);
                await RequestAdapter.SendNoContentAsync(requestInfo);
                // Print request output. What if the request has no return?
                Console.WriteLine("Success");
            });
            return command;
        }
        public Command BuildSetCommand() {
            var command = new Command("set");
            var builder = new ApiSdk.Sites.Item.TermStores.Item.Groups.Item.Sets.Item.Terms.Item.Relations.Item.Set.SetRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        public Command BuildToTermCommand() {
            var command = new Command("to-term");
            var builder = new ApiSdk.Sites.Item.TermStores.Item.Groups.Item.Sets.Item.Terms.Item.Relations.Item.ToTerm.ToTermRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new RelationRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public RelationRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/sites/{site_id}/termStores/{store_id}/groups/{group_id}/sets/{set_id}/terms/{term_id}/relations/{relation_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// To indicate which terms are related to the current term as either pinned or reused.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreateDeleteRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// To indicate which terms are related to the current term as either pinned or reused.
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
        /// To indicate which terms are related to the current term as either pinned or reused.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(Relation body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// To indicate which terms are related to the current term as either pinned or reused.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateDeleteRequestInformation(h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>
        /// To indicate which terms are related to the current term as either pinned or reused.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<Relation> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<Relation>(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>
        /// To indicate which terms are related to the current term as either pinned or reused.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="model"></param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(Relation model, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = model ?? throw new ArgumentNullException(nameof(model));
            var requestInfo = CreatePatchRequestInformation(model, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>To indicate which terms are related to the current term as either pinned or reused.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
