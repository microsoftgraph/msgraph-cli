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
namespace ApiSdk.DeviceAppManagement.TargetedManagedAppConfigurations.Item.Assignments.Item {
    /// <summary>Builds and executes requests for operations under \deviceAppManagement\targetedManagedAppConfigurations\{targetedManagedAppConfiguration-id}\assignments\{targetedManagedAppPolicyAssignment-id}</summary>
    public class TargetedManagedAppPolicyAssignmentItemRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Navigation property to list of inclusion and exclusion groups to which the policy is deployed.
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Navigation property to list of inclusion and exclusion groups to which the policy is deployed.";
            // Create options for all the parameters
            var targetedManagedAppConfigurationIdOption = new Option<string>("--targeted-managed-app-configuration-id", description: "key: id of targetedManagedAppConfiguration") {
            };
            targetedManagedAppConfigurationIdOption.IsRequired = true;
            command.AddOption(targetedManagedAppConfigurationIdOption);
            var targetedManagedAppPolicyAssignmentIdOption = new Option<string>("--targeted-managed-app-policy-assignment-id", description: "key: id of targetedManagedAppPolicyAssignment") {
            };
            targetedManagedAppPolicyAssignmentIdOption.IsRequired = true;
            command.AddOption(targetedManagedAppPolicyAssignmentIdOption);
            command.SetHandler(async (object[] parameters) => {
                var targetedManagedAppConfigurationId = (string) parameters[0];
                var targetedManagedAppPolicyAssignmentId = (string) parameters[1];
                var outputFormatterFactory = (IOutputFormatterFactory) parameters[2];
                var cancellationToken = (CancellationToken) parameters[3];
                PathParameters.Clear();
                PathParameters.Add("targetedManagedAppConfiguration_id", targetedManagedAppConfigurationId);
                PathParameters.Add("targetedManagedAppPolicyAssignment_id", targetedManagedAppPolicyAssignmentId);
                var requestInfo = CreateDeleteRequestInformation(q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(targetedManagedAppConfigurationIdOption, targetedManagedAppPolicyAssignmentIdOption, new TypeBinding(typeof(IOutputFormatterFactory)), new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// Navigation property to list of inclusion and exclusion groups to which the policy is deployed.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Navigation property to list of inclusion and exclusion groups to which the policy is deployed.";
            // Create options for all the parameters
            var targetedManagedAppConfigurationIdOption = new Option<string>("--targeted-managed-app-configuration-id", description: "key: id of targetedManagedAppConfiguration") {
            };
            targetedManagedAppConfigurationIdOption.IsRequired = true;
            command.AddOption(targetedManagedAppConfigurationIdOption);
            var targetedManagedAppPolicyAssignmentIdOption = new Option<string>("--targeted-managed-app-policy-assignment-id", description: "key: id of targetedManagedAppPolicyAssignment") {
            };
            targetedManagedAppPolicyAssignmentIdOption.IsRequired = true;
            command.AddOption(targetedManagedAppPolicyAssignmentIdOption);
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
                var targetedManagedAppConfigurationId = (string) parameters[0];
                var targetedManagedAppPolicyAssignmentId = (string) parameters[1];
                var select = (string[]) parameters[2];
                var expand = (string[]) parameters[3];
                var output = (FormatterType) parameters[4];
                var outputFormatterFactory = (IOutputFormatterFactory) parameters[5];
                var cancellationToken = (CancellationToken) parameters[6];
                PathParameters.Clear();
                PathParameters.Add("targetedManagedAppConfiguration_id", targetedManagedAppConfigurationId);
                PathParameters.Add("targetedManagedAppPolicyAssignment_id", targetedManagedAppPolicyAssignmentId);
                var requestInfo = CreateGetRequestInformation(q => {
                    q.Select = select;
                    q.Expand = expand;
                });
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                var formatter = outputFormatterFactory.GetFormatter(output);
                formatter.WriteOutput(response);
            }, new CollectionBinding(targetedManagedAppConfigurationIdOption, targetedManagedAppPolicyAssignmentIdOption, selectOption, expandOption, outputOption, new TypeBinding(typeof(IOutputFormatterFactory)), new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// Navigation property to list of inclusion and exclusion groups to which the policy is deployed.
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Navigation property to list of inclusion and exclusion groups to which the policy is deployed.";
            // Create options for all the parameters
            var targetedManagedAppConfigurationIdOption = new Option<string>("--targeted-managed-app-configuration-id", description: "key: id of targetedManagedAppConfiguration") {
            };
            targetedManagedAppConfigurationIdOption.IsRequired = true;
            command.AddOption(targetedManagedAppConfigurationIdOption);
            var targetedManagedAppPolicyAssignmentIdOption = new Option<string>("--targeted-managed-app-policy-assignment-id", description: "key: id of targetedManagedAppPolicyAssignment") {
            };
            targetedManagedAppPolicyAssignmentIdOption.IsRequired = true;
            command.AddOption(targetedManagedAppPolicyAssignmentIdOption);
            var bodyOption = new Option<string>("--body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (object[] parameters) => {
                var targetedManagedAppConfigurationId = (string) parameters[0];
                var targetedManagedAppPolicyAssignmentId = (string) parameters[1];
                var body = (string) parameters[2];
                var outputFormatterFactory = (IOutputFormatterFactory) parameters[3];
                var cancellationToken = (CancellationToken) parameters[4];
                PathParameters.Clear();
                PathParameters.Add("targetedManagedAppConfiguration_id", targetedManagedAppConfigurationId);
                PathParameters.Add("targetedManagedAppPolicyAssignment_id", targetedManagedAppPolicyAssignmentId);
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<TargetedManagedAppPolicyAssignment>();
                var requestInfo = CreatePatchRequestInformation(model, q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(targetedManagedAppConfigurationIdOption, targetedManagedAppPolicyAssignmentIdOption, bodyOption, new TypeBinding(typeof(IOutputFormatterFactory)), new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// Instantiates a new TargetedManagedAppPolicyAssignmentItemRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public TargetedManagedAppPolicyAssignmentItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceAppManagement/targetedManagedAppConfigurations/{targetedManagedAppConfiguration_id}/assignments/{targetedManagedAppPolicyAssignment_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Navigation property to list of inclusion and exclusion groups to which the policy is deployed.
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
        /// Navigation property to list of inclusion and exclusion groups to which the policy is deployed.
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
        /// Navigation property to list of inclusion and exclusion groups to which the policy is deployed.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(TargetedManagedAppPolicyAssignment body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// <summary>Navigation property to list of inclusion and exclusion groups to which the policy is deployed.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
