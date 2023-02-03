using ApiSdk.Models;
using ApiSdk.Models.ODataErrors;
using ApiSdk.ServicePrincipals.Item.AppRoleAssignedTo;
using ApiSdk.ServicePrincipals.Item.AppRoleAssignments;
using ApiSdk.ServicePrincipals.Item.ClaimsMappingPolicies;
using ApiSdk.ServicePrincipals.Item.CreatedObjects;
using ApiSdk.ServicePrincipals.Item.DelegatedPermissionClassifications;
using ApiSdk.ServicePrincipals.Item.Endpoints;
using ApiSdk.ServicePrincipals.Item.FederatedIdentityCredentials;
using ApiSdk.ServicePrincipals.Item.HomeRealmDiscoveryPolicies;
using ApiSdk.ServicePrincipals.Item.MemberOf;
using ApiSdk.ServicePrincipals.Item.MicrosoftGraphAddKey;
using ApiSdk.ServicePrincipals.Item.MicrosoftGraphAddPassword;
using ApiSdk.ServicePrincipals.Item.MicrosoftGraphAddTokenSigningCertificate;
using ApiSdk.ServicePrincipals.Item.MicrosoftGraphCheckMemberGroups;
using ApiSdk.ServicePrincipals.Item.MicrosoftGraphCheckMemberObjects;
using ApiSdk.ServicePrincipals.Item.MicrosoftGraphGetMemberGroups;
using ApiSdk.ServicePrincipals.Item.MicrosoftGraphGetMemberObjects;
using ApiSdk.ServicePrincipals.Item.MicrosoftGraphRemoveKey;
using ApiSdk.ServicePrincipals.Item.MicrosoftGraphRemovePassword;
using ApiSdk.ServicePrincipals.Item.MicrosoftGraphRestore;
using ApiSdk.ServicePrincipals.Item.Oauth2PermissionGrants;
using ApiSdk.ServicePrincipals.Item.OwnedObjects;
using ApiSdk.ServicePrincipals.Item.Owners;
using ApiSdk.ServicePrincipals.Item.TokenIssuancePolicies;
using ApiSdk.ServicePrincipals.Item.TokenLifetimePolicies;
using ApiSdk.ServicePrincipals.Item.TransitiveMemberOf;
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
namespace ApiSdk.ServicePrincipals.Item {
    /// <summary>
    /// Provides operations to manage the collection of servicePrincipal entities.
    /// </summary>
    public class ServicePrincipalItemRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Provides operations to manage the appRoleAssignedTo property of the microsoft.graph.servicePrincipal entity.
        /// </summary>
        public Command BuildAppRoleAssignedToCommand() {
            var command = new Command("app-role-assigned-to");
            command.Description = "Provides operations to manage the appRoleAssignedTo property of the microsoft.graph.servicePrincipal entity.";
            var builder = new AppRoleAssignedToRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the appRoleAssignments property of the microsoft.graph.servicePrincipal entity.
        /// </summary>
        public Command BuildAppRoleAssignmentsCommand() {
            var command = new Command("app-role-assignments");
            command.Description = "Provides operations to manage the appRoleAssignments property of the microsoft.graph.servicePrincipal entity.";
            var builder = new AppRoleAssignmentsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the claimsMappingPolicies property of the microsoft.graph.servicePrincipal entity.
        /// </summary>
        public Command BuildClaimsMappingPoliciesCommand() {
            var command = new Command("claims-mapping-policies");
            command.Description = "Provides operations to manage the claimsMappingPolicies property of the microsoft.graph.servicePrincipal entity.";
            var builder = new ClaimsMappingPoliciesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the createdObjects property of the microsoft.graph.servicePrincipal entity.
        /// </summary>
        public Command BuildCreatedObjectsCommand() {
            var command = new Command("created-objects");
            command.Description = "Provides operations to manage the createdObjects property of the microsoft.graph.servicePrincipal entity.";
            var builder = new CreatedObjectsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphServicePrincipalCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the delegatedPermissionClassifications property of the microsoft.graph.servicePrincipal entity.
        /// </summary>
        public Command BuildDelegatedPermissionClassificationsCommand() {
            var command = new Command("delegated-permission-classifications");
            command.Description = "Provides operations to manage the delegatedPermissionClassifications property of the microsoft.graph.servicePrincipal entity.";
            var builder = new DelegatedPermissionClassificationsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Delete a servicePrincipal object.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/serviceprincipal-delete?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Delete a servicePrincipal object.\n\nFind more info here:\n  https://docs.microsoft.com/graph/api/serviceprincipal-delete?view=graph-rest-1.0";
            // Create options for all the parameters
            var servicePrincipalIdOption = new Option<string>("--service-principal-id", description: "key: id of servicePrincipal") {
            };
            servicePrincipalIdOption.IsRequired = true;
            command.AddOption(servicePrincipalIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var servicePrincipalId = invocationContext.ParseResult.GetValueForOption(servicePrincipalIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (servicePrincipalId is not null) requestInfo.PathParameters.Add("servicePrincipal%2Did", servicePrincipalId);
                if (ifMatch is not null) requestInfo.Headers.Add("If-Match", ifMatch);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            });
            return command;
        }
        /// <summary>
        /// Provides operations to manage the endpoints property of the microsoft.graph.servicePrincipal entity.
        /// </summary>
        public Command BuildEndpointsCommand() {
            var command = new Command("endpoints");
            command.Description = "Provides operations to manage the endpoints property of the microsoft.graph.servicePrincipal entity.";
            var builder = new EndpointsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the federatedIdentityCredentials property of the microsoft.graph.servicePrincipal entity.
        /// </summary>
        public Command BuildFederatedIdentityCredentialsCommand() {
            var command = new Command("federated-identity-credentials");
            command.Description = "Provides operations to manage the federatedIdentityCredentials property of the microsoft.graph.servicePrincipal entity.";
            var builder = new FederatedIdentityCredentialsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Retrieve the properties and relationships of a servicePrincipal object.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/serviceprincipal-get?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Retrieve the properties and relationships of a servicePrincipal object.\n\nFind more info here:\n  https://docs.microsoft.com/graph/api/serviceprincipal-get?view=graph-rest-1.0";
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
            command.SetHandler(async (invocationContext) => {
                var servicePrincipalId = invocationContext.ParseResult.GetValueForOption(servicePrincipalIdOption);
                var select = invocationContext.ParseResult.GetValueForOption(selectOption);
                var expand = invocationContext.ParseResult.GetValueForOption(expandOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                var jsonNoIndent = invocationContext.ParseResult.GetValueForOption(jsonNoIndentOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetRequiredService<IOutputFilter>();
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetRequiredService<IOutputFormatterFactory>();
                var cancellationToken = invocationContext.GetCancellationToken();
                var requestInfo = ToGetRequestInformation(q => {
                    q.QueryParameters.Select = select;
                    q.QueryParameters.Expand = expand;
                });
                if (servicePrincipalId is not null) requestInfo.PathParameters.Add("servicePrincipal%2Did", servicePrincipalId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatterOptions = output.GetOutputFormatterOptions(new FormatterOptionsModel(!jsonNoIndent));
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, formatterOptions, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Provides operations to manage the homeRealmDiscoveryPolicies property of the microsoft.graph.servicePrincipal entity.
        /// </summary>
        public Command BuildHomeRealmDiscoveryPoliciesCommand() {
            var command = new Command("home-realm-discovery-policies");
            command.Description = "Provides operations to manage the homeRealmDiscoveryPolicies property of the microsoft.graph.servicePrincipal entity.";
            var builder = new HomeRealmDiscoveryPoliciesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildRefCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the memberOf property of the microsoft.graph.servicePrincipal entity.
        /// </summary>
        public Command BuildMemberOfCommand() {
            var command = new Command("member-of");
            command.Description = "Provides operations to manage the memberOf property of the microsoft.graph.servicePrincipal entity.";
            var builder = new MemberOfRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphApplicationCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDeviceCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGroupCommand());
            command.AddCommand(builder.BuildMicrosoftGraphOrgContactCommand());
            command.AddCommand(builder.BuildMicrosoftGraphServicePrincipalCommand());
            command.AddCommand(builder.BuildMicrosoftGraphUserCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the addKey method.
        /// </summary>
        public Command BuildMicrosoftGraphAddKeyCommand() {
            var command = new Command("microsoft-graph-add-key");
            command.Description = "Provides operations to call the addKey method.";
            var builder = new AddKeyRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the addPassword method.
        /// </summary>
        public Command BuildMicrosoftGraphAddPasswordCommand() {
            var command = new Command("microsoft-graph-add-password");
            command.Description = "Provides operations to call the addPassword method.";
            var builder = new AddPasswordRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the addTokenSigningCertificate method.
        /// </summary>
        public Command BuildMicrosoftGraphAddTokenSigningCertificateCommand() {
            var command = new Command("microsoft-graph-add-token-signing-certificate");
            command.Description = "Provides operations to call the addTokenSigningCertificate method.";
            var builder = new AddTokenSigningCertificateRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the checkMemberGroups method.
        /// </summary>
        public Command BuildMicrosoftGraphCheckMemberGroupsCommand() {
            var command = new Command("microsoft-graph-check-member-groups");
            command.Description = "Provides operations to call the checkMemberGroups method.";
            var builder = new CheckMemberGroupsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the checkMemberObjects method.
        /// </summary>
        public Command BuildMicrosoftGraphCheckMemberObjectsCommand() {
            var command = new Command("microsoft-graph-check-member-objects");
            command.Description = "Provides operations to call the checkMemberObjects method.";
            var builder = new CheckMemberObjectsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the getMemberGroups method.
        /// </summary>
        public Command BuildMicrosoftGraphGetMemberGroupsCommand() {
            var command = new Command("microsoft-graph-get-member-groups");
            command.Description = "Provides operations to call the getMemberGroups method.";
            var builder = new GetMemberGroupsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the getMemberObjects method.
        /// </summary>
        public Command BuildMicrosoftGraphGetMemberObjectsCommand() {
            var command = new Command("microsoft-graph-get-member-objects");
            command.Description = "Provides operations to call the getMemberObjects method.";
            var builder = new GetMemberObjectsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the removeKey method.
        /// </summary>
        public Command BuildMicrosoftGraphRemoveKeyCommand() {
            var command = new Command("microsoft-graph-remove-key");
            command.Description = "Provides operations to call the removeKey method.";
            var builder = new RemoveKeyRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the removePassword method.
        /// </summary>
        public Command BuildMicrosoftGraphRemovePasswordCommand() {
            var command = new Command("microsoft-graph-remove-password");
            command.Description = "Provides operations to call the removePassword method.";
            var builder = new RemovePasswordRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the restore method.
        /// </summary>
        public Command BuildMicrosoftGraphRestoreCommand() {
            var command = new Command("microsoft-graph-restore");
            command.Description = "Provides operations to call the restore method.";
            var builder = new RestoreRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the oauth2PermissionGrants property of the microsoft.graph.servicePrincipal entity.
        /// </summary>
        public Command BuildOauth2PermissionGrantsCommand() {
            var command = new Command("oauth2-permission-grants");
            command.Description = "Provides operations to manage the oauth2PermissionGrants property of the microsoft.graph.servicePrincipal entity.";
            var builder = new Oauth2PermissionGrantsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the ownedObjects property of the microsoft.graph.servicePrincipal entity.
        /// </summary>
        public Command BuildOwnedObjectsCommand() {
            var command = new Command("owned-objects");
            command.Description = "Provides operations to manage the ownedObjects property of the microsoft.graph.servicePrincipal entity.";
            var builder = new OwnedObjectsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphApplicationCommand());
            command.AddCommand(builder.BuildMicrosoftGraphAppRoleAssignmentCommand());
            command.AddCommand(builder.BuildMicrosoftGraphEndpointCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGroupCommand());
            command.AddCommand(builder.BuildMicrosoftGraphServicePrincipalCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the owners property of the microsoft.graph.servicePrincipal entity.
        /// </summary>
        public Command BuildOwnersCommand() {
            var command = new Command("owners");
            command.Description = "Provides operations to manage the owners property of the microsoft.graph.servicePrincipal entity.";
            var builder = new OwnersRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphAppRoleAssignmentCommand());
            command.AddCommand(builder.BuildMicrosoftGraphEndpointCommand());
            command.AddCommand(builder.BuildMicrosoftGraphServicePrincipalCommand());
            command.AddCommand(builder.BuildMicrosoftGraphUserCommand());
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
            var servicePrincipalIdOption = new Option<string>("--service-principal-id", description: "key: id of servicePrincipal") {
            };
            servicePrincipalIdOption.IsRequired = true;
            command.AddOption(servicePrincipalIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
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
                var servicePrincipalId = invocationContext.ParseResult.GetValueForOption(servicePrincipalIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                var jsonNoIndent = invocationContext.ParseResult.GetValueForOption(jsonNoIndentOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetRequiredService<IOutputFilter>();
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetRequiredService<IOutputFormatterFactory>();
                var cancellationToken = invocationContext.GetCancellationToken();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ServicePrincipal>(ServicePrincipal.CreateFromDiscriminatorValue);
                if (model is null) return; // Cannot create a POST request from a null model.
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (servicePrincipalId is not null) requestInfo.PathParameters.Add("servicePrincipal%2Did", servicePrincipalId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatterOptions = output.GetOutputFormatterOptions(new FormatterOptionsModel(!jsonNoIndent));
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, formatterOptions, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Provides operations to manage the tokenIssuancePolicies property of the microsoft.graph.servicePrincipal entity.
        /// </summary>
        public Command BuildTokenIssuancePoliciesCommand() {
            var command = new Command("token-issuance-policies");
            command.Description = "Provides operations to manage the tokenIssuancePolicies property of the microsoft.graph.servicePrincipal entity.";
            var builder = new TokenIssuancePoliciesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the tokenLifetimePolicies property of the microsoft.graph.servicePrincipal entity.
        /// </summary>
        public Command BuildTokenLifetimePoliciesCommand() {
            var command = new Command("token-lifetime-policies");
            command.Description = "Provides operations to manage the tokenLifetimePolicies property of the microsoft.graph.servicePrincipal entity.";
            var builder = new TokenLifetimePoliciesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the transitiveMemberOf property of the microsoft.graph.servicePrincipal entity.
        /// </summary>
        public Command BuildTransitiveMemberOfCommand() {
            var command = new Command("transitive-member-of");
            command.Description = "Provides operations to manage the transitiveMemberOf property of the microsoft.graph.servicePrincipal entity.";
            var builder = new TransitiveMemberOfRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphApplicationCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDeviceCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGroupCommand());
            command.AddCommand(builder.BuildMicrosoftGraphOrgContactCommand());
            command.AddCommand(builder.BuildMicrosoftGraphServicePrincipalCommand());
            command.AddCommand(builder.BuildMicrosoftGraphUserCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new ServicePrincipalItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ServicePrincipalItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/servicePrincipals/{servicePrincipal%2Did}{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete a servicePrincipal object.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<ServicePrincipalItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<ServicePrincipalItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new ServicePrincipalItemRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Retrieve the properties and relationships of a servicePrincipal object.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<ServicePrincipalItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<ServicePrincipalItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new ServicePrincipalItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update entity in servicePrincipals
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(ServicePrincipal body, Action<ServicePrincipalItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(ServicePrincipal body, Action<ServicePrincipalItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new ServicePrincipalItemRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class ServicePrincipalItemRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new ServicePrincipalItemRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public ServicePrincipalItemRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Retrieve the properties and relationships of a servicePrincipal object.
        /// </summary>
        public class ServicePrincipalItemRequestBuilderGetQueryParameters {
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class ServicePrincipalItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public ServicePrincipalItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new ServicePrincipalItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new ServicePrincipalItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public ServicePrincipalItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class ServicePrincipalItemRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new ServicePrincipalItemRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public ServicePrincipalItemRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
