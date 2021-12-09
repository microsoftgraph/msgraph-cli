using ApiSdk.IdentityGovernance.AppConsent.AppConsentRequests.Item.UserConsentRequests.Item.Approval.Stages.Item;
using ApiSdk.Models.Microsoft.Graph;
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
namespace ApiSdk.IdentityGovernance.AppConsent.AppConsentRequests.Item.UserConsentRequests.Item.Approval.Stages {
    /// <summary>Builds and executes requests for operations under \identityGovernance\appConsent\appConsentRequests\{appConsentRequest-id}\userConsentRequests\{userConsentRequest-id}\approval\stages</summary>
    public class StagesRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public List<Command> BuildCommand() {
            var builder = new ApprovalStageRequestBuilder(PathParameters, RequestAdapter);
            var commands = new List<Command> { 
                builder.BuildDeleteCommand(),
                builder.BuildGetCommand(),
                builder.BuildPatchCommand(),
            };
            return commands;
        }
        /// <summary>
        /// A collection of stages in the approval decision.
        /// </summary>
        public Command BuildCreateCommand() {
            var command = new Command("create");
            command.Description = "A collection of stages in the approval decision.";
            // Create options for all the parameters
            var appConsentRequestIdOption = new Option<string>("--appconsentrequest-id", description: "key: id of appConsentRequest");
            appConsentRequestIdOption.IsRequired = true;
            command.AddOption(appConsentRequestIdOption);
            var userConsentRequestIdOption = new Option<string>("--userconsentrequest-id", description: "key: id of userConsentRequest");
            userConsentRequestIdOption.IsRequired = true;
            command.AddOption(userConsentRequestIdOption);
            var bodyOption = new Option<string>("--body");
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.Handler = CommandHandler.Create<string, string, string>(async (appConsentRequestId, userConsentRequestId, body) => {
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ApprovalStage>();
                var requestInfo = CreatePostRequestInformation(model, q => {
                });
                var result = await RequestAdapter.SendAsync<ApprovalStage>(requestInfo);
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
        /// A collection of stages in the approval decision.
        /// </summary>
        public Command BuildListCommand() {
            var command = new Command("list");
            command.Description = "A collection of stages in the approval decision.";
            // Create options for all the parameters
            var appConsentRequestIdOption = new Option<string>("--appconsentrequest-id", description: "key: id of appConsentRequest");
            appConsentRequestIdOption.IsRequired = true;
            command.AddOption(appConsentRequestIdOption);
            var userConsentRequestIdOption = new Option<string>("--userconsentrequest-id", description: "key: id of userConsentRequest");
            userConsentRequestIdOption.IsRequired = true;
            command.AddOption(userConsentRequestIdOption);
            var topOption = new Option<int?>("--top", description: "Show only the first n items");
            topOption.IsRequired = false;
            command.AddOption(topOption);
            var skipOption = new Option<int?>("--skip", description: "Skip the first n items");
            skipOption.IsRequired = false;
            command.AddOption(skipOption);
            var searchOption = new Option<string>("--search", description: "Search items by search phrases");
            searchOption.IsRequired = false;
            command.AddOption(searchOption);
            var filterOption = new Option<string>("--filter", description: "Filter items by property values");
            filterOption.IsRequired = false;
            command.AddOption(filterOption);
            var countOption = new Option<bool?>("--count", description: "Include count of items");
            countOption.IsRequired = false;
            command.AddOption(countOption);
            var orderbyOption = new Option<string[]>("--orderby", description: "Order items by property values");
            orderbyOption.IsRequired = false;
            orderbyOption.Arity = ArgumentArity.ZeroOrMore;
            command.AddOption(orderbyOption);
            var selectOption = new Option<string[]>("--select", description: "Select properties to be returned");
            selectOption.IsRequired = false;
            selectOption.Arity = ArgumentArity.ZeroOrMore;
            command.AddOption(selectOption);
            var expandOption = new Option<string[]>("--expand", description: "Expand related entities");
            expandOption.IsRequired = false;
            expandOption.Arity = ArgumentArity.ZeroOrMore;
            command.AddOption(expandOption);
            command.Handler = CommandHandler.Create<string, string, int?, int?, string, string, bool?, string[], string[], string[]>(async (appConsentRequestId, userConsentRequestId, top, skip, search, filter, count, orderby, select, expand) => {
                var requestInfo = CreateGetRequestInformation(q => {
                    q.Top = top;
                    q.Skip = skip;
                    if (!String.IsNullOrEmpty(search)) q.Search = search;
                    if (!String.IsNullOrEmpty(filter)) q.Filter = filter;
                    q.Count = count;
                    q.Orderby = orderby;
                    q.Select = select;
                    q.Expand = expand;
                });
                var result = await RequestAdapter.SendAsync<StagesResponse>(requestInfo);
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
        /// Instantiates a new StagesRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public StagesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/identityGovernance/appConsent/appConsentRequests/{appConsentRequest_id}/userConsentRequests/{userConsentRequest_id}/approval/stages{?top,skip,search,filter,count,orderby,select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// A collection of stages in the approval decision.
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
        /// A collection of stages in the approval decision.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePostRequestInformation(ApprovalStage body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// A collection of stages in the approval decision.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<StagesResponse> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<StagesResponse>(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>
        /// A collection of stages in the approval decision.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="model"></param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<ApprovalStage> PostAsync(ApprovalStage model, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = model ?? throw new ArgumentNullException(nameof(model));
            var requestInfo = CreatePostRequestInformation(model, h, o);
            return await RequestAdapter.SendAsync<ApprovalStage>(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>A collection of stages in the approval decision.</summary>
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
