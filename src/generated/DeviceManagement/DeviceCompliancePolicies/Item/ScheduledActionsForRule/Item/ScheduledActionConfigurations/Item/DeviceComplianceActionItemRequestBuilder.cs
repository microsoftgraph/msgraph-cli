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
namespace ApiSdk.DeviceManagement.DeviceCompliancePolicies.Item.ScheduledActionsForRule.Item.ScheduledActionConfigurations.Item {
    /// <summary>Builds and executes requests for operations under \deviceManagement\deviceCompliancePolicies\{deviceCompliancePolicy-id}\scheduledActionsForRule\{deviceComplianceScheduledActionForRule-id}\scheduledActionConfigurations\{deviceComplianceActionItem-id}</summary>
    public class DeviceComplianceActionItemRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// The list of scheduled action configurations for this compliance policy. Compliance policy must have one and only one block scheduled action.
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "The list of scheduled action configurations for this compliance policy. Compliance policy must have one and only one block scheduled action.";
            // Create options for all the parameters
            var deviceCompliancePolicyIdOption = new Option<string>("--devicecompliancepolicy-id", description: "key: id of deviceCompliancePolicy") {
            };
            deviceCompliancePolicyIdOption.IsRequired = true;
            command.AddOption(deviceCompliancePolicyIdOption);
            var deviceComplianceScheduledActionForRuleIdOption = new Option<string>("--devicecompliancescheduledactionforrule-id", description: "key: id of deviceComplianceScheduledActionForRule") {
            };
            deviceComplianceScheduledActionForRuleIdOption.IsRequired = true;
            command.AddOption(deviceComplianceScheduledActionForRuleIdOption);
            var deviceComplianceActionItemIdOption = new Option<string>("--devicecomplianceactionitem-id", description: "key: id of deviceComplianceActionItem") {
            };
            deviceComplianceActionItemIdOption.IsRequired = true;
            command.AddOption(deviceComplianceActionItemIdOption);
            command.SetHandler(async (string deviceCompliancePolicyId, string deviceComplianceScheduledActionForRuleId, string deviceComplianceActionItemId, IServiceProvider serviceProvider, IConsole console) => {
                var responseHandler = serviceProvider.GetService(typeof(IResponseHandler)) as IResponseHandler;
                var requestInfo = CreateDeleteRequestInformation(q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler);
                // Print request output. What if the request has no return?
                console.WriteLine("Success");
            }, deviceCompliancePolicyIdOption, deviceComplianceScheduledActionForRuleIdOption, deviceComplianceActionItemIdOption, new ServiceProviderBinder());
            return command;
        }
        /// <summary>
        /// The list of scheduled action configurations for this compliance policy. Compliance policy must have one and only one block scheduled action.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "The list of scheduled action configurations for this compliance policy. Compliance policy must have one and only one block scheduled action.";
            // Create options for all the parameters
            var deviceCompliancePolicyIdOption = new Option<string>("--devicecompliancepolicy-id", description: "key: id of deviceCompliancePolicy") {
            };
            deviceCompliancePolicyIdOption.IsRequired = true;
            command.AddOption(deviceCompliancePolicyIdOption);
            var deviceComplianceScheduledActionForRuleIdOption = new Option<string>("--devicecompliancescheduledactionforrule-id", description: "key: id of deviceComplianceScheduledActionForRule") {
            };
            deviceComplianceScheduledActionForRuleIdOption.IsRequired = true;
            command.AddOption(deviceComplianceScheduledActionForRuleIdOption);
            var deviceComplianceActionItemIdOption = new Option<string>("--devicecomplianceactionitem-id", description: "key: id of deviceComplianceActionItem") {
            };
            deviceComplianceActionItemIdOption.IsRequired = true;
            command.AddOption(deviceComplianceActionItemIdOption);
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
            command.SetHandler(async (string deviceCompliancePolicyId, string deviceComplianceScheduledActionForRuleId, string deviceComplianceActionItemId, string[] select, string[] expand, FormatterType output, IServiceProvider serviceProvider, IConsole console) => {
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
            }, deviceCompliancePolicyIdOption, deviceComplianceScheduledActionForRuleIdOption, deviceComplianceActionItemIdOption, selectOption, expandOption, outputOption, new ServiceProviderBinder());
            return command;
        }
        /// <summary>
        /// The list of scheduled action configurations for this compliance policy. Compliance policy must have one and only one block scheduled action.
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "The list of scheduled action configurations for this compliance policy. Compliance policy must have one and only one block scheduled action.";
            // Create options for all the parameters
            var deviceCompliancePolicyIdOption = new Option<string>("--devicecompliancepolicy-id", description: "key: id of deviceCompliancePolicy") {
            };
            deviceCompliancePolicyIdOption.IsRequired = true;
            command.AddOption(deviceCompliancePolicyIdOption);
            var deviceComplianceScheduledActionForRuleIdOption = new Option<string>("--devicecompliancescheduledactionforrule-id", description: "key: id of deviceComplianceScheduledActionForRule") {
            };
            deviceComplianceScheduledActionForRuleIdOption.IsRequired = true;
            command.AddOption(deviceComplianceScheduledActionForRuleIdOption);
            var deviceComplianceActionItemIdOption = new Option<string>("--devicecomplianceactionitem-id", description: "key: id of deviceComplianceActionItem") {
            };
            deviceComplianceActionItemIdOption.IsRequired = true;
            command.AddOption(deviceComplianceActionItemIdOption);
            var bodyOption = new Option<string>("--body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (string deviceCompliancePolicyId, string deviceComplianceScheduledActionForRuleId, string deviceComplianceActionItemId, string body, IServiceProvider serviceProvider, IConsole console) => {
                var responseHandler = serviceProvider.GetService(typeof(IResponseHandler)) as IResponseHandler;
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<DeviceComplianceActionItem>();
                var requestInfo = CreatePatchRequestInformation(model, q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler);
                // Print request output. What if the request has no return?
                console.WriteLine("Success");
            }, deviceCompliancePolicyIdOption, deviceComplianceScheduledActionForRuleIdOption, deviceComplianceActionItemIdOption, bodyOption, new ServiceProviderBinder());
            return command;
        }
        /// <summary>
        /// Instantiates a new DeviceComplianceActionItemRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public DeviceComplianceActionItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/deviceCompliancePolicies/{deviceCompliancePolicy_id}/scheduledActionsForRule/{deviceComplianceScheduledActionForRule_id}/scheduledActionConfigurations/{deviceComplianceActionItem_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new DeviceComplianceActionItemRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public DeviceComplianceActionItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/deviceCompliancePolicies/{deviceCompliancePolicy_id}/scheduledActionsForRule/{deviceComplianceScheduledActionForRule_id}/scheduledActionConfigurations/{deviceComplianceActionItem_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// The list of scheduled action configurations for this compliance policy. Compliance policy must have one and only one block scheduled action.
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
        /// The list of scheduled action configurations for this compliance policy. Compliance policy must have one and only one block scheduled action.
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
        /// The list of scheduled action configurations for this compliance policy. Compliance policy must have one and only one block scheduled action.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(DeviceComplianceActionItem body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// The list of scheduled action configurations for this compliance policy. Compliance policy must have one and only one block scheduled action.
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
        /// The list of scheduled action configurations for this compliance policy. Compliance policy must have one and only one block scheduled action.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<DeviceComplianceActionItem> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<DeviceComplianceActionItem>(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>
        /// The list of scheduled action configurations for this compliance policy. Compliance policy must have one and only one block scheduled action.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="model"></param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(DeviceComplianceActionItem model, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = model ?? throw new ArgumentNullException(nameof(model));
            var requestInfo = CreatePatchRequestInformation(model, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>The list of scheduled action configurations for this compliance policy. Compliance policy must have one and only one block scheduled action.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
