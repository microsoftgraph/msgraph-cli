using ApiSdk.Models.Microsoft.Graph;
using ApiSdk.ServicePrincipals.Item.AddKey;
using ApiSdk.ServicePrincipals.Item.AddPassword;
using ApiSdk.ServicePrincipals.Item.AppRoleAssignedTo;
using ApiSdk.ServicePrincipals.Item.AppRoleAssignments;
using ApiSdk.ServicePrincipals.Item.CheckMemberGroups;
using ApiSdk.ServicePrincipals.Item.CheckMemberObjects;
using ApiSdk.ServicePrincipals.Item.ClaimsMappingPolicies;
using ApiSdk.ServicePrincipals.Item.CreatedObjects;
using ApiSdk.ServicePrincipals.Item.DelegatedPermissionClassifications;
using ApiSdk.ServicePrincipals.Item.Endpoints;
using ApiSdk.ServicePrincipals.Item.GetMemberGroups;
using ApiSdk.ServicePrincipals.Item.GetMemberObjects;
using ApiSdk.ServicePrincipals.Item.HomeRealmDiscoveryPolicies;
using ApiSdk.ServicePrincipals.Item.MemberOf;
using ApiSdk.ServicePrincipals.Item.Oauth2PermissionGrants;
using ApiSdk.ServicePrincipals.Item.OwnedObjects;
using ApiSdk.ServicePrincipals.Item.Owners;
using ApiSdk.ServicePrincipals.Item.RemoveKey;
using ApiSdk.ServicePrincipals.Item.RemovePassword;
using ApiSdk.ServicePrincipals.Item.Restore;
using ApiSdk.ServicePrincipals.Item.TokenIssuancePolicies;
using ApiSdk.ServicePrincipals.Item.TokenLifetimePolicies;
using ApiSdk.ServicePrincipals.Item.TransitiveMemberOf;
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
namespace ApiSdk.ServicePrincipals.Item {
    /// <summary>Builds and executes requests for operations under \servicePrincipals\{servicePrincipal-id}</summary>
    public class ServicePrincipalRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public Command BuildAddKeyCommand() {
            var command = new Command("add-key");
            var builder = new ApiSdk.ServicePrincipals.Item.AddKey.AddKeyRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildAddPasswordCommand() {
            var command = new Command("add-password");
            var builder = new ApiSdk.ServicePrincipals.Item.AddPassword.AddPasswordRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildAppRoleAssignedToCommand() {
            var command = new Command("app-role-assigned-to");
            var builder = new ApiSdk.ServicePrincipals.Item.AppRoleAssignedTo.AppRoleAssignedToRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildAppRoleAssignmentsCommand() {
            var command = new Command("app-role-assignments");
            var builder = new ApiSdk.ServicePrincipals.Item.AppRoleAssignments.AppRoleAssignmentsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildCheckMemberGroupsCommand() {
            var command = new Command("check-member-groups");
            var builder = new ApiSdk.ServicePrincipals.Item.CheckMemberGroups.CheckMemberGroupsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildCheckMemberObjectsCommand() {
            var command = new Command("check-member-objects");
            var builder = new ApiSdk.ServicePrincipals.Item.CheckMemberObjects.CheckMemberObjectsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildClaimsMappingPoliciesCommand() {
            var command = new Command("claims-mapping-policies");
            var builder = new ApiSdk.ServicePrincipals.Item.ClaimsMappingPolicies.ClaimsMappingPoliciesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        public Command BuildCreatedObjectsCommand() {
            var command = new Command("created-objects");
            var builder = new ApiSdk.ServicePrincipals.Item.CreatedObjects.CreatedObjectsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        public Command BuildDelegatedPermissionClassificationsCommand() {
            var command = new Command("delegated-permission-classifications");
            var builder = new ApiSdk.ServicePrincipals.Item.DelegatedPermissionClassifications.DelegatedPermissionClassificationsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Delete entity from servicePrincipals
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Delete entity from servicePrincipals";
            // Create options for all the parameters
            var servicePrincipalIdOption = new Option<string>("--serviceprincipal-id", description: "key: id of servicePrincipal") {
            };
            servicePrincipalIdOption.IsRequired = true;
            command.AddOption(servicePrincipalIdOption);
            command.SetHandler(async (string servicePrincipalId, IOutputFormatterFactory outputFormatterFactory, IConsole console) => {
                var requestInfo = CreateDeleteRequestInformation(q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo);
                console.WriteLine("Success");
            }, servicePrincipalIdOption);
            return command;
        }
        public Command BuildEndpointsCommand() {
            var command = new Command("endpoints");
            var builder = new ApiSdk.ServicePrincipals.Item.Endpoints.EndpointsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Get entity from servicePrincipals by key
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Get entity from servicePrincipals by key";
            // Create options for all the parameters
            var servicePrincipalIdOption = new Option<string>("--serviceprincipal-id", description: "key: id of servicePrincipal") {
            };
            servicePrincipalIdOption.IsRequired = true;
            command.AddOption(servicePrincipalIdOption);
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
            command.SetHandler(async (string servicePrincipalId, string[] select, string[] expand, FormatterType output, IOutputFormatterFactory outputFormatterFactory, IConsole console) => {
                var requestInfo = CreateGetRequestInformation(q => {
                    q.Select = select;
                    q.Expand = expand;
                });
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo);
                var formatter = outputFormatterFactory.GetFormatter(output);
                formatter.WriteOutput(response, console);
            }, servicePrincipalIdOption, selectOption, expandOption, outputOption);
            return command;
        }
        public Command BuildGetMemberGroupsCommand() {
            var command = new Command("get-member-groups");
            var builder = new ApiSdk.ServicePrincipals.Item.GetMemberGroups.GetMemberGroupsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildGetMemberObjectsCommand() {
            var command = new Command("get-member-objects");
            var builder = new ApiSdk.ServicePrincipals.Item.GetMemberObjects.GetMemberObjectsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildHomeRealmDiscoveryPoliciesCommand() {
            var command = new Command("home-realm-discovery-policies");
            var builder = new ApiSdk.ServicePrincipals.Item.HomeRealmDiscoveryPolicies.HomeRealmDiscoveryPoliciesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        public Command BuildMemberOfCommand() {
            var command = new Command("member-of");
            var builder = new ApiSdk.ServicePrincipals.Item.MemberOf.MemberOfRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        public Command BuildOauth2PermissionGrantsCommand() {
            var command = new Command("oauth2-permission-grants");
            var builder = new ApiSdk.ServicePrincipals.Item.Oauth2PermissionGrants.Oauth2PermissionGrantsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        public Command BuildOwnedObjectsCommand() {
            var command = new Command("owned-objects");
            var builder = new ApiSdk.ServicePrincipals.Item.OwnedObjects.OwnedObjectsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        public Command BuildOwnersCommand() {
            var command = new Command("owners");
            var builder = new ApiSdk.ServicePrincipals.Item.Owners.OwnersRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        /// <summary>
        /// Update entity in servicePrincipals
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Update entity in servicePrincipals";
            // Create options for all the parameters
            var servicePrincipalIdOption = new Option<string>("--serviceprincipal-id", description: "key: id of servicePrincipal") {
            };
            servicePrincipalIdOption.IsRequired = true;
            command.AddOption(servicePrincipalIdOption);
            var bodyOption = new Option<string>("--body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (string servicePrincipalId, string body, IOutputFormatterFactory outputFormatterFactory, IConsole console) => {
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ServicePrincipal>();
                var requestInfo = CreatePatchRequestInformation(model, q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo);
                console.WriteLine("Success");
            }, servicePrincipalIdOption, bodyOption);
            return command;
        }
        public Command BuildRemoveKeyCommand() {
            var command = new Command("remove-key");
            var builder = new ApiSdk.ServicePrincipals.Item.RemoveKey.RemoveKeyRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildRemovePasswordCommand() {
            var command = new Command("remove-password");
            var builder = new ApiSdk.ServicePrincipals.Item.RemovePassword.RemovePasswordRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildRestoreCommand() {
            var command = new Command("restore");
            var builder = new ApiSdk.ServicePrincipals.Item.Restore.RestoreRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildTokenIssuancePoliciesCommand() {
            var command = new Command("token-issuance-policies");
            var builder = new ApiSdk.ServicePrincipals.Item.TokenIssuancePolicies.TokenIssuancePoliciesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        public Command BuildTokenLifetimePoliciesCommand() {
            var command = new Command("token-lifetime-policies");
            var builder = new ApiSdk.ServicePrincipals.Item.TokenLifetimePolicies.TokenLifetimePoliciesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        public Command BuildTransitiveMemberOfCommand() {
            var command = new Command("transitive-member-of");
            var builder = new ApiSdk.ServicePrincipals.Item.TransitiveMemberOf.TransitiveMemberOfRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new ServicePrincipalRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public ServicePrincipalRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/servicePrincipals/{servicePrincipal_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new ServicePrincipalRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public ServicePrincipalRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/servicePrincipals/{servicePrincipal_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete entity from servicePrincipals
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
        /// Get entity from servicePrincipals by key
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
        /// Update entity in servicePrincipals
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(ServicePrincipal body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// Delete entity from servicePrincipals
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
        /// Get entity from servicePrincipals by key
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<ServicePrincipal> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<ServicePrincipal>(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>
        /// Update entity in servicePrincipals
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="model"></param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(ServicePrincipal model, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = model ?? throw new ArgumentNullException(nameof(model));
            var requestInfo = CreatePatchRequestInformation(model, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>Get entity from servicePrincipals by key</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
