using ApiSdk.Models.Microsoft.Graph;
using ApiSdk.Models.Microsoft.Graph.ODataErrors;
using ApiSdk.ServicePrincipals.Item.AddKey;
using ApiSdk.ServicePrincipals.Item.AddPassword;
using ApiSdk.ServicePrincipals.Item.AddTokenSigningCertificate;
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
namespace ApiSdk.ServicePrincipals.Item {
    /// <summary>Provides operations to manage the collection of servicePrincipal entities.</summary>
    public class ServicePrincipalItemRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public Command BuildAddKeyCommand() {
            var command = new Command("add-key");
            var builder = new AddKeyRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildAddPasswordCommand() {
            var command = new Command("add-password");
            var builder = new AddPasswordRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildAddTokenSigningCertificateCommand() {
            var command = new Command("add-token-signing-certificate");
            var builder = new AddTokenSigningCertificateRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildAppRoleAssignedToCommand() {
            var command = new Command("app-role-assigned-to");
            var builder = new AppRoleAssignedToRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildAppRoleAssignmentsCommand() {
            var command = new Command("app-role-assignments");
            var builder = new AppRoleAssignmentsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildCheckMemberGroupsCommand() {
            var command = new Command("check-member-groups");
            var builder = new CheckMemberGroupsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildCheckMemberObjectsCommand() {
            var command = new Command("check-member-objects");
            var builder = new CheckMemberObjectsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildClaimsMappingPoliciesCommand() {
            var command = new Command("claims-mapping-policies");
            var builder = new ClaimsMappingPoliciesRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildCreatedObjectsCommand() {
            var command = new Command("created-objects");
            var builder = new CreatedObjectsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildDelegatedPermissionClassificationsCommand() {
            var command = new Command("delegated-permission-classifications");
            var builder = new DelegatedPermissionClassificationsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountCommand());
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
            var servicePrincipalIdOption = new Option<string>("--service-principal-id", description: "key: id of servicePrincipal") {
            };
            servicePrincipalIdOption.IsRequired = true;
            command.AddOption(servicePrincipalIdOption);
            command.SetHandler(async (object[] parameters) => {
                var servicePrincipalId = (string) parameters[0];
                var cancellationToken = (CancellationToken) parameters[1];
                PathParameters.Clear();
                PathParameters.Add("servicePrincipal_id", servicePrincipalId);
                var requestInfo = CreateDeleteRequestInformation(q => {
                });
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(servicePrincipalIdOption, new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        public Command BuildEndpointsCommand() {
            var command = new Command("endpoints");
            var builder = new EndpointsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountCommand());
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
            var servicePrincipalIdOption = new Option<string>("--service-principal-id", description: "key: id of servicePrincipal") {
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
                var servicePrincipalId = (string) parameters[0];
                var select = (string[]) parameters[1];
                var expand = (string[]) parameters[2];
                var output = (FormatterType) parameters[3];
                var query = (string) parameters[4];
                var jsonNoIndent = (bool) parameters[5];
                var outputFilter = (IOutputFilter) parameters[6];
                var outputFormatterFactory = (IOutputFormatterFactory) parameters[7];
                var cancellationToken = (CancellationToken) parameters[8];
                PathParameters.Clear();
                PathParameters.Add("servicePrincipal_id", servicePrincipalId);
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
            }, new CollectionBinding(servicePrincipalIdOption, selectOption, expandOption, outputOption, queryOption, jsonNoIndentOption, new TypeBinding(typeof(IOutputFilter)), new TypeBinding(typeof(IOutputFormatterFactory)), new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        public Command BuildGetMemberGroupsCommand() {
            var command = new Command("get-member-groups");
            var builder = new GetMemberGroupsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildGetMemberObjectsCommand() {
            var command = new Command("get-member-objects");
            var builder = new GetMemberObjectsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildHomeRealmDiscoveryPoliciesCommand() {
            var command = new Command("home-realm-discovery-policies");
            var builder = new HomeRealmDiscoveryPoliciesRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildMemberOfCommand() {
            var command = new Command("member-of");
            var builder = new MemberOfRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildOauth2PermissionGrantsCommand() {
            var command = new Command("oauth2-permission-grants");
            var builder = new Oauth2PermissionGrantsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildOwnedObjectsCommand() {
            var command = new Command("owned-objects");
            var builder = new OwnedObjectsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildOwnersCommand() {
            var command = new Command("owners");
            var builder = new OwnersRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Update entity in servicePrincipals
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Update entity in servicePrincipals";
            // Create options for all the parameters
            var servicePrincipalIdOption = new Option<string>("--service-principal-id", description: "key: id of servicePrincipal") {
            };
            servicePrincipalIdOption.IsRequired = true;
            command.AddOption(servicePrincipalIdOption);
            var bodyOption = new Option<string>("--body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (object[] parameters) => {
                var servicePrincipalId = (string) parameters[0];
                var body = (string) parameters[1];
                var cancellationToken = (CancellationToken) parameters[2];
                PathParameters.Clear();
                PathParameters.Add("servicePrincipal_id", servicePrincipalId);
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ServicePrincipal>(ServicePrincipal.CreateFromDiscriminatorValue);
                var requestInfo = CreatePatchRequestInformation(model, q => {
                });
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(servicePrincipalIdOption, bodyOption, new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        public Command BuildRemoveKeyCommand() {
            var command = new Command("remove-key");
            var builder = new RemoveKeyRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildRemovePasswordCommand() {
            var command = new Command("remove-password");
            var builder = new RemovePasswordRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildRestoreCommand() {
            var command = new Command("restore");
            var builder = new RestoreRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildTokenIssuancePoliciesCommand() {
            var command = new Command("token-issuance-policies");
            var builder = new TokenIssuancePoliciesRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildTokenLifetimePoliciesCommand() {
            var command = new Command("token-lifetime-policies");
            var builder = new TokenLifetimePoliciesRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildTransitiveMemberOfCommand() {
            var command = new Command("transitive-member-of");
            var builder = new TransitiveMemberOfRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new ServicePrincipalItemRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public ServicePrincipalItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/servicePrincipals/{servicePrincipal_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete entity from servicePrincipals
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
        /// Get entity from servicePrincipals by key
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
        /// Update entity in servicePrincipals
        /// <param name="body"></param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(ServicePrincipal body, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default) {
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
        /// <summary>Get entity from servicePrincipals by key</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
