using ApiSdk.DeviceAppManagement.ManagedAppRegistrations.Item.AppliedPolicies.Item.ManagedAppProtection;
using ApiSdk.DeviceAppManagement.ManagedAppRegistrations.Item.AppliedPolicies.Item.TargetApps;
using ApiSdk.DeviceAppManagement.ManagedAppRegistrations.Item.AppliedPolicies.Item.TargetedManagedAppProtection;
using ApiSdk.DeviceAppManagement.ManagedAppRegistrations.Item.AppliedPolicies.Item.WindowsInformationProtection;
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
namespace ApiSdk.DeviceAppManagement.ManagedAppRegistrations.Item.AppliedPolicies.Item {
    /// <summary>Builds and executes requests for operations under \deviceAppManagement\managedAppRegistrations\{managedAppRegistration-id}\appliedPolicies\{managedAppPolicy-id}</summary>
    public class ManagedAppPolicyRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Zero or more policys already applied on the registered app when it last synchronized with managment service.
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            // Create options for all the parameters
            command.AddOption(new Option<string>("--managedappregistration-id", description: "key: id of managedAppRegistration"));
            command.AddOption(new Option<string>("--managedapppolicy-id", description: "key: id of managedAppPolicy"));
            command.Handler = CommandHandler.Create<string, string>(async (managedAppRegistrationId, managedAppPolicyId) => {
                var requestInfo = CreateDeleteRequestInformation();
                if (!String.IsNullOrEmpty(managedAppRegistrationId)) requestInfo.PathParameters.Add("managedAppRegistration_id", managedAppRegistrationId);
                if (!String.IsNullOrEmpty(managedAppPolicyId)) requestInfo.PathParameters.Add("managedAppPolicy_id", managedAppPolicyId);
                await RequestAdapter.SendNoContentAsync(requestInfo);
                // Print request output. What if the request has no return?
                Console.WriteLine("Success");
            });
            return command;
        }
        /// <summary>
        /// Zero or more policys already applied on the registered app when it last synchronized with managment service.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            // Create options for all the parameters
            command.AddOption(new Option<string>("--managedappregistration-id", description: "key: id of managedAppRegistration"));
            command.AddOption(new Option<string>("--managedapppolicy-id", description: "key: id of managedAppPolicy"));
            command.AddOption(new Option<object>("--select", description: "Select properties to be returned"));
            command.AddOption(new Option<object>("--expand", description: "Expand related entities"));
            command.Handler = CommandHandler.Create<string, string, object, object>(async (managedAppRegistrationId, managedAppPolicyId, select, expand) => {
                var requestInfo = CreateGetRequestInformation();
                if (!String.IsNullOrEmpty(managedAppRegistrationId)) requestInfo.PathParameters.Add("managedAppRegistration_id", managedAppRegistrationId);
                if (!String.IsNullOrEmpty(managedAppPolicyId)) requestInfo.PathParameters.Add("managedAppPolicy_id", managedAppPolicyId);
                requestInfo.QueryParameters.Add("select", select);
                requestInfo.QueryParameters.Add("expand", expand);
                var result = await RequestAdapter.SendAsync<ManagedAppPolicy>(requestInfo);
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
        public Command BuildManagedAppProtectionCommand() {
            var command = new Command("managed-app-protection");
            var builder = new ApiSdk.DeviceAppManagement.ManagedAppRegistrations.Item.AppliedPolicies.Item.ManagedAppProtection.ManagedAppProtectionRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildTargetAppsCommand());
            return command;
        }
        /// <summary>
        /// Zero or more policys already applied on the registered app when it last synchronized with managment service.
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            // Create options for all the parameters
            command.AddOption(new Option<string>("--managedappregistration-id", description: "key: id of managedAppRegistration"));
            command.AddOption(new Option<string>("--managedapppolicy-id", description: "key: id of managedAppPolicy"));
            command.AddOption(new Option<string>("--body"));
            command.Handler = CommandHandler.Create<string, string, string>(async (managedAppRegistrationId, managedAppPolicyId, body) => {
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ManagedAppPolicy>();
                var requestInfo = CreatePatchRequestInformation(model);
                if (!String.IsNullOrEmpty(managedAppRegistrationId)) requestInfo.PathParameters.Add("managedAppRegistration_id", managedAppRegistrationId);
                if (!String.IsNullOrEmpty(managedAppPolicyId)) requestInfo.PathParameters.Add("managedAppPolicy_id", managedAppPolicyId);
                await RequestAdapter.SendNoContentAsync(requestInfo);
                // Print request output. What if the request has no return?
                Console.WriteLine("Success");
            });
            return command;
        }
        public Command BuildTargetAppsCommand() {
            var command = new Command("target-apps");
            var builder = new ApiSdk.DeviceAppManagement.ManagedAppRegistrations.Item.AppliedPolicies.Item.TargetApps.TargetAppsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildTargetedManagedAppProtectionCommand() {
            var command = new Command("targeted-managed-app-protection");
            var builder = new ApiSdk.DeviceAppManagement.ManagedAppRegistrations.Item.AppliedPolicies.Item.TargetedManagedAppProtection.TargetedManagedAppProtectionRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildAssignCommand());
            command.AddCommand(builder.BuildTargetAppsCommand());
            return command;
        }
        public Command BuildWindowsInformationProtectionCommand() {
            var command = new Command("windows-information-protection");
            var builder = new ApiSdk.DeviceAppManagement.ManagedAppRegistrations.Item.AppliedPolicies.Item.WindowsInformationProtection.WindowsInformationProtectionRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildAssignCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new ManagedAppPolicyRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public ManagedAppPolicyRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceAppManagement/managedAppRegistrations/{managedAppRegistration_id}/appliedPolicies/{managedAppPolicy_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Zero or more policys already applied on the registered app when it last synchronized with managment service.
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
        /// Zero or more policys already applied on the registered app when it last synchronized with managment service.
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
        /// Zero or more policys already applied on the registered app when it last synchronized with managment service.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(ManagedAppPolicy body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// Zero or more policys already applied on the registered app when it last synchronized with managment service.
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
        /// Zero or more policys already applied on the registered app when it last synchronized with managment service.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<ManagedAppPolicy> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<ManagedAppPolicy>(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>
        /// Zero or more policys already applied on the registered app when it last synchronized with managment service.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="model"></param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(ManagedAppPolicy model, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = model ?? throw new ArgumentNullException(nameof(model));
            var requestInfo = CreatePatchRequestInformation(model, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>Zero or more policys already applied on the registered app when it last synchronized with managment service.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
