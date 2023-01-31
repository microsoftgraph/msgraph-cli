using ApiSdk.Models;
using ApiSdk.Models.ODataErrors;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
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
    /// <summary>
    /// Provides operations to manage the scheduledActionConfigurations property of the microsoft.graph.deviceComplianceScheduledActionForRule entity.
    /// </summary>
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
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var deviceCompliancePolicyId = invocationContext.ParseResult.GetValueForOption(deviceCompliancePolicyIdOption);
                var deviceComplianceScheduledActionForRuleId = invocationContext.ParseResult.GetValueForOption(deviceComplianceScheduledActionForRuleIdOption);
                var deviceComplianceActionItemId = invocationContext.ParseResult.GetValueForOption(deviceComplianceActionItemIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (deviceCompliancePolicyId is not null) requestInfo.PathParameters.Add("deviceCompliancePolicy%2Did", deviceCompliancePolicyId);
                if (deviceComplianceScheduledActionForRuleId is not null) requestInfo.PathParameters.Add("deviceComplianceScheduledActionForRule%2Did", deviceComplianceScheduledActionForRuleId);
                if (deviceComplianceActionItemId is not null) requestInfo.PathParameters.Add("deviceComplianceActionItem%2Did", deviceComplianceActionItemId);
                if (ifMatch is not null) requestInfo.Headers.Add("If-Match", ifMatch);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            });
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
            command.SetHandler(async (invocationContext) => {
                var deviceCompliancePolicyId = invocationContext.ParseResult.GetValueForOption(deviceCompliancePolicyIdOption);
                var deviceComplianceScheduledActionForRuleId = invocationContext.ParseResult.GetValueForOption(deviceComplianceScheduledActionForRuleIdOption);
                var deviceComplianceActionItemId = invocationContext.ParseResult.GetValueForOption(deviceComplianceActionItemIdOption);
                var select = invocationContext.ParseResult.GetValueForOption(selectOption);
                var expand = invocationContext.ParseResult.GetValueForOption(expandOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                var jsonNoIndent = invocationContext.ParseResult.GetValueForOption(jsonNoIndentOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetRequiredService<IOutputFilter>();
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetRequiredService<IOutputFormatterFactory>();
                var cancellationToken = invocationContext.GetCancellationToken();
                var requestInfo = ToGetRequestInformation(q => {
                    q.QueryParameters.Select = select;
                    q.QueryParameters.Expand = expand;
                });
                if (deviceCompliancePolicyId is not null) requestInfo.PathParameters.Add("deviceCompliancePolicy%2Did", deviceCompliancePolicyId);
                if (deviceComplianceScheduledActionForRuleId is not null) requestInfo.PathParameters.Add("deviceComplianceScheduledActionForRule%2Did", deviceComplianceScheduledActionForRuleId);
                if (deviceComplianceActionItemId is not null) requestInfo.PathParameters.Add("deviceComplianceActionItem%2Did", deviceComplianceActionItemId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response is not null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatterOptions = output.GetOutputFormatterOptions(new FormatterOptionsModel(!jsonNoIndent));
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, formatterOptions, cancellationToken);
            });
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
            command.SetHandler(async (invocationContext) => {
                var deviceCompliancePolicyId = invocationContext.ParseResult.GetValueForOption(deviceCompliancePolicyIdOption);
                var deviceComplianceScheduledActionForRuleId = invocationContext.ParseResult.GetValueForOption(deviceComplianceScheduledActionForRuleIdOption);
                var deviceComplianceActionItemId = invocationContext.ParseResult.GetValueForOption(deviceComplianceActionItemIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                var jsonNoIndent = invocationContext.ParseResult.GetValueForOption(jsonNoIndentOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetRequiredService<IOutputFilter>();
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetRequiredService<IOutputFormatterFactory>();
                var cancellationToken = invocationContext.GetCancellationToken();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<DeviceComplianceActionItem>(DeviceComplianceActionItem.CreateFromDiscriminatorValue);
                if (model is null) return; // Cannot create a POST request from a null model.
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (deviceCompliancePolicyId is not null) requestInfo.PathParameters.Add("deviceCompliancePolicy%2Did", deviceCompliancePolicyId);
                if (deviceComplianceScheduledActionForRuleId is not null) requestInfo.PathParameters.Add("deviceComplianceScheduledActionForRule%2Did", deviceComplianceScheduledActionForRuleId);
                if (deviceComplianceActionItemId is not null) requestInfo.PathParameters.Add("deviceComplianceActionItem%2Did", deviceComplianceActionItemId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response is not null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatterOptions = output.GetOutputFormatterOptions(new FormatterOptionsModel(!jsonNoIndent));
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, formatterOptions, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new DeviceComplianceActionItemItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
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
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<DeviceComplianceActionItemItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<DeviceComplianceActionItemItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new DeviceComplianceActionItemItemRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// The list of scheduled action configurations for this compliance policy. Compliance policy must have one and only one block scheduled action.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<DeviceComplianceActionItemItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<DeviceComplianceActionItemItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new DeviceComplianceActionItemItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property scheduledActionConfigurations in deviceManagement
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(DeviceComplianceActionItem? body, Action<DeviceComplianceActionItemItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(DeviceComplianceActionItem body, Action<DeviceComplianceActionItemItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new DeviceComplianceActionItemItemRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class DeviceComplianceActionItemItemRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new DeviceComplianceActionItemItemRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public DeviceComplianceActionItemItemRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// The list of scheduled action configurations for this compliance policy. Compliance policy must have one and only one block scheduled action.
        /// </summary>
        public class DeviceComplianceActionItemItemRequestBuilderGetQueryParameters {
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class DeviceComplianceActionItemItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public DeviceComplianceActionItemItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new DeviceComplianceActionItemItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new DeviceComplianceActionItemItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public DeviceComplianceActionItemItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class DeviceComplianceActionItemItemRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new DeviceComplianceActionItemItemRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public DeviceComplianceActionItemItemRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
