using ApiSdk.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.AcceptRecommendations;
using ApiSdk.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.ApplyDecisions;
using ApiSdk.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.BatchRecordDecisions;
using ApiSdk.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.ContactedReviewers;
using ApiSdk.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.Decisions;
using ApiSdk.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.ResetDecisions;
using ApiSdk.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.SendReminder;
using ApiSdk.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.Stop;
using ApiSdk.Models.Microsoft.Graph;
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
namespace ApiSdk.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item {
    /// <summary>Builds and executes requests for operations under \identityGovernance\accessReviews\definitions\{accessReviewScheduleDefinition-id}\instances\{accessReviewInstance-id}</summary>
    public class AccessReviewInstanceRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public Command BuildAcceptRecommendationsCommand() {
            var command = new Command("accept-recommendations");
            var builder = new ApiSdk.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.AcceptRecommendations.AcceptRecommendationsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildApplyDecisionsCommand() {
            var command = new Command("apply-decisions");
            var builder = new ApiSdk.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.ApplyDecisions.ApplyDecisionsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildBatchRecordDecisionsCommand() {
            var command = new Command("batch-record-decisions");
            var builder = new ApiSdk.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.BatchRecordDecisions.BatchRecordDecisionsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildContactedReviewersCommand() {
            var command = new Command("contacted-reviewers");
            var builder = new ApiSdk.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.ContactedReviewers.ContactedReviewersRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildDecisionsCommand() {
            var command = new Command("decisions");
            var builder = new ApiSdk.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.Decisions.DecisionsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Set of access reviews instances for this access review series. Access reviews that do not recur will only have one instance; otherwise, there is an instance for each recurrence.
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Set of access reviews instances for this access review series. Access reviews that do not recur will only have one instance; otherwise, there is an instance for each recurrence.";
            // Create options for all the parameters
            var accessReviewScheduleDefinitionIdOption = new Option<string>("--accessreviewscheduledefinition-id", description: "key: id of accessReviewScheduleDefinition") {
            };
            accessReviewScheduleDefinitionIdOption.IsRequired = true;
            command.AddOption(accessReviewScheduleDefinitionIdOption);
            var accessReviewInstanceIdOption = new Option<string>("--accessreviewinstance-id", description: "key: id of accessReviewInstance") {
            };
            accessReviewInstanceIdOption.IsRequired = true;
            command.AddOption(accessReviewInstanceIdOption);
            command.SetHandler(async (string accessReviewScheduleDefinitionId, string accessReviewInstanceId, IServiceProvider serviceProvider, IConsole console) => {
                var responseHandler = serviceProvider.GetService(typeof(IResponseHandler)) as IResponseHandler;
                var requestInfo = CreateDeleteRequestInformation(q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler);
                // Print request output. What if the request has no return?
                console.WriteLine("Success");
            }, accessReviewScheduleDefinitionIdOption, accessReviewInstanceIdOption, new ServiceProviderBinder());
            return command;
        }
        /// <summary>
        /// Set of access reviews instances for this access review series. Access reviews that do not recur will only have one instance; otherwise, there is an instance for each recurrence.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Set of access reviews instances for this access review series. Access reviews that do not recur will only have one instance; otherwise, there is an instance for each recurrence.";
            // Create options for all the parameters
            var accessReviewScheduleDefinitionIdOption = new Option<string>("--accessreviewscheduledefinition-id", description: "key: id of accessReviewScheduleDefinition") {
            };
            accessReviewScheduleDefinitionIdOption.IsRequired = true;
            command.AddOption(accessReviewScheduleDefinitionIdOption);
            var accessReviewInstanceIdOption = new Option<string>("--accessreviewinstance-id", description: "key: id of accessReviewInstance") {
            };
            accessReviewInstanceIdOption.IsRequired = true;
            command.AddOption(accessReviewInstanceIdOption);
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
            command.SetHandler(async (string accessReviewScheduleDefinitionId, string accessReviewInstanceId, string[] select, string[] expand, FormatterType output, IServiceProvider serviceProvider, IConsole console) => {
                var responseHandler = serviceProvider.GetService(typeof(IResponseHandler)) as IResponseHandler;
                var requestInfo = CreateGetRequestInformation(q => {
                    q.Select = select;
                    q.Expand = expand;
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler);
                // Print request output. What if the request has no return?
                var responseProcessor = serviceProvider.GetService(typeof(IResponseProcessor)) as IResponseProcessor;
                var factory = serviceProvider.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory;
                var formatter = factory.GetFormatter(output);
                if (responseProcessor.IsResponseSuccessful(responseHandler)) {
                    var content = await responseProcessor.ExtractStringResponseAsync(responseHandler);
                    formatter.WriteOutput(content, console);
                }
                else {
                    var content = await responseProcessor.ExtractStringResponseAsync(responseHandler);
                    console.WriteLine(content);
                }
            }, accessReviewScheduleDefinitionIdOption, accessReviewInstanceIdOption, selectOption, expandOption, outputOption, new ServiceProviderBinder());
            return command;
        }
        /// <summary>
        /// Set of access reviews instances for this access review series. Access reviews that do not recur will only have one instance; otherwise, there is an instance for each recurrence.
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Set of access reviews instances for this access review series. Access reviews that do not recur will only have one instance; otherwise, there is an instance for each recurrence.";
            // Create options for all the parameters
            var accessReviewScheduleDefinitionIdOption = new Option<string>("--accessreviewscheduledefinition-id", description: "key: id of accessReviewScheduleDefinition") {
            };
            accessReviewScheduleDefinitionIdOption.IsRequired = true;
            command.AddOption(accessReviewScheduleDefinitionIdOption);
            var accessReviewInstanceIdOption = new Option<string>("--accessreviewinstance-id", description: "key: id of accessReviewInstance") {
            };
            accessReviewInstanceIdOption.IsRequired = true;
            command.AddOption(accessReviewInstanceIdOption);
            var bodyOption = new Option<string>("--body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (string accessReviewScheduleDefinitionId, string accessReviewInstanceId, string body, IServiceProvider serviceProvider, IConsole console) => {
                var responseHandler = serviceProvider.GetService(typeof(IResponseHandler)) as IResponseHandler;
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<AccessReviewInstance>();
                var requestInfo = CreatePatchRequestInformation(model, q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler);
                // Print request output. What if the request has no return?
                console.WriteLine("Success");
            }, accessReviewScheduleDefinitionIdOption, accessReviewInstanceIdOption, bodyOption, new ServiceProviderBinder());
            return command;
        }
        public Command BuildResetDecisionsCommand() {
            var command = new Command("reset-decisions");
            var builder = new ApiSdk.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.ResetDecisions.ResetDecisionsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildSendReminderCommand() {
            var command = new Command("send-reminder");
            var builder = new ApiSdk.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.SendReminder.SendReminderRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildStopCommand() {
            var command = new Command("stop");
            var builder = new ApiSdk.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.Stop.StopRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new AccessReviewInstanceRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public AccessReviewInstanceRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/identityGovernance/accessReviews/definitions/{accessReviewScheduleDefinition_id}/instances/{accessReviewInstance_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new AccessReviewInstanceRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public AccessReviewInstanceRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/identityGovernance/accessReviews/definitions/{accessReviewScheduleDefinition_id}/instances/{accessReviewInstance_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Set of access reviews instances for this access review series. Access reviews that do not recur will only have one instance; otherwise, there is an instance for each recurrence.
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
        /// Set of access reviews instances for this access review series. Access reviews that do not recur will only have one instance; otherwise, there is an instance for each recurrence.
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
        /// Set of access reviews instances for this access review series. Access reviews that do not recur will only have one instance; otherwise, there is an instance for each recurrence.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(AccessReviewInstance body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// <summary>
        /// Set of access reviews instances for this access review series. Access reviews that do not recur will only have one instance; otherwise, there is an instance for each recurrence.
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
        /// Set of access reviews instances for this access review series. Access reviews that do not recur will only have one instance; otherwise, there is an instance for each recurrence.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<AccessReviewInstance> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<AccessReviewInstance>(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>
        /// Set of access reviews instances for this access review series. Access reviews that do not recur will only have one instance; otherwise, there is an instance for each recurrence.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="model"></param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(AccessReviewInstance model, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = model ?? throw new ArgumentNullException(nameof(model));
            var requestInfo = CreatePatchRequestInformation(model, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>Set of access reviews instances for this access review series. Access reviews that do not recur will only have one instance; otherwise, there is an instance for each recurrence.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
