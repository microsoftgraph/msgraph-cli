using ApiSdk.Models.Microsoft.Graph;
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
namespace ApiSdk.DeviceManagement.DeviceCompliancePolicies.Item.ScheduledActionsForRule.Item.ScheduledActionConfigurations.Item {
    /// <summary>Builds and executes requests for operations under \deviceManagement\deviceCompliancePolicies\{deviceCompliancePolicy-id}\scheduledActionsForRule\{deviceComplianceScheduledActionForRule-id}\scheduledActionConfigurations\{deviceComplianceActionItem-id}</summary>
    public class DeviceComplianceActionItemItemRequestBuilder {
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
            var deviceCompliancePolicyIdOption = new Option<string>("--device-compliance-policy-id", description: "key: id of deviceCompliancePolicy") {
            };
            deviceCompliancePolicyIdOption.IsRequired = true;
            command.AddOption(deviceCompliancePolicyIdOption);
            var deviceComplianceScheduledActionForRuleIdOption = new Option<string>("--device-compliance-scheduled-action-for-rule-id", description: "key: id of deviceComplianceScheduledActionForRule") {
            };
            deviceComplianceScheduledActionForRuleIdOption.IsRequired = true;
            command.AddOption(deviceComplianceScheduledActionForRuleIdOption);
            var deviceComplianceActionItemIdOption = new Option<string>("--device-compliance-action-item-id", description: "key: id of deviceComplianceActionItem") {
            };
            deviceComplianceActionItemIdOption.IsRequired = true;
            command.AddOption(deviceComplianceActionItemIdOption);
            command.SetHandler(async (object[] parameters) => {
                var deviceCompliancePolicyId = (string) parameters[0];
                var deviceComplianceScheduledActionForRuleId = (string) parameters[1];
                var deviceComplianceActionItemId = (string) parameters[2];
                var cancellationToken = (CancellationToken) parameters[3];
                PathParameters.Clear();
                PathParameters.Add("deviceCompliancePolicy_id", deviceCompliancePolicyId);
                PathParameters.Add("deviceComplianceScheduledActionForRule_id", deviceComplianceScheduledActionForRuleId);
                PathParameters.Add("deviceComplianceActionItem_id", deviceComplianceActionItemId);
                var requestInfo = CreateDeleteRequestInformation(q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(deviceCompliancePolicyIdOption, deviceComplianceScheduledActionForRuleIdOption, deviceComplianceActionItemIdOption, new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// The list of scheduled action configurations for this compliance policy. Compliance policy must have one and only one block scheduled action.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "The list of scheduled action configurations for this compliance policy. Compliance policy must have one and only one block scheduled action.";
            // Create options for all the parameters
            var deviceCompliancePolicyIdOption = new Option<string>("--device-compliance-policy-id", description: "key: id of deviceCompliancePolicy") {
            };
            deviceCompliancePolicyIdOption.IsRequired = true;
            command.AddOption(deviceCompliancePolicyIdOption);
            var deviceComplianceScheduledActionForRuleIdOption = new Option<string>("--device-compliance-scheduled-action-for-rule-id", description: "key: id of deviceComplianceScheduledActionForRule") {
            };
            deviceComplianceScheduledActionForRuleIdOption.IsRequired = true;
            command.AddOption(deviceComplianceScheduledActionForRuleIdOption);
            var deviceComplianceActionItemIdOption = new Option<string>("--device-compliance-action-item-id", description: "key: id of deviceComplianceActionItem") {
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
            var outputFilterOption = new Option<string>("--query");
            command.AddOption(outputFilterOption);
            command.SetHandler(async (object[] parameters) => {
                var deviceCompliancePolicyId = (string) parameters[0];
                var deviceComplianceScheduledActionForRuleId = (string) parameters[1];
                var deviceComplianceActionItemId = (string) parameters[2];
                var select = (string[]) parameters[3];
                var expand = (string[]) parameters[4];
                var output = (FormatterType) parameters[5];
                var outputFilterOption = (string) parameters[6];
                var outputFormatterFactory = (IOutputFormatterFactory) parameters[7];
                var cancellationToken = (CancellationToken) parameters[8];
                PathParameters.Clear();
                PathParameters.Add("deviceCompliancePolicy_id", deviceCompliancePolicyId);
                PathParameters.Add("deviceComplianceScheduledActionForRule_id", deviceComplianceScheduledActionForRuleId);
                PathParameters.Add("deviceComplianceActionItem_id", deviceComplianceActionItemId);
                var requestInfo = CreateGetRequestInformation(q => {
                    q.Select = select;
                    q.Expand = expand;
                });
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                var formatter = outputFormatterFactory.GetFormatter(output);
                formatter.WriteOutput(response);
            }, new CollectionBinding(deviceCompliancePolicyIdOption, deviceComplianceScheduledActionForRuleIdOption, deviceComplianceActionItemIdOption, selectOption, expandOption, outputOption, outputFilterOption, new TypeBinding(typeof(IOutputFormatterFactory)), new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// The list of scheduled action configurations for this compliance policy. Compliance policy must have one and only one block scheduled action.
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "The list of scheduled action configurations for this compliance policy. Compliance policy must have one and only one block scheduled action.";
            // Create options for all the parameters
            var deviceCompliancePolicyIdOption = new Option<string>("--device-compliance-policy-id", description: "key: id of deviceCompliancePolicy") {
            };
            deviceCompliancePolicyIdOption.IsRequired = true;
            command.AddOption(deviceCompliancePolicyIdOption);
            var deviceComplianceScheduledActionForRuleIdOption = new Option<string>("--device-compliance-scheduled-action-for-rule-id", description: "key: id of deviceComplianceScheduledActionForRule") {
            };
            deviceComplianceScheduledActionForRuleIdOption.IsRequired = true;
            command.AddOption(deviceComplianceScheduledActionForRuleIdOption);
            var deviceComplianceActionItemIdOption = new Option<string>("--device-compliance-action-item-id", description: "key: id of deviceComplianceActionItem") {
            };
            deviceComplianceActionItemIdOption.IsRequired = true;
            command.AddOption(deviceComplianceActionItemIdOption);
            var bodyOption = new Option<string>("--body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (object[] parameters) => {
                var deviceCompliancePolicyId = (string) parameters[0];
                var deviceComplianceScheduledActionForRuleId = (string) parameters[1];
                var deviceComplianceActionItemId = (string) parameters[2];
                var body = (string) parameters[3];
                var cancellationToken = (CancellationToken) parameters[4];
                PathParameters.Clear();
                PathParameters.Add("deviceCompliancePolicy_id", deviceCompliancePolicyId);
                PathParameters.Add("deviceComplianceScheduledActionForRule_id", deviceComplianceScheduledActionForRuleId);
                PathParameters.Add("deviceComplianceActionItem_id", deviceComplianceActionItemId);
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<DeviceComplianceActionItem>();
                var requestInfo = CreatePatchRequestInformation(model, q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(deviceCompliancePolicyIdOption, deviceComplianceScheduledActionForRuleIdOption, deviceComplianceActionItemIdOption, bodyOption, new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// Instantiates a new DeviceComplianceActionItemItemRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public DeviceComplianceActionItemItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/deviceCompliancePolicies/{deviceCompliancePolicy_id}/scheduledActionsForRule/{deviceComplianceScheduledActionForRule_id}/scheduledActionConfigurations/{deviceComplianceActionItem_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
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
        /// <summary>The list of scheduled action configurations for this compliance policy. Compliance policy must have one and only one block scheduled action.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
