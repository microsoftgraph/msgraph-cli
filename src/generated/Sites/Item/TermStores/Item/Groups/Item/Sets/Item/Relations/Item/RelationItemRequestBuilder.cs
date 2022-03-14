using ApiSdk.Models.Microsoft.Graph.TermStore;
using ApiSdk.Sites.Item.TermStores.Item.Groups.Item.Sets.Item.Relations.Item.FromTerm;
using ApiSdk.Sites.Item.TermStores.Item.Groups.Item.Sets.Item.Relations.Item.Set;
using ApiSdk.Sites.Item.TermStores.Item.Groups.Item.Sets.Item.Relations.Item.ToTerm;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Cli.Commons.Binding;
using Microsoft.Kiota.Cli.Commons.IO;
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace ApiSdk.Sites.Item.TermStores.Item.Groups.Item.Sets.Item.Relations.Item {
    /// <summary>Builds and executes requests for operations under \sites\{site-id}\termStores\{store-id}\groups\{group-id}\sets\{set-id}\relations\{relation-id}</summary>
    public class RelationItemRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Indicates which terms have been pinned or reused directly under the set.
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Indicates which terms have been pinned or reused directly under the set.";
            // Create options for all the parameters
            var siteIdOption = new Option<string>("--site-id", description: "key: id of site") {
            };
            siteIdOption.IsRequired = true;
            command.AddOption(siteIdOption);
            var storeIdOption = new Option<string>("--store-id", description: "key: id of store") {
            };
            storeIdOption.IsRequired = true;
            command.AddOption(storeIdOption);
            var groupIdOption = new Option<string>("--group-id", description: "key: id of group") {
            };
            groupIdOption.IsRequired = true;
            command.AddOption(groupIdOption);
            var setIdOption = new Option<string>("--set-id", description: "key: id of set") {
            };
            setIdOption.IsRequired = true;
            command.AddOption(setIdOption);
            var relationIdOption = new Option<string>("--relation-id", description: "key: id of relation") {
            };
            relationIdOption.IsRequired = true;
            command.AddOption(relationIdOption);
            command.SetHandler(async (object[] parameters) => {
                var siteId = (string) parameters[0];
                var storeId = (string) parameters[1];
                var groupId = (string) parameters[2];
                var setId = (string) parameters[3];
                var relationId = (string) parameters[4];
                var cancellationToken = (CancellationToken) parameters[5];
                PathParameters.Clear();
                PathParameters.Add("site_id", siteId);
                PathParameters.Add("store_id", storeId);
                PathParameters.Add("group_id", groupId);
                PathParameters.Add("set_id", setId);
                PathParameters.Add("relation_id", relationId);
                var requestInfo = CreateDeleteRequestInformation(q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(siteIdOption, storeIdOption, groupIdOption, setIdOption, relationIdOption, new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        public Command BuildFromTermCommand() {
            var command = new Command("from-term");
            var builder = new ApiSdk.Sites.Item.TermStores.Item.Groups.Item.Sets.Item.Relations.Item.FromTerm.FromTermRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        /// <summary>
        /// Indicates which terms have been pinned or reused directly under the set.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Indicates which terms have been pinned or reused directly under the set.";
            // Create options for all the parameters
            var siteIdOption = new Option<string>("--site-id", description: "key: id of site") {
            };
            siteIdOption.IsRequired = true;
            command.AddOption(siteIdOption);
            var storeIdOption = new Option<string>("--store-id", description: "key: id of store") {
            };
            storeIdOption.IsRequired = true;
            command.AddOption(storeIdOption);
            var groupIdOption = new Option<string>("--group-id", description: "key: id of group") {
            };
            groupIdOption.IsRequired = true;
            command.AddOption(groupIdOption);
            var setIdOption = new Option<string>("--set-id", description: "key: id of set") {
            };
            setIdOption.IsRequired = true;
            command.AddOption(setIdOption);
            var relationIdOption = new Option<string>("--relation-id", description: "key: id of relation") {
            };
            relationIdOption.IsRequired = true;
            command.AddOption(relationIdOption);
            var selectOption = new Option<string[]>("--select", description: "Select properties to be returned") {
                Arity = ArgumentArity.ZeroOrMore
            };
            selectOption.IsRequired = false;
            command.AddOption(selectOption);
            var expandOption = new Option<string[]>("--expand", description: "Expand related entities") {
                Arity = ArgumentArity.ZeroOrMore
            };
            expandOption.IsRequired = false;
            command.AddOption(expandOption);
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
            command.SetHandler(async (object[] parameters) => {
                var siteId = (string) parameters[0];
                var storeId = (string) parameters[1];
                var groupId = (string) parameters[2];
                var setId = (string) parameters[3];
                var relationId = (string) parameters[4];
                var select = (string[]) parameters[5];
                var expand = (string[]) parameters[6];
                var output = (FormatterType) parameters[7];
                var query = (string) parameters[8];
                var jsonNoIndent = (bool) parameters[9];
                var outputFilter = (IOutputFilter) parameters[10];
                var outputFormatterFactory = (IOutputFormatterFactory) parameters[11];
                var cancellationToken = (CancellationToken) parameters[12];
                PathParameters.Clear();
                PathParameters.Add("site_id", siteId);
                PathParameters.Add("store_id", storeId);
                PathParameters.Add("group_id", groupId);
                PathParameters.Add("set_id", setId);
                PathParameters.Add("relation_id", relationId);
                var requestInfo = CreateGetRequestInformation(q => {
                    q.Select = select;
                    q.Expand = expand;
                });
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                var formatter = outputFormatterFactory.GetFormatter(output);
                response = await outputFilter?.FilterOutputAsync(response, query, cancellationToken) ?? response;
                var formatterOptions = output.GetOutputFormatterOptions(new FormatterOptionsModel(!jsonNoIndent));
                await formatter.WriteOutputAsync(response, formatterOptions, cancellationToken);
            }, new CollectionBinding(siteIdOption, storeIdOption, groupIdOption, setIdOption, relationIdOption, selectOption, expandOption, outputOption, queryOption, jsonNoIndentOption, new TypeBinding(typeof(IOutputFilter)), new TypeBinding(typeof(IOutputFormatterFactory)), new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// Indicates which terms have been pinned or reused directly under the set.
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Indicates which terms have been pinned or reused directly under the set.";
            // Create options for all the parameters
            var siteIdOption = new Option<string>("--site-id", description: "key: id of site") {
            };
            siteIdOption.IsRequired = true;
            command.AddOption(siteIdOption);
            var storeIdOption = new Option<string>("--store-id", description: "key: id of store") {
            };
            storeIdOption.IsRequired = true;
            command.AddOption(storeIdOption);
            var groupIdOption = new Option<string>("--group-id", description: "key: id of group") {
            };
            groupIdOption.IsRequired = true;
            command.AddOption(groupIdOption);
            var setIdOption = new Option<string>("--set-id", description: "key: id of set") {
            };
            setIdOption.IsRequired = true;
            command.AddOption(setIdOption);
            var relationIdOption = new Option<string>("--relation-id", description: "key: id of relation") {
            };
            relationIdOption.IsRequired = true;
            command.AddOption(relationIdOption);
            var bodyOption = new Option<string>("--body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (object[] parameters) => {
                var siteId = (string) parameters[0];
                var storeId = (string) parameters[1];
                var groupId = (string) parameters[2];
                var setId = (string) parameters[3];
                var relationId = (string) parameters[4];
                var body = (string) parameters[5];
                var cancellationToken = (CancellationToken) parameters[6];
                PathParameters.Clear();
                PathParameters.Add("site_id", siteId);
                PathParameters.Add("store_id", storeId);
                PathParameters.Add("group_id", groupId);
                PathParameters.Add("set_id", setId);
                PathParameters.Add("relation_id", relationId);
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<Relation>(Relation.CreateFromDiscriminatorValue);
                var requestInfo = CreatePatchRequestInformation(model, q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(siteIdOption, storeIdOption, groupIdOption, setIdOption, relationIdOption, bodyOption, new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        public Command BuildSetCommand() {
            var command = new Command("set");
            var builder = new ApiSdk.Sites.Item.TermStores.Item.Groups.Item.Sets.Item.Relations.Item.Set.SetRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        public Command BuildToTermCommand() {
            var command = new Command("to-term");
            var builder = new ApiSdk.Sites.Item.TermStores.Item.Groups.Item.Sets.Item.Relations.Item.ToTerm.ToTermRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new RelationItemRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public RelationItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/sites/{site_id}/termStores/{store_id}/groups/{group_id}/sets/{set_id}/relations/{relation_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Indicates which terms have been pinned or reused directly under the set.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreateDeleteRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Indicates which terms have been pinned or reused directly under the set.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
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
        /// Indicates which terms have been pinned or reused directly under the set.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(Relation body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>Indicates which terms have been pinned or reused directly under the set.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
