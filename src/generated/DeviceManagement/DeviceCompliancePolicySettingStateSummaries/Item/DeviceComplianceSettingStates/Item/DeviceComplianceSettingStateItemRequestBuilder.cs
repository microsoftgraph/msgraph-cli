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
namespace ApiSdk.DeviceManagement.DeviceCompliancePolicySettingStateSummaries.Item.DeviceComplianceSettingStates.Item {
    /// <summary>Builds and executes requests for operations under \deviceManagement\deviceCompliancePolicySettingStateSummaries\{deviceCompliancePolicySettingStateSummary-id}\deviceComplianceSettingStates\{deviceComplianceSettingState-id}</summary>
    public class DeviceComplianceSettingStateItemRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Not yet documented
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Not yet documented";
            // Create options for all the parameters
            var deviceCompliancePolicySettingStateSummaryIdOption = new Option<string>("--device-compliance-policy-setting-state-summary-id", description: "key: id of deviceCompliancePolicySettingStateSummary") {
            };
            deviceCompliancePolicySettingStateSummaryIdOption.IsRequired = true;
            command.AddOption(deviceCompliancePolicySettingStateSummaryIdOption);
            var deviceComplianceSettingStateIdOption = new Option<string>("--device-compliance-setting-state-id", description: "key: id of deviceComplianceSettingState") {
            };
            deviceComplianceSettingStateIdOption.IsRequired = true;
            command.AddOption(deviceComplianceSettingStateIdOption);
            command.SetHandler(async (object[] parameters) => {
                var deviceCompliancePolicySettingStateSummaryId = (string) parameters[0];
                var deviceComplianceSettingStateId = (string) parameters[1];
                var outputFormatterFactory = (IOutputFormatterFactory) parameters[2];
                var cancellationToken = (CancellationToken) parameters[3];
                PathParameters.Clear();
                PathParameters.Add("deviceCompliancePolicySettingStateSummary_id", deviceCompliancePolicySettingStateSummaryId);
                PathParameters.Add("deviceComplianceSettingState_id", deviceComplianceSettingStateId);
                var requestInfo = CreateDeleteRequestInformation(q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(deviceCompliancePolicySettingStateSummaryIdOption, deviceComplianceSettingStateIdOption, new TypeBinding(typeof(IOutputFormatterFactory)), new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// Not yet documented
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Not yet documented";
            // Create options for all the parameters
            var deviceCompliancePolicySettingStateSummaryIdOption = new Option<string>("--device-compliance-policy-setting-state-summary-id", description: "key: id of deviceCompliancePolicySettingStateSummary") {
            };
            deviceCompliancePolicySettingStateSummaryIdOption.IsRequired = true;
            command.AddOption(deviceCompliancePolicySettingStateSummaryIdOption);
            var deviceComplianceSettingStateIdOption = new Option<string>("--device-compliance-setting-state-id", description: "key: id of deviceComplianceSettingState") {
            };
            deviceComplianceSettingStateIdOption.IsRequired = true;
            command.AddOption(deviceComplianceSettingStateIdOption);
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
            command.SetHandler(async (object[] parameters) => {
                var deviceCompliancePolicySettingStateSummaryId = (string) parameters[0];
                var deviceComplianceSettingStateId = (string) parameters[1];
                var select = (string[]) parameters[2];
                var expand = (string[]) parameters[3];
                var output = (FormatterType) parameters[4];
                var outputFormatterFactory = (IOutputFormatterFactory) parameters[5];
                var cancellationToken = (CancellationToken) parameters[6];
                PathParameters.Clear();
                PathParameters.Add("deviceCompliancePolicySettingStateSummary_id", deviceCompliancePolicySettingStateSummaryId);
                PathParameters.Add("deviceComplianceSettingState_id", deviceComplianceSettingStateId);
                var requestInfo = CreateGetRequestInformation(q => {
                    q.Select = select;
                    q.Expand = expand;
                });
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                var formatter = outputFormatterFactory.GetFormatter(output);
                formatter.WriteOutput(response);
            }, new CollectionBinding(deviceCompliancePolicySettingStateSummaryIdOption, deviceComplianceSettingStateIdOption, selectOption, expandOption, outputOption, new TypeBinding(typeof(IOutputFormatterFactory)), new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// Not yet documented
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Not yet documented";
            // Create options for all the parameters
            var deviceCompliancePolicySettingStateSummaryIdOption = new Option<string>("--device-compliance-policy-setting-state-summary-id", description: "key: id of deviceCompliancePolicySettingStateSummary") {
            };
            deviceCompliancePolicySettingStateSummaryIdOption.IsRequired = true;
            command.AddOption(deviceCompliancePolicySettingStateSummaryIdOption);
            var deviceComplianceSettingStateIdOption = new Option<string>("--device-compliance-setting-state-id", description: "key: id of deviceComplianceSettingState") {
            };
            deviceComplianceSettingStateIdOption.IsRequired = true;
            command.AddOption(deviceComplianceSettingStateIdOption);
            var bodyOption = new Option<string>("--body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (object[] parameters) => {
                var deviceCompliancePolicySettingStateSummaryId = (string) parameters[0];
                var deviceComplianceSettingStateId = (string) parameters[1];
                var body = (string) parameters[2];
                var outputFormatterFactory = (IOutputFormatterFactory) parameters[3];
                var cancellationToken = (CancellationToken) parameters[4];
                PathParameters.Clear();
                PathParameters.Add("deviceCompliancePolicySettingStateSummary_id", deviceCompliancePolicySettingStateSummaryId);
                PathParameters.Add("deviceComplianceSettingState_id", deviceComplianceSettingStateId);
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<DeviceComplianceSettingState>();
                var requestInfo = CreatePatchRequestInformation(model, q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(deviceCompliancePolicySettingStateSummaryIdOption, deviceComplianceSettingStateIdOption, bodyOption, new TypeBinding(typeof(IOutputFormatterFactory)), new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// Instantiates a new DeviceComplianceSettingStateItemRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public DeviceComplianceSettingStateItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/deviceCompliancePolicySettingStateSummaries/{deviceCompliancePolicySettingStateSummary_id}/deviceComplianceSettingStates/{deviceComplianceSettingState_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Not yet documented
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
        /// Not yet documented
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
        /// Not yet documented
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(DeviceComplianceSettingState body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// <summary>Not yet documented</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
