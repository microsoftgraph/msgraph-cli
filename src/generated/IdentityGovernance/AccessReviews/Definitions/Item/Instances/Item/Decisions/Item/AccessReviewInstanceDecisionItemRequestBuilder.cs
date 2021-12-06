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
using System.Threading.Tasks;
namespace ApiSdk.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.Decisions.Item {
    /// <summary>Builds and executes requests for operations under \identityGovernance\accessReviews\definitions\{accessReviewScheduleDefinition-id}\instances\{accessReviewInstance-id}\decisions\{accessReviewInstanceDecisionItem-id}</summary>
    public class AccessReviewInstanceDecisionItemRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Each principal reviewed in an accessReviewInstance has a decision item representing if they were approved, denied, or not yet reviewed.
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            // Create options for all the parameters
            command.AddOption(new Option<string>("--accessreviewscheduledefinition-id", description: "key: id of accessReviewScheduleDefinition"));
            command.AddOption(new Option<string>("--accessreviewinstance-id", description: "key: id of accessReviewInstance"));
            command.AddOption(new Option<string>("--accessreviewinstancedecisionitem-id", description: "key: id of accessReviewInstanceDecisionItem"));
            command.Handler = CommandHandler.Create<string, string, string>(async (accessReviewScheduleDefinitionId, accessReviewInstanceId, accessReviewInstanceDecisionItemId) => {
                var requestInfo = CreateDeleteRequestInformation();
                if (!String.IsNullOrEmpty(accessReviewScheduleDefinitionId)) requestInfo.PathParameters.Add("accessReviewScheduleDefinition_id", accessReviewScheduleDefinitionId);
                if (!String.IsNullOrEmpty(accessReviewInstanceId)) requestInfo.PathParameters.Add("accessReviewInstance_id", accessReviewInstanceId);
                if (!String.IsNullOrEmpty(accessReviewInstanceDecisionItemId)) requestInfo.PathParameters.Add("accessReviewInstanceDecisionItem_id", accessReviewInstanceDecisionItemId);
                await RequestAdapter.SendNoContentAsync(requestInfo);
                // Print request output. What if the request has no return?
                Console.WriteLine("Success");
            });
            return command;
        }
        /// <summary>
        /// Each principal reviewed in an accessReviewInstance has a decision item representing if they were approved, denied, or not yet reviewed.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            // Create options for all the parameters
            command.AddOption(new Option<string>("--accessreviewscheduledefinition-id", description: "key: id of accessReviewScheduleDefinition"));
            command.AddOption(new Option<string>("--accessreviewinstance-id", description: "key: id of accessReviewInstance"));
            command.AddOption(new Option<string>("--accessreviewinstancedecisionitem-id", description: "key: id of accessReviewInstanceDecisionItem"));
            command.AddOption(new Option<object>("--select", description: "Select properties to be returned"));
            command.AddOption(new Option<object>("--expand", description: "Expand related entities"));
            command.Handler = CommandHandler.Create<string, string, string, object, object>(async (accessReviewScheduleDefinitionId, accessReviewInstanceId, accessReviewInstanceDecisionItemId, select, expand) => {
                var requestInfo = CreateGetRequestInformation();
                if (!String.IsNullOrEmpty(accessReviewScheduleDefinitionId)) requestInfo.PathParameters.Add("accessReviewScheduleDefinition_id", accessReviewScheduleDefinitionId);
                if (!String.IsNullOrEmpty(accessReviewInstanceId)) requestInfo.PathParameters.Add("accessReviewInstance_id", accessReviewInstanceId);
                if (!String.IsNullOrEmpty(accessReviewInstanceDecisionItemId)) requestInfo.PathParameters.Add("accessReviewInstanceDecisionItem_id", accessReviewInstanceDecisionItemId);
                requestInfo.QueryParameters.Add("select", select);
                requestInfo.QueryParameters.Add("expand", expand);
                var result = await RequestAdapter.SendAsync<AccessReviewInstanceDecisionItem>(requestInfo);
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
        /// Each principal reviewed in an accessReviewInstance has a decision item representing if they were approved, denied, or not yet reviewed.
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            // Create options for all the parameters
            command.AddOption(new Option<string>("--accessreviewscheduledefinition-id", description: "key: id of accessReviewScheduleDefinition"));
            command.AddOption(new Option<string>("--accessreviewinstance-id", description: "key: id of accessReviewInstance"));
            command.AddOption(new Option<string>("--accessreviewinstancedecisionitem-id", description: "key: id of accessReviewInstanceDecisionItem"));
            command.AddOption(new Option<string>("--body"));
            command.Handler = CommandHandler.Create<string, string, string, string>(async (accessReviewScheduleDefinitionId, accessReviewInstanceId, accessReviewInstanceDecisionItemId, body) => {
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<AccessReviewInstanceDecisionItem>();
                var requestInfo = CreatePatchRequestInformation(model);
                if (!String.IsNullOrEmpty(accessReviewScheduleDefinitionId)) requestInfo.PathParameters.Add("accessReviewScheduleDefinition_id", accessReviewScheduleDefinitionId);
                if (!String.IsNullOrEmpty(accessReviewInstanceId)) requestInfo.PathParameters.Add("accessReviewInstance_id", accessReviewInstanceId);
                if (!String.IsNullOrEmpty(accessReviewInstanceDecisionItemId)) requestInfo.PathParameters.Add("accessReviewInstanceDecisionItem_id", accessReviewInstanceDecisionItemId);
                await RequestAdapter.SendNoContentAsync(requestInfo);
                // Print request output. What if the request has no return?
                Console.WriteLine("Success");
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new AccessReviewInstanceDecisionItemRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public AccessReviewInstanceDecisionItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/identityGovernance/accessReviews/definitions/{accessReviewScheduleDefinition_id}/instances/{accessReviewInstance_id}/decisions/{accessReviewInstanceDecisionItem_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Each principal reviewed in an accessReviewInstance has a decision item representing if they were approved, denied, or not yet reviewed.
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
        /// Each principal reviewed in an accessReviewInstance has a decision item representing if they were approved, denied, or not yet reviewed.
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
        /// Each principal reviewed in an accessReviewInstance has a decision item representing if they were approved, denied, or not yet reviewed.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(AccessReviewInstanceDecisionItem body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// Each principal reviewed in an accessReviewInstance has a decision item representing if they were approved, denied, or not yet reviewed.
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
        /// Each principal reviewed in an accessReviewInstance has a decision item representing if they were approved, denied, or not yet reviewed.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<AccessReviewInstanceDecisionItem> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<AccessReviewInstanceDecisionItem>(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>
        /// Each principal reviewed in an accessReviewInstance has a decision item representing if they were approved, denied, or not yet reviewed.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="model"></param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(AccessReviewInstanceDecisionItem model, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = model ?? throw new ArgumentNullException(nameof(model));
            var requestInfo = CreatePatchRequestInformation(model, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>Each principal reviewed in an accessReviewInstance has a decision item representing if they were approved, denied, or not yet reviewed.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
