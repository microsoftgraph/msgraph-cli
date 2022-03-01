using ApiSdk.Models.Microsoft.Graph;
using ApiSdk.Users.Item.Authentication.MicrosoftAuthenticatorMethods.Item.Device;
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
namespace ApiSdk.Users.Item.Authentication.MicrosoftAuthenticatorMethods.Item {
    /// <summary>Builds and executes requests for operations under \users\{user-id}\authentication\microsoftAuthenticatorMethods\{microsoftAuthenticatorAuthenticationMethod-id}</summary>
    public class MicrosoftAuthenticatorAuthenticationMethodItemRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Delete navigation property microsoftAuthenticatorMethods for users
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Delete navigation property microsoftAuthenticatorMethods for users";
            // Create options for all the parameters
            var userIdOption = new Option<string>("--user-id", description: "key: id of user") {
            };
            userIdOption.IsRequired = true;
            command.AddOption(userIdOption);
            var microsoftAuthenticatorAuthenticationMethodIdOption = new Option<string>("--microsoft-authenticator-authentication-method-id", description: "key: id of microsoftAuthenticatorAuthenticationMethod") {
            };
            microsoftAuthenticatorAuthenticationMethodIdOption.IsRequired = true;
            command.AddOption(microsoftAuthenticatorAuthenticationMethodIdOption);
            command.SetHandler(async (object[] parameters) => {
                var userId = (string) parameters[0];
                var microsoftAuthenticatorAuthenticationMethodId = (string) parameters[1];
                var cancellationToken = (CancellationToken) parameters[2];
                PathParameters.Clear();
                PathParameters.Add("user_id", userId);
                PathParameters.Add("microsoftAuthenticatorAuthenticationMethod_id", microsoftAuthenticatorAuthenticationMethodId);
                var requestInfo = CreateDeleteRequestInformation(q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(userIdOption, microsoftAuthenticatorAuthenticationMethodIdOption, new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        public Command BuildDeviceCommand() {
            var command = new Command("device");
            var builder = new ApiSdk.Users.Item.Authentication.MicrosoftAuthenticatorMethods.Item.Device.DeviceRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        /// <summary>
        /// Get microsoftAuthenticatorMethods from users
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Get microsoftAuthenticatorMethods from users";
            // Create options for all the parameters
            var userIdOption = new Option<string>("--user-id", description: "key: id of user") {
            };
            userIdOption.IsRequired = true;
            command.AddOption(userIdOption);
            var microsoftAuthenticatorAuthenticationMethodIdOption = new Option<string>("--microsoft-authenticator-authentication-method-id", description: "key: id of microsoftAuthenticatorAuthenticationMethod") {
            };
            microsoftAuthenticatorAuthenticationMethodIdOption.IsRequired = true;
            command.AddOption(microsoftAuthenticatorAuthenticationMethodIdOption);
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
                var userId = (string) parameters[0];
                var microsoftAuthenticatorAuthenticationMethodId = (string) parameters[1];
                var select = (string[]) parameters[2];
                var expand = (string[]) parameters[3];
                var output = (FormatterType) parameters[4];
                var outputFilterOption = (string) parameters[5];
                var outputFormatterFactory = (IOutputFormatterFactory) parameters[6];
                var cancellationToken = (CancellationToken) parameters[7];
                PathParameters.Clear();
                PathParameters.Add("user_id", userId);
                PathParameters.Add("microsoftAuthenticatorAuthenticationMethod_id", microsoftAuthenticatorAuthenticationMethodId);
                var requestInfo = CreateGetRequestInformation(q => {
                    q.Select = select;
                    q.Expand = expand;
                });
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                var formatter = outputFormatterFactory.GetFormatter(output);
                formatter.WriteOutput(response);
            }, new CollectionBinding(userIdOption, microsoftAuthenticatorAuthenticationMethodIdOption, selectOption, expandOption, outputOption, outputFilterOption, new TypeBinding(typeof(IOutputFormatterFactory)), new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// Update the navigation property microsoftAuthenticatorMethods in users
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Update the navigation property microsoftAuthenticatorMethods in users";
            // Create options for all the parameters
            var userIdOption = new Option<string>("--user-id", description: "key: id of user") {
            };
            userIdOption.IsRequired = true;
            command.AddOption(userIdOption);
            var microsoftAuthenticatorAuthenticationMethodIdOption = new Option<string>("--microsoft-authenticator-authentication-method-id", description: "key: id of microsoftAuthenticatorAuthenticationMethod") {
            };
            microsoftAuthenticatorAuthenticationMethodIdOption.IsRequired = true;
            command.AddOption(microsoftAuthenticatorAuthenticationMethodIdOption);
            var bodyOption = new Option<string>("--body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (object[] parameters) => {
                var userId = (string) parameters[0];
                var microsoftAuthenticatorAuthenticationMethodId = (string) parameters[1];
                var body = (string) parameters[2];
                var cancellationToken = (CancellationToken) parameters[3];
                PathParameters.Clear();
                PathParameters.Add("user_id", userId);
                PathParameters.Add("microsoftAuthenticatorAuthenticationMethod_id", microsoftAuthenticatorAuthenticationMethodId);
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<MicrosoftAuthenticatorAuthenticationMethod>();
                var requestInfo = CreatePatchRequestInformation(model, q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(userIdOption, microsoftAuthenticatorAuthenticationMethodIdOption, bodyOption, new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// Instantiates a new MicrosoftAuthenticatorAuthenticationMethodItemRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public MicrosoftAuthenticatorAuthenticationMethodItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/users/{user_id}/authentication/microsoftAuthenticatorMethods/{microsoftAuthenticatorAuthenticationMethod_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete navigation property microsoftAuthenticatorMethods for users
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
        /// Get microsoftAuthenticatorMethods from users
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
        /// Update the navigation property microsoftAuthenticatorMethods in users
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(MicrosoftAuthenticatorAuthenticationMethod body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// <summary>Get microsoftAuthenticatorMethods from users</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
