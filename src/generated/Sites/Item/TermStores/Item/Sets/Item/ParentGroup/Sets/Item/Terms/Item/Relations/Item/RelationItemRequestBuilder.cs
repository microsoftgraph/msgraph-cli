using ApiSdk.Models.Microsoft.Graph.ODataErrors;
using ApiSdk.Models.Microsoft.Graph.TermStore;
using ApiSdk.Sites.Item.TermStores.Item.Sets.Item.ParentGroup.Sets.Item.Terms.Item.Relations.Item.FromTerm;
using ApiSdk.Sites.Item.TermStores.Item.Sets.Item.ParentGroup.Sets.Item.Terms.Item.Relations.Item.Set;
using ApiSdk.Sites.Item.TermStores.Item.Sets.Item.ParentGroup.Sets.Item.Terms.Item.Relations.Item.ToTerm;
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
namespace ApiSdk.Sites.Item.TermStores.Item.Sets.Item.ParentGroup.Sets.Item.Terms.Item.Relations.Item {
    /// <summary>Provides operations to manage the relations property of the microsoft.graph.termStore.term entity.</summary>
    public class RelationItemRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Delete navigation property relations for sites
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Delete navigation property relations for sites";
            // Create options for all the parameters
            var siteIdOption = new Option<string>("--site-id", description: "key: id of site") {
            };
            siteIdOption.IsRequired = true;
            command.AddOption(siteIdOption);
            var storeIdOption = new Option<string>("--store-id", description: "key: id of store") {
            };
            storeIdOption.IsRequired = true;
            command.AddOption(storeIdOption);
            var setIdOption = new Option<string>("--set-id", description: "key: id of set") {
            };
            setIdOption.IsRequired = true;
            command.AddOption(setIdOption);
            var setId1Option = new Option<string>("--set-id1", description: "key: id of set") {
            };
            setId1Option.IsRequired = true;
            command.AddOption(setId1Option);
            var termIdOption = new Option<string>("--term-id", description: "key: id of term") {
            };
            termIdOption.IsRequired = true;
            command.AddOption(termIdOption);
            var relationIdOption = new Option<string>("--relation-id", description: "key: id of relation") {
            };
            relationIdOption.IsRequired = true;
            command.AddOption(relationIdOption);
            command.SetHandler(async (object[] parameters) => {
                var siteId = (string) parameters[0];
                var storeId = (string) parameters[1];
                var setId = (string) parameters[2];
                var setId1 = (string) parameters[3];
                var termId = (string) parameters[4];
                var relationId = (string) parameters[5];
                var cancellationToken = (CancellationToken) parameters[6];
                PathParameters.Clear();
                PathParameters.Add("site_id", siteId);
                PathParameters.Add("store_id", storeId);
                PathParameters.Add("set_id", setId);
                PathParameters.Add("set_id1", setId1);
                PathParameters.Add("term_id", termId);
                PathParameters.Add("relation_id", relationId);
                var requestInfo = CreateDeleteRequestInformation(q => {
                });
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(siteIdOption, storeIdOption, setIdOption, setId1Option, termIdOption, relationIdOption, new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        public Command BuildFromTermCommand() {
            var command = new Command("from-term");
            var builder = new FromTermRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// To indicate which terms are related to the current term as either pinned or reused.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "To indicate which terms are related to the current term as either pinned or reused.";
            // Create options for all the parameters
            var siteIdOption = new Option<string>("--site-id", description: "key: id of site") {
            };
            siteIdOption.IsRequired = true;
            command.AddOption(siteIdOption);
            var storeIdOption = new Option<string>("--store-id", description: "key: id of store") {
            };
            storeIdOption.IsRequired = true;
            command.AddOption(storeIdOption);
            var setIdOption = new Option<string>("--set-id", description: "key: id of set") {
            };
            setIdOption.IsRequired = true;
            command.AddOption(setIdOption);
            var setId1Option = new Option<string>("--set-id1", description: "key: id of set") {
            };
            setId1Option.IsRequired = true;
            command.AddOption(setId1Option);
            var termIdOption = new Option<string>("--term-id", description: "key: id of term") {
            };
            termIdOption.IsRequired = true;
            command.AddOption(termIdOption);
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
                var setId = (string) parameters[2];
                var setId1 = (string) parameters[3];
                var termId = (string) parameters[4];
                var relationId = (string) parameters[5];
                var select = (string[]) parameters[6];
                var expand = (string[]) parameters[7];
                var output = (FormatterType) parameters[8];
                var query = (string) parameters[9];
                var jsonNoIndent = (bool) parameters[10];
                var outputFilter = (IOutputFilter) parameters[11];
                var outputFormatterFactory = (IOutputFormatterFactory) parameters[12];
                var cancellationToken = (CancellationToken) parameters[13];
                PathParameters.Clear();
                PathParameters.Add("site_id", siteId);
                PathParameters.Add("store_id", storeId);
                PathParameters.Add("set_id", setId);
                PathParameters.Add("set_id1", setId1);
                PathParameters.Add("term_id", termId);
                PathParameters.Add("relation_id", relationId);
                var requestInfo = CreateGetRequestInformation(q => {
                    q.Select = select;
                    q.Expand = expand;
                });
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                response = await outputFilter?.FilterOutputAsync(response, query, cancellationToken) ?? response;
                var formatterOptions = output.GetOutputFormatterOptions(new FormatterOptionsModel(!jsonNoIndent));
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, formatterOptions, cancellationToken);
            }, new CollectionBinding(siteIdOption, storeIdOption, setIdOption, setId1Option, termIdOption, relationIdOption, selectOption, expandOption, outputOption, queryOption, jsonNoIndentOption, new TypeBinding(typeof(IOutputFilter)), new TypeBinding(typeof(IOutputFormatterFactory)), new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// Update the navigation property relations in sites
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Update the navigation property relations in sites";
            // Create options for all the parameters
            var siteIdOption = new Option<string>("--site-id", description: "key: id of site") {
            };
            siteIdOption.IsRequired = true;
            command.AddOption(siteIdOption);
            var storeIdOption = new Option<string>("--store-id", description: "key: id of store") {
            };
            storeIdOption.IsRequired = true;
            command.AddOption(storeIdOption);
            var setIdOption = new Option<string>("--set-id", description: "key: id of set") {
            };
            setIdOption.IsRequired = true;
            command.AddOption(setIdOption);
            var setId1Option = new Option<string>("--set-id1", description: "key: id of set") {
            };
            setId1Option.IsRequired = true;
            command.AddOption(setId1Option);
            var termIdOption = new Option<string>("--term-id", description: "key: id of term") {
            };
            termIdOption.IsRequired = true;
            command.AddOption(termIdOption);
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
                var setId = (string) parameters[2];
                var setId1 = (string) parameters[3];
                var termId = (string) parameters[4];
                var relationId = (string) parameters[5];
                var body = (string) parameters[6];
                var cancellationToken = (CancellationToken) parameters[7];
                PathParameters.Clear();
                PathParameters.Add("site_id", siteId);
                PathParameters.Add("store_id", storeId);
                PathParameters.Add("set_id", setId);
                PathParameters.Add("set_id1", setId1);
                PathParameters.Add("term_id", termId);
                PathParameters.Add("relation_id", relationId);
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<Relation>(Relation.CreateFromDiscriminatorValue);
                var requestInfo = CreatePatchRequestInformation(model, q => {
                });
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(siteIdOption, storeIdOption, setIdOption, setId1Option, termIdOption, relationIdOption, bodyOption, new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        public Command BuildSetCommand() {
            var command = new Command("set");
            var builder = new SetRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        public Command BuildToTermCommand() {
            var command = new Command("to-term");
            var builder = new ToTermRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
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
            UrlTemplate = "{+baseurl}/sites/{site_id}/termStores/{store_id}/sets/{set_id}/parentGroup/sets/{set_id1}/terms/{term_id}/relations/{relation_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete navigation property relations for sites
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// </summary>
        public RequestInformation CreateDeleteRequestInformation(Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            headers?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(options?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// To indicate which terms are related to the current term as either pinned or reused.
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// <param name="queryParameters">Request query parameters</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<GetQueryParameters> queryParameters = default, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (queryParameters != null) {
                var qParams = new GetQueryParameters();
                queryParameters.Invoke(qParams);
                qParams.AddQueryParameters(requestInfo.QueryParameters);
            }
            headers?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(options?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property relations in sites
        /// <param name="body"></param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(Relation body, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            headers?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(options?.ToArray());
            return requestInfo;
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
