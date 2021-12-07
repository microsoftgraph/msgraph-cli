using ApiSdk.DeviceAppManagement.AndroidManagedAppProtections;
using ApiSdk.DeviceAppManagement.DefaultManagedAppProtections;
using ApiSdk.DeviceAppManagement.IosManagedAppProtections;
using ApiSdk.DeviceAppManagement.ManagedAppPolicies;
using ApiSdk.DeviceAppManagement.ManagedAppRegistrations;
using ApiSdk.DeviceAppManagement.ManagedAppStatuses;
using ApiSdk.DeviceAppManagement.ManagedEBooks;
using ApiSdk.DeviceAppManagement.MdmWindowsInformationProtectionPolicies;
using ApiSdk.DeviceAppManagement.MobileAppCategories;
using ApiSdk.DeviceAppManagement.MobileAppConfigurations;
using ApiSdk.DeviceAppManagement.MobileApps;
using ApiSdk.DeviceAppManagement.SyncMicrosoftStoreForBusinessApps;
using ApiSdk.DeviceAppManagement.TargetedManagedAppConfigurations;
using ApiSdk.DeviceAppManagement.VppTokens;
using ApiSdk.DeviceAppManagement.WindowsInformationProtectionPolicies;
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
namespace ApiSdk.DeviceAppManagement {
    /// <summary>Builds and executes requests for operations under \deviceAppManagement</summary>
    public class DeviceAppManagementRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public Command BuildAndroidManagedAppProtectionsCommand() {
            var command = new Command("android-managed-app-protections");
            var builder = new ApiSdk.DeviceAppManagement.AndroidManagedAppProtections.AndroidManagedAppProtectionsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildDefaultManagedAppProtectionsCommand() {
            var command = new Command("default-managed-app-protections");
            var builder = new ApiSdk.DeviceAppManagement.DefaultManagedAppProtections.DefaultManagedAppProtectionsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Get deviceAppManagement
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Get deviceAppManagement";
            // Create options for all the parameters
            command.AddOption(new Option<object>("--select", description: "Select properties to be returned"));
            command.AddOption(new Option<object>("--expand", description: "Expand related entities"));
            command.Handler = CommandHandler.Create<object, object>(async (select, expand) => {
                var requestInfo = CreateGetRequestInformation();
                requestInfo.QueryParameters.Add("select", select);
                requestInfo.QueryParameters.Add("expand", expand);
                var result = await RequestAdapter.SendAsync<ApiSdk.Models.Microsoft.Graph.DeviceAppManagement>(requestInfo);
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
        public Command BuildIosManagedAppProtectionsCommand() {
            var command = new Command("ios-managed-app-protections");
            var builder = new ApiSdk.DeviceAppManagement.IosManagedAppProtections.IosManagedAppProtectionsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildManagedAppPoliciesCommand() {
            var command = new Command("managed-app-policies");
            var builder = new ApiSdk.DeviceAppManagement.ManagedAppPolicies.ManagedAppPoliciesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildManagedAppRegistrationsCommand() {
            var command = new Command("managed-app-registrations");
            var builder = new ApiSdk.DeviceAppManagement.ManagedAppRegistrations.ManagedAppRegistrationsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildManagedAppStatusesCommand() {
            var command = new Command("managed-app-statuses");
            var builder = new ApiSdk.DeviceAppManagement.ManagedAppStatuses.ManagedAppStatusesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildManagedEBooksCommand() {
            var command = new Command("managed-e-books");
            var builder = new ApiSdk.DeviceAppManagement.ManagedEBooks.ManagedEBooksRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildMdmWindowsInformationProtectionPoliciesCommand() {
            var command = new Command("mdm-windows-information-protection-policies");
            var builder = new ApiSdk.DeviceAppManagement.MdmWindowsInformationProtectionPolicies.MdmWindowsInformationProtectionPoliciesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildMobileAppCategoriesCommand() {
            var command = new Command("mobile-app-categories");
            var builder = new ApiSdk.DeviceAppManagement.MobileAppCategories.MobileAppCategoriesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildMobileAppConfigurationsCommand() {
            var command = new Command("mobile-app-configurations");
            var builder = new ApiSdk.DeviceAppManagement.MobileAppConfigurations.MobileAppConfigurationsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildMobileAppsCommand() {
            var command = new Command("mobile-apps");
            var builder = new ApiSdk.DeviceAppManagement.MobileApps.MobileAppsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Update deviceAppManagement
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Update deviceAppManagement";
            // Create options for all the parameters
            command.AddOption(new Option<string>("--body"));
            command.Handler = CommandHandler.Create<string>(async (body) => {
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ApiSdk.Models.Microsoft.Graph.DeviceAppManagement>();
                var requestInfo = CreatePatchRequestInformation(model);
                await RequestAdapter.SendNoContentAsync(requestInfo);
                // Print request output. What if the request has no return?
                Console.WriteLine("Success");
            });
            return command;
        }
        public Command BuildSyncMicrosoftStoreForBusinessAppsCommand() {
            var command = new Command("sync-microsoft-store-for-business-apps");
            var builder = new ApiSdk.DeviceAppManagement.SyncMicrosoftStoreForBusinessApps.SyncMicrosoftStoreForBusinessAppsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildTargetedManagedAppConfigurationsCommand() {
            var command = new Command("targeted-managed-app-configurations");
            var builder = new ApiSdk.DeviceAppManagement.TargetedManagedAppConfigurations.TargetedManagedAppConfigurationsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildVppTokensCommand() {
            var command = new Command("vpp-tokens");
            var builder = new ApiSdk.DeviceAppManagement.VppTokens.VppTokensRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildWindowsInformationProtectionPoliciesCommand() {
            var command = new Command("windows-information-protection-policies");
            var builder = new ApiSdk.DeviceAppManagement.WindowsInformationProtectionPolicies.WindowsInformationProtectionPoliciesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new DeviceAppManagementRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public DeviceAppManagementRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceAppManagement{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Get deviceAppManagement
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
        /// Update deviceAppManagement
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(ApiSdk.Models.Microsoft.Graph.DeviceAppManagement body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// Get deviceAppManagement
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<ApiSdk.Models.Microsoft.Graph.DeviceAppManagement> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<ApiSdk.Models.Microsoft.Graph.DeviceAppManagement>(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>
        /// Update deviceAppManagement
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="model"></param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(ApiSdk.Models.Microsoft.Graph.DeviceAppManagement model, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = model ?? throw new ArgumentNullException(nameof(model));
            var requestInfo = CreatePatchRequestInformation(model, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>Get deviceAppManagement</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
