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
namespace ApiSdk.DeviceAppManagement.MobileAppConfigurations.Item.DeviceStatuses.Item {
    /// <summary>Builds and executes requests for operations under \deviceAppManagement\mobileAppConfigurations\{managedDeviceMobileAppConfiguration-id}\deviceStatuses\{managedDeviceMobileAppConfigurationDeviceStatus-id}</summary>
    public class ManagedDeviceMobileAppConfigurationDeviceStatusRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// List of ManagedDeviceMobileAppConfigurationDeviceStatus.
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "List of ManagedDeviceMobileAppConfigurationDeviceStatus.";
            // Create options for all the parameters
            var managedDeviceMobileAppConfigurationIdOption = new Option<string>("--managed-device-mobile-app-configuration-id", description: "key: id of managedDeviceMobileAppConfiguration") {
            };
            managedDeviceMobileAppConfigurationIdOption.IsRequired = true;
            command.AddOption(managedDeviceMobileAppConfigurationIdOption);
            var managedDeviceMobileAppConfigurationDeviceStatusIdOption = new Option<string>("--managed-device-mobile-app-configuration-device-status-id", description: "key: id of managedDeviceMobileAppConfigurationDeviceStatus") {
            };
            managedDeviceMobileAppConfigurationDeviceStatusIdOption.IsRequired = true;
            command.AddOption(managedDeviceMobileAppConfigurationDeviceStatusIdOption);
            command.SetHandler(async (string managedDeviceMobileAppConfigurationId, string managedDeviceMobileAppConfigurationDeviceStatusId, IOutputFormatterFactory outputFormatterFactory, CancellationToken cancellationToken) => {
                var requestInfo = CreateDeleteRequestInformation(q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, managedDeviceMobileAppConfigurationIdOption, managedDeviceMobileAppConfigurationDeviceStatusIdOption);
            return command;
        }
        /// <summary>
        /// List of ManagedDeviceMobileAppConfigurationDeviceStatus.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "List of ManagedDeviceMobileAppConfigurationDeviceStatus.";
            // Create options for all the parameters
            var managedDeviceMobileAppConfigurationIdOption = new Option<string>("--managed-device-mobile-app-configuration-id", description: "key: id of managedDeviceMobileAppConfiguration") {
            };
            managedDeviceMobileAppConfigurationIdOption.IsRequired = true;
            command.AddOption(managedDeviceMobileAppConfigurationIdOption);
            var managedDeviceMobileAppConfigurationDeviceStatusIdOption = new Option<string>("--managed-device-mobile-app-configuration-device-status-id", description: "key: id of managedDeviceMobileAppConfigurationDeviceStatus") {
            };
            managedDeviceMobileAppConfigurationDeviceStatusIdOption.IsRequired = true;
            command.AddOption(managedDeviceMobileAppConfigurationDeviceStatusIdOption);
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
            command.SetHandler(async (string managedDeviceMobileAppConfigurationId, string managedDeviceMobileAppConfigurationDeviceStatusId, string[] select, string[] expand, FormatterType output, IOutputFormatterFactory outputFormatterFactory, CancellationToken cancellationToken) => {
                var requestInfo = CreateGetRequestInformation(q => {
                    q.Select = select;
                    q.Expand = expand;
                });
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                var formatter = outputFormatterFactory.GetFormatter(output);
                formatter.WriteOutput(response);
            }, managedDeviceMobileAppConfigurationIdOption, managedDeviceMobileAppConfigurationDeviceStatusIdOption, selectOption, expandOption, outputOption);
            return command;
        }
        /// <summary>
        /// List of ManagedDeviceMobileAppConfigurationDeviceStatus.
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "List of ManagedDeviceMobileAppConfigurationDeviceStatus.";
            // Create options for all the parameters
            var managedDeviceMobileAppConfigurationIdOption = new Option<string>("--managed-device-mobile-app-configuration-id", description: "key: id of managedDeviceMobileAppConfiguration") {
            };
            managedDeviceMobileAppConfigurationIdOption.IsRequired = true;
            command.AddOption(managedDeviceMobileAppConfigurationIdOption);
            var managedDeviceMobileAppConfigurationDeviceStatusIdOption = new Option<string>("--managed-device-mobile-app-configuration-device-status-id", description: "key: id of managedDeviceMobileAppConfigurationDeviceStatus") {
            };
            managedDeviceMobileAppConfigurationDeviceStatusIdOption.IsRequired = true;
            command.AddOption(managedDeviceMobileAppConfigurationDeviceStatusIdOption);
            var bodyOption = new Option<string>("--body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (string managedDeviceMobileAppConfigurationId, string managedDeviceMobileAppConfigurationDeviceStatusId, string body, IOutputFormatterFactory outputFormatterFactory, CancellationToken cancellationToken) => {
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ManagedDeviceMobileAppConfigurationDeviceStatus>();
                var requestInfo = CreatePatchRequestInformation(model, q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, managedDeviceMobileAppConfigurationIdOption, managedDeviceMobileAppConfigurationDeviceStatusIdOption, bodyOption);
            return command;
        }
        /// <summary>
        /// Instantiates a new ManagedDeviceMobileAppConfigurationDeviceStatusRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public ManagedDeviceMobileAppConfigurationDeviceStatusRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceAppManagement/mobileAppConfigurations/{managedDeviceMobileAppConfiguration_id}/deviceStatuses/{managedDeviceMobileAppConfigurationDeviceStatus_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// List of ManagedDeviceMobileAppConfigurationDeviceStatus.
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
        /// List of ManagedDeviceMobileAppConfigurationDeviceStatus.
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
        /// List of ManagedDeviceMobileAppConfigurationDeviceStatus.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(ManagedDeviceMobileAppConfigurationDeviceStatus body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// <summary>List of ManagedDeviceMobileAppConfigurationDeviceStatus.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
