using ApiSdk.DeviceManagement.DeviceCompliancePolicies.Item.ScheduledActionsForRule.Item.ScheduledActionConfigurations;
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
namespace ApiSdk.DeviceManagement.DeviceCompliancePolicies.Item.ScheduledActionsForRule.Item {
    /// <summary>Builds and executes requests for operations under \deviceManagement\deviceCompliancePolicies\{deviceCompliancePolicy-id}\scheduledActionsForRule\{deviceComplianceScheduledActionForRule-id}</summary>
    public class DeviceComplianceScheduledActionForRuleRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// The list of scheduled action per rule for this compliance policy. This is a required property when creating any individual per-platform compliance policies.
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "The list of scheduled action per rule for this compliance policy. This is a required property when creating any individual per-platform compliance policies.";
            // Create options for all the parameters
            command.AddOption(new Option<string>("--devicecompliancepolicy-id", description: "key: id of deviceCompliancePolicy"));
            command.AddOption(new Option<string>("--devicecompliancescheduledactionforrule-id", description: "key: id of deviceComplianceScheduledActionForRule"));
            command.Handler = CommandHandler.Create<string, string>(async (deviceCompliancePolicyId, deviceComplianceScheduledActionForRuleId) => {
                var requestInfo = CreateDeleteRequestInformation();
                if (!String.IsNullOrEmpty(deviceCompliancePolicyId)) requestInfo.PathParameters.Add("deviceCompliancePolicy_id", deviceCompliancePolicyId);
                if (!String.IsNullOrEmpty(deviceComplianceScheduledActionForRuleId)) requestInfo.PathParameters.Add("deviceComplianceScheduledActionForRule_id", deviceComplianceScheduledActionForRuleId);
                await RequestAdapter.SendNoContentAsync(requestInfo);
                // Print request output. What if the request has no return?
                Console.WriteLine("Success");
            });
            return command;
        }
        /// <summary>
        /// The list of scheduled action per rule for this compliance policy. This is a required property when creating any individual per-platform compliance policies.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "The list of scheduled action per rule for this compliance policy. This is a required property when creating any individual per-platform compliance policies.";
            // Create options for all the parameters
            command.AddOption(new Option<string>("--devicecompliancepolicy-id", description: "key: id of deviceCompliancePolicy"));
            command.AddOption(new Option<string>("--devicecompliancescheduledactionforrule-id", description: "key: id of deviceComplianceScheduledActionForRule"));
            command.AddOption(new Option<object>("--select", description: "Select properties to be returned"));
            command.AddOption(new Option<object>("--expand", description: "Expand related entities"));
            command.Handler = CommandHandler.Create<string, string, object, object>(async (deviceCompliancePolicyId, deviceComplianceScheduledActionForRuleId, select, expand) => {
                var requestInfo = CreateGetRequestInformation();
                if (!String.IsNullOrEmpty(deviceCompliancePolicyId)) requestInfo.PathParameters.Add("deviceCompliancePolicy_id", deviceCompliancePolicyId);
                if (!String.IsNullOrEmpty(deviceComplianceScheduledActionForRuleId)) requestInfo.PathParameters.Add("deviceComplianceScheduledActionForRule_id", deviceComplianceScheduledActionForRuleId);
                requestInfo.QueryParameters.Add("select", select);
                requestInfo.QueryParameters.Add("expand", expand);
                var result = await RequestAdapter.SendAsync<DeviceComplianceScheduledActionForRule>(requestInfo);
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
        /// The list of scheduled action per rule for this compliance policy. This is a required property when creating any individual per-platform compliance policies.
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "The list of scheduled action per rule for this compliance policy. This is a required property when creating any individual per-platform compliance policies.";
            // Create options for all the parameters
            command.AddOption(new Option<string>("--devicecompliancepolicy-id", description: "key: id of deviceCompliancePolicy"));
            command.AddOption(new Option<string>("--devicecompliancescheduledactionforrule-id", description: "key: id of deviceComplianceScheduledActionForRule"));
            command.AddOption(new Option<string>("--body"));
            command.Handler = CommandHandler.Create<string, string, string>(async (deviceCompliancePolicyId, deviceComplianceScheduledActionForRuleId, body) => {
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<DeviceComplianceScheduledActionForRule>();
                var requestInfo = CreatePatchRequestInformation(model);
                if (!String.IsNullOrEmpty(deviceCompliancePolicyId)) requestInfo.PathParameters.Add("deviceCompliancePolicy_id", deviceCompliancePolicyId);
                if (!String.IsNullOrEmpty(deviceComplianceScheduledActionForRuleId)) requestInfo.PathParameters.Add("deviceComplianceScheduledActionForRule_id", deviceComplianceScheduledActionForRuleId);
                await RequestAdapter.SendNoContentAsync(requestInfo);
                // Print request output. What if the request has no return?
                Console.WriteLine("Success");
            });
            return command;
        }
        public Command BuildScheduledActionConfigurationsCommand() {
            var command = new Command("scheduled-action-configurations");
            var builder = new ApiSdk.DeviceManagement.DeviceCompliancePolicies.Item.ScheduledActionsForRule.Item.ScheduledActionConfigurations.ScheduledActionConfigurationsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new DeviceComplianceScheduledActionForRuleRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public DeviceComplianceScheduledActionForRuleRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/deviceCompliancePolicies/{deviceCompliancePolicy_id}/scheduledActionsForRule/{deviceComplianceScheduledActionForRule_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// The list of scheduled action per rule for this compliance policy. This is a required property when creating any individual per-platform compliance policies.
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
        /// The list of scheduled action per rule for this compliance policy. This is a required property when creating any individual per-platform compliance policies.
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
        /// The list of scheduled action per rule for this compliance policy. This is a required property when creating any individual per-platform compliance policies.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(DeviceComplianceScheduledActionForRule body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// The list of scheduled action per rule for this compliance policy. This is a required property when creating any individual per-platform compliance policies.
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
        /// The list of scheduled action per rule for this compliance policy. This is a required property when creating any individual per-platform compliance policies.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<DeviceComplianceScheduledActionForRule> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<DeviceComplianceScheduledActionForRule>(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>
        /// The list of scheduled action per rule for this compliance policy. This is a required property when creating any individual per-platform compliance policies.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="model"></param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(DeviceComplianceScheduledActionForRule model, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = model ?? throw new ArgumentNullException(nameof(model));
            var requestInfo = CreatePatchRequestInformation(model, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>The list of scheduled action per rule for this compliance policy. This is a required property when creating any individual per-platform compliance policies.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
