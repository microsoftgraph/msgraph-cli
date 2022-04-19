using ApiSdk.Models;
using ApiSdk.Models.ODataErrors;
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
    /// <summary>Provides operations to manage the scheduledActionConfigurations property of the microsoft.graph.deviceComplianceScheduledActionForRule entity.</summary>
    public class DeviceComplianceActionItemItemRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Delete navigation property scheduledActionConfigurations for deviceManagement
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Delete navigation property scheduledActionConfigurations for deviceManagement";
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
            var ifMatchOption = new Option<string>("--if-match", description: "ETag") {
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (object[] parameters) => {
                var deviceCompliancePolicyId = (string) parameters[0];
                var deviceComplianceScheduledActionForRuleId = (string) parameters[1];
                var deviceComplianceActionItemId = (string) parameters[2];
                var ifMatch = (string) parameters[3];
                var cancellationToken = (CancellationToken) parameters[4];
                var requestInfo = CreateDeleteRequestInformation(q => {
                });
                requestInfo.PathParameters.Add("deviceCompliancePolicy%2Did", deviceCompliancePolicyId);
                requestInfo.PathParameters.Add("deviceComplianceScheduledActionForRule%2Did", deviceComplianceScheduledActionForRuleId);
                requestInfo.PathParameters.Add("deviceComplianceActionItem%2Did", deviceComplianceActionItemId);
                requestInfo.Headers["If-Match"] = ifMatch;
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(deviceCompliancePolicyIdOption, deviceComplianceScheduledActionForRuleIdOption, deviceComplianceActionItemIdOption, ifMatchOption, new TypeBinding(typeof(CancellationToken))));
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
                var deviceCompliancePolicyId = (string) parameters[0];
                var deviceComplianceScheduledActionForRuleId = (string) parameters[1];
                var deviceComplianceActionItemId = (string) parameters[2];
                var select = (string[]) parameters[3];
                var expand = (string[]) parameters[4];
                var output = (FormatterType) parameters[5];
                var query = (string) parameters[6];
                var jsonNoIndent = (bool) parameters[7];
                var outputFilter = (IOutputFilter) parameters[8];
                var outputFormatterFactory = (IOutputFormatterFactory) parameters[9];
                var cancellationToken = (CancellationToken) parameters[10];
                var requestInfo = CreateGetRequestInformation(q => {
                    q.Select = select;
                    q.Expand = expand;
                });
                requestInfo.PathParameters.Add("deviceCompliancePolicy%2Did", deviceCompliancePolicyId);
                requestInfo.PathParameters.Add("deviceComplianceScheduledActionForRule%2Did", deviceComplianceScheduledActionForRuleId);
                requestInfo.PathParameters.Add("deviceComplianceActionItem%2Did", deviceComplianceActionItemId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                response = await outputFilter?.FilterOutputAsync(response, query, cancellationToken) ?? response;
                var formatterOptions = output.GetOutputFormatterOptions(new FormatterOptionsModel(!jsonNoIndent));
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, formatterOptions, cancellationToken);
            }, new CollectionBinding(deviceCompliancePolicyIdOption, deviceComplianceScheduledActionForRuleIdOption, deviceComplianceActionItemIdOption, selectOption, expandOption, outputOption, queryOption, jsonNoIndentOption, new TypeBinding(typeof(IOutputFilter)), new TypeBinding(typeof(IOutputFormatterFactory)), new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// Update the navigation property scheduledActionConfigurations in deviceManagement
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Update the navigation property scheduledActionConfigurations in deviceManagement";
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
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<DeviceComplianceActionItem>(DeviceComplianceActionItem.CreateFromDiscriminatorValue);
                var requestInfo = CreatePatchRequestInformation(model, q => {
                });
                requestInfo.PathParameters.Add("deviceCompliancePolicy%2Did", deviceCompliancePolicyId);
                requestInfo.PathParameters.Add("deviceComplianceScheduledActionForRule%2Did", deviceComplianceScheduledActionForRuleId);
                requestInfo.PathParameters.Add("deviceComplianceActionItem%2Did", deviceComplianceActionItemId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
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
            UrlTemplate = "{+baseurl}/deviceManagement/deviceCompliancePolicies/{deviceCompliancePolicy%2Did}/scheduledActionsForRule/{deviceComplianceScheduledActionForRule%2Did}/scheduledActionConfigurations/{deviceComplianceActionItem%2Did}{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete navigation property scheduledActionConfigurations for deviceManagement
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
        /// The list of scheduled action configurations for this compliance policy. Compliance policy must have one and only one block scheduled action.
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
        /// Update the navigation property scheduledActionConfigurations in deviceManagement
        /// <param name="body"></param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(DeviceComplianceActionItem body, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default) {
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
        /// <summary>The list of scheduled action configurations for this compliance policy. Compliance policy must have one and only one block scheduled action.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
        }
    }
}
