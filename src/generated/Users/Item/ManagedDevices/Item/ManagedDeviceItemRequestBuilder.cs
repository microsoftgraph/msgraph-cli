using ApiSdk.Models;
using ApiSdk.Models.ODataErrors;
using ApiSdk.Users.Item.ManagedDevices.Item.DeviceCategory;
using ApiSdk.Users.Item.ManagedDevices.Item.DeviceCompliancePolicyStates;
using ApiSdk.Users.Item.ManagedDevices.Item.DeviceConfigurationStates;
using ApiSdk.Users.Item.ManagedDevices.Item.MicrosoftGraphBypassActivationLock;
using ApiSdk.Users.Item.ManagedDevices.Item.MicrosoftGraphCleanWindowsDevice;
using ApiSdk.Users.Item.ManagedDevices.Item.MicrosoftGraphDeleteUserFromSharedAppleDevice;
using ApiSdk.Users.Item.ManagedDevices.Item.MicrosoftGraphDisableLostMode;
using ApiSdk.Users.Item.ManagedDevices.Item.MicrosoftGraphLocateDevice;
using ApiSdk.Users.Item.ManagedDevices.Item.MicrosoftGraphLogoutSharedAppleDeviceActiveUser;
using ApiSdk.Users.Item.ManagedDevices.Item.MicrosoftGraphRebootNow;
using ApiSdk.Users.Item.ManagedDevices.Item.MicrosoftGraphRecoverPasscode;
using ApiSdk.Users.Item.ManagedDevices.Item.MicrosoftGraphRemoteLock;
using ApiSdk.Users.Item.ManagedDevices.Item.MicrosoftGraphRequestRemoteAssistance;
using ApiSdk.Users.Item.ManagedDevices.Item.MicrosoftGraphResetPasscode;
using ApiSdk.Users.Item.ManagedDevices.Item.MicrosoftGraphRetire;
using ApiSdk.Users.Item.ManagedDevices.Item.MicrosoftGraphShutDown;
using ApiSdk.Users.Item.ManagedDevices.Item.MicrosoftGraphSyncDevice;
using ApiSdk.Users.Item.ManagedDevices.Item.MicrosoftGraphUpdateWindowsDeviceAccount;
using ApiSdk.Users.Item.ManagedDevices.Item.MicrosoftGraphWindowsDefenderScan;
using ApiSdk.Users.Item.ManagedDevices.Item.MicrosoftGraphWindowsDefenderUpdateSignatures;
using ApiSdk.Users.Item.ManagedDevices.Item.MicrosoftGraphWipe;
using ApiSdk.Users.Item.ManagedDevices.Item.Users;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Cli.Commons.Extensions;
using Microsoft.Kiota.Cli.Commons.IO;
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace ApiSdk.Users.Item.ManagedDevices.Item {
    /// <summary>
    /// Provides operations to manage the managedDevices property of the microsoft.graph.user entity.
    /// </summary>
    public class ManagedDeviceItemRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Delete navigation property managedDevices for users
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Delete navigation property managedDevices for users";
            // Create options for all the parameters
            var userIdOption = new Option<string>("--user-id", description: "key: id of user") {
            };
            userIdOption.IsRequired = true;
            command.AddOption(userIdOption);
            var managedDeviceIdOption = new Option<string>("--managed-device-id", description: "key: id of managedDevice") {
            };
            managedDeviceIdOption.IsRequired = true;
            command.AddOption(managedDeviceIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var userId = invocationContext.ParseResult.GetValueForOption(userIdOption);
                var managedDeviceId = invocationContext.ParseResult.GetValueForOption(managedDeviceIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (userId is not null) requestInfo.PathParameters.Add("user%2Did", userId);
                if (managedDeviceId is not null) requestInfo.PathParameters.Add("managedDevice%2Did", managedDeviceId);
                if (ifMatch is not null) requestInfo.Headers.Add("If-Match", ifMatch);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                await reqAdapter.SendNoContentAsync(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            });
            return command;
        }
        /// <summary>
        /// Provides operations to manage the deviceCategory property of the microsoft.graph.managedDevice entity.
        /// </summary>
        public Command BuildDeviceCategoryCommand() {
            var command = new Command("device-category");
            command.Description = "Provides operations to manage the deviceCategory property of the microsoft.graph.managedDevice entity.";
            var builder = new DeviceCategoryRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the deviceCompliancePolicyStates property of the microsoft.graph.managedDevice entity.
        /// </summary>
        public Command BuildDeviceCompliancePolicyStatesCommand() {
            var command = new Command("device-compliance-policy-states");
            command.Description = "Provides operations to manage the deviceCompliancePolicyStates property of the microsoft.graph.managedDevice entity.";
            var builder = new DeviceCompliancePolicyStatesRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the deviceConfigurationStates property of the microsoft.graph.managedDevice entity.
        /// </summary>
        public Command BuildDeviceConfigurationStatesCommand() {
            var command = new Command("device-configuration-states");
            command.Description = "Provides operations to manage the deviceConfigurationStates property of the microsoft.graph.managedDevice entity.";
            var builder = new DeviceConfigurationStatesRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// The managed devices associated with the user.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "The managed devices associated with the user.";
            // Create options for all the parameters
            var userIdOption = new Option<string>("--user-id", description: "key: id of user") {
            };
            userIdOption.IsRequired = true;
            command.AddOption(userIdOption);
            var managedDeviceIdOption = new Option<string>("--managed-device-id", description: "key: id of managedDevice") {
            };
            managedDeviceIdOption.IsRequired = true;
            command.AddOption(managedDeviceIdOption);
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
                var userId = invocationContext.ParseResult.GetValueForOption(userIdOption);
                var managedDeviceId = invocationContext.ParseResult.GetValueForOption(managedDeviceIdOption);
                var select = invocationContext.ParseResult.GetValueForOption(selectOption);
                var expand = invocationContext.ParseResult.GetValueForOption(expandOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                var jsonNoIndent = invocationContext.ParseResult.GetValueForOption(jsonNoIndentOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetRequiredService<IOutputFilter>();
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetRequiredService<IOutputFormatterFactory>();
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                    q.QueryParameters.Select = select;
                    q.QueryParameters.Expand = expand;
                });
                if (userId is not null) requestInfo.PathParameters.Add("user%2Did", userId);
                if (managedDeviceId is not null) requestInfo.PathParameters.Add("managedDevice%2Did", managedDeviceId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatterOptions = output.GetOutputFormatterOptions(new FormatterOptionsModel(!jsonNoIndent));
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, formatterOptions, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Provides operations to call the bypassActivationLock method.
        /// </summary>
        public Command BuildMicrosoftGraphBypassActivationLockCommand() {
            var command = new Command("microsoft-graph-bypass-activation-lock");
            command.Description = "Provides operations to call the bypassActivationLock method.";
            var builder = new MicrosoftGraphBypassActivationLockRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the cleanWindowsDevice method.
        /// </summary>
        public Command BuildMicrosoftGraphCleanWindowsDeviceCommand() {
            var command = new Command("microsoft-graph-clean-windows-device");
            command.Description = "Provides operations to call the cleanWindowsDevice method.";
            var builder = new MicrosoftGraphCleanWindowsDeviceRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the deleteUserFromSharedAppleDevice method.
        /// </summary>
        public Command BuildMicrosoftGraphDeleteUserFromSharedAppleDeviceCommand() {
            var command = new Command("microsoft-graph-delete-user-from-shared-apple-device");
            command.Description = "Provides operations to call the deleteUserFromSharedAppleDevice method.";
            var builder = new MicrosoftGraphDeleteUserFromSharedAppleDeviceRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the disableLostMode method.
        /// </summary>
        public Command BuildMicrosoftGraphDisableLostModeCommand() {
            var command = new Command("microsoft-graph-disable-lost-mode");
            command.Description = "Provides operations to call the disableLostMode method.";
            var builder = new MicrosoftGraphDisableLostModeRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the locateDevice method.
        /// </summary>
        public Command BuildMicrosoftGraphLocateDeviceCommand() {
            var command = new Command("microsoft-graph-locate-device");
            command.Description = "Provides operations to call the locateDevice method.";
            var builder = new MicrosoftGraphLocateDeviceRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the logoutSharedAppleDeviceActiveUser method.
        /// </summary>
        public Command BuildMicrosoftGraphLogoutSharedAppleDeviceActiveUserCommand() {
            var command = new Command("microsoft-graph-logout-shared-apple-device-active-user");
            command.Description = "Provides operations to call the logoutSharedAppleDeviceActiveUser method.";
            var builder = new MicrosoftGraphLogoutSharedAppleDeviceActiveUserRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the rebootNow method.
        /// </summary>
        public Command BuildMicrosoftGraphRebootNowCommand() {
            var command = new Command("microsoft-graph-reboot-now");
            command.Description = "Provides operations to call the rebootNow method.";
            var builder = new MicrosoftGraphRebootNowRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the recoverPasscode method.
        /// </summary>
        public Command BuildMicrosoftGraphRecoverPasscodeCommand() {
            var command = new Command("microsoft-graph-recover-passcode");
            command.Description = "Provides operations to call the recoverPasscode method.";
            var builder = new MicrosoftGraphRecoverPasscodeRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the remoteLock method.
        /// </summary>
        public Command BuildMicrosoftGraphRemoteLockCommand() {
            var command = new Command("microsoft-graph-remote-lock");
            command.Description = "Provides operations to call the remoteLock method.";
            var builder = new MicrosoftGraphRemoteLockRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the requestRemoteAssistance method.
        /// </summary>
        public Command BuildMicrosoftGraphRequestRemoteAssistanceCommand() {
            var command = new Command("microsoft-graph-request-remote-assistance");
            command.Description = "Provides operations to call the requestRemoteAssistance method.";
            var builder = new MicrosoftGraphRequestRemoteAssistanceRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the resetPasscode method.
        /// </summary>
        public Command BuildMicrosoftGraphResetPasscodeCommand() {
            var command = new Command("microsoft-graph-reset-passcode");
            command.Description = "Provides operations to call the resetPasscode method.";
            var builder = new MicrosoftGraphResetPasscodeRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the retire method.
        /// </summary>
        public Command BuildMicrosoftGraphRetireCommand() {
            var command = new Command("microsoft-graph-retire");
            command.Description = "Provides operations to call the retire method.";
            var builder = new MicrosoftGraphRetireRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the shutDown method.
        /// </summary>
        public Command BuildMicrosoftGraphShutDownCommand() {
            var command = new Command("microsoft-graph-shut-down");
            command.Description = "Provides operations to call the shutDown method.";
            var builder = new MicrosoftGraphShutDownRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the syncDevice method.
        /// </summary>
        public Command BuildMicrosoftGraphSyncDeviceCommand() {
            var command = new Command("microsoft-graph-sync-device");
            command.Description = "Provides operations to call the syncDevice method.";
            var builder = new MicrosoftGraphSyncDeviceRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the updateWindowsDeviceAccount method.
        /// </summary>
        public Command BuildMicrosoftGraphUpdateWindowsDeviceAccountCommand() {
            var command = new Command("microsoft-graph-update-windows-device-account");
            command.Description = "Provides operations to call the updateWindowsDeviceAccount method.";
            var builder = new MicrosoftGraphUpdateWindowsDeviceAccountRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the windowsDefenderScan method.
        /// </summary>
        public Command BuildMicrosoftGraphWindowsDefenderScanCommand() {
            var command = new Command("microsoft-graph-windows-defender-scan");
            command.Description = "Provides operations to call the windowsDefenderScan method.";
            var builder = new MicrosoftGraphWindowsDefenderScanRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the windowsDefenderUpdateSignatures method.
        /// </summary>
        public Command BuildMicrosoftGraphWindowsDefenderUpdateSignaturesCommand() {
            var command = new Command("microsoft-graph-windows-defender-update-signatures");
            command.Description = "Provides operations to call the windowsDefenderUpdateSignatures method.";
            var builder = new MicrosoftGraphWindowsDefenderUpdateSignaturesRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the wipe method.
        /// </summary>
        public Command BuildMicrosoftGraphWipeCommand() {
            var command = new Command("microsoft-graph-wipe");
            command.Description = "Provides operations to call the wipe method.";
            var builder = new MicrosoftGraphWipeRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Update the navigation property managedDevices in users
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Update the navigation property managedDevices in users";
            // Create options for all the parameters
            var userIdOption = new Option<string>("--user-id", description: "key: id of user") {
            };
            userIdOption.IsRequired = true;
            command.AddOption(userIdOption);
            var managedDeviceIdOption = new Option<string>("--managed-device-id", description: "key: id of managedDevice") {
            };
            managedDeviceIdOption.IsRequired = true;
            command.AddOption(managedDeviceIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
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
                var userId = invocationContext.ParseResult.GetValueForOption(userIdOption);
                var managedDeviceId = invocationContext.ParseResult.GetValueForOption(managedDeviceIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                var jsonNoIndent = invocationContext.ParseResult.GetValueForOption(jsonNoIndentOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetRequiredService<IOutputFilter>();
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetRequiredService<IOutputFormatterFactory>();
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ManagedDevice>(ManagedDevice.CreateFromDiscriminatorValue);
                if (model is null) return; // Cannot create a POST request from a null model.
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (userId is not null) requestInfo.PathParameters.Add("user%2Did", userId);
                if (managedDeviceId is not null) requestInfo.PathParameters.Add("managedDevice%2Did", managedDeviceId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatterOptions = output.GetOutputFormatterOptions(new FormatterOptionsModel(!jsonNoIndent));
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, formatterOptions, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Provides operations to manage the users property of the microsoft.graph.managedDevice entity.
        /// </summary>
        public Command BuildUsersCommand() {
            var command = new Command("users");
            command.Description = "Provides operations to manage the users property of the microsoft.graph.managedDevice entity.";
            var builder = new ApiSdk.Users.Item.ManagedDevices.Item.Users.UsersRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new ManagedDeviceItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public ManagedDeviceItemRequestBuilder(Dictionary<string, object> pathParameters) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            UrlTemplate = "{+baseurl}/users/{user%2Did}/managedDevices/{managedDevice%2Did}{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
        }
        /// <summary>
        /// Delete navigation property managedDevices for users
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<ManagedDeviceItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<ManagedDeviceItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new ManagedDeviceItemRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// The managed devices associated with the user.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<ManagedDeviceItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<ManagedDeviceItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new ManagedDeviceItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property managedDevices in users
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(ManagedDevice body, Action<ManagedDeviceItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(ManagedDevice body, Action<ManagedDeviceItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new ManagedDeviceItemRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class ManagedDeviceItemRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new ManagedDeviceItemRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public ManagedDeviceItemRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// The managed devices associated with the user.
        /// </summary>
        public class ManagedDeviceItemRequestBuilderGetQueryParameters {
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
        public class ManagedDeviceItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public ManagedDeviceItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new ManagedDeviceItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new ManagedDeviceItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public ManagedDeviceItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class ManagedDeviceItemRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new ManagedDeviceItemRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public ManagedDeviceItemRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
