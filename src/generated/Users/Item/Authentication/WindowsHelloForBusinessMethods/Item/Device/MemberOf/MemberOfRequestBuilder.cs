using ApiSdk.Models;
using ApiSdk.Models.ODataErrors;
using ApiSdk.Users.Item.Authentication.WindowsHelloForBusinessMethods.Item.Device.MemberOf.Application;
using ApiSdk.Users.Item.Authentication.WindowsHelloForBusinessMethods.Item.Device.MemberOf.Count;
using ApiSdk.Users.Item.Authentication.WindowsHelloForBusinessMethods.Item.Device.MemberOf.Device;
using ApiSdk.Users.Item.Authentication.WindowsHelloForBusinessMethods.Item.Device.MemberOf.Group;
using ApiSdk.Users.Item.Authentication.WindowsHelloForBusinessMethods.Item.Device.MemberOf.Item;
using ApiSdk.Users.Item.Authentication.WindowsHelloForBusinessMethods.Item.Device.MemberOf.OrgContact;
using ApiSdk.Users.Item.Authentication.WindowsHelloForBusinessMethods.Item.Device.MemberOf.ServicePrincipal;
using ApiSdk.Users.Item.Authentication.WindowsHelloForBusinessMethods.Item.Device.MemberOf.User;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
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
namespace ApiSdk.Users.Item.Authentication.WindowsHelloForBusinessMethods.Item.Device.MemberOf {
    /// <summary>Provides operations to manage the memberOf property of the microsoft.graph.device entity.</summary>
    public class MemberOfRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public Command BuildApplicationCommand() {
            var command = new Command("application");
            var builder = new ApplicationRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        public Command BuildCommand() {
            var command = new Command("item");
            var builder = new DirectoryObjectItemRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildApplicationCommand());
            command.AddCommand(builder.BuildDeviceCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildGroupCommand());
            command.AddCommand(builder.BuildOrgContactCommand());
            command.AddCommand(builder.BuildServicePrincipalCommand());
            command.AddCommand(builder.BuildUserCommand());
            return command;
        }
        public Command BuildCountCommand() {
            var command = new Command("count");
            var builder = new CountRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        public Command BuildDeviceCommand() {
            var command = new Command("device");
            var builder = new ApiSdk.Users.Item.Authentication.WindowsHelloForBusinessMethods.Item.Device.MemberOf.Device.DeviceRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        public Command BuildGroupCommand() {
            var command = new Command("group");
            var builder = new GroupRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Groups and administrative units that this device is a member of. Read-only. Nullable. Supports $expand.
        /// </summary>
        public Command BuildListCommand() {
            var command = new Command("list");
            command.Description = "Groups and administrative units that this device is a member of. Read-only. Nullable. Supports $expand.";
            // Create options for all the parameters
            var userIdOption = new Option<string>("--user-id", description: "key: id of user") {
            };
            userIdOption.IsRequired = true;
            command.AddOption(userIdOption);
            var windowsHelloForBusinessAuthenticationMethodIdOption = new Option<string>("--windows-hello-for-business-authentication-method-id", description: "key: id of windowsHelloForBusinessAuthenticationMethod") {
            };
            windowsHelloForBusinessAuthenticationMethodIdOption.IsRequired = true;
            command.AddOption(windowsHelloForBusinessAuthenticationMethodIdOption);
            var topOption = new Option<int?>("--top", description: "Show only the first n items") {
            };
            topOption.IsRequired = false;
            command.AddOption(topOption);
            var skipOption = new Option<int?>("--skip", description: "Skip the first n items") {
            };
            skipOption.IsRequired = false;
            command.AddOption(skipOption);
            var searchOption = new Option<string>("--search", description: "Search items by search phrases") {
            };
            searchOption.IsRequired = false;
            command.AddOption(searchOption);
            var filterOption = new Option<string>("--filter", description: "Filter items by property values") {
            };
            filterOption.IsRequired = false;
            command.AddOption(filterOption);
            var countOption = new Option<bool?>("--count", description: "Include count of items") {
            };
            countOption.IsRequired = false;
            command.AddOption(countOption);
            var orderbyOption = new Option<string[]>("--orderby", description: "Order items by property values") {
                Arity = ArgumentArity.ZeroOrMore
            };
            orderbyOption.IsRequired = false;
            command.AddOption(orderbyOption);
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
            var allOption = new Option<bool>("--all");
            command.AddOption(allOption);
            command.SetHandler(async (invocationContext) => {
                var userId = invocationContext.ParseResult.GetValueForOption(userIdOption);
                var windowsHelloForBusinessAuthenticationMethodId = invocationContext.ParseResult.GetValueForOption(windowsHelloForBusinessAuthenticationMethodIdOption);
                var top = invocationContext.ParseResult.GetValueForOption(topOption);
                var skip = invocationContext.ParseResult.GetValueForOption(skipOption);
                var search = invocationContext.ParseResult.GetValueForOption(searchOption);
                var filter = invocationContext.ParseResult.GetValueForOption(filterOption);
                var count = invocationContext.ParseResult.GetValueForOption(countOption);
                var orderby = invocationContext.ParseResult.GetValueForOption(orderbyOption);
                var select = invocationContext.ParseResult.GetValueForOption(selectOption);
                var expand = invocationContext.ParseResult.GetValueForOption(expandOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                var jsonNoIndent = invocationContext.ParseResult.GetValueForOption(jsonNoIndentOption);
                var all = invocationContext.ParseResult.GetValueForOption(allOption);
                var outputFilter = invocationContext.BindingContext.GetRequiredService<IOutputFilter>();
                var outputFormatterFactory = invocationContext.BindingContext.GetRequiredService<IOutputFormatterFactory>();
                var pagingService = invocationContext.BindingContext.GetRequiredService<IPagingService>();
                var cancellationToken = invocationContext.GetCancellationToken();
                var requestInfo = CreateGetRequestInformation(q => {
                    q.QueryParameters.Top = top;
                    q.QueryParameters.Skip = skip;
                    if (!String.IsNullOrEmpty(search)) q.QueryParameters.Search = search;
                    if (!String.IsNullOrEmpty(filter)) q.QueryParameters.Filter = filter;
                    q.QueryParameters.Count = count;
                    q.QueryParameters.Orderby = orderby;
                    q.QueryParameters.Select = select;
                    q.QueryParameters.Expand = expand;
                });
                requestInfo.PathParameters.Add("user%2Did", userId);
                requestInfo.PathParameters.Add("windowsHelloForBusinessAuthenticationMethod%2Did", windowsHelloForBusinessAuthenticationMethodId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var pagingData = new PageLinkData(requestInfo, null, itemName: "value", nextLinkName: "@odata.nextLink");
                var pageResponse = await pagingService.GetPagedDataAsync((info, handler, token) => RequestAdapter.SendNoContentAsync(info, cancellationToken: token, responseHandler: handler), pagingData, all, cancellationToken);
                var response = pageResponse?.Response;
                IOutputFormatterOptions? formatterOptions = null;
                IOutputFormatter? formatter = null;
                if (pageResponse?.StatusCode >= 200 && pageResponse?.StatusCode < 300) {
                    formatter = outputFormatterFactory.GetFormatter(output);
                    response = await outputFilter?.FilterOutputAsync(response, query, cancellationToken) ?? response;
                    formatterOptions = output.GetOutputFormatterOptions(new FormatterOptionsModel(!jsonNoIndent));
                } else {
                    formatter = outputFormatterFactory.GetFormatter(FormatterType.TEXT);
                }
                await formatter.WriteOutputAsync(response, formatterOptions, cancellationToken);
            });
            return command;
        }
        public Command BuildOrgContactCommand() {
            var command = new Command("org-contact");
            var builder = new OrgContactRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        public Command BuildServicePrincipalCommand() {
            var command = new Command("service-principal");
            var builder = new ServicePrincipalRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        public Command BuildUserCommand() {
            var command = new Command("user");
            var builder = new UserRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new MemberOfRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public MemberOfRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/users/{user%2Did}/authentication/windowsHelloForBusinessMethods/{windowsHelloForBusinessAuthenticationMethod%2Did}/device/memberOf{?%24top,%24skip,%24search,%24filter,%24count,%24orderby,%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Groups and administrative units that this device is a member of. Read-only. Nullable. Supports $expand.
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<MemberOfRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new MemberOfRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>Groups and administrative units that this device is a member of. Read-only. Nullable. Supports $expand.</summary>
        public class MemberOfRequestBuilderGetQueryParameters {
            /// <summary>Include count of items</summary>
            [QueryParameter("%24count")]
            public bool? Count { get; set; }
            /// <summary>Expand related entities</summary>
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
            /// <summary>Filter items by property values</summary>
            [QueryParameter("%24filter")]
            public string Filter { get; set; }
            /// <summary>Order items by property values</summary>
            [QueryParameter("%24orderby")]
            public string[] Orderby { get; set; }
            /// <summary>Search items by search phrases</summary>
            [QueryParameter("%24search")]
            public string Search { get; set; }
            /// <summary>Select properties to be returned</summary>
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
            /// <summary>Skip the first n items</summary>
            [QueryParameter("%24skip")]
            public int? Skip { get; set; }
            /// <summary>Show only the first n items</summary>
            [QueryParameter("%24top")]
            public int? Top { get; set; }
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class MemberOfRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public MemberOfRequestBuilderGetQueryParameters QueryParameters { get; set; } = new MemberOfRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new memberOfRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public MemberOfRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
    }
}
