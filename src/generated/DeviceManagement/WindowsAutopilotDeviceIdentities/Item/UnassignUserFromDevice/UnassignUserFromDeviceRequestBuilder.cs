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
namespace ApiSdk.DeviceManagement.WindowsAutopilotDeviceIdentities.Item.UnassignUserFromDevice {
    /// <summary>Provides operations to call the unassignUserFromDevice method.</summary>
    public class UnassignUserFromDeviceRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Unassigns the user from an Autopilot device.
        /// </summary>
        public Command BuildPostCommand() {
            var command = new Command("post");
            command.Description = "Unassigns the user from an Autopilot device.";
            // Create options for all the parameters
            var windowsAutopilotDeviceIdentityIdOption = new Option<string>("--windows-autopilot-device-identity-id", description: "key: id of windowsAutopilotDeviceIdentity") {
            };
            windowsAutopilotDeviceIdentityIdOption.IsRequired = true;
            command.AddOption(windowsAutopilotDeviceIdentityIdOption);
            command.SetHandler(async (object[] parameters) => {
                var windowsAutopilotDeviceIdentityId = (string) parameters[0];
                var cancellationToken = (CancellationToken) parameters[1];
                var requestInfo = CreatePostRequestInformation(q => {
                });
                requestInfo.PathParameters.Add("windowsAutopilotDeviceIdentity%2Did", windowsAutopilotDeviceIdentityId);
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(windowsAutopilotDeviceIdentityIdOption, new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// Instantiates a new UnassignUserFromDeviceRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public UnassignUserFromDeviceRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/windowsAutopilotDeviceIdentities/{windowsAutopilotDeviceIdentity%2Did}/microsoft.graph.unassignUserFromDevice";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Unassigns the user from an Autopilot device.
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreatePostRequestInformation(Action<UnassignUserFromDeviceRequestBuilderPostRequestConfiguration> requestConfiguration = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new UnassignUserFromDeviceRequestBuilderPostRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class UnassignUserFromDeviceRequestBuilderPostRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new unassignUserFromDeviceRequestBuilderPostRequestConfiguration and sets the default values.
            /// </summary>
            public UnassignUserFromDeviceRequestBuilderPostRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
    }
}
