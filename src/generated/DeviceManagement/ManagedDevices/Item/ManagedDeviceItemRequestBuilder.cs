using ApiSdk.DeviceManagement.ManagedDevices.Item.BypassActivationLock;
using ApiSdk.DeviceManagement.ManagedDevices.Item.CleanWindowsDevice;
using ApiSdk.DeviceManagement.ManagedDevices.Item.DeleteUserFromSharedAppleDevice;
using ApiSdk.DeviceManagement.ManagedDevices.Item.DeviceCategory;
using ApiSdk.DeviceManagement.ManagedDevices.Item.DeviceCompliancePolicyStates;
using ApiSdk.DeviceManagement.ManagedDevices.Item.DeviceConfigurationStates;
using ApiSdk.DeviceManagement.ManagedDevices.Item.DisableLostMode;
using ApiSdk.DeviceManagement.ManagedDevices.Item.LocateDevice;
using ApiSdk.DeviceManagement.ManagedDevices.Item.LogoutSharedAppleDeviceActiveUser;
using ApiSdk.DeviceManagement.ManagedDevices.Item.RebootNow;
using ApiSdk.DeviceManagement.ManagedDevices.Item.RecoverPasscode;
using ApiSdk.DeviceManagement.ManagedDevices.Item.RemoteLock;
using ApiSdk.DeviceManagement.ManagedDevices.Item.RequestRemoteAssistance;
using ApiSdk.DeviceManagement.ManagedDevices.Item.ResetPasscode;
using ApiSdk.DeviceManagement.ManagedDevices.Item.Retire;
using ApiSdk.DeviceManagement.ManagedDevices.Item.ShutDown;
using ApiSdk.DeviceManagement.ManagedDevices.Item.SyncDevice;
using ApiSdk.DeviceManagement.ManagedDevices.Item.UpdateWindowsDeviceAccount;
using ApiSdk.DeviceManagement.ManagedDevices.Item.WindowsDefenderScan;
using ApiSdk.DeviceManagement.ManagedDevices.Item.WindowsDefenderUpdateSignatures;
using ApiSdk.DeviceManagement.ManagedDevices.Item.Wipe;
using ApiSdk.Models.Microsoft.Graph;
using ApiSdk.Models.Microsoft.Graph.ODataErrors;
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
namespace ApiSdk.DeviceManagement.ManagedDevices.Item {
    /// <summary>Provides operations to manage the managedDevices property of the microsoft.graph.deviceManagement entity.</summary>
    public class ManagedDeviceItemRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public Command BuildBypassActivationLockCommand() {
            var command = new Command("bypass-activation-lock");
            var builder = new BypassActivationLockRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildCleanWindowsDeviceCommand() {
            var command = new Command("clean-windows-device");
            var builder = new CleanWindowsDeviceRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Delete navigation property managedDevices for deviceManagement
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Delete navigation property managedDevices for deviceManagement";
            // Create options for all the parameters
            var managedDeviceIdOption = new Option<string>("--managed-device-id", description: "key: id of managedDevice") {
            };
            managedDeviceIdOption.IsRequired = true;
            command.AddOption(managedDeviceIdOption);
            command.SetHandler(async (object[] parameters) => {
                var managedDeviceId = (string) parameters[0];
                var cancellationToken = (CancellationToken) parameters[1];
                PathParameters.Clear();
                PathParameters.Add("managedDevice_id", managedDeviceId);
                var requestInfo = CreateDeleteRequestInformation(q => {
                });
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(managedDeviceIdOption, new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        public Command BuildDeleteUserFromSharedAppleDeviceCommand() {
            var command = new Command("delete-user-from-shared-apple-device");
            var builder = new DeleteUserFromSharedAppleDeviceRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildDeviceCategoryCommand() {
            var command = new Command("device-category");
            var builder = new DeviceCategoryRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        public Command BuildDeviceCompliancePolicyStatesCommand() {
            var command = new Command("device-compliance-policy-states");
            var builder = new DeviceCompliancePolicyStatesRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildDeviceConfigurationStatesCommand() {
            var command = new Command("device-configuration-states");
            var builder = new DeviceConfigurationStatesRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildDisableLostModeCommand() {
            var command = new Command("disable-lost-mode");
            var builder = new DisableLostModeRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// The list of managed devices.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "The list of managed devices.";
            // Create options for all the parameters
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
            command.SetHandler(async (object[] parameters) => {
                var managedDeviceId = (string) parameters[0];
                var select = (string[]) parameters[1];
                var expand = (string[]) parameters[2];
                var output = (FormatterType) parameters[3];
                var query = (string) parameters[4];
                var jsonNoIndent = (bool) parameters[5];
                var outputFilter = (IOutputFilter) parameters[6];
                var outputFormatterFactory = (IOutputFormatterFactory) parameters[7];
                var cancellationToken = (CancellationToken) parameters[8];
                PathParameters.Clear();
                PathParameters.Add("managedDevice_id", managedDeviceId);
                var requestInfo = CreateGetRequestInformation(q => {
                    q.Select = select;
                    q.Expand = expand;
                });
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                response = await outputFilter?.FilterOutputAsync(response, query, cancellationToken) ?? response;
                var formatterOptions = output.GetOutputFormatterOptions(new FormatterOptionsModel(!jsonNoIndent));
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, formatterOptions, cancellationToken);
            }, new CollectionBinding(managedDeviceIdOption, selectOption, expandOption, outputOption, queryOption, jsonNoIndentOption, new TypeBinding(typeof(IOutputFilter)), new TypeBinding(typeof(IOutputFormatterFactory)), new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        public Command BuildLocateDeviceCommand() {
            var command = new Command("locate-device");
            var builder = new LocateDeviceRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildLogoutSharedAppleDeviceActiveUserCommand() {
            var command = new Command("logout-shared-apple-device-active-user");
            var builder = new LogoutSharedAppleDeviceActiveUserRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Update the navigation property managedDevices in deviceManagement
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Update the navigation property managedDevices in deviceManagement";
            // Create options for all the parameters
            var managedDeviceIdOption = new Option<string>("--managed-device-id", description: "key: id of managedDevice") {
            };
            managedDeviceIdOption.IsRequired = true;
            command.AddOption(managedDeviceIdOption);
            var bodyOption = new Option<string>("--body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (object[] parameters) => {
                var managedDeviceId = (string) parameters[0];
                var body = (string) parameters[1];
                var cancellationToken = (CancellationToken) parameters[2];
                PathParameters.Clear();
                PathParameters.Add("managedDevice_id", managedDeviceId);
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ManagedDevice>(ManagedDevice.CreateFromDiscriminatorValue);
                var requestInfo = CreatePatchRequestInformation(model, q => {
                });
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(managedDeviceIdOption, bodyOption, new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        public Command BuildRebootNowCommand() {
            var command = new Command("reboot-now");
            var builder = new RebootNowRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildRecoverPasscodeCommand() {
            var command = new Command("recover-passcode");
            var builder = new RecoverPasscodeRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildRemoteLockCommand() {
            var command = new Command("remote-lock");
            var builder = new RemoteLockRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildRequestRemoteAssistanceCommand() {
            var command = new Command("request-remote-assistance");
            var builder = new RequestRemoteAssistanceRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildResetPasscodeCommand() {
            var command = new Command("reset-passcode");
            var builder = new ResetPasscodeRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildRetireCommand() {
            var command = new Command("retire");
            var builder = new RetireRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildShutDownCommand() {
            var command = new Command("shut-down");
            var builder = new ShutDownRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildSyncDeviceCommand() {
            var command = new Command("sync-device");
            var builder = new SyncDeviceRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildUpdateWindowsDeviceAccountCommand() {
            var command = new Command("update-windows-device-account");
            var builder = new UpdateWindowsDeviceAccountRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildWindowsDefenderScanCommand() {
            var command = new Command("windows-defender-scan");
            var builder = new WindowsDefenderScanRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildWindowsDefenderUpdateSignaturesCommand() {
            var command = new Command("windows-defender-update-signatures");
            var builder = new WindowsDefenderUpdateSignaturesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildWipeCommand() {
            var command = new Command("wipe");
            var builder = new WipeRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new ManagedDeviceItemRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public ManagedDeviceItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/managedDevices/{managedDevice_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete navigation property managedDevices for deviceManagement
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
        /// The list of managed devices.
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
        /// Update the navigation property managedDevices in deviceManagement
        /// <param name="body"></param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(ManagedDevice body, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default) {
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
        /// <summary>The list of managed devices.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
