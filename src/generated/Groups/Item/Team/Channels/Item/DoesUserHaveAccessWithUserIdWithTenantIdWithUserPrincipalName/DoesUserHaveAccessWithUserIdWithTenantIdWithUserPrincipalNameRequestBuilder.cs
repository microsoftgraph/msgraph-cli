using ApiSdk.Models.ODataErrors;
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
namespace ApiSdk.Groups.Item.Team.Channels.Item.DoesUserHaveAccessWithUserIdWithTenantIdWithUserPrincipalName {
    /// <summary>Provides operations to call the doesUserHaveAccess method.</summary>
    public class DoesUserHaveAccessWithUserIdWithTenantIdWithUserPrincipalNameRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Invoke function doesUserHaveAccess
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Invoke function doesUserHaveAccess";
            // Create options for all the parameters
            var groupIdOption = new Option<string>("--group-id", description: "key: id of group") {
            };
            groupIdOption.IsRequired = true;
            command.AddOption(groupIdOption);
            var channelIdOption = new Option<string>("--channel-id", description: "key: id of channel") {
            };
            channelIdOption.IsRequired = true;
            command.AddOption(channelIdOption);
            var userIdOption = new Option<string>("--user-id", description: "Usage: userId='{userId}'") {
            };
            userIdOption.IsRequired = false;
            command.AddOption(userIdOption);
            var tenantIdOption = new Option<string>("--tenant-id", description: "Usage: tenantId='{tenantId}'") {
            };
            tenantIdOption.IsRequired = false;
            command.AddOption(tenantIdOption);
            var userPrincipalNameOption = new Option<string>("--user-principal-name", description: "Usage: userPrincipalName='{userPrincipalName}'") {
            };
            userPrincipalNameOption.IsRequired = false;
            command.AddOption(userPrincipalNameOption);
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
                var groupId = invocationContext.ParseResult.GetValueForOption(groupIdOption);
                var channelId = invocationContext.ParseResult.GetValueForOption(channelIdOption);
                var userId = invocationContext.ParseResult.GetValueForOption(userIdOption);
                var tenantId = invocationContext.ParseResult.GetValueForOption(tenantIdOption);
                var userPrincipalName = invocationContext.ParseResult.GetValueForOption(userPrincipalNameOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                var jsonNoIndent = invocationContext.ParseResult.GetValueForOption(jsonNoIndentOption);
                var outputFilter = invocationContext.BindingContext.GetRequiredService<IOutputFilter>();
                var outputFormatterFactory = invocationContext.BindingContext.GetRequiredService<IOutputFormatterFactory>();
                var cancellationToken = invocationContext.GetCancellationToken();
                var requestInfo = CreateGetRequestInformation(q => {
                    if (!String.IsNullOrEmpty(userId)) q.QueryParameters.UserId = userId;
                    if (!String.IsNullOrEmpty(tenantId)) q.QueryParameters.TenantId = tenantId;
                    if (!String.IsNullOrEmpty(userPrincipalName)) q.QueryParameters.UserPrincipalName = userPrincipalName;
                });
                requestInfo.PathParameters.Add("group%2Did", groupId);
                requestInfo.PathParameters.Add("channel%2Did", channelId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                response = await outputFilter?.FilterOutputAsync(response, query, cancellationToken) ?? response;
                var formatterOptions = output.GetOutputFormatterOptions(new FormatterOptionsModel(!jsonNoIndent));
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, formatterOptions, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new DoesUserHaveAccessWithUserIdWithTenantIdWithUserPrincipalNameRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public DoesUserHaveAccessWithUserIdWithTenantIdWithUserPrincipalNameRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/groups/{group%2Did}/team/channels/{channel%2Did}/microsoft.graph.doesUserHaveAccess(userId='{userId}',tenantId='{tenantId}',userPrincipalName='{userPrincipalName}'){?userId,tenantId,userPrincipalName}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Invoke function doesUserHaveAccess
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<DoesUserHaveAccessWithUserIdWithTenantIdWithUserPrincipalNameRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new DoesUserHaveAccessWithUserIdWithTenantIdWithUserPrincipalNameRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>Invoke function doesUserHaveAccess</summary>
        public class DoesUserHaveAccessWithUserIdWithTenantIdWithUserPrincipalNameRequestBuilderGetQueryParameters {
            /// <summary>Usage: tenantId=&apos;{tenantId}&apos;</summary>
            public string TenantId { get; set; }
            /// <summary>Usage: userId=&apos;{userId}&apos;</summary>
            public string UserId { get; set; }
            /// <summary>Usage: userPrincipalName=&apos;{userPrincipalName}&apos;</summary>
            public string UserPrincipalName { get; set; }
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class DoesUserHaveAccessWithUserIdWithTenantIdWithUserPrincipalNameRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public DoesUserHaveAccessWithUserIdWithTenantIdWithUserPrincipalNameRequestBuilderGetQueryParameters QueryParameters { get; set; } = new DoesUserHaveAccessWithUserIdWithTenantIdWithUserPrincipalNameRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new doesUserHaveAccessWithUserIdWithTenantIdWithUserPrincipalNameRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public DoesUserHaveAccessWithUserIdWithTenantIdWithUserPrincipalNameRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
    }
}
