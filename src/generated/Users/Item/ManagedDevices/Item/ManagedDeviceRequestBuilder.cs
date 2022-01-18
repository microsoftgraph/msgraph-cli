using ApiSdk.Models.Microsoft.Graph;
using ApiSdk.Users.Item.ManagedDevices.Item.BypassActivationLock;
using ApiSdk.Users.Item.ManagedDevices.Item.CleanWindowsDevice;
using ApiSdk.Users.Item.ManagedDevices.Item.DeleteUserFromSharedAppleDevice;
using ApiSdk.Users.Item.ManagedDevices.Item.DeviceCategory;
using ApiSdk.Users.Item.ManagedDevices.Item.DeviceCompliancePolicyStates;
using ApiSdk.Users.Item.ManagedDevices.Item.DeviceConfigurationStates;
using ApiSdk.Users.Item.ManagedDevices.Item.DisableLostMode;
using ApiSdk.Users.Item.ManagedDevices.Item.LocateDevice;
using ApiSdk.Users.Item.ManagedDevices.Item.LogoutSharedAppleDeviceActiveUser;
using ApiSdk.Users.Item.ManagedDevices.Item.RebootNow;
using ApiSdk.Users.Item.ManagedDevices.Item.RecoverPasscode;
using ApiSdk.Users.Item.ManagedDevices.Item.RemoteLock;
using ApiSdk.Users.Item.ManagedDevices.Item.RequestRemoteAssistance;
using ApiSdk.Users.Item.ManagedDevices.Item.ResetPasscode;
using ApiSdk.Users.Item.ManagedDevices.Item.Retire;
using ApiSdk.Users.Item.ManagedDevices.Item.ShutDown;
using ApiSdk.Users.Item.ManagedDevices.Item.SyncDevice;
using ApiSdk.Users.Item.ManagedDevices.Item.UpdateWindowsDeviceAccount;
using ApiSdk.Users.Item.ManagedDevices.Item.WindowsDefenderScan;
using ApiSdk.Users.Item.ManagedDevices.Item.WindowsDefenderUpdateSignatures;
using ApiSdk.Users.Item.ManagedDevices.Item.Wipe;
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
namespace ApiSdk.Users.Item.ManagedDevices.Item {
    /// <summary>Builds and executes requests for operations under \users\{user-id}\managedDevices\{managedDevice-id}</summary>
    public class ManagedDeviceRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public Command BuildBypassActivationLockCommand() {
            var command = new Command("bypass-activation-lock");
            var builder = new ApiSdk.Users.Item.ManagedDevices.Item.BypassActivationLock.BypassActivationLockRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildCleanWindowsDeviceCommand() {
            var command = new Command("clean-windows-device");
            var builder = new ApiSdk.Users.Item.ManagedDevices.Item.CleanWindowsDevice.CleanWindowsDeviceRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// The managed devices associated with the user.
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "The managed devices associated with the user.";
            // Create options for all the parameters
            var userIdOption = new Option<string>("--user-id", description: "key: id of user");
            userIdOption.IsRequired = true;
            command.AddOption(userIdOption);
            var managedDeviceIdOption = new Option<string>("--manageddevice-id", description: "key: id of managedDevice");
            managedDeviceIdOption.IsRequired = true;
            command.AddOption(managedDeviceIdOption);
            command.Handler = CommandHandler.Create<string, string>(async (userId, managedDeviceId) => {
                var requestInfo = CreateDeleteRequestInformation(q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo);
                // Print request output. What if the request has no return?
                Console.WriteLine("Success");
            });
            return command;
        }
        public Command BuildDeleteUserFromSharedAppleDeviceCommand() {
            var command = new Command("delete-user-from-shared-apple-device");
            var builder = new ApiSdk.Users.Item.ManagedDevices.Item.DeleteUserFromSharedAppleDevice.DeleteUserFromSharedAppleDeviceRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildDeviceCategoryCommand() {
            var command = new Command("device-category");
            var builder = new ApiSdk.Users.Item.ManagedDevices.Item.DeviceCategory.DeviceCategoryRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        public Command BuildDeviceCompliancePolicyStatesCommand() {
            var command = new Command("device-compliance-policy-states");
            var builder = new ApiSdk.Users.Item.ManagedDevices.Item.DeviceCompliancePolicyStates.DeviceCompliancePolicyStatesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildDeviceConfigurationStatesCommand() {
            var command = new Command("device-configuration-states");
            var builder = new ApiSdk.Users.Item.ManagedDevices.Item.DeviceConfigurationStates.DeviceConfigurationStatesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildDisableLostModeCommand() {
            var command = new Command("disable-lost-mode");
            var builder = new ApiSdk.Users.Item.ManagedDevices.Item.DisableLostMode.DisableLostModeRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// The managed devices associated with the user.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "The managed devices associated with the user.";
            // Create options for all the parameters
            var userIdOption = new Option<string>("--user-id", description: "key: id of user");
            userIdOption.IsRequired = true;
            command.AddOption(userIdOption);
            var managedDeviceIdOption = new Option<string>("--manageddevice-id", description: "key: id of managedDevice");
            managedDeviceIdOption.IsRequired = true;
            command.AddOption(managedDeviceIdOption);
            var selectOption = new Option<string[]>("--select", description: "Select properties to be returned");
            selectOption.IsRequired = false;
            selectOption.Arity = ArgumentArity.ZeroOrMore;
            command.AddOption(selectOption);
            var expandOption = new Option<string[]>("--expand", description: "Expand related entities");
            expandOption.IsRequired = false;
            expandOption.Arity = ArgumentArity.ZeroOrMore;
            command.AddOption(expandOption);
            command.Handler = CommandHandler.Create<string, string, string[], string[]>(async (userId, managedDeviceId, select, expand) => {
                var requestInfo = CreateGetRequestInformation(q => {
                    q.Select = select;
                    q.Expand = expand;
                });
                var result = await RequestAdapter.SendAsync<ManagedDevice>(requestInfo);
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
        public Command BuildLocateDeviceCommand() {
            var command = new Command("locate-device");
            var builder = new ApiSdk.Users.Item.ManagedDevices.Item.LocateDevice.LocateDeviceRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildLogoutSharedAppleDeviceActiveUserCommand() {
            var command = new Command("logout-shared-apple-device-active-user");
            var builder = new ApiSdk.Users.Item.ManagedDevices.Item.LogoutSharedAppleDeviceActiveUser.LogoutSharedAppleDeviceActiveUserRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// The managed devices associated with the user.
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "The managed devices associated with the user.";
            // Create options for all the parameters
            var userIdOption = new Option<string>("--user-id", description: "key: id of user");
            userIdOption.IsRequired = true;
            command.AddOption(userIdOption);
            var managedDeviceIdOption = new Option<string>("--manageddevice-id", description: "key: id of managedDevice");
            managedDeviceIdOption.IsRequired = true;
            command.AddOption(managedDeviceIdOption);
            var bodyOption = new Option<string>("--body");
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.Handler = CommandHandler.Create<string, string, string>(async (userId, managedDeviceId, body) => {
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ManagedDevice>();
                var requestInfo = CreatePatchRequestInformation(model, q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo);
                // Print request output. What if the request has no return?
                Console.WriteLine("Success");
            });
            return command;
        }
        public Command BuildRebootNowCommand() {
            var command = new Command("reboot-now");
            var builder = new ApiSdk.Users.Item.ManagedDevices.Item.RebootNow.RebootNowRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildRecoverPasscodeCommand() {
            var command = new Command("recover-passcode");
            var builder = new ApiSdk.Users.Item.ManagedDevices.Item.RecoverPasscode.RecoverPasscodeRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildRemoteLockCommand() {
            var command = new Command("remote-lock");
            var builder = new ApiSdk.Users.Item.ManagedDevices.Item.RemoteLock.RemoteLockRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildRequestRemoteAssistanceCommand() {
            var command = new Command("request-remote-assistance");
            var builder = new ApiSdk.Users.Item.ManagedDevices.Item.RequestRemoteAssistance.RequestRemoteAssistanceRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildResetPasscodeCommand() {
            var command = new Command("reset-passcode");
            var builder = new ApiSdk.Users.Item.ManagedDevices.Item.ResetPasscode.ResetPasscodeRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildRetireCommand() {
            var command = new Command("retire");
            var builder = new ApiSdk.Users.Item.ManagedDevices.Item.Retire.RetireRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildShutDownCommand() {
            var command = new Command("shut-down");
            var builder = new ApiSdk.Users.Item.ManagedDevices.Item.ShutDown.ShutDownRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildSyncDeviceCommand() {
            var command = new Command("sync-device");
            var builder = new ApiSdk.Users.Item.ManagedDevices.Item.SyncDevice.SyncDeviceRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildUpdateWindowsDeviceAccountCommand() {
            var command = new Command("update-windows-device-account");
            var builder = new ApiSdk.Users.Item.ManagedDevices.Item.UpdateWindowsDeviceAccount.UpdateWindowsDeviceAccountRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildWindowsDefenderScanCommand() {
            var command = new Command("windows-defender-scan");
            var builder = new ApiSdk.Users.Item.ManagedDevices.Item.WindowsDefenderScan.WindowsDefenderScanRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildWindowsDefenderUpdateSignaturesCommand() {
            var command = new Command("windows-defender-update-signatures");
            var builder = new ApiSdk.Users.Item.ManagedDevices.Item.WindowsDefenderUpdateSignatures.WindowsDefenderUpdateSignaturesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildWipeCommand() {
            var command = new Command("wipe");
            var builder = new ApiSdk.Users.Item.ManagedDevices.Item.Wipe.WipeRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new ManagedDeviceRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public ManagedDeviceRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/users/{user_id}/managedDevices/{managedDevice_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// The managed devices associated with the user.
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
        /// The managed devices associated with the user.
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
        /// The managed devices associated with the user.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(ManagedDevice body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// The managed devices associated with the user.
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
        /// The managed devices associated with the user.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<ManagedDevice> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<ManagedDevice>(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>
        /// The managed devices associated with the user.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="model"></param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(ManagedDevice model, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = model ?? throw new ArgumentNullException(nameof(model));
            var requestInfo = CreatePatchRequestInformation(model, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>The managed devices associated with the user.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
