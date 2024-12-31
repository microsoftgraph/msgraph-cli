// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.Models.ODataErrors;
using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Cli.Commons.Extensions;
using Microsoft.Kiota.Cli.Commons.IO;
using Microsoft.Kiota.Cli.Commons;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace ApiSdk.TenantRelationships.DelegatedAdminRelationships.Item.AccessAssignments.Item
{
    /// <summary>
    /// Provides operations to manage the accessAssignments property of the microsoft.graph.delegatedAdminRelationship entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DelegatedAdminAccessAssignmentItemRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Delete a delegatedAdminAccessAssignment object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/delegatedadminaccessassignment-delete?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDeleteCommand()
        {
            var command = new Command("delete");
            command.Description = "Delete a delegatedAdminAccessAssignment object.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/delegatedadminaccessassignment-delete?view=graph-rest-1.0";
            var delegatedAdminRelationshipIdOption = new Option<string>("--delegated-admin-relationship-id", description: "The unique identifier of delegatedAdminRelationship") {
            };
            delegatedAdminRelationshipIdOption.IsRequired = true;
            command.AddOption(delegatedAdminRelationshipIdOption);
            var delegatedAdminAccessAssignmentIdOption = new Option<string>("--delegated-admin-access-assignment-id", description: "The unique identifier of delegatedAdminAccessAssignment") {
            };
            delegatedAdminAccessAssignmentIdOption.IsRequired = true;
            command.AddOption(delegatedAdminAccessAssignmentIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var delegatedAdminRelationshipId = invocationContext.ParseResult.GetValueForOption(delegatedAdminRelationshipIdOption);
                var delegatedAdminAccessAssignmentId = invocationContext.ParseResult.GetValueForOption(delegatedAdminAccessAssignmentIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (delegatedAdminRelationshipId is not null) requestInfo.PathParameters.Add("delegatedAdminRelationship%2Did", delegatedAdminRelationshipId);
                if (delegatedAdminAccessAssignmentId is not null) requestInfo.PathParameters.Add("delegatedAdminAccessAssignment%2Did", delegatedAdminAccessAssignmentId);
                if (ifMatch is not null) requestInfo.Headers.Add("If-Match", ifMatch);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                await reqAdapter.SendNoContentAsync(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            });
            return command;
        }
        /// <summary>
        /// Read the properties of a delegatedAdminAccessAssignment object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/delegatedadminaccessassignment-get?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Read the properties of a delegatedAdminAccessAssignment object.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/delegatedadminaccessassignment-get?view=graph-rest-1.0";
            var delegatedAdminRelationshipIdOption = new Option<string>("--delegated-admin-relationship-id", description: "The unique identifier of delegatedAdminRelationship") {
            };
            delegatedAdminRelationshipIdOption.IsRequired = true;
            command.AddOption(delegatedAdminRelationshipIdOption);
            var delegatedAdminAccessAssignmentIdOption = new Option<string>("--delegated-admin-access-assignment-id", description: "The unique identifier of delegatedAdminAccessAssignment") {
            };
            delegatedAdminAccessAssignmentIdOption.IsRequired = true;
            command.AddOption(delegatedAdminAccessAssignmentIdOption);
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
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var delegatedAdminRelationshipId = invocationContext.ParseResult.GetValueForOption(delegatedAdminRelationshipIdOption);
                var delegatedAdminAccessAssignmentId = invocationContext.ParseResult.GetValueForOption(delegatedAdminAccessAssignmentIdOption);
                var select = invocationContext.ParseResult.GetValueForOption(selectOption);
                var expand = invocationContext.ParseResult.GetValueForOption(expandOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                    q.QueryParameters.Select = select;
                    q.QueryParameters.Expand = expand;
                });
                if (delegatedAdminRelationshipId is not null) requestInfo.PathParameters.Add("delegatedAdminRelationship%2Did", delegatedAdminRelationshipId);
                if (delegatedAdminAccessAssignmentId is not null) requestInfo.PathParameters.Add("delegatedAdminAccessAssignment%2Did", delegatedAdminAccessAssignmentId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Update the properties of a delegatedAdminAccessAssignment object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/delegatedadminaccessassignment-update?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPatchCommand()
        {
            var command = new Command("patch");
            command.Description = "Update the properties of a delegatedAdminAccessAssignment object.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/delegatedadminaccessassignment-update?view=graph-rest-1.0";
            var delegatedAdminRelationshipIdOption = new Option<string>("--delegated-admin-relationship-id", description: "The unique identifier of delegatedAdminRelationship") {
            };
            delegatedAdminRelationshipIdOption.IsRequired = true;
            command.AddOption(delegatedAdminRelationshipIdOption);
            var delegatedAdminAccessAssignmentIdOption = new Option<string>("--delegated-admin-access-assignment-id", description: "The unique identifier of delegatedAdminAccessAssignment") {
            };
            delegatedAdminAccessAssignmentIdOption.IsRequired = true;
            command.AddOption(delegatedAdminAccessAssignmentIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var delegatedAdminRelationshipId = invocationContext.ParseResult.GetValueForOption(delegatedAdminRelationshipIdOption);
                var delegatedAdminAccessAssignmentId = invocationContext.ParseResult.GetValueForOption(delegatedAdminAccessAssignmentIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = await ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNodeAsync("application/json", stream, cancellationToken);
                var model = parseNode.GetObjectValue<global::ApiSdk.Models.DelegatedAdminAccessAssignment>(global::ApiSdk.Models.DelegatedAdminAccessAssignment.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (delegatedAdminRelationshipId is not null) requestInfo.PathParameters.Add("delegatedAdminRelationship%2Did", delegatedAdminRelationshipId);
                if (delegatedAdminAccessAssignmentId is not null) requestInfo.PathParameters.Add("delegatedAdminAccessAssignment%2Did", delegatedAdminAccessAssignmentId);
                requestInfo.SetContentFromParsable(reqAdapter, "application/json", model);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.TenantRelationships.DelegatedAdminRelationships.Item.AccessAssignments.Item.DelegatedAdminAccessAssignmentItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public DelegatedAdminAccessAssignmentItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/tenantRelationships/delegatedAdminRelationships/{delegatedAdminRelationship%2Did}/accessAssignments/{delegatedAdminAccessAssignment%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.TenantRelationships.DelegatedAdminRelationships.Item.AccessAssignments.Item.DelegatedAdminAccessAssignmentItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public DelegatedAdminAccessAssignmentItemRequestBuilder(string rawUrl) : base("{+baseurl}/tenantRelationships/delegatedAdminRelationships/{delegatedAdminRelationship%2Did}/accessAssignments/{delegatedAdminAccessAssignment%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete a delegatedAdminAccessAssignment object.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Read the properties of a delegatedAdminAccessAssignment object.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.TenantRelationships.DelegatedAdminRelationships.Item.AccessAssignments.Item.DelegatedAdminAccessAssignmentItemRequestBuilder.DelegatedAdminAccessAssignmentItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.TenantRelationships.DelegatedAdminRelationships.Item.AccessAssignments.Item.DelegatedAdminAccessAssignmentItemRequestBuilder.DelegatedAdminAccessAssignmentItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the properties of a delegatedAdminAccessAssignment object.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::ApiSdk.Models.DelegatedAdminAccessAssignment body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::ApiSdk.Models.DelegatedAdminAccessAssignment body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Read the properties of a delegatedAdminAccessAssignment object.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class DelegatedAdminAccessAssignmentItemRequestBuilderGetQueryParameters 
        {
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
    }
}
#pragma warning restore CS0618
