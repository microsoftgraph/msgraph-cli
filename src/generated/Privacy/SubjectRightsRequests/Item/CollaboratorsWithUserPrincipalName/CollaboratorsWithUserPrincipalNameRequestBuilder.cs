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
namespace ApiSdk.Privacy.SubjectRightsRequests.Item.CollaboratorsWithUserPrincipalName
{
    /// <summary>
    /// Provides operations to manage the collaborators property of the microsoft.graph.subjectRightsRequest entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class CollaboratorsWithUserPrincipalNameRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Collection of users who can collaborate on the request.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        [Obsolete("The subject rights request API under Privacy is deprecated and will stop working on  March 22, 2025. Please use the new API under Security. as of 2022-02/PrivacyDeprecate")]
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Collection of users who can collaborate on the request.";
            var subjectRightsRequestIdOption = new Option<string>("--subject-rights-request-id", description: "The unique identifier of subjectRightsRequest") {
            };
            subjectRightsRequestIdOption.IsRequired = true;
            command.AddOption(subjectRightsRequestIdOption);
            var userPrincipalNameOption = new Option<string>("--user-principal-name", description: "Alternate key of user") {
            };
            userPrincipalNameOption.IsRequired = true;
            command.AddOption(userPrincipalNameOption);
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
                var subjectRightsRequestId = invocationContext.ParseResult.GetValueForOption(subjectRightsRequestIdOption);
                var userPrincipalName = invocationContext.ParseResult.GetValueForOption(userPrincipalNameOption);
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
                if (subjectRightsRequestId is not null) requestInfo.PathParameters.Add("subjectRightsRequest%2Did", subjectRightsRequestId);
                if (userPrincipalName is not null) requestInfo.PathParameters.Add("userPrincipalName", userPrincipalName);
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
        /// Instantiates a new <see cref="global::ApiSdk.Privacy.SubjectRightsRequests.Item.CollaboratorsWithUserPrincipalName.CollaboratorsWithUserPrincipalNameRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public CollaboratorsWithUserPrincipalNameRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/privacy/subjectRightsRequests/{subjectRightsRequest%2Did}/collaborators(userPrincipalName='{userPrincipalName}'){?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Privacy.SubjectRightsRequests.Item.CollaboratorsWithUserPrincipalName.CollaboratorsWithUserPrincipalNameRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public CollaboratorsWithUserPrincipalNameRequestBuilder(string rawUrl) : base("{+baseurl}/privacy/subjectRightsRequests/{subjectRightsRequest%2Did}/collaborators(userPrincipalName='{userPrincipalName}'){?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Collection of users who can collaborate on the request.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("The subject rights request API under Privacy is deprecated and will stop working on  March 22, 2025. Please use the new API under Security. as of 2022-02/PrivacyDeprecate")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.Privacy.SubjectRightsRequests.Item.CollaboratorsWithUserPrincipalName.CollaboratorsWithUserPrincipalNameRequestBuilder.CollaboratorsWithUserPrincipalNameRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.Privacy.SubjectRightsRequests.Item.CollaboratorsWithUserPrincipalName.CollaboratorsWithUserPrincipalNameRequestBuilder.CollaboratorsWithUserPrincipalNameRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Collection of users who can collaborate on the request.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CollaboratorsWithUserPrincipalNameRequestBuilderGetQueryParameters 
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
