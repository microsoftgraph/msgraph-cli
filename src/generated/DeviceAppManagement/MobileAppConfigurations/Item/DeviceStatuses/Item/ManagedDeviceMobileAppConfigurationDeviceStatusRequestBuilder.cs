using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Graph.Cli.Core.Binding;
using Microsoft.Graph.Cli.Core.IO;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
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
            var managedDeviceMobileAppConfigurationIdOption = new Option<string>("--manageddevicemobileappconfiguration-id", description: "key: id of managedDeviceMobileAppConfiguration") {
            };
            managedDeviceMobileAppConfigurationIdOption.IsRequired = true;
            command.AddOption(managedDeviceMobileAppConfigurationIdOption);
            var managedDeviceMobileAppConfigurationDeviceStatusIdOption = new Option<string>("--manageddevicemobileappconfigurationdevicestatus-id", description: "key: id of managedDeviceMobileAppConfigurationDeviceStatus") {
            };
            managedDeviceMobileAppConfigurationDeviceStatusIdOption.IsRequired = true;
            command.AddOption(managedDeviceMobileAppConfigurationDeviceStatusIdOption);
            command.SetHandler(async (string managedDeviceMobileAppConfigurationId, string managedDeviceMobileAppConfigurationDeviceStatusId, IServiceProvider serviceProvider, IConsole console) => {
                var responseHandler = serviceProvider.GetService(typeof(IResponseHandler)) as IResponseHandler;
                var requestInfo = CreateDeleteRequestInformation(q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler);
                // Print request output. What if the request has no return?
                console.WriteLine("Success");
            }, managedDeviceMobileAppConfigurationIdOption, managedDeviceMobileAppConfigurationDeviceStatusIdOption, new ServiceProviderBinder());
            return command;
        }
        /// <summary>
        /// List of ManagedDeviceMobileAppConfigurationDeviceStatus.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "List of ManagedDeviceMobileAppConfigurationDeviceStatus.";
            // Create options for all the parameters
            var managedDeviceMobileAppConfigurationIdOption = new Option<string>("--manageddevicemobileappconfiguration-id", description: "key: id of managedDeviceMobileAppConfiguration") {
            };
            managedDeviceMobileAppConfigurationIdOption.IsRequired = true;
            command.AddOption(managedDeviceMobileAppConfigurationIdOption);
            var managedDeviceMobileAppConfigurationDeviceStatusIdOption = new Option<string>("--manageddevicemobileappconfigurationdevicestatus-id", description: "key: id of managedDeviceMobileAppConfigurationDeviceStatus") {
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
            command.SetHandler(async (string managedDeviceMobileAppConfigurationId, string managedDeviceMobileAppConfigurationDeviceStatusId, string[] select, string[] expand, FormatterType output, IServiceProvider serviceProvider, IConsole console) => {
                var responseHandler = serviceProvider.GetService(typeof(IResponseHandler)) as IResponseHandler;
                var requestInfo = CreateGetRequestInformation(q => {
                    q.Select = select;
                    q.Expand = expand;
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler);
                // Print request output. What if the request has no return?
                var responseProcessor = serviceProvider.GetService(typeof(IResponseProcessor)) as IResponseProcessor;
                var factory = serviceProvider.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory;
                var formatter = factory.GetFormatter(output);
                if (responseProcessor.IsResponseSuccessful(responseHandler)) {
                    var content = await responseProcessor.ExtractStringResponseAsync(responseHandler);
                    formatter.WriteOutput(content, console);
                }
                else {
                    var content = await responseProcessor.ExtractStringResponseAsync(responseHandler);
                    console.WriteLine(content);
                }
            }, managedDeviceMobileAppConfigurationIdOption, managedDeviceMobileAppConfigurationDeviceStatusIdOption, selectOption, expandOption, outputOption, new ServiceProviderBinder());
            return command;
        }
        /// <summary>
        /// List of ManagedDeviceMobileAppConfigurationDeviceStatus.
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "List of ManagedDeviceMobileAppConfigurationDeviceStatus.";
            // Create options for all the parameters
            var managedDeviceMobileAppConfigurationIdOption = new Option<string>("--manageddevicemobileappconfiguration-id", description: "key: id of managedDeviceMobileAppConfiguration") {
            };
            managedDeviceMobileAppConfigurationIdOption.IsRequired = true;
            command.AddOption(managedDeviceMobileAppConfigurationIdOption);
            var managedDeviceMobileAppConfigurationDeviceStatusIdOption = new Option<string>("--manageddevicemobileappconfigurationdevicestatus-id", description: "key: id of managedDeviceMobileAppConfigurationDeviceStatus") {
            };
            managedDeviceMobileAppConfigurationDeviceStatusIdOption.IsRequired = true;
            command.AddOption(managedDeviceMobileAppConfigurationDeviceStatusIdOption);
            var bodyOption = new Option<string>("--body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (string managedDeviceMobileAppConfigurationId, string managedDeviceMobileAppConfigurationDeviceStatusId, string body, IServiceProvider serviceProvider, IConsole console) => {
                var responseHandler = serviceProvider.GetService(typeof(IResponseHandler)) as IResponseHandler;
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ManagedDeviceMobileAppConfigurationDeviceStatus>();
                var requestInfo = CreatePatchRequestInformation(model, q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler);
                // Print request output. What if the request has no return?
                console.WriteLine("Success");
            }, managedDeviceMobileAppConfigurationIdOption, managedDeviceMobileAppConfigurationDeviceStatusIdOption, bodyOption, new ServiceProviderBinder());
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
        /// Instantiates a new ManagedDeviceMobileAppConfigurationDeviceStatusRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public ManagedDeviceMobileAppConfigurationDeviceStatusRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceAppManagement/mobileAppConfigurations/{managedDeviceMobileAppConfiguration_id}/deviceStatuses/{managedDeviceMobileAppConfigurationDeviceStatus_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
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
        /// <summary>
        /// List of ManagedDeviceMobileAppConfigurationDeviceStatus.
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
        /// List of ManagedDeviceMobileAppConfigurationDeviceStatus.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<ManagedDeviceMobileAppConfigurationDeviceStatus> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<ManagedDeviceMobileAppConfigurationDeviceStatus>(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>
        /// List of ManagedDeviceMobileAppConfigurationDeviceStatus.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="model"></param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(ManagedDeviceMobileAppConfigurationDeviceStatus model, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = model ?? throw new ArgumentNullException(nameof(model));
            var requestInfo = CreatePatchRequestInformation(model, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, cancellationToken);
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
