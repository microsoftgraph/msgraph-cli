using ApiSdk.Me.Authentication.WindowsHelloForBusinessMethods.Item.Device;
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
namespace ApiSdk.Me.Authentication.WindowsHelloForBusinessMethods.Item {
    /// <summary>Builds and executes requests for operations under \me\authentication\windowsHelloForBusinessMethods\{windowsHelloForBusinessAuthenticationMethod-id}</summary>
    public class WindowsHelloForBusinessAuthenticationMethodItemRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Delete navigation property windowsHelloForBusinessMethods for me
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Delete navigation property windowsHelloForBusinessMethods for me";
            // Create options for all the parameters
            var windowsHelloForBusinessAuthenticationMethodIdOption = new Option<string>("--windows-hello-for-business-authentication-method-id", description: "key: id of windowsHelloForBusinessAuthenticationMethod") {
            };
            windowsHelloForBusinessAuthenticationMethodIdOption.IsRequired = true;
            command.AddOption(windowsHelloForBusinessAuthenticationMethodIdOption);
            command.SetHandler(async (object[] parameters) => {
                var windowsHelloForBusinessAuthenticationMethodId = (string) parameters[0];
                var cancellationToken = (CancellationToken) parameters[1];
                PathParameters.Clear();
                PathParameters.Add("windowsHelloForBusinessAuthenticationMethod_id", windowsHelloForBusinessAuthenticationMethodId);
                var requestInfo = CreateDeleteRequestInformation(q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(windowsHelloForBusinessAuthenticationMethodIdOption, new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        public Command BuildDeviceCommand() {
            var command = new Command("device");
            var builder = new ApiSdk.Me.Authentication.WindowsHelloForBusinessMethods.Item.Device.DeviceRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        /// <summary>
        /// Get windowsHelloForBusinessMethods from me
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Get windowsHelloForBusinessMethods from me";
            // Create options for all the parameters
            var windowsHelloForBusinessAuthenticationMethodIdOption = new Option<string>("--windows-hello-for-business-authentication-method-id", description: "key: id of windowsHelloForBusinessAuthenticationMethod") {
            };
            windowsHelloForBusinessAuthenticationMethodIdOption.IsRequired = true;
            command.AddOption(windowsHelloForBusinessAuthenticationMethodIdOption);
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
            var outputFilterOption = new Option<string>("--query");
            command.AddOption(outputFilterOption);
            command.SetHandler(async (object[] parameters) => {
                var windowsHelloForBusinessAuthenticationMethodId = (string) parameters[0];
                var select = (string[]) parameters[1];
                var expand = (string[]) parameters[2];
                var output = (FormatterType) parameters[3];
                var outputFilterOption = (string) parameters[4];
                var outputFormatterFactory = (IOutputFormatterFactory) parameters[5];
                var cancellationToken = (CancellationToken) parameters[6];
                PathParameters.Clear();
                PathParameters.Add("windowsHelloForBusinessAuthenticationMethod_id", windowsHelloForBusinessAuthenticationMethodId);
                var requestInfo = CreateGetRequestInformation(q => {
                    q.Select = select;
                    q.Expand = expand;
                });
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                var formatter = outputFormatterFactory.GetFormatter(output);
                formatter.WriteOutput(response);
            }, new CollectionBinding(windowsHelloForBusinessAuthenticationMethodIdOption, selectOption, expandOption, outputOption, outputFilterOption, new TypeBinding(typeof(IOutputFormatterFactory)), new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// Update the navigation property windowsHelloForBusinessMethods in me
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Update the navigation property windowsHelloForBusinessMethods in me";
            // Create options for all the parameters
            var windowsHelloForBusinessAuthenticationMethodIdOption = new Option<string>("--windows-hello-for-business-authentication-method-id", description: "key: id of windowsHelloForBusinessAuthenticationMethod") {
            };
            windowsHelloForBusinessAuthenticationMethodIdOption.IsRequired = true;
            command.AddOption(windowsHelloForBusinessAuthenticationMethodIdOption);
            var bodyOption = new Option<string>("--body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (object[] parameters) => {
                var windowsHelloForBusinessAuthenticationMethodId = (string) parameters[0];
                var body = (string) parameters[1];
                var cancellationToken = (CancellationToken) parameters[2];
                PathParameters.Clear();
                PathParameters.Add("windowsHelloForBusinessAuthenticationMethod_id", windowsHelloForBusinessAuthenticationMethodId);
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<WindowsHelloForBusinessAuthenticationMethod>();
                var requestInfo = CreatePatchRequestInformation(model, q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(windowsHelloForBusinessAuthenticationMethodIdOption, bodyOption, new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// Instantiates a new WindowsHelloForBusinessAuthenticationMethodItemRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public WindowsHelloForBusinessAuthenticationMethodItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/me/authentication/windowsHelloForBusinessMethods/{windowsHelloForBusinessAuthenticationMethod_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete navigation property windowsHelloForBusinessMethods for me
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
        /// Get windowsHelloForBusinessMethods from me
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
        /// Update the navigation property windowsHelloForBusinessMethods in me
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(WindowsHelloForBusinessAuthenticationMethod body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// <summary>Get windowsHelloForBusinessMethods from me</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
