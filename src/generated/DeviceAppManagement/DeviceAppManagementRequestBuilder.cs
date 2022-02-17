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
using Microsoft.Kiota.Cli.Commons.IO;
using System;
using System.Collections.Generic;
using System.CommandLine;
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
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildDefaultManagedAppProtectionsCommand() {
            var command = new Command("default-managed-app-protections");
            var builder = new ApiSdk.DeviceAppManagement.DefaultManagedAppProtections.DefaultManagedAppProtectionsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
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
            command.SetHandler(async (string[] select, string[] expand, FormatterType output, IOutputFormatterFactory outputFormatterFactory, CancellationToken cancellationToken) => {
                var requestInfo = CreateGetRequestInformation(q => {
                    q.Select = select;
                    q.Expand = expand;
                });
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                var formatter = outputFormatterFactory.GetFormatter(output);
                formatter.WriteOutput(response);
            }, selectOption, expandOption, outputOption);
            return command;
        }
        public Command BuildIosManagedAppProtectionsCommand() {
            var command = new Command("ios-managed-app-protections");
            var builder = new ApiSdk.DeviceAppManagement.IosManagedAppProtections.IosManagedAppProtectionsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildManagedAppPoliciesCommand() {
            var command = new Command("managed-app-policies");
            var builder = new ApiSdk.DeviceAppManagement.ManagedAppPolicies.ManagedAppPoliciesRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildManagedAppRegistrationsCommand() {
            var command = new Command("managed-app-registrations");
            var builder = new ApiSdk.DeviceAppManagement.ManagedAppRegistrations.ManagedAppRegistrationsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildManagedAppStatusesCommand() {
            var command = new Command("managed-app-statuses");
            var builder = new ApiSdk.DeviceAppManagement.ManagedAppStatuses.ManagedAppStatusesRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildManagedEBooksCommand() {
            var command = new Command("managed-e-books");
            var builder = new ApiSdk.DeviceAppManagement.ManagedEBooks.ManagedEBooksRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildMdmWindowsInformationProtectionPoliciesCommand() {
            var command = new Command("mdm-windows-information-protection-policies");
            var builder = new ApiSdk.DeviceAppManagement.MdmWindowsInformationProtectionPolicies.MdmWindowsInformationProtectionPoliciesRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildMobileAppCategoriesCommand() {
            var command = new Command("mobile-app-categories");
            var builder = new ApiSdk.DeviceAppManagement.MobileAppCategories.MobileAppCategoriesRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildMobileAppConfigurationsCommand() {
            var command = new Command("mobile-app-configurations");
            var builder = new ApiSdk.DeviceAppManagement.MobileAppConfigurations.MobileAppConfigurationsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildMobileAppsCommand() {
            var command = new Command("mobile-apps");
            var builder = new ApiSdk.DeviceAppManagement.MobileApps.MobileAppsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
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
            var bodyOption = new Option<string>("--body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (string body, IOutputFormatterFactory outputFormatterFactory, CancellationToken cancellationToken) => {
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ApiSdk.Models.Microsoft.Graph.DeviceAppManagement>();
                var requestInfo = CreatePatchRequestInformation(model, q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, bodyOption);
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
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildVppTokensCommand() {
            var command = new Command("vpp-tokens");
            var builder = new ApiSdk.DeviceAppManagement.VppTokens.VppTokensRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildWindowsInformationProtectionPoliciesCommand() {
            var command = new Command("windows-information-protection-policies");
            var builder = new ApiSdk.DeviceAppManagement.WindowsInformationProtectionPolicies.WindowsInformationProtectionPoliciesRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
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
        /// Update deviceAppManagement
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(ApiSdk.Models.Microsoft.Graph.DeviceAppManagement body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// <summary>Get deviceAppManagement</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
